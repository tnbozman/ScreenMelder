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
    public partial class ScreenRoiPickerControl : Form
    {
        public ScreenRoiPickerControl()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Instructions");
            sb.AppendLine("1. On the screen draw rectangle regions where you want OCR to occur");
            sb.AppendLine("2. A dialog will appear asking for a name and data type");
            sb.AppendLine("2.A. Name: this is expected to be a dot separated name defining the mapping to the payload's json path");
            sb.AppendLine("3. Draw a final rectangle and name it 'trigger'. This area will be used to determine where the screen has changed an trigger ocr processing to occur");
            sb.AppendLine("4. Now save and exit");

            sb.AppendLine("");
            sb.AppendLine("Control Keys");
            sb.AppendLine("R: Refresh screenshot");
            sb.AppendLine("M: Minimise/maximise Screen ROI picker");
            sb.AppendLine("X: Save and Exit");
            sb.AppendLine("Q: Exit");

            InitializeComponent();
            screenRoiInstructions.Text = sb.ToString();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            // Close the dialog
            this.Close();
        }

    }
}
