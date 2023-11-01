namespace ScreenMelder
{
    partial class ScreenRoiPickerControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            screenRoiInstructions = new TextBox();
            continueButton = new Button();
            SuspendLayout();
            // 
            // screenRoiInstructions
            // 
            screenRoiInstructions.Enabled = false;
            screenRoiInstructions.Location = new Point(12, 12);
            screenRoiInstructions.Multiline = true;
            screenRoiInstructions.Name = "screenRoiInstructions";
            screenRoiInstructions.Size = new Size(425, 360);
            screenRoiInstructions.TabIndex = 0;
            // 
            // continueButton
            // 
            continueButton.Location = new Point(173, 378);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(107, 29);
            continueButton.TabIndex = 1;
            continueButton.Text = "Continue";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += continueButton_Click;
            // 
            // ScreenRoiPickerControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 412);
            Controls.Add(continueButton);
            Controls.Add(screenRoiInstructions);
            Name = "ScreenRoiPickerControl";
            Text = "ScreenRoiPickerControl";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox screenRoiInstructions;
        private Button continueButton;
    }
}