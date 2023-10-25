using ScreenMelder.Lib.ScreenCapture.Models;
using ScreenMelder.Models;

namespace ScreenMelder
{
    partial class ScreenMelder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            host_label = new Label();
            host_input = new TextBox();
            port_label = new Label();
            port_input = new TextBox();
            host_groupBox = new GroupBox();
            host_connect_button = new Button();
            data_tabControl = new TabControl();
            ocrTab = new TabPage();
            pollingPeriod = new NumericUpDown();
            overlayOutputPath = new TextBox();
            payloadTemplatePath = new TextBox();
            configPath = new TextBox();
            pollingLabel = new Label();
            ocrOverlayLabel = new Label();
            ocrTemplateLabel = new Label();
            ocrRoiConfigLabel = new Label();
            overlayOutputEnable = new CheckBox();
            stopOcrButton = new Button();
            ocrStartButton = new Button();
            logTab = new TabPage();
            textBox1 = new TextBox();
            manualTab = new TabPage();
            manual_payload_label = new Label();
            manual_send_button = new Button();
            manual_textBox = new TextBox();
            launch_roi_picker_button = new Button();
            ocr_roi_groupBox = new GroupBox();
            ocrROICaptureTargetOptions = new ComboBox();
            ocrROINameLabel = new Label();
            ocrRoiListLabel = new Label();
            ocrROIOptions = new ComboBox();
            host_groupBox.SuspendLayout();
            data_tabControl.SuspendLayout();
            ocrTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pollingPeriod).BeginInit();
            logTab.SuspendLayout();
            manualTab.SuspendLayout();
            ocr_roi_groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // host_label
            // 
            host_label.AutoSize = true;
            host_label.Location = new Point(27, 17);
            host_label.Name = "host_label";
            host_label.Size = new Size(62, 15);
            host_label.TabIndex = 0;
            host_label.Text = "IP Address";
            // 
            // host_input
            // 
            host_input.Location = new Point(27, 34);
            host_input.Margin = new Padding(3, 2, 3, 2);
            host_input.Name = "host_input";
            host_input.Size = new Size(110, 23);
            host_input.TabIndex = 1;
            host_input.Text = "127.0.0.1";
            // 
            // port_label
            // 
            port_label.AutoSize = true;
            port_label.Location = new Point(27, 57);
            port_label.Name = "port_label";
            port_label.Size = new Size(29, 15);
            port_label.TabIndex = 2;
            port_label.Text = "Port";
            // 
            // port_input
            // 
            port_input.Location = new Point(27, 74);
            port_input.Margin = new Padding(3, 2, 3, 2);
            port_input.Name = "port_input";
            port_input.Size = new Size(110, 23);
            port_input.TabIndex = 3;
            port_input.Text = "9090";
            // 
            // host_groupBox
            // 
            host_groupBox.Controls.Add(host_connect_button);
            host_groupBox.Controls.Add(port_input);
            host_groupBox.Controls.Add(host_label);
            host_groupBox.Controls.Add(port_label);
            host_groupBox.Controls.Add(host_input);
            host_groupBox.Location = new Point(512, 44);
            host_groupBox.Margin = new Padding(3, 2, 3, 2);
            host_groupBox.Name = "host_groupBox";
            host_groupBox.Padding = new Padding(3, 2, 3, 2);
            host_groupBox.Size = new Size(178, 147);
            host_groupBox.TabIndex = 4;
            host_groupBox.TabStop = false;
            host_groupBox.Text = "Host Details";
            // 
            // host_connect_button
            // 
            host_connect_button.Location = new Point(43, 109);
            host_connect_button.Margin = new Padding(3, 2, 3, 2);
            host_connect_button.Name = "host_connect_button";
            host_connect_button.Size = new Size(82, 22);
            host_connect_button.TabIndex = 4;
            host_connect_button.Text = "Connect";
            host_connect_button.UseVisualStyleBackColor = true;
            host_connect_button.Click += host_connect_button_Click;
            // 
            // data_tabControl
            // 
            data_tabControl.Controls.Add(ocrTab);
            data_tabControl.Controls.Add(logTab);
            data_tabControl.Controls.Add(manualTab);
            data_tabControl.Location = new Point(28, 22);
            data_tabControl.Margin = new Padding(3, 2, 3, 2);
            data_tabControl.Name = "data_tabControl";
            data_tabControl.SelectedIndex = 0;
            data_tabControl.Size = new Size(479, 307);
            data_tabControl.TabIndex = 5;
            // 
            // ocrTab
            // 
            ocrTab.Controls.Add(pollingPeriod);
            ocrTab.Controls.Add(overlayOutputPath);
            ocrTab.Controls.Add(payloadTemplatePath);
            ocrTab.Controls.Add(configPath);
            ocrTab.Controls.Add(pollingLabel);
            ocrTab.Controls.Add(ocrOverlayLabel);
            ocrTab.Controls.Add(ocrTemplateLabel);
            ocrTab.Controls.Add(ocrRoiConfigLabel);
            ocrTab.Controls.Add(overlayOutputEnable);
            ocrTab.Controls.Add(stopOcrButton);
            ocrTab.Controls.Add(ocrStartButton);
            ocrTab.Location = new Point(4, 24);
            ocrTab.Margin = new Padding(3, 2, 3, 2);
            ocrTab.Name = "ocrTab";
            ocrTab.Padding = new Padding(3, 2, 3, 2);
            ocrTab.Size = new Size(471, 279);
            ocrTab.TabIndex = 2;
            ocrTab.Text = "OCR";
            ocrTab.UseVisualStyleBackColor = true;
            // 
            // pollingPeriod
            // 
            pollingPeriod.Location = new Point(244, 191);
            pollingPeriod.Margin = new Padding(3, 2, 3, 2);
            pollingPeriod.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            pollingPeriod.Name = "pollingPeriod";
            pollingPeriod.Size = new Size(131, 23);
            pollingPeriod.TabIndex = 12;
            pollingPeriod.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // overlayOutputPath
            // 
            overlayOutputPath.Location = new Point(116, 158);
            overlayOutputPath.Margin = new Padding(3, 2, 3, 2);
            overlayOutputPath.Name = "overlayOutputPath";
            overlayOutputPath.Size = new Size(260, 23);
            overlayOutputPath.TabIndex = 10;
            overlayOutputPath.Text = "output/overlay.png";
            // 
            // payloadTemplatePath
            // 
            payloadTemplatePath.Location = new Point(116, 82);
            payloadTemplatePath.Margin = new Padding(3, 2, 3, 2);
            payloadTemplatePath.Name = "payloadTemplatePath";
            payloadTemplatePath.Size = new Size(260, 23);
            payloadTemplatePath.TabIndex = 9;
            payloadTemplatePath.Text = "config/payload.json";
            // 
            // configPath
            // 
            configPath.Location = new Point(116, 35);
            configPath.Margin = new Padding(3, 2, 3, 2);
            configPath.Name = "configPath";
            configPath.Size = new Size(260, 23);
            configPath.TabIndex = 8;
            configPath.Text = "config/config.json";
            // 
            // pollingLabel
            // 
            pollingLabel.AutoSize = true;
            pollingLabel.Location = new Point(116, 193);
            pollingLabel.Name = "pollingLabel";
            pollingLabel.Size = new Size(108, 15);
            pollingLabel.TabIndex = 7;
            pollingLabel.Text = "Polling Period (ms)";
            // 
            // ocrOverlayLabel
            // 
            ocrOverlayLabel.AutoSize = true;
            ocrOverlayLabel.Location = new Point(116, 141);
            ocrOverlayLabel.Name = "ocrOverlayLabel";
            ocrOverlayLabel.Size = new Size(119, 15);
            ocrOverlayLabel.TabIndex = 6;
            ocrOverlayLabel.Text = "Overlay Output Label";
            // 
            // ocrTemplateLabel
            // 
            ocrTemplateLabel.AutoSize = true;
            ocrTemplateLabel.Location = new Point(116, 64);
            ocrTemplateLabel.Name = "ocrTemplateLabel";
            ocrTemplateLabel.Size = new Size(127, 15);
            ocrTemplateLabel.TabIndex = 5;
            ocrTemplateLabel.Text = "Payload Template Path";
            // 
            // ocrRoiConfigLabel
            // 
            ocrRoiConfigLabel.AutoSize = true;
            ocrRoiConfigLabel.Location = new Point(116, 18);
            ocrRoiConfigLabel.Name = "ocrRoiConfigLabel";
            ocrRoiConfigLabel.Size = new Size(90, 15);
            ocrRoiConfigLabel.TabIndex = 4;
            ocrRoiConfigLabel.Text = "Roi Config Path";
            // 
            // overlayOutputEnable
            // 
            overlayOutputEnable.AutoSize = true;
            overlayOutputEnable.Location = new Point(116, 116);
            overlayOutputEnable.Margin = new Padding(3, 2, 3, 2);
            overlayOutputEnable.Name = "overlayOutputEnable";
            overlayOutputEnable.Size = new Size(145, 19);
            overlayOutputEnable.TabIndex = 3;
            overlayOutputEnable.Text = "Enable Overlay Output";
            overlayOutputEnable.UseVisualStyleBackColor = true;
            // 
            // stopOcrButton
            // 
            stopOcrButton.Enabled = false;
            stopOcrButton.ForeColor = Color.Red;
            stopOcrButton.Location = new Point(293, 241);
            stopOcrButton.Margin = new Padding(3, 2, 3, 2);
            stopOcrButton.Name = "stopOcrButton";
            stopOcrButton.Size = new Size(82, 22);
            stopOcrButton.TabIndex = 2;
            stopOcrButton.Text = "Stop";
            stopOcrButton.UseVisualStyleBackColor = true;
            stopOcrButton.Click += stopOcrButton_Click;
            // 
            // ocrStartButton
            // 
            ocrStartButton.ForeColor = Color.Black;
            ocrStartButton.Location = new Point(206, 241);
            ocrStartButton.Margin = new Padding(3, 2, 3, 2);
            ocrStartButton.Name = "ocrStartButton";
            ocrStartButton.Size = new Size(82, 22);
            ocrStartButton.TabIndex = 1;
            ocrStartButton.Text = "Start";
            ocrStartButton.UseVisualStyleBackColor = true;
            ocrStartButton.Click += ocrStartButton_Click;
            // 
            // logTab
            // 
            logTab.Controls.Add(textBox1);
            logTab.Location = new Point(4, 24);
            logTab.Margin = new Padding(3, 2, 3, 2);
            logTab.Name = "logTab";
            logTab.Padding = new Padding(3, 2, 3, 2);
            logTab.Size = new Size(471, 279);
            logTab.TabIndex = 1;
            logTab.Text = "Log";
            logTab.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(5, 4);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(462, 274);
            textBox1.TabIndex = 0;
            // 
            // manualTab
            // 
            manualTab.Controls.Add(manual_payload_label);
            manualTab.Controls.Add(manual_send_button);
            manualTab.Controls.Add(manual_textBox);
            manualTab.Location = new Point(4, 24);
            manualTab.Margin = new Padding(3, 2, 3, 2);
            manualTab.Name = "manualTab";
            manualTab.Padding = new Padding(3, 2, 3, 2);
            manualTab.Size = new Size(471, 279);
            manualTab.TabIndex = 0;
            manualTab.Text = "Manual";
            manualTab.UseVisualStyleBackColor = true;
            // 
            // manual_payload_label
            // 
            manual_payload_label.AutoSize = true;
            manual_payload_label.Location = new Point(17, 10);
            manual_payload_label.Name = "manual_payload_label";
            manual_payload_label.Size = new Size(75, 15);
            manual_payload_label.TabIndex = 2;
            manual_payload_label.Text = "Json Payload";
            // 
            // manual_send_button
            // 
            manual_send_button.Location = new Point(361, 226);
            manual_send_button.Margin = new Padding(3, 2, 3, 2);
            manual_send_button.Name = "manual_send_button";
            manual_send_button.Size = new Size(82, 22);
            manual_send_button.TabIndex = 1;
            manual_send_button.Text = "Send";
            manual_send_button.UseVisualStyleBackColor = true;
            manual_send_button.Click += manual_send_button_Click;
            // 
            // manual_textBox
            // 
            manual_textBox.Location = new Point(17, 34);
            manual_textBox.Margin = new Padding(3, 2, 3, 2);
            manual_textBox.Multiline = true;
            manual_textBox.Name = "manual_textBox";
            manual_textBox.Size = new Size(440, 188);
            manual_textBox.TabIndex = 0;
            // 
            // launch_roi_picker_button
            // 
            launch_roi_picker_button.Location = new Point(38, 104);
            launch_roi_picker_button.Margin = new Padding(3, 2, 3, 2);
            launch_roi_picker_button.Name = "launch_roi_picker_button";
            launch_roi_picker_button.Size = new Size(99, 22);
            launch_roi_picker_button.TabIndex = 6;
            launch_roi_picker_button.Text = "Draw Regions";
            launch_roi_picker_button.UseVisualStyleBackColor = true;
            launch_roi_picker_button.Click += launch_roi_picker_button_Click;
            // 
            // ocr_roi_groupBox
            // 
            ocr_roi_groupBox.Controls.Add(ocrROICaptureTargetOptions);
            ocr_roi_groupBox.Controls.Add(ocrROINameLabel);
            ocr_roi_groupBox.Controls.Add(ocrRoiListLabel);
            ocr_roi_groupBox.Controls.Add(ocrROIOptions);
            ocr_roi_groupBox.Controls.Add(launch_roi_picker_button);
            ocr_roi_groupBox.Location = new Point(512, 195);
            ocr_roi_groupBox.Margin = new Padding(3, 2, 3, 2);
            ocr_roi_groupBox.Name = "ocr_roi_groupBox";
            ocr_roi_groupBox.Padding = new Padding(3, 2, 3, 2);
            ocr_roi_groupBox.Size = new Size(178, 130);
            ocr_roi_groupBox.TabIndex = 7;
            ocr_roi_groupBox.TabStop = false;
            ocr_roi_groupBox.Text = "OCR ROIs";
            // 
            // ocrROICaptureTargetOptions
            // 
            ocrROICaptureTargetOptions.FormattingEnabled = true;
            ocrROICaptureTargetOptions.Location = new Point(16, 80);
            ocrROICaptureTargetOptions.Margin = new Padding(3, 2, 3, 2);
            ocrROICaptureTargetOptions.Name = "ocrROICaptureTargetOptions";
            ocrROICaptureTargetOptions.Size = new Size(146, 23);
            ocrROICaptureTargetOptions.TabIndex = 11;
            // 
            // ocrROINameLabel
            // 
            ocrROINameLabel.AutoSize = true;
            ocrROINameLabel.Location = new Point(16, 62);
            ocrROINameLabel.Name = "ocrROINameLabel";
            ocrROINameLabel.Size = new Size(84, 15);
            ocrROINameLabel.TabIndex = 10;
            ocrROINameLabel.Text = "Capture Target";
            // 
            // ocrRoiListLabel
            // 
            ocrRoiListLabel.AutoSize = true;
            ocrRoiListLabel.Location = new Point(16, 17);
            ocrRoiListLabel.Name = "ocrRoiListLabel";
            ocrRoiListLabel.Size = new Size(76, 15);
            ocrRoiListLabel.TabIndex = 9;
            ocrRoiListLabel.Text = "Capture Type";
            // 
            // ocrROIOptions
            // 
            ocrROIOptions.FormattingEnabled = true;
            ocrROIOptions.Location = new Point(16, 34);
            ocrROIOptions.Margin = new Padding(3, 2, 3, 2);
            ocrROIOptions.Name = "ocrROIOptions";
            ocrROIOptions.Size = new Size(146, 23);
            ocrROIOptions.TabIndex = 8;
            ocrROIOptions.SelectedIndexChanged += ocrROIOptions_SelectedIndexChanged;
            // 
            // ScreenMelder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(data_tabControl);
            Controls.Add(host_groupBox);
            Controls.Add(ocr_roi_groupBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ScreenMelder";
            Text = "Form1";
            host_groupBox.ResumeLayout(false);
            host_groupBox.PerformLayout();
            data_tabControl.ResumeLayout(false);
            ocrTab.ResumeLayout(false);
            ocrTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pollingPeriod).EndInit();
            logTab.ResumeLayout(false);
            logTab.PerformLayout();
            manualTab.ResumeLayout(false);
            manualTab.PerformLayout();
            ocr_roi_groupBox.ResumeLayout(false);
            ocr_roi_groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label host_label;
        private TextBox host_input;
        private Label port_label;
        private TextBox port_input;
        private GroupBox host_groupBox;
        private Button host_connect_button;
        private TabControl data_tabControl;
        private TabPage manualTab;
        private TabPage logTab;
        private Button manual_send_button;
        private TextBox manual_textBox;
        private TextBox textBox1;
        private Button launch_roi_picker_button;
        private GroupBox ocr_roi_groupBox;
        private Label manual_payload_label;
        private ComboBox ocrROIOptions;
        private Label ocrROINameLabel;
        private Label ocrRoiListLabel;
        private ComboBox ocrROICaptureTargetOptions;
        private TabPage ocrTab;
        private Button stopOcrButton;
        private Button ocrStartButton;
        private CheckBox overlayOutputEnable;
        private Label ocrTemplateLabel;
        private Label ocrRoiConfigLabel;
        private Label ocrOverlayLabel;
        private Label pollingLabel;
        private TextBox payloadTemplatePath;
        private TextBox configPath;
        private TextBox overlayOutputPath;
        private NumericUpDown pollingPeriod;
    }
}