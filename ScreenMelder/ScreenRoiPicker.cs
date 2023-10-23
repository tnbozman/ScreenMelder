using ScreenMelder.Lib.Core.Models;
using ScreenMelder.Lib.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenMelder
{
    public partial class ScreenRoiPicker : Form
    {
        private bool _isDrawing;
        private int _screenId = 0;
        private Point? _startPoint = null;
        private RoiConfig _currentRegion = null;
        private List<RoiConfig> _regions = new List<RoiConfig>();
        private RoiConfig _trigger;
        private Bitmap _desktopScreenshot;
        private readonly IConfigurationService _configService;
        private readonly IPayloadService _payloadService;
        public ScreenRoiPicker(IConfigurationService configService, IPayloadService payloadService)
        {
            _configService = configService;
            _payloadService = payloadService;
            InitializeComponent();
            this.DoubleBuffered = true;
            this.MouseDown += ScreenRoiPicker_MouseDown;
            this.MouseMove += ScreenRoiPicker_MouseMove;
            this.MouseUp += ScreenRoiPicker_MouseUp;
            this.Paint += ScreenRoiPicker_Paint;

            _desktopScreenshot = CaptureDesktop(1);
            this.BackgroundImage = _desktopScreenshot;
            this.WindowState = FormWindowState.Maximized; // covers the entire screen
            this.FormBorderStyle = FormBorderStyle.None;
        }

        public Bitmap CaptureDesktop(int screenId)
        {
            _screenId = screenId;
            if (Screen.AllScreens.Length <= screenId)
            {
                MessageBox.Show("There are not enough screens to capture, defaulting to Primary (screen 0).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                screenId = 0;
            }

            _screenId = screenId;
            var screen = Screen.AllScreens[screenId];
            Bitmap screenshot = new Bitmap(screen.Bounds.Width, screen.Bounds.Height);

            using (Graphics graphics = Graphics.FromImage(screenshot))
            {
                graphics.CopyFromScreen(screen.Bounds.X, screen.Bounds.Y, 0, 0, screen.Bounds.Size);
            }

            return screenshot;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Check if the 'R' key is pressed
            if (keyData == Keys.R)
            {
                RefreshScreenshot();
                return true;  // indicate that you handled the key
            }
            else if (keyData == Keys.M)
            {
                if (this.FormBorderStyle == FormBorderStyle.None)
                {
                    this.FormBorderStyle = FormBorderStyle.FixedDialog;
                }
                else
                {
                    this.FormBorderStyle = FormBorderStyle.None;
                }

                return true;  // indicate that you handled the key
            }
            else if (keyData == Keys.X)
            {
                SaveConfig();
                this.Close();
            }

            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void SaveConfig()
        {
            if (_trigger != null && _regions != null)
            {
                Config config = new Config
                {
                    ScreenId = _screenId,
                    Trigger = _trigger,
                    Regions = _regions,
                };

                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string configDir = Path.Combine(baseDirectory, "config");
                string configPath = Path.Combine(baseDirectory, "config", "config.json");
                string templatePath = Path.Combine(baseDirectory, "config", "gspro-template.json");

                if (!Directory.Exists(configDir))
                {
                    Directory.CreateDirectory(configDir);
                }
                _configService.SaveConfig(config, configPath);
                var ocr = new Dictionary<string, string>();
                ocr.Add("BallData.Speed", "120");
                ocr.Add("BallData.SpinAxis", "13");
                ocr.Add("BallData.TotalSpin", "2000");
                ocr.Add("BallData.HLA", "0.1");
                ocr.Add("BallData.VLA", "16");
                ocr.Add("BallData.CarryDistance", "220");

                _payloadService.PopulateTemplateWithRegions(templatePath, _regions, ocr);
            }

        }


        private void RefreshScreenshot()
        {
            if (_desktopScreenshot != null)
            {
                _desktopScreenshot.Dispose();
            }

            _desktopScreenshot = CaptureDesktop(_screenId);
            this.BackgroundImage = _desktopScreenshot;
        }

        private void ScreenRoiPicker_MouseDown(object sender, MouseEventArgs e)
        {
            _startPoint = e.Location;
            _isDrawing = true;
        }

        private void ScreenRoiPicker_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDrawing && _startPoint.HasValue)
            {
                _currentRegion = CreateRegion(_startPoint.Value, e);
                Invalidate();
            }
        }

        private RoiConfig CreateRegion(Point point, MouseEventArgs e)
        {
            return new RoiConfig
            {
                X = point.X,
                Y = point.Y,
                Width = e.X - point.X,
                Height = e.Y - point.Y
            };
        }

        private RoiConfig UpdateRegion(RoiConfig region, Point point, MouseEventArgs e)
        {
            if (region == null)
            {
                return CreateRegion(point, e);
            }
            region.Width = e.X - point.X;
            region.Height = e.Y - point.Y;
            return region;
        }

        private void ScreenRoiPicker_MouseUp(object sender, MouseEventArgs e)
        {
            if (_isDrawing && _startPoint.HasValue)
            {
                _currentRegion = UpdateRegion(_currentRegion, _startPoint.Value, e);

                // Pop up the label input dialog
                using (var dialog = new RoiLabelDialog())
                {
                    var result = dialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        // Store the entered label with the region
                        _currentRegion.Label = dialog.EnteredLabel; // Assuming you've exposed the TextBox value through a property named EnteredLabel in LabelInputDialog
                        if (_currentRegion.Label == "trigger")
                        {
                            _trigger = _currentRegion;
                        }
                        else if (_currentRegion.Label != null && _currentRegion.Label.Length > 0)
                        {
                            _regions.Add(_currentRegion);
                        }

                    }
                }

                _currentRegion = null;

                _isDrawing = false;
                this.Invalidate();
            }
        }

        private void ScreenRoiPicker_Paint(object sender, PaintEventArgs e)
        {
            foreach (var region in _regions)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(80, Color.Blue)), region.X, region.Y, region.Width, region.Height);
                e.Graphics.DrawRectangle(Pens.Blue, region.X, region.Y, region.Width, region.Height);
                e.Graphics.DrawString(region.Label, this.Font, Brushes.White, region.X, region.Y - 20); // -20 positions the label above the rectangle
            }

            if (_trigger != null)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(80, Color.Yellow)), _trigger.X, _trigger.Y, _trigger.Width, _trigger.Height);
                e.Graphics.DrawRectangle(Pens.Yellow, _trigger.X, _trigger.Y, _trigger.Width, _trigger.Height);
                e.Graphics.DrawString(_trigger.Label, this.Font, Brushes.White, _trigger.X, _trigger.Y - 20); // -20 positions the label above the rectangle
            }

            if (_currentRegion != null)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(80, Color.Red)), _currentRegion.X, _currentRegion.Y, _currentRegion.Width, _currentRegion.Height);
                e.Graphics.DrawRectangle(Pens.Red, _currentRegion.X, _currentRegion.Y, _currentRegion.Width, _currentRegion.Height);
                e.Graphics.DrawString(_currentRegion.Label, this.Font, Brushes.White, _currentRegion.X, _currentRegion.Y - 20);
            }
        }
    }
}
