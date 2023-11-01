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
            host_disconnect_button = new Button();
            host_connect_button = new Button();
            data_tabControl = new TabControl();
            ocrTab = new TabPage();
            captureCount = new TextBox();
            captureCountLabel = new Label();
            ocr_roi_groupBox = new GroupBox();
            ocrROICaptureTargetOptions = new ComboBox();
            ocrROINameLabel = new Label();
            ocrRoiListLabel = new Label();
            ocrROIOptions = new ComboBox();
            launch_roi_picker_button = new Button();
            ocrPayloadRegexLabel = new Label();
            ocrPayloadRegex = new TextBox();
            overlayOutputGroupBox = new GroupBox();
            overlayOutputEnable = new CheckBox();
            pollingPeriod = new NumericUpDown();
            pollingLabel = new Label();
            stopOcrButton = new Button();
            ocrStartButton = new Button();
            ocrConfigTab = new TabPage();
            configEditCheckBox = new CheckBox();
            configSaveButton = new Button();
            configTextBox = new TextBox();
            payloadTab = new TabPage();
            payloadEditCheckBox = new CheckBox();
            payloadTextBox = new TextBox();
            payloadSaveButton = new Button();
            logTab = new TabPage();
            manualTab = new TabPage();
            manual_payload_label = new Label();
            manual_send_button = new Button();
            manual_textBox = new TextBox();
            host_groupBox.SuspendLayout();
            data_tabControl.SuspendLayout();
            ocrTab.SuspendLayout();
            ocr_roi_groupBox.SuspendLayout();
            overlayOutputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pollingPeriod).BeginInit();
            ocrConfigTab.SuspendLayout();
            payloadTab.SuspendLayout();
            manualTab.SuspendLayout();
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
            host_input.Size = new Size(194, 23);
            host_input.TabIndex = 1;
            host_input.Text = "127.0.0.1";
            // 
            // port_label
            // 
            port_label.AutoSize = true;
            port_label.Location = new Point(241, 17);
            port_label.Name = "port_label";
            port_label.Size = new Size(29, 15);
            port_label.TabIndex = 2;
            port_label.Text = "Port";
            // 
            // port_input
            // 
            port_input.Location = new Point(241, 34);
            port_input.Margin = new Padding(3, 2, 3, 2);
            port_input.Name = "port_input";
            port_input.Size = new Size(51, 23);
            port_input.TabIndex = 3;
            port_input.Text = "9090";
            // 
            // host_groupBox
            // 
            host_groupBox.Controls.Add(port_input);
            host_groupBox.Controls.Add(host_label);
            host_groupBox.Controls.Add(port_label);
            host_groupBox.Controls.Add(host_input);
            host_groupBox.Location = new Point(17, 211);
            host_groupBox.Margin = new Padding(3, 2, 3, 2);
            host_groupBox.Name = "host_groupBox";
            host_groupBox.Padding = new Padding(3, 2, 3, 2);
            host_groupBox.Size = new Size(319, 67);
            host_groupBox.TabIndex = 4;
            host_groupBox.TabStop = false;
            host_groupBox.Text = "Host Details";
            // 
            // host_disconnect_button
            // 
            host_disconnect_button.Enabled = false;
            host_disconnect_button.Location = new Point(451, 226);
            host_disconnect_button.Margin = new Padding(3, 2, 3, 2);
            host_disconnect_button.Name = "host_disconnect_button";
            host_disconnect_button.Size = new Size(82, 22);
            host_disconnect_button.TabIndex = 5;
            host_disconnect_button.Text = "Disconnect";
            host_disconnect_button.UseVisualStyleBackColor = true;
            host_disconnect_button.Click += host_disconnect_button_Click;
            // 
            // host_connect_button
            // 
            host_connect_button.Location = new Point(360, 226);
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
            data_tabControl.Controls.Add(ocrConfigTab);
            data_tabControl.Controls.Add(payloadTab);
            data_tabControl.Controls.Add(logTab);
            data_tabControl.Controls.Add(manualTab);
            data_tabControl.Location = new Point(28, 22);
            data_tabControl.Margin = new Padding(3, 2, 3, 2);
            data_tabControl.Name = "data_tabControl";
            data_tabControl.SelectedIndex = 0;
            data_tabControl.Size = new Size(666, 307);
            data_tabControl.TabIndex = 5;
            // 
            // ocrTab
            // 
            ocrTab.Controls.Add(captureCount);
            ocrTab.Controls.Add(captureCountLabel);
            ocrTab.Controls.Add(ocr_roi_groupBox);
            ocrTab.Controls.Add(ocrPayloadRegexLabel);
            ocrTab.Controls.Add(ocrPayloadRegex);
            ocrTab.Controls.Add(overlayOutputGroupBox);
            ocrTab.Controls.Add(pollingPeriod);
            ocrTab.Controls.Add(pollingLabel);
            ocrTab.Controls.Add(stopOcrButton);
            ocrTab.Controls.Add(ocrStartButton);
            ocrTab.Location = new Point(4, 24);
            ocrTab.Margin = new Padding(3, 2, 3, 2);
            ocrTab.Name = "ocrTab";
            ocrTab.Padding = new Padding(3, 2, 3, 2);
            ocrTab.Size = new Size(658, 279);
            ocrTab.TabIndex = 2;
            ocrTab.Text = "OCR";
            ocrTab.UseVisualStyleBackColor = true;
            // 
            // captureCount
            // 
            captureCount.Location = new Point(472, 98);
            captureCount.Margin = new Padding(3, 2, 3, 2);
            captureCount.Name = "captureCount";
            captureCount.Size = new Size(175, 23);
            captureCount.TabIndex = 17;
            captureCount.Text = "data.shotnumber";
            // 
            // captureCountLabel
            // 
            captureCountLabel.AutoSize = true;
            captureCountLabel.Location = new Point(473, 81);
            captureCountLabel.Name = "captureCountLabel";
            captureCountLabel.Size = new Size(116, 15);
            captureCountLabel.TabIndex = 16;
            captureCountLabel.Text = "Capture Count Label";
            // 
            // ocr_roi_groupBox
            // 
            ocr_roi_groupBox.Controls.Add(ocrROICaptureTargetOptions);
            ocr_roi_groupBox.Controls.Add(ocrROINameLabel);
            ocr_roi_groupBox.Controls.Add(ocrRoiListLabel);
            ocr_roi_groupBox.Controls.Add(ocrROIOptions);
            ocr_roi_groupBox.Controls.Add(launch_roi_picker_button);
            ocr_roi_groupBox.Location = new Point(263, 18);
            ocr_roi_groupBox.Margin = new Padding(3, 2, 3, 2);
            ocr_roi_groupBox.Name = "ocr_roi_groupBox";
            ocr_roi_groupBox.Padding = new Padding(3, 2, 3, 2);
            ocr_roi_groupBox.Size = new Size(191, 130);
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
            // ocrPayloadRegexLabel
            // 
            ocrPayloadRegexLabel.AutoSize = true;
            ocrPayloadRegexLabel.Location = new Point(472, 26);
            ocrPayloadRegexLabel.Name = "ocrPayloadRegexLabel";
            ocrPayloadRegexLabel.Size = new Size(131, 15);
            ocrPayloadRegexLabel.TabIndex = 15;
            ocrPayloadRegexLabel.Text = "Payload Cleanup Regex";
            // 
            // ocrPayloadRegex
            // 
            ocrPayloadRegex.Location = new Point(472, 44);
            ocrPayloadRegex.Margin = new Padding(3, 2, 3, 2);
            ocrPayloadRegex.Name = "ocrPayloadRegex";
            ocrPayloadRegex.Size = new Size(175, 23);
            ocrPayloadRegex.TabIndex = 14;
            ocrPayloadRegex.Text = "\\s+";
            ocrPayloadRegex.TextChanged += ocrPayloadRegex_TextChanged;
            // 
            // overlayOutputGroupBox
            // 
            overlayOutputGroupBox.Controls.Add(overlayOutputEnable);
            overlayOutputGroupBox.Location = new Point(36, 23);
            overlayOutputGroupBox.Margin = new Padding(3, 2, 3, 2);
            overlayOutputGroupBox.Name = "overlayOutputGroupBox";
            overlayOutputGroupBox.Padding = new Padding(3, 2, 3, 2);
            overlayOutputGroupBox.Size = new Size(197, 52);
            overlayOutputGroupBox.TabIndex = 13;
            overlayOutputGroupBox.TabStop = false;
            overlayOutputGroupBox.Text = "Overlay Output";
            // 
            // overlayOutputEnable
            // 
            overlayOutputEnable.AutoSize = true;
            overlayOutputEnable.Location = new Point(6, 25);
            overlayOutputEnable.Margin = new Padding(3, 2, 3, 2);
            overlayOutputEnable.Name = "overlayOutputEnable";
            overlayOutputEnable.Size = new Size(61, 19);
            overlayOutputEnable.TabIndex = 3;
            overlayOutputEnable.Text = "Enable";
            overlayOutputEnable.UseVisualStyleBackColor = true;
            // 
            // pollingPeriod
            // 
            pollingPeriod.Location = new Point(592, 130);
            pollingPeriod.Margin = new Padding(3, 2, 3, 2);
            pollingPeriod.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            pollingPeriod.Name = "pollingPeriod";
            pollingPeriod.Size = new Size(58, 23);
            pollingPeriod.TabIndex = 12;
            pollingPeriod.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // pollingLabel
            // 
            pollingLabel.AutoSize = true;
            pollingLabel.Location = new Point(473, 133);
            pollingLabel.Name = "pollingLabel";
            pollingLabel.Size = new Size(108, 15);
            pollingLabel.TabIndex = 7;
            pollingLabel.Text = "Polling Period (ms)";
            // 
            // stopOcrButton
            // 
            stopOcrButton.Enabled = false;
            stopOcrButton.ForeColor = Color.Red;
            stopOcrButton.Location = new Point(564, 242);
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
            ocrStartButton.Location = new Point(472, 242);
            ocrStartButton.Margin = new Padding(3, 2, 3, 2);
            ocrStartButton.Name = "ocrStartButton";
            ocrStartButton.Size = new Size(82, 22);
            ocrStartButton.TabIndex = 1;
            ocrStartButton.Text = "Start";
            ocrStartButton.UseVisualStyleBackColor = true;
            ocrStartButton.Click += ocrStartButton_Click;
            // 
            // ocrConfigTab
            // 
            ocrConfigTab.Controls.Add(configEditCheckBox);
            ocrConfigTab.Controls.Add(configSaveButton);
            ocrConfigTab.Controls.Add(configTextBox);
            ocrConfigTab.Location = new Point(4, 24);
            ocrConfigTab.Margin = new Padding(3, 2, 3, 2);
            ocrConfigTab.Name = "ocrConfigTab";
            ocrConfigTab.Padding = new Padding(3, 2, 3, 2);
            ocrConfigTab.Size = new Size(658, 279);
            ocrConfigTab.TabIndex = 3;
            ocrConfigTab.Text = "OCR Configuration";
            ocrConfigTab.UseVisualStyleBackColor = true;
            // 
            // configEditCheckBox
            // 
            configEditCheckBox.AutoSize = true;
            configEditCheckBox.Location = new Point(447, 249);
            configEditCheckBox.Margin = new Padding(3, 2, 3, 2);
            configEditCheckBox.Name = "configEditCheckBox";
            configEditCheckBox.Size = new Size(101, 19);
            configEditCheckBox.TabIndex = 3;
            configEditCheckBox.Text = "Enable Editing";
            configEditCheckBox.UseVisualStyleBackColor = true;
            configEditCheckBox.CheckedChanged += configEditCheckBox_CheckedChanged;
            // 
            // configSaveButton
            // 
            configSaveButton.Enabled = false;
            configSaveButton.Location = new Point(563, 248);
            configSaveButton.Margin = new Padding(3, 2, 3, 2);
            configSaveButton.Name = "configSaveButton";
            configSaveButton.Size = new Size(82, 22);
            configSaveButton.TabIndex = 1;
            configSaveButton.Text = "Save";
            configSaveButton.UseVisualStyleBackColor = true;
            configSaveButton.Click += configSaveButton_Click;
            // 
            // configTextBox
            // 
            configTextBox.Enabled = false;
            configTextBox.Location = new Point(5, 4);
            configTextBox.Margin = new Padding(3, 2, 3, 2);
            configTextBox.Multiline = true;
            configTextBox.Name = "configTextBox";
            configTextBox.ScrollBars = ScrollBars.Vertical;
            configTextBox.Size = new Size(649, 240);
            configTextBox.TabIndex = 0;
            // 
            // payloadTab
            // 
            payloadTab.Controls.Add(payloadEditCheckBox);
            payloadTab.Controls.Add(payloadTextBox);
            payloadTab.Controls.Add(payloadSaveButton);
            payloadTab.Location = new Point(4, 24);
            payloadTab.Margin = new Padding(3, 2, 3, 2);
            payloadTab.Name = "payloadTab";
            payloadTab.Padding = new Padding(3, 2, 3, 2);
            payloadTab.Size = new Size(658, 279);
            payloadTab.TabIndex = 4;
            payloadTab.Text = "Payload Configuration";
            payloadTab.UseVisualStyleBackColor = true;
            // 
            // payloadEditCheckBox
            // 
            payloadEditCheckBox.AutoSize = true;
            payloadEditCheckBox.Location = new Point(440, 248);
            payloadEditCheckBox.Margin = new Padding(3, 2, 3, 2);
            payloadEditCheckBox.Name = "payloadEditCheckBox";
            payloadEditCheckBox.Size = new Size(101, 19);
            payloadEditCheckBox.TabIndex = 2;
            payloadEditCheckBox.Text = "Enable Editing";
            payloadEditCheckBox.UseVisualStyleBackColor = true;
            payloadEditCheckBox.CheckedChanged += payloadEditCheckBox_CheckedChanged;
            // 
            // payloadTextBox
            // 
            payloadTextBox.Enabled = false;
            payloadTextBox.Location = new Point(5, 4);
            payloadTextBox.Margin = new Padding(3, 2, 3, 2);
            payloadTextBox.Multiline = true;
            payloadTextBox.Name = "payloadTextBox";
            payloadTextBox.Size = new Size(640, 240);
            payloadTextBox.TabIndex = 1;
            // 
            // payloadSaveButton
            // 
            payloadSaveButton.Enabled = false;
            payloadSaveButton.Location = new Point(556, 246);
            payloadSaveButton.Margin = new Padding(3, 2, 3, 2);
            payloadSaveButton.Name = "payloadSaveButton";
            payloadSaveButton.Size = new Size(82, 22);
            payloadSaveButton.TabIndex = 0;
            payloadSaveButton.Text = "Save";
            payloadSaveButton.UseVisualStyleBackColor = true;
            payloadSaveButton.Click += payloadSaveButton_Click;
            // 
            // logTab
            // 
            logTab.Location = new Point(4, 24);
            logTab.Margin = new Padding(3, 2, 3, 2);
            logTab.Name = "logTab";
            logTab.Padding = new Padding(3, 2, 3, 2);
            logTab.Size = new Size(658, 279);
            logTab.TabIndex = 1;
            logTab.Text = "Log";
            logTab.UseVisualStyleBackColor = true;
            // 
            // manualTab
            // 
            manualTab.Controls.Add(host_disconnect_button);
            manualTab.Controls.Add(manual_payload_label);
            manualTab.Controls.Add(host_connect_button);
            manualTab.Controls.Add(host_groupBox);
            manualTab.Controls.Add(manual_send_button);
            manualTab.Controls.Add(manual_textBox);
            manualTab.Location = new Point(4, 24);
            manualTab.Margin = new Padding(3, 2, 3, 2);
            manualTab.Name = "manualTab";
            manualTab.Padding = new Padding(3, 2, 3, 2);
            manualTab.Size = new Size(658, 279);
            manualTab.TabIndex = 0;
            manualTab.Text = "TCP Test";
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
            manual_send_button.Location = new Point(538, 226);
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
            manual_textBox.Size = new Size(618, 174);
            manual_textBox.TabIndex = 0;
            // 
            // ScreenMelder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 337);
            Controls.Add(data_tabControl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ScreenMelder";
            Text = "Form1";
            host_groupBox.ResumeLayout(false);
            host_groupBox.PerformLayout();
            data_tabControl.ResumeLayout(false);
            ocrTab.ResumeLayout(false);
            ocrTab.PerformLayout();
            ocr_roi_groupBox.ResumeLayout(false);
            ocr_roi_groupBox.PerformLayout();
            overlayOutputGroupBox.ResumeLayout(false);
            overlayOutputGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pollingPeriod).EndInit();
            ocrConfigTab.ResumeLayout(false);
            ocrConfigTab.PerformLayout();
            payloadTab.ResumeLayout(false);
            payloadTab.PerformLayout();
            manualTab.ResumeLayout(false);
            manualTab.PerformLayout();
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
        private Label pollingLabel;
        private NumericUpDown pollingPeriod;
        private Button host_disconnect_button;
        private GroupBox overlayOutputGroupBox;
        private Label ocrPayloadRegexLabel;
        private TextBox ocrPayloadRegex;
        private Label captureCountLabel;
        private TextBox captureCount;
        private TabPage ocrConfigTab;
        private TabPage payloadTab;
        private Button configSaveButton;
        private TextBox configTextBox;
        private TextBox payloadTextBox;
        private Button payloadSaveButton;
        private CheckBox configEditCheckBox;
        private CheckBox payloadEditCheckBox;
    }
}