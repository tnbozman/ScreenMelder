namespace ScreenMelder
{
    partial class RoiLabelDialog
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
            roiNameLabel = new Label();
            roiNameTextBox = new TextBox();
            roiNameButton = new Button();
            roiDataTypeOptions = new ComboBox();
            dataTypeLabel = new Label();
            SuspendLayout();
            // 
            // roiNameLabel
            // 
            roiNameLabel.AutoSize = true;
            roiNameLabel.Location = new Point(12, 9);
            roiNameLabel.Name = "roiNameLabel";
            roiNameLabel.Size = new Size(173, 20);
            roiNameLabel.TabIndex = 0;
            roiNameLabel.Text = "Region Of Interest Name";
            // 
            // roiNameTextBox
            // 
            roiNameTextBox.Location = new Point(12, 32);
            roiNameTextBox.Name = "roiNameTextBox";
            roiNameTextBox.Size = new Size(186, 27);
            roiNameTextBox.TabIndex = 1;
            // 
            // roiNameButton
            // 
            roiNameButton.Location = new Point(104, 140);
            roiNameButton.Name = "roiNameButton";
            roiNameButton.Size = new Size(94, 29);
            roiNameButton.TabIndex = 2;
            roiNameButton.Text = "Ok";
            roiNameButton.UseVisualStyleBackColor = true;
            roiNameButton.Click += roiNameButton_Click;
            // 
            // roiDataTypeOptions
            // 
            roiDataTypeOptions.FormattingEnabled = true;
            roiDataTypeOptions.Location = new Point(12, 90);
            roiDataTypeOptions.Name = "roiDataTypeOptions";
            roiDataTypeOptions.Size = new Size(186, 28);
            roiDataTypeOptions.TabIndex = 3;
            // 
            // dataTypeLabel
            // 
            dataTypeLabel.AutoSize = true;
            dataTypeLabel.Location = new Point(12, 62);
            dataTypeLabel.Name = "dataTypeLabel";
            dataTypeLabel.Size = new Size(76, 20);
            dataTypeLabel.TabIndex = 4;
            dataTypeLabel.Text = "Data Type";
            // 
            // RoiLabelDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(215, 181);
            Controls.Add(dataTypeLabel);
            Controls.Add(roiDataTypeOptions);
            Controls.Add(roiNameButton);
            Controls.Add(roiNameTextBox);
            Controls.Add(roiNameLabel);
            Name = "RoiLabelDialog";
            Text = "RoiLabelDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label roiNameLabel;
        private TextBox roiNameTextBox;
        private Button roiNameButton;
        private ComboBox roiDataTypeOptions;
        private Label dataTypeLabel;
    }
}