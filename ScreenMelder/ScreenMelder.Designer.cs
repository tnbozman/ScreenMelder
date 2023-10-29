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
            ocrPayloadRegexLabel = new Label();
            ocrPayloadRegex = new TextBox();
            overlayOutputPath = new TextBox();
            ocrOverlayLabel = new Label();
            overlayOutputGroupBox = new GroupBox();
            overlayOutputEnable = new CheckBox();
            pollingPeriod = new NumericUpDown();
            payloadTemplatePath = new TextBox();
            configPath = new TextBox();
            pollingLabel = new Label();
            ocrTemplateLabel = new Label();
            ocrRoiConfigLabel = new Label();
            stopOcrButton = new Button();
            ocrStartButton = new Button();
            logTab = new TabPage();
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
            overlayOutputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pollingPeriod).BeginInit();
            logTab.SuspendLayout();
            manualTab.SuspendLayout();
            ocr_roi_groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // host_label
            // 
            host_label.AutoSize = true;
            host_label.Location = new Point(31, 23);
            host_label.Name = "host_label";
            host_label.Size = new Size(78, 20);
            host_label.TabIndex = 0;
            host_label.Text = "IP Address";
            // 
            // host_input
            // 
            host_input.Location = new Point(31, 45);
            host_input.Name = "host_input";
            host_input.Size = new Size(125, 27);
            host_input.TabIndex = 1;
            host_input.Text = "127.0.0.1";
            // 
            // port_label
            // 
            port_label.AutoSize = true;
            port_label.Location = new Point(31, 76);
            port_label.Name = "port_label";
            port_label.Size = new Size(35, 20);
            port_label.TabIndex = 2;
            port_label.Text = "Port";
            // 
            // port_input
            // 
            port_input.Location = new Point(31, 99);
            port_input.Name = "port_input";
            port_input.Size = new Size(125, 27);
            port_input.TabIndex = 3;
            port_input.Text = "9090";
            // 
            // host_groupBox
            // 
            host_groupBox.Controls.Add(host_disconnect_button);
            host_groupBox.Controls.Add(host_connect_button);
            host_groupBox.Controls.Add(port_input);
            host_groupBox.Controls.Add(host_label);
            host_groupBox.Controls.Add(port_label);
            host_groupBox.Controls.Add(host_input);
            host_groupBox.Location = new Point(585, 59);
            host_groupBox.Name = "host_groupBox";
            host_groupBox.Size = new Size(218, 196);
            host_groupBox.TabIndex = 4;
            host_groupBox.TabStop = false;
            host_groupBox.Text = "Host Details";
            // 
            // host_disconnect_button
            // 
            host_disconnect_button.Enabled = false;
            host_disconnect_button.Location = new Point(109, 149);
            host_disconnect_button.Name = "host_disconnect_button";
            host_disconnect_button.Size = new Size(94, 29);
            host_disconnect_button.TabIndex = 5;
            host_disconnect_button.Text = "Disconnect";
            host_disconnect_button.UseVisualStyleBackColor = true;
            host_disconnect_button.Click += host_disconnect_button_Click;
            // 
            // host_connect_button
            // 
            host_connect_button.Location = new Point(6, 149);
            host_connect_button.Name = "host_connect_button";
            host_connect_button.Size = new Size(94, 29);
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
            data_tabControl.Location = new Point(32, 29);
            data_tabControl.Name = "data_tabControl";
            data_tabControl.SelectedIndex = 0;
            data_tabControl.Size = new Size(547, 409);
            data_tabControl.TabIndex = 5;
            // 
            // ocrTab
            // 
            ocrTab.Controls.Add(captureCount);
            ocrTab.Controls.Add(captureCountLabel);
            ocrTab.Controls.Add(ocrPayloadRegexLabel);
            ocrTab.Controls.Add(ocrPayloadRegex);
            ocrTab.Controls.Add(overlayOutputPath);
            ocrTab.Controls.Add(ocrOverlayLabel);
            ocrTab.Controls.Add(overlayOutputGroupBox);
            ocrTab.Controls.Add(pollingPeriod);
            ocrTab.Controls.Add(payloadTemplatePath);
            ocrTab.Controls.Add(configPath);
            ocrTab.Controls.Add(pollingLabel);
            ocrTab.Controls.Add(ocrTemplateLabel);
            ocrTab.Controls.Add(ocrRoiConfigLabel);
            ocrTab.Controls.Add(stopOcrButton);
            ocrTab.Controls.Add(ocrStartButton);
            ocrTab.Location = new Point(4, 29);
            ocrTab.Name = "ocrTab";
            ocrTab.Padding = new Padding(3);
            ocrTab.Size = new Size(539, 376);
            ocrTab.TabIndex = 2;
            ocrTab.Text = "OCR";
            ocrTab.UseVisualStyleBackColor = true;
            // 
            // captureCount
            // 
            captureCount.Location = new Point(297, 107);
            captureCount.Name = "captureCount";
            captureCount.Size = new Size(199, 27);
            captureCount.TabIndex = 17;
            captureCount.Text = "data.shotnumber";
            // 
            // captureCountLabel
            // 
            captureCountLabel.AutoSize = true;
            captureCountLabel.Location = new Point(298, 84);
            captureCountLabel.Name = "captureCountLabel";
            captureCountLabel.Size = new Size(144, 20);
            captureCountLabel.TabIndex = 16;
            captureCountLabel.Text = "Capture Count Label";
            // 
            // ocrPayloadRegexLabel
            // 
            ocrPayloadRegexLabel.AutoSize = true;
            ocrPayloadRegexLabel.Location = new Point(297, 24);
            ocrPayloadRegexLabel.Name = "ocrPayloadRegexLabel";
            ocrPayloadRegexLabel.Size = new Size(164, 20);
            ocrPayloadRegexLabel.TabIndex = 15;
            ocrPayloadRegexLabel.Text = "Payload Cleanup Regex";
            // 
            // ocrPayloadRegex
            // 
            ocrPayloadRegex.Location = new Point(297, 47);
            ocrPayloadRegex.Name = "ocrPayloadRegex";
            ocrPayloadRegex.Size = new Size(199, 27);
            ocrPayloadRegex.TabIndex = 14;
            ocrPayloadRegex.Text = "\\s+";
            ocrPayloadRegex.TextChanged += ocrPayloadRegex_TextChanged;
            // 
            // overlayOutputPath
            // 
            overlayOutputPath.Location = new Point(20, 235);
            overlayOutputPath.Name = "overlayOutputPath";
            overlayOutputPath.Size = new Size(221, 27);
            overlayOutputPath.TabIndex = 10;
            overlayOutputPath.Text = "output/overlay.png";
            // 
            // ocrOverlayLabel
            // 
            ocrOverlayLabel.AutoSize = true;
            ocrOverlayLabel.Location = new Point(20, 212);
            ocrOverlayLabel.Name = "ocrOverlayLabel";
            ocrOverlayLabel.Size = new Size(37, 20);
            ocrOverlayLabel.TabIndex = 6;
            ocrOverlayLabel.Text = "Path";
            // 
            // overlayOutputGroupBox
            // 
            overlayOutputGroupBox.Controls.Add(overlayOutputEnable);
            overlayOutputGroupBox.Location = new Point(6, 143);
            overlayOutputGroupBox.Name = "overlayOutputGroupBox";
            overlayOutputGroupBox.Size = new Size(244, 127);
            overlayOutputGroupBox.TabIndex = 13;
            overlayOutputGroupBox.TabStop = false;
            overlayOutputGroupBox.Text = "Overlay Output";
            overlayOutputGroupBox.Enter += groupBox1_Enter;
            // 
            // overlayOutputEnable
            // 
            overlayOutputEnable.AutoSize = true;
            overlayOutputEnable.Location = new Point(14, 30);
            overlayOutputEnable.Name = "overlayOutputEnable";
            overlayOutputEnable.Size = new Size(76, 24);
            overlayOutputEnable.TabIndex = 3;
            overlayOutputEnable.Text = "Enable";
            overlayOutputEnable.UseVisualStyleBackColor = true;
            // 
            // pollingPeriod
            // 
            pollingPeriod.Location = new Point(166, 276);
            pollingPeriod.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            pollingPeriod.Name = "pollingPeriod";
            pollingPeriod.Size = new Size(84, 27);
            pollingPeriod.TabIndex = 12;
            pollingPeriod.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // payloadTemplatePath
            // 
            payloadTemplatePath.Location = new Point(20, 109);
            payloadTemplatePath.Name = "payloadTemplatePath";
            payloadTemplatePath.Size = new Size(221, 27);
            payloadTemplatePath.TabIndex = 9;
            payloadTemplatePath.Text = "config/payload.json";
            // 
            // configPath
            // 
            configPath.Location = new Point(20, 47);
            configPath.Name = "configPath";
            configPath.Size = new Size(221, 27);
            configPath.TabIndex = 8;
            configPath.Text = "config/config.json";
            // 
            // pollingLabel
            // 
            pollingLabel.AutoSize = true;
            pollingLabel.Location = new Point(20, 278);
            pollingLabel.Name = "pollingLabel";
            pollingLabel.Size = new Size(133, 20);
            pollingLabel.TabIndex = 7;
            pollingLabel.Text = "Polling Period (ms)";
            // 
            // ocrTemplateLabel
            // 
            ocrTemplateLabel.AutoSize = true;
            ocrTemplateLabel.Location = new Point(20, 85);
            ocrTemplateLabel.Name = "ocrTemplateLabel";
            ocrTemplateLabel.Size = new Size(159, 20);
            ocrTemplateLabel.TabIndex = 5;
            ocrTemplateLabel.Text = "Payload Template Path";
            // 
            // ocrRoiConfigLabel
            // 
            ocrRoiConfigLabel.AutoSize = true;
            ocrRoiConfigLabel.Location = new Point(20, 24);
            ocrRoiConfigLabel.Name = "ocrRoiConfigLabel";
            ocrRoiConfigLabel.Size = new Size(111, 20);
            ocrRoiConfigLabel.TabIndex = 4;
            ocrRoiConfigLabel.Text = "Roi Config Path";
            // 
            // stopOcrButton
            // 
            stopOcrButton.Enabled = false;
            stopOcrButton.ForeColor = Color.Red;
            stopOcrButton.Location = new Point(335, 321);
            stopOcrButton.Name = "stopOcrButton";
            stopOcrButton.Size = new Size(94, 29);
            stopOcrButton.TabIndex = 2;
            stopOcrButton.Text = "Stop";
            stopOcrButton.UseVisualStyleBackColor = true;
            stopOcrButton.Click += stopOcrButton_Click;
            // 
            // ocrStartButton
            // 
            ocrStartButton.ForeColor = Color.Black;
            ocrStartButton.Location = new Point(235, 321);
            ocrStartButton.Name = "ocrStartButton";
            ocrStartButton.Size = new Size(94, 29);
            ocrStartButton.TabIndex = 1;
            ocrStartButton.Text = "Start";
            ocrStartButton.UseVisualStyleBackColor = true;
            ocrStartButton.Click += ocrStartButton_Click;
            // 
            // logTab
            // 
            
            logTab.Location = new Point(4, 29);
            logTab.Name = "logTab";
            logTab.Padding = new Padding(3);
            logTab.Size = new Size(539, 376);
            logTab.TabIndex = 1;
            logTab.Text = "Log";
            logTab.UseVisualStyleBackColor = true;

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
            manual_send_button.Click += manual_send_button_Click;
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
            ocr_roi_groupBox.Size = new Size(218, 173);
            ocr_roi_groupBox.TabIndex = 7;
            ocr_roi_groupBox.TabStop = false;
            ocr_roi_groupBox.Text = "OCR ROIs";
            // 
            // ocrROICaptureTargetOptions
            // 
            ocrROICaptureTargetOptions.FormattingEnabled = true;
            ocrROICaptureTargetOptions.Location = new Point(18, 107);
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
            ocrROIOptions.Location = new Point(18, 45);
            ocrROIOptions.Name = "ocrROIOptions";
            ocrROIOptions.Size = new Size(166, 28);
            ocrROIOptions.TabIndex = 8;
            ocrROIOptions.SelectedIndexChanged += ocrROIOptions_SelectedIndexChanged;
            // 
            // ScreenMelder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 451);
            Controls.Add(data_tabControl);
            Controls.Add(host_groupBox);
            Controls.Add(ocr_roi_groupBox);
            Name = "ScreenMelder";
            Text = "Form1";
            host_groupBox.ResumeLayout(false);
            host_groupBox.PerformLayout();
            data_tabControl.ResumeLayout(false);
            ocrTab.ResumeLayout(false);
            ocrTab.PerformLayout();
            overlayOutputGroupBox.ResumeLayout(false);
            overlayOutputGroupBox.PerformLayout();
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
        private Button host_disconnect_button;
        private GroupBox overlayOutputGroupBox;
        private Label ocrPayloadRegexLabel;
        private TextBox ocrPayloadRegex;
        private Label captureCountLabel;
        private TextBox captureCount;
    }
}