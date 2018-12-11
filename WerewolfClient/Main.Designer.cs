namespace WerewolfClient
{
    partial class Main
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
            this.gbPlayerinfo = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbUID = new System.Windows.Forms.TextBox();
            this.gbAccSettings = new System.Windows.Forms.GroupBox();
            this.btnAvatar = new System.Windows.Forms.Button();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.btnPwd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbGameMenu = new System.Windows.Forms.GroupBox();
            this.btnMM = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbPlayerStat = new System.Windows.Forms.GroupBox();
            this.lbTopRole = new System.Windows.Forms.ListBox();
            this.tbWonCount = new System.Windows.Forms.TextBox();
            this.tbPlayedCount = new System.Windows.Forms.TextBox();
            this.gbPlayerinfo.SuspendLayout();
            this.gbAccSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbGameMenu.SuspendLayout();
            this.gbPlayerStat.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPlayerinfo
            // 
            this.gbPlayerinfo.Controls.Add(this.textBox3);
            this.gbPlayerinfo.Controls.Add(this.tbUsername);
            this.gbPlayerinfo.Controls.Add(this.tbUID);
            this.gbPlayerinfo.Controls.Add(this.gbAccSettings);
            this.gbPlayerinfo.Controls.Add(this.label3);
            this.gbPlayerinfo.Controls.Add(this.label2);
            this.gbPlayerinfo.Controls.Add(this.label1);
            this.gbPlayerinfo.Controls.Add(this.pictureBox1);
            this.gbPlayerinfo.Location = new System.Drawing.Point(13, 13);
            this.gbPlayerinfo.Name = "gbPlayerinfo";
            this.gbPlayerinfo.Size = new System.Drawing.Size(385, 202);
            this.gbPlayerinfo.TabIndex = 0;
            this.gbPlayerinfo.TabStop = false;
            this.gbPlayerinfo.Text = "Playerinfo";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(100, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 13);
            this.textBox3.TabIndex = 4;
            // 
            // tbUsername
            // 
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Location = new System.Drawing.Point(100, 48);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.ReadOnly = true;
            this.tbUsername.Size = new System.Drawing.Size(100, 13);
            this.tbUsername.TabIndex = 4;
            // 
            // tbUID
            // 
            this.tbUID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUID.Location = new System.Drawing.Point(100, 23);
            this.tbUID.Name = "tbUID";
            this.tbUID.ReadOnly = true;
            this.tbUID.Size = new System.Drawing.Size(100, 13);
            this.tbUID.TabIndex = 4;
            // 
            // gbAccSettings
            // 
            this.gbAccSettings.Controls.Add(this.btnAvatar);
            this.gbAccSettings.Controls.Add(this.btnPwd);
            this.gbAccSettings.Location = new System.Drawing.Point(7, 137);
            this.gbAccSettings.Name = "gbAccSettings";
            this.gbAccSettings.Size = new System.Drawing.Size(215, 54);
            this.gbAccSettings.TabIndex = 3;
            this.gbAccSettings.TabStop = false;
            this.gbAccSettings.Text = "Account Settings";
            // 
            // btnAvatar
            // 
            this.btnAvatar.Enabled = false;
            this.btnAvatar.Location = new System.Drawing.Point(108, 19);
            this.btnAvatar.Name = "btnAvatar";
            this.btnAvatar.Size = new System.Drawing.Size(101, 23);
            this.btnAvatar.TabIndex = 1;
            this.btnAvatar.Text = "Change Avatar";
            this.btnAvatar.UseVisualStyleBackColor = true;
            // 
            // btnLogoff
            // 
            this.btnLogoff.Location = new System.Drawing.Point(13, 30);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(120, 50);
            this.btnLogoff.TabIndex = 1;
            this.btnLogoff.Text = "Logoff";
            this.btnLogoff.UseVisualStyleBackColor = true;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // btnPwd
            // 
            this.btnPwd.Location = new System.Drawing.Point(6, 19);
            this.btnPwd.Name = "btnPwd";
            this.btnPwd.Size = new System.Drawing.Size(102, 23);
            this.btnPwd.TabIndex = 0;
            this.btnPwd.Text = "Change Password";
            this.btnPwd.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Registered On:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(228, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 175);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbGameMenu
            // 
            this.gbGameMenu.Controls.Add(this.btnMM);
            this.gbGameMenu.Controls.Add(this.btnLogoff);
            this.gbGameMenu.Location = new System.Drawing.Point(13, 231);
            this.gbGameMenu.Name = "gbGameMenu";
            this.gbGameMenu.Size = new System.Drawing.Size(385, 101);
            this.gbGameMenu.TabIndex = 1;
            this.gbGameMenu.TabStop = false;
            this.gbGameMenu.Text = "Menu";
            // 
            // btnMM
            // 
            this.btnMM.Location = new System.Drawing.Point(248, 30);
            this.btnMM.Name = "btnMM";
            this.btnMM.Size = new System.Drawing.Size(120, 50);
            this.btnMM.TabIndex = 3;
            this.btnMM.Text = "Auto Matchmaking";
            this.btnMM.UseVisualStyleBackColor = true;
            this.btnMM.Click += new System.EventHandler(this.btnMM_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "# Games Played:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "# Games Won:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Top Roles:";
            // 
            // gbPlayerStat
            // 
            this.gbPlayerStat.Controls.Add(this.lbTopRole);
            this.gbPlayerStat.Controls.Add(this.tbWonCount);
            this.gbPlayerStat.Controls.Add(this.tbPlayedCount);
            this.gbPlayerStat.Controls.Add(this.label5);
            this.gbPlayerStat.Controls.Add(this.label6);
            this.gbPlayerStat.Controls.Add(this.label4);
            this.gbPlayerStat.Location = new System.Drawing.Point(404, 13);
            this.gbPlayerStat.Name = "gbPlayerStat";
            this.gbPlayerStat.Size = new System.Drawing.Size(385, 202);
            this.gbPlayerStat.TabIndex = 5;
            this.gbPlayerStat.TabStop = false;
            this.gbPlayerStat.Text = "Stats";
            // 
            // lbTopRole
            // 
            this.lbTopRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbTopRole.FormattingEnabled = true;
            this.lbTopRole.Location = new System.Drawing.Point(260, 24);
            this.lbTopRole.Name = "lbTopRole";
            this.lbTopRole.Size = new System.Drawing.Size(110, 117);
            this.lbTopRole.TabIndex = 7;
            // 
            // tbWonCount
            // 
            this.tbWonCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWonCount.Location = new System.Drawing.Point(104, 59);
            this.tbWonCount.Name = "tbWonCount";
            this.tbWonCount.ReadOnly = true;
            this.tbWonCount.Size = new System.Drawing.Size(75, 13);
            this.tbWonCount.TabIndex = 6;
            // 
            // tbPlayedCount
            // 
            this.tbPlayedCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPlayedCount.Location = new System.Drawing.Point(104, 27);
            this.tbPlayedCount.Name = "tbPlayedCount";
            this.tbPlayedCount.ReadOnly = true;
            this.tbPlayedCount.Size = new System.Drawing.Size(75, 13);
            this.tbPlayedCount.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.gbPlayerStat);
            this.Controls.Add(this.gbGameMenu);
            this.Controls.Add(this.gbPlayerinfo);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.gbPlayerinfo.ResumeLayout(false);
            this.gbPlayerinfo.PerformLayout();
            this.gbAccSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbGameMenu.ResumeLayout(false);
            this.gbPlayerStat.ResumeLayout(false);
            this.gbPlayerStat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPlayerinfo;
        private System.Windows.Forms.GroupBox gbGameMenu;
        private System.Windows.Forms.Button btnMM;
        private System.Windows.Forms.GroupBox gbAccSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbPlayerStat;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbUID;
        private System.Windows.Forms.Button btnAvatar;
        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.Button btnPwd;
        private System.Windows.Forms.TextBox tbWonCount;
        private System.Windows.Forms.TextBox tbPlayedCount;
        private System.Windows.Forms.ListBox lbTopRole;
    }
}