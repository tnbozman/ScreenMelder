using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ScreenMelder
{
    public partial class RoiLabelDialog : Form
    {
        public string EnteredLabel => roiNameTextBox.Text;
        public RoiLabelDialog()
        {
            InitializeComponent();
        }

        private void roiNameButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(roiNameTextBox.Text))
            {
                MessageBox.Show("Please enter a valid label.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
            // Close the dialog
            this.Close();
        }
    }
}
