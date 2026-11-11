namespace WeatherPOS
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.api_key_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartServer_btn = new System.Windows.Forms.Button();
            this.tcp_port_nm = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.city_tb = new System.Windows.Forms.TextBox();
            this.weatherUpdate_bw = new System.ComponentModel.BackgroundWorker();
            this.StopServer_btn = new System.Windows.Forms.Button();
            this.SaveSettings_btn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.chk_Api = new System.Windows.Forms.Button();
            this.snd_Test_dta = new System.Windows.Forms.Button();
            this.country_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startTCPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopTCPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateIntms = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tcp_port_nm)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateIntms)).BeginInit();
            this.SuspendLayout();
            // 
            // api_key_tb
            // 
            this.api_key_tb.Location = new System.Drawing.Point(12, 54);
            this.api_key_tb.Name = "api_key_tb";
            this.api_key_tb.Size = new System.Drawing.Size(149, 20);
            this.api_key_tb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "API Key";
            // 
            // StartServer_btn
            // 
            this.StartServer_btn.Location = new System.Drawing.Point(12, 169);
            this.StartServer_btn.Name = "StartServer_btn";
            this.StartServer_btn.Size = new System.Drawing.Size(75, 23);
            this.StartServer_btn.TabIndex = 2;
            this.StartServer_btn.Text = "Start TCP Server";
            this.StartServer_btn.UseVisualStyleBackColor = true;
            this.StartServer_btn.Click += new System.EventHandler(this.StartServer_btn_Click);
            // 
            // tcp_port_nm
            // 
            this.tcp_port_nm.Location = new System.Drawing.Point(12, 131);
            this.tcp_port_nm.Maximum = new decimal(new int[] {
            10010,
            0,
            0,
            0});
            this.tcp_port_nm.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tcp_port_nm.Name = "tcp_port_nm";
            this.tcp_port_nm.Size = new System.Drawing.Size(120, 20);
            this.tcp_port_nm.TabIndex = 0;
            this.tcp_port_nm.Value = new decimal(new int[] {
            10001,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "TCP Port Number";
            // 
            // updateTimer
            // 
            this.updateTimer.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "City";
            // 
            // city_tb
            // 
            this.city_tb.Location = new System.Drawing.Point(171, 53);
            this.city_tb.Name = "city_tb";
            this.city_tb.Size = new System.Drawing.Size(107, 20);
            this.city_tb.TabIndex = 8;
            // 
            // StopServer_btn
            // 
            this.StopServer_btn.Location = new System.Drawing.Point(117, 169);
            this.StopServer_btn.Name = "StopServer_btn";
            this.StopServer_btn.Size = new System.Drawing.Size(75, 23);
            this.StopServer_btn.TabIndex = 2;
            this.StopServer_btn.Text = "Stop TCP Server";
            this.StopServer_btn.UseVisualStyleBackColor = true;
            this.StopServer_btn.Click += new System.EventHandler(this.StopServer_btn_Click);
            // 
            // SaveSettings_btn
            // 
            this.SaveSettings_btn.Location = new System.Drawing.Point(227, 169);
            this.SaveSettings_btn.Name = "SaveSettings_btn";
            this.SaveSettings_btn.Size = new System.Drawing.Size(75, 23);
            this.SaveSettings_btn.TabIndex = 2;
            this.SaveSettings_btn.Text = "Save Settings";
            this.SaveSettings_btn.UseVisualStyleBackColor = true;
            this.SaveSettings_btn.Click += new System.EventHandler(this.SaveSettings_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 237);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(389, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel1.Text = "status_lbl";
            // 
            // chk_Api
            // 
            this.chk_Api.Location = new System.Drawing.Point(12, 81);
            this.chk_Api.Name = "chk_Api";
            this.chk_Api.Size = new System.Drawing.Size(149, 23);
            this.chk_Api.TabIndex = 11;
            this.chk_Api.Text = "Check Weather API";
            this.chk_Api.UseVisualStyleBackColor = true;
            this.chk_Api.Click += new System.EventHandler(this.button1_Click);
            // 
            // snd_Test_dta
            // 
            this.snd_Test_dta.Location = new System.Drawing.Point(227, 131);
            this.snd_Test_dta.Name = "snd_Test_dta";
            this.snd_Test_dta.Size = new System.Drawing.Size(134, 23);
            this.snd_Test_dta.TabIndex = 12;
            this.snd_Test_dta.Text = "Send Test POS Data";
            this.snd_Test_dta.UseVisualStyleBackColor = true;
            this.snd_Test_dta.Click += new System.EventHandler(this.button2_Click);
            // 
            // country_tb
            // 
            this.country_tb.Location = new System.Drawing.Point(284, 53);
            this.country_tb.Name = "country_tb";
            this.country_tb.Size = new System.Drawing.Size(45, 20);
            this.country_tb.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Country";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem,
            this.aboutMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(389, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItem
            // 
            this.MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startTCPToolStripMenuItem,
            this.stopTCPToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.MenuItem.Name = "MenuItem";
            this.MenuItem.Size = new System.Drawing.Size(50, 20);
            this.MenuItem.Text = "Menu";
            // 
            // startTCPToolStripMenuItem
            // 
            this.startTCPToolStripMenuItem.Name = "startTCPToolStripMenuItem";
            this.startTCPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startTCPToolStripMenuItem.Text = "Start TCP";
            this.startTCPToolStripMenuItem.Click += new System.EventHandler(this.startTCPToolStripMenuItem_Click);
            // 
            // stopTCPToolStripMenuItem
            // 
            this.stopTCPToolStripMenuItem.Name = "stopTCPToolStripMenuItem";
            this.stopTCPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stopTCPToolStripMenuItem.Text = "Stop TCP";
            this.stopTCPToolStripMenuItem.Click += new System.EventHandler(this.stopTCPToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // updateIntms
            // 
            this.updateIntms.Location = new System.Drawing.Point(139, 131);
            this.updateIntms.Maximum = new decimal(new int[] {
            600000,
            0,
            0,
            0});
            this.updateIntms.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updateIntms.Name = "updateIntms";
            this.updateIntms.Size = new System.Drawing.Size(64, 20);
            this.updateIntms.TabIndex = 16;
            this.updateIntms.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Update Mins";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 259);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.updateIntms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.country_tb);
            this.Controls.Add(this.snd_Test_dta);
            this.Controls.Add(this.chk_Api);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.city_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tcp_port_nm);
            this.Controls.Add(this.SaveSettings_btn);
            this.Controls.Add(this.StopServer_btn);
            this.Controls.Add(this.StartServer_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.api_key_tb);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Open Weather Map POS";
            ((System.ComponentModel.ISupportInitialize)(this.tcp_port_nm)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateIntms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox api_key_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartServer_btn;
        private System.Windows.Forms.NumericUpDown tcp_port_nm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox city_tb;
        private System.ComponentModel.BackgroundWorker weatherUpdate_bw;
        private System.Windows.Forms.Button StopServer_btn;
        private System.Windows.Forms.Button SaveSettings_btn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button chk_Api;
        private System.Windows.Forms.Button snd_Test_dta;
        private System.Windows.Forms.TextBox country_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem;
        private System.Windows.Forms.ToolStripMenuItem startTCPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopTCPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.NumericUpDown updateIntms;
        private System.Windows.Forms.Label label4;
    }
}

