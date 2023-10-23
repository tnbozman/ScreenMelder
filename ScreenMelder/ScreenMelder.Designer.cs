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
            manualTab = new TabPage();
            logTab = new TabPage();
            manual_textBox = new TextBox();
            manual_send_button = new Button();
            textBox1 = new TextBox();
            host_groupBox.SuspendLayout();
            data_tabControl.SuspendLayout();
            manualTab.SuspendLayout();
            logTab.SuspendLayout();
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
            host_input.Location = new Point(18, 46);
            host_input.Name = "host_input";
            host_input.Size = new Size(125, 27);
            host_input.TabIndex = 1;
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
            // 
            // host_groupBox
            // 
            host_groupBox.Controls.Add(host_connect_button);
            host_groupBox.Controls.Add(port_input);
            host_groupBox.Controls.Add(host_label);
            host_groupBox.Controls.Add(port_label);
            host_groupBox.Controls.Add(host_input);
            host_groupBox.Location = new Point(621, 58);
            host_groupBox.Name = "host_groupBox";
            host_groupBox.Size = new Size(167, 192);
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
            // 
            // data_tabControl
            // 
            data_tabControl.Controls.Add(logTab);
            data_tabControl.Controls.Add(manualTab);
            data_tabControl.Location = new Point(32, 29);
            data_tabControl.Name = "data_tabControl";
            data_tabControl.SelectedIndex = 0;
            data_tabControl.Size = new Size(547, 346);
            data_tabControl.TabIndex = 5;
            // 
            // manualTab
            // 
            manualTab.Controls.Add(manual_send_button);
            manualTab.Controls.Add(manual_textBox);
            manualTab.Location = new Point(4, 29);
            manualTab.Name = "manualTab";
            manualTab.Padding = new Padding(3);
            manualTab.Size = new Size(539, 313);
            manualTab.TabIndex = 0;
            manualTab.Text = "Manual";
            manualTab.UseVisualStyleBackColor = true;
            // 
            // logTab
            // 
            logTab.Controls.Add(textBox1);
            logTab.Location = new Point(4, 29);
            logTab.Name = "logTab";
            logTab.Padding = new Padding(3);
            logTab.Size = new Size(539, 313);
            logTab.TabIndex = 1;
            logTab.Text = "Log";
            logTab.UseVisualStyleBackColor = true;
            // 
            // manual_textBox
            // 
            manual_textBox.Location = new Point(19, 38);
            manual_textBox.Multiline = true;
            manual_textBox.Name = "manual_textBox";
            manual_textBox.Size = new Size(502, 225);
            manual_textBox.TabIndex = 0;
            // 
            // manual_send_button
            // 
            manual_send_button.Location = new Point(412, 276);
            manual_send_button.Name = "manual_send_button";
            manual_send_button.Size = new Size(94, 29);
            manual_send_button.TabIndex = 1;
            manual_send_button.Text = "Send";
            manual_send_button.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 6);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(527, 301);
            textBox1.TabIndex = 0;
            // 
            // ScreenMelder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(data_tabControl);
            Controls.Add(host_groupBox);
            Name = "ScreenMelder";
            Text = "Form1";
            host_groupBox.ResumeLayout(false);
            host_groupBox.PerformLayout();
            data_tabControl.ResumeLayout(false);
            manualTab.ResumeLayout(false);
            manualTab.PerformLayout();
            logTab.ResumeLayout(false);
            logTab.PerformLayout();
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
    }
}