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
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.gbPlayerConfig = new System.Windows.Forms.GroupBox();
            this.btnPwd = new System.Windows.Forms.Button();
            this.btnAvatarChg = new System.Windows.Forms.Button();
            this.tbRegisDate = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbUID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.gbGameMenu = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbMMStatus = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTimeElapsed = new System.Windows.Forms.Label();
            this.BtnMM = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbPlayerStat = new System.Windows.Forms.GroupBox();
            this.lbTopRole = new System.Windows.Forms.ListBox();
            this.tbWonCount = new System.Windows.Forms.TextBox();
            this.tbPlayedCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.tbMMStatus = new System.Windows.Forms.TextBox();
            this.tbMMElapsed = new System.Windows.Forms.TextBox();
            this.gbPlayerinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.gbPlayerConfig.SuspendLayout();
            this.gbGameMenu.SuspendLayout();
            this.gbPlayerStat.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPlayerinfo
            // 
            this.gbPlayerinfo.Controls.Add(this.pbAvatar);
            this.gbPlayerinfo.Controls.Add(this.gbPlayerConfig);
            this.gbPlayerinfo.Controls.Add(this.tbRegisDate);
            this.gbPlayerinfo.Controls.Add(this.tbUsername);
            this.gbPlayerinfo.Controls.Add(this.tbUID);
            this.gbPlayerinfo.Controls.Add(this.label3);
            this.gbPlayerinfo.Controls.Add(this.label2);
            this.gbPlayerinfo.Controls.Add(this.label1);
            this.gbPlayerinfo.Location = new System.Drawing.Point(12, 12);
            this.gbPlayerinfo.Name = "gbPlayerinfo";
            this.gbPlayerinfo.Size = new System.Drawing.Size(378, 200);
            this.gbPlayerinfo.TabIndex = 0;
            this.gbPlayerinfo.TabStop = false;
            this.gbPlayerinfo.Text = "Account Information";
            // 
            // pbAvatar
            // 
            this.pbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAvatar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbAvatar.InitialImage = global::WerewolfClient.Properties.Resources.Icon01;
            this.pbAvatar.Location = new System.Drawing.Point(247, 16);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(128, 181);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 6;
            this.pbAvatar.TabStop = false;
            // 
            // gbPlayerConfig
            // 
            this.gbPlayerConfig.Controls.Add(this.btnPwd);
            this.gbPlayerConfig.Controls.Add(this.btnAvatarChg);
            this.gbPlayerConfig.Location = new System.Drawing.Point(3, 131);
            this.gbPlayerConfig.Name = "gbPlayerConfig";
            this.gbPlayerConfig.Size = new System.Drawing.Size(238, 68);
            this.gbPlayerConfig.TabIndex = 5;
            this.gbPlayerConfig.TabStop = false;
            this.gbPlayerConfig.Text = "Account Setting";
            // 
            // btnPwd
            // 
            this.btnPwd.Location = new System.Drawing.Point(6, 19);
            this.btnPwd.Name = "btnPwd";
            this.btnPwd.Size = new System.Drawing.Size(106, 36);
            this.btnPwd.TabIndex = 0;
            this.btnPwd.Text = "Change Password";
            this.btnPwd.UseVisualStyleBackColor = true;
            // 
            // btnAvatarChg
            // 
            this.btnAvatarChg.Enabled = false;
            this.btnAvatarChg.Location = new System.Drawing.Point(126, 19);
            this.btnAvatarChg.Name = "btnAvatarChg";
            this.btnAvatarChg.Size = new System.Drawing.Size(106, 36);
            this.btnAvatarChg.TabIndex = 0;
            this.btnAvatarChg.Text = "Change Avatar";
            this.btnAvatarChg.UseVisualStyleBackColor = true;
            // 
            // tbRegisDate
            // 
            this.tbRegisDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRegisDate.Enabled = false;
            this.tbRegisDate.Location = new System.Drawing.Point(100, 73);
            this.tbRegisDate.Name = "tbRegisDate";
            this.tbRegisDate.ReadOnly = true;
            this.tbRegisDate.Size = new System.Drawing.Size(135, 13);
            this.tbRegisDate.TabIndex = 4;
            // 
            // tbUsername
            // 
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Enabled = false;
            this.tbUsername.Location = new System.Drawing.Point(100, 47);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.ReadOnly = true;
            this.tbUsername.Size = new System.Drawing.Size(135, 13);
            this.tbUsername.TabIndex = 4;
            // 
            // tbUID
            // 
            this.tbUID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUID.Enabled = false;
            this.tbUID.Location = new System.Drawing.Point(100, 23);
            this.tbUID.Name = "tbUID";
            this.tbUID.ReadOnly = true;
            this.tbUID.Size = new System.Drawing.Size(135, 13);
            this.tbUID.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Registered On:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 47);
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
            // btnLogoff
            // 
            this.btnLogoff.Location = new System.Drawing.Point(12, 422);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(112, 54);
            this.btnLogoff.TabIndex = 1;
            this.btnLogoff.Text = "Logoff";
            this.btnLogoff.UseVisualStyleBackColor = true;
            this.btnLogoff.Click += new System.EventHandler(this.BtnLogoff_Click);
            // 
            // gbGameMenu
            // 
            this.gbGameMenu.Controls.Add(this.tbMMElapsed);
            this.gbGameMenu.Controls.Add(this.tbMMStatus);
            this.gbGameMenu.Controls.Add(this.label8);
            this.gbGameMenu.Controls.Add(this.lbMMStatus);
            this.gbGameMenu.Controls.Add(this.label9);
            this.gbGameMenu.Controls.Add(this.lbTimeElapsed);
            this.gbGameMenu.Controls.Add(this.BtnMM);
            this.gbGameMenu.Location = new System.Drawing.Point(404, 240);
            this.gbGameMenu.Name = "gbGameMenu";
            this.gbGameMenu.Size = new System.Drawing.Size(378, 237);
            this.gbGameMenu.TabIndex = 1;
            this.gbGameMenu.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Status:";
            // 
            // lbMMStatus
            // 
            this.lbMMStatus.AutoSize = true;
            this.lbMMStatus.Location = new System.Drawing.Point(120, 31);
            this.lbMMStatus.Name = "lbMMStatus";
            this.lbMMStatus.Size = new System.Drawing.Size(0, 13);
            this.lbMMStatus.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Time Elapsed:";
            // 
            // lbTimeElapsed
            // 
            this.lbTimeElapsed.AutoSize = true;
            this.lbTimeElapsed.Location = new System.Drawing.Point(120, 69);
            this.lbTimeElapsed.Name = "lbTimeElapsed";
            this.lbTimeElapsed.Size = new System.Drawing.Size(0, 13);
            this.lbTimeElapsed.TabIndex = 4;
            // 
            // BtnMM
            // 
            this.BtnMM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnMM.Location = new System.Drawing.Point(3, 184);
            this.BtnMM.Name = "BtnMM";
            this.BtnMM.Size = new System.Drawing.Size(372, 50);
            this.BtnMM.TabIndex = 3;
            this.BtnMM.Text = "Find Game";
            this.BtnMM.UseVisualStyleBackColor = true;
            this.BtnMM.Click += new System.EventHandler(this.BtnMM_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "# Games Played:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "# Games Won:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 23);
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
            this.gbPlayerStat.Controls.Add(this.label7);
            this.gbPlayerStat.Controls.Add(this.label5);
            this.gbPlayerStat.Controls.Add(this.label6);
            this.gbPlayerStat.Controls.Add(this.label4);
            this.gbPlayerStat.Location = new System.Drawing.Point(404, 12);
            this.gbPlayerStat.Name = "gbPlayerStat";
            this.gbPlayerStat.Size = new System.Drawing.Size(378, 200);
            this.gbPlayerStat.TabIndex = 5;
            this.gbPlayerStat.TabStop = false;
            this.gbPlayerStat.Text = "Player Statistics";
            // 
            // lbTopRole
            // 
            this.lbTopRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbTopRole.FormattingEnabled = true;
            this.lbTopRole.Location = new System.Drawing.Point(246, 23);
            this.lbTopRole.Name = "lbTopRole";
            this.lbTopRole.Size = new System.Drawing.Size(110, 156);
            this.lbTopRole.TabIndex = 7;
            // 
            // tbWonCount
            // 
            this.tbWonCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWonCount.Location = new System.Drawing.Point(100, 59);
            this.tbWonCount.Name = "tbWonCount";
            this.tbWonCount.ReadOnly = true;
            this.tbWonCount.Size = new System.Drawing.Size(75, 13);
            this.tbWonCount.TabIndex = 6;
            // 
            // tbPlayedCount
            // 
            this.tbPlayedCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPlayedCount.Location = new System.Drawing.Point(100, 31);
            this.tbPlayedCount.Name = "tbPlayedCount";
            this.tbPlayedCount.ReadOnly = true;
            this.tbPlayedCount.Size = new System.Drawing.Size(75, 13);
            this.tbPlayedCount.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Win Ratio:";
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(161, 422);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(112, 54);
            this.BtnQuit.TabIndex = 1;
            this.BtnQuit.Text = "Quit";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnLogoff_Click);
            // 
            // tbMMStatus
            // 
            this.tbMMStatus.BackColor = System.Drawing.SystemColors.Control;
            this.tbMMStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMMStatus.Location = new System.Drawing.Point(126, 31);
            this.tbMMStatus.Name = "tbMMStatus";
            this.tbMMStatus.Size = new System.Drawing.Size(220, 13);
            this.tbMMStatus.TabIndex = 5;
            // 
            // tbMMElapsed
            // 
            this.tbMMElapsed.BackColor = System.Drawing.SystemColors.Control;
            this.tbMMElapsed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMMElapsed.Enabled = false;
            this.tbMMElapsed.Location = new System.Drawing.Point(126, 69);
            this.tbMMElapsed.Name = "tbMMElapsed";
            this.tbMMElapsed.Size = new System.Drawing.Size(220, 13);
            this.tbMMElapsed.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(794, 501);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.btnLogoff);
            this.Controls.Add(this.gbPlayerStat);
            this.Controls.Add(this.gbGameMenu);
            this.Controls.Add(this.gbPlayerinfo);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.gbPlayerinfo.ResumeLayout(false);
            this.gbPlayerinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.gbPlayerConfig.ResumeLayout(false);
            this.gbGameMenu.ResumeLayout(false);
            this.gbGameMenu.PerformLayout();
            this.gbPlayerStat.ResumeLayout(false);
            this.gbPlayerStat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPlayerinfo;
        private System.Windows.Forms.GroupBox gbGameMenu;
        private System.Windows.Forms.Button BtnMM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbPlayerStat;
        private System.Windows.Forms.TextBox tbRegisDate;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbUID;
        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.Button btnPwd;
        private System.Windows.Forms.TextBox tbWonCount;
        private System.Windows.Forms.TextBox tbPlayedCount;
        private System.Windows.Forms.ListBox lbTopRole;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.GroupBox gbPlayerConfig;
        private System.Windows.Forms.Button btnAvatarChg;
        private System.Windows.Forms.Label lbMMStatus;
        private System.Windows.Forms.Label lbTimeElapsed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbMMElapsed;
        private System.Windows.Forms.TextBox tbMMStatus;
    }
}