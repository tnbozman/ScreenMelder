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
            logTab.SuspendLayout();
            manualTab.SuspendLayout();
            ocr_roi_groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // host_label
            // 
            host_label.AutoSize = true;
            host_label.Location = new Point(18, 23);
            host_label.Name = "host_label";
            host_label.Size = new Size(78, 20);
            host_label.TabIndex = 0;
            host_label.Text = "IP Address";
            // 
            // host_input
            // 
            host_input.Location = new Point(18, 45);
            host_input.Name = "host_input";
            host_input.Size = new Size(125, 27);
            host_input.TabIndex = 1;
            host_input.Text = "127.0.0.1";
            // 
            // port_label
            // 
            port_label.AutoSize = true;
            port_label.Location = new Point(18, 76);
            port_label.Name = "port_label";
            port_label.Size = new Size(35, 20);
            port_label.TabIndex = 2;
            port_label.Text = "Port";
            // 
            // port_input
            // 
            port_input.Location = new Point(18, 99);
            port_input.Name = "port_input";
            port_input.Size = new Size(125, 27);
            port_input.TabIndex = 3;
            port_input.Text = "0921 | 9090";
            // 
            // host_groupBox
            // 
            host_groupBox.Controls.Add(host_connect_button);
            host_groupBox.Controls.Add(port_input);
            host_groupBox.Controls.Add(host_label);
            host_groupBox.Controls.Add(port_label);
            host_groupBox.Controls.Add(host_input);
            host_groupBox.Location = new Point(585, 59);
            host_groupBox.Name = "host_groupBox";
            host_groupBox.Size = new Size(203, 196);
            host_groupBox.TabIndex = 4;
            host_groupBox.TabStop = false;
            host_groupBox.Text = "Host Details";
            // 
            // host_connect_button
            // 
            host_connect_button.Location = new Point(32, 145);
            host_connect_button.Name = "host_connect_button";
            host_connect_button.Size = new Size(94, 29);
            host_connect_button.TabIndex = 4;
            host_connect_button.Text = "Connect";
            host_connect_button.UseVisualStyleBackColor = true;
            host_connect_button.Click += host_connect_button_Click;
            // 
            // data_tabControl
            // 
            data_tabControl.Controls.Add(logTab);
            data_tabControl.Controls.Add(manualTab);
            data_tabControl.Location = new Point(32, 29);
            data_tabControl.Name = "data_tabControl";
            data_tabControl.SelectedIndex = 0;
            data_tabControl.Size = new Size(547, 409);
            data_tabControl.TabIndex = 5;
            // 
            // logTab
            // 
            logTab.Controls.Add(textBox1);
            logTab.Location = new Point(4, 29);
            logTab.Name = "logTab";
            logTab.Padding = new Padding(3);
            logTab.Size = new Size(539, 376);
            logTab.TabIndex = 1;
            logTab.Text = "Log";
            logTab.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 5);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(527, 364);
            textBox1.TabIndex = 0;
            // 
            // manualTab
            // 
            manualTab.Controls.Add(manual_payload_label);
            manualTab.Controls.Add(manual_send_button);
            manualTab.Controls.Add(manual_textBox);
            manualTab.Location = new Point(4, 29);
            manualTab.Name = "manualTab";
            manualTab.Padding = new Padding(3);
            manualTab.Size = new Size(539, 376);
            manualTab.TabIndex = 0;
            manualTab.Text = "Manual";
            manualTab.UseVisualStyleBackColor = true;
            // 
            // manual_payload_label
            // 
            manual_payload_label.AutoSize = true;
            manual_payload_label.Location = new Point(19, 13);
            manual_payload_label.Name = "manual_payload_label";
            manual_payload_label.Size = new Size(93, 20);
            manual_payload_label.TabIndex = 2;
            manual_payload_label.Text = "Json Payload";
            // 
            // manual_send_button
            // 
            manual_send_button.Location = new Point(413, 301);
            manual_send_button.Name = "manual_send_button";
            manual_send_button.Size = new Size(94, 29);
            manual_send_button.TabIndex = 1;
            manual_send_button.Text = "Send";
            manual_send_button.UseVisualStyleBackColor = true;
            // 
            // manual_textBox
            // 
            manual_textBox.Location = new Point(19, 45);
            manual_textBox.Multiline = true;
            manual_textBox.Name = "manual_textBox";
            manual_textBox.Size = new Size(502, 249);
            manual_textBox.TabIndex = 0;
            // 
            // launch_roi_picker_button
            // 
            launch_roi_picker_button.Location = new Point(43, 139);
            launch_roi_picker_button.Name = "launch_roi_picker_button";
            launch_roi_picker_button.Size = new Size(113, 29);
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
            ocr_roi_groupBox.Location = new Point(585, 260);
            ocr_roi_groupBox.Name = "ocr_roi_groupBox";
            ocr_roi_groupBox.Size = new Size(203, 173);
            ocr_roi_groupBox.TabIndex = 7;
            ocr_roi_groupBox.TabStop = false;
            ocr_roi_groupBox.Text = "OCR ROIs";
            // 
            // ocrROICaptureTargetOptions
            // 
            ocrROICaptureTargetOptions.FormattingEnabled = true;
            ocrROICaptureTargetOptions.Location = new Point(18, 106);
            ocrROICaptureTargetOptions.Name = "ocrROICaptureTargetOptions";
            ocrROICaptureTargetOptions.Size = new Size(166, 28);
            ocrROICaptureTargetOptions.TabIndex = 11;
            // 
            // ocrROINameLabel
            // 
            ocrROINameLabel.AutoSize = true;
            ocrROINameLabel.Location = new Point(18, 83);
            ocrROINameLabel.Name = "ocrROINameLabel";
            ocrROINameLabel.Size = new Size(106, 20);
            ocrROINameLabel.TabIndex = 10;
            ocrROINameLabel.Text = "Capture Target";
            // 
            // ocrRoiListLabel
            // 
            ocrRoiListLabel.AutoSize = true;
            ocrRoiListLabel.Location = new Point(18, 23);
            ocrRoiListLabel.Name = "ocrRoiListLabel";
            ocrRoiListLabel.Size = new Size(96, 20);
            ocrRoiListLabel.TabIndex = 9;
            ocrRoiListLabel.Text = "Capture Type";
            // 
            // ocrROIOptions
            // 
            ocrROIOptions.FormattingEnabled = true;
            ocrROIOptions.Location = new Point(18, 46);
            ocrROIOptions.Name = "ocrROIOptions";
            ocrROIOptions.Size = new Size(166, 28);
            ocrROIOptions.TabIndex = 8;
            ocrROIOptions.SelectedIndexChanged += ocrROIOptions_SelectedIndexChanged;
            // 
            // ScreenMelder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(data_tabControl);
            Controls.Add(host_groupBox);
            Controls.Add(ocr_roi_groupBox);
            Name = "ScreenMelder";
            Text = "Form1";
            host_groupBox.ResumeLayout(false);
            host_groupBox.PerformLayout();
            data_tabControl.ResumeLayout(false);
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
    }
}