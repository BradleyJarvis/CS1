namespace Group_project
{
    partial class MainMenuForm
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
            this.textBoxIntro = new System.Windows.Forms.TextBox();
            this.Cryptography = new System.Windows.Forms.Button();
            this.imageLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jumpToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CeasarShift = new System.Windows.Forms.Button();
            this.CeasarShiftContinued = new System.Windows.Forms.Button();
            this.SymetricalKeys = new System.Windows.Forms.Button();
            this.PublicAndPrivateKeys = new System.Windows.Forms.Button();
            this.TwoFactorAuthentication = new System.Windows.Forms.Button();
            this.DigitalCertificatesAndHttps = new System.Windows.Forms.Button();
            this.PasswordManagers = new System.Windows.Forms.Button();
            this.PasswordStrength = new System.Windows.Forms.Button();
            this.PasswordsAndDigitalSecurity = new System.Windows.Forms.Button();
            this.WhitelistsAndEncrption = new System.Windows.Forms.Button();
            this.NetworkFirewalls = new System.Windows.Forms.Button();
            this.PublicWifi = new System.Windows.Forms.Button();
            this.PhysicalHacking = new System.Windows.Forms.Button();
            this.NetworkSecurity = new System.Windows.Forms.Button();
            this.Quiz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxIntro
            // 
            this.textBoxIntro.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIntro.Location = new System.Drawing.Point(256, 27);
            this.textBoxIntro.Multiline = true;
            this.textBoxIntro.Name = "textBoxIntro";
            this.textBoxIntro.ReadOnly = true;
            this.textBoxIntro.Size = new System.Drawing.Size(723, 200);
            this.textBoxIntro.TabIndex = 1;
            this.textBoxIntro.Text = "Welcome to Edu Cyber Scelus , this program will help you understand the world of " +
    "cyber crime and cyber security so that you can lead a safer life online.";
            // 
            // Cryptography
            // 
            this.Cryptography.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cryptography.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cryptography.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Cryptography.Location = new System.Drawing.Point(12, 233);
            this.Cryptography.Name = "Cryptography";
            this.Cryptography.Size = new System.Drawing.Size(238, 91);
            this.Cryptography.TabIndex = 2;
            this.Cryptography.Text = "Cryptography";
            this.Cryptography.UseVisualStyleBackColor = false;
            this.Cryptography.Click += new System.EventHandler(this.buttonSection1Click);
            // 
            // imageLogo
            // 
            this.imageLogo.Image = global::Group_project.Properties.Resources.PlaceholderLogo;
            this.imageLogo.Location = new System.Drawing.Point(12, 27);
            this.imageLogo.Name = "imageLogo";
            this.imageLogo.Size = new System.Drawing.Size(238, 200);
            this.imageLogo.TabIndex = 0;
            this.imageLogo.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jumpToToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(991, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jumpToToolStripMenuItem
            // 
            this.jumpToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem});
            this.jumpToToolStripMenuItem.Name = "jumpToToolStripMenuItem";
            this.jumpToToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.jumpToToolStripMenuItem.Text = "Jump to";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.mainMenuToolStripMenuItem.Text = "Main menu";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitProgram);
            // 
            // CeasarShift
            // 
            this.CeasarShift.Location = new System.Drawing.Point(28, 343);
            this.CeasarShift.Name = "CeasarShift";
            this.CeasarShift.Size = new System.Drawing.Size(184, 37);
            this.CeasarShift.TabIndex = 7;
            this.CeasarShift.Text = "Ceasar Shift";
            this.CeasarShift.UseVisualStyleBackColor = true;
            this.CeasarShift.Visible = false;
            // 
            // CeasarShiftContinued
            // 
            this.CeasarShiftContinued.Location = new System.Drawing.Point(28, 386);
            this.CeasarShiftContinued.Name = "CeasarShiftContinued";
            this.CeasarShiftContinued.Size = new System.Drawing.Size(184, 39);
            this.CeasarShiftContinued.TabIndex = 8;
            this.CeasarShiftContinued.Text = "Ceasar Shift Continued";
            this.CeasarShiftContinued.UseVisualStyleBackColor = true;
            this.CeasarShiftContinued.Visible = false;
            // 
            // SymetricalKeys
            // 
            this.SymetricalKeys.Location = new System.Drawing.Point(28, 431);
            this.SymetricalKeys.Name = "SymetricalKeys";
            this.SymetricalKeys.Size = new System.Drawing.Size(184, 39);
            this.SymetricalKeys.TabIndex = 13;
            this.SymetricalKeys.Text = "Symetrical Keys";
            this.SymetricalKeys.UseVisualStyleBackColor = true;
            this.SymetricalKeys.Visible = false;
            // 
            // PublicAndPrivateKeys
            // 
            this.PublicAndPrivateKeys.Location = new System.Drawing.Point(28, 476);
            this.PublicAndPrivateKeys.Name = "PublicAndPrivateKeys";
            this.PublicAndPrivateKeys.Size = new System.Drawing.Size(184, 39);
            this.PublicAndPrivateKeys.TabIndex = 14;
            this.PublicAndPrivateKeys.Text = "Public And Private Keys";
            this.PublicAndPrivateKeys.UseVisualStyleBackColor = true;
            this.PublicAndPrivateKeys.Visible = false;
            // 
            // TwoFactorAuthentication
            // 
            this.TwoFactorAuthentication.Location = new System.Drawing.Point(272, 476);
            this.TwoFactorAuthentication.Name = "TwoFactorAuthentication";
            this.TwoFactorAuthentication.Size = new System.Drawing.Size(184, 39);
            this.TwoFactorAuthentication.TabIndex = 19;
            this.TwoFactorAuthentication.Text = "Two Factor Authentication";
            this.TwoFactorAuthentication.UseVisualStyleBackColor = true;
            this.TwoFactorAuthentication.Visible = false;
            // 
            // DigitalCertificatesAndHttps
            // 
            this.DigitalCertificatesAndHttps.Location = new System.Drawing.Point(272, 431);
            this.DigitalCertificatesAndHttps.Name = "DigitalCertificatesAndHttps";
            this.DigitalCertificatesAndHttps.Size = new System.Drawing.Size(184, 39);
            this.DigitalCertificatesAndHttps.TabIndex = 18;
            this.DigitalCertificatesAndHttps.Text = "Digital Certificates And Https";
            this.DigitalCertificatesAndHttps.UseVisualStyleBackColor = true;
            this.DigitalCertificatesAndHttps.Visible = false;
            // 
            // PasswordManagers
            // 
            this.PasswordManagers.Location = new System.Drawing.Point(272, 386);
            this.PasswordManagers.Name = "PasswordManagers";
            this.PasswordManagers.Size = new System.Drawing.Size(184, 39);
            this.PasswordManagers.TabIndex = 17;
            this.PasswordManagers.Text = "Password Managers";
            this.PasswordManagers.UseVisualStyleBackColor = true;
            this.PasswordManagers.Visible = false;
            // 
            // PasswordStrength
            // 
            this.PasswordStrength.Location = new System.Drawing.Point(272, 343);
            this.PasswordStrength.Name = "PasswordStrength";
            this.PasswordStrength.Size = new System.Drawing.Size(184, 37);
            this.PasswordStrength.TabIndex = 16;
            this.PasswordStrength.Text = "Password Strength";
            this.PasswordStrength.UseVisualStyleBackColor = true;
            this.PasswordStrength.Visible = false;
            // 
            // PasswordsAndDigitalSecurity
            // 
            this.PasswordsAndDigitalSecurity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PasswordsAndDigitalSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordsAndDigitalSecurity.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PasswordsAndDigitalSecurity.Location = new System.Drawing.Point(256, 233);
            this.PasswordsAndDigitalSecurity.Name = "PasswordsAndDigitalSecurity";
            this.PasswordsAndDigitalSecurity.Size = new System.Drawing.Size(238, 91);
            this.PasswordsAndDigitalSecurity.TabIndex = 15;
            this.PasswordsAndDigitalSecurity.Text = "Passwords And Digital Security";
            this.PasswordsAndDigitalSecurity.UseVisualStyleBackColor = false;
            this.PasswordsAndDigitalSecurity.Click += new System.EventHandler(this.PasswordsAndDigitalSecurity_Click);
            // 
            // WhitelistsAndEncrption
            // 
            this.WhitelistsAndEncrption.Location = new System.Drawing.Point(516, 476);
            this.WhitelistsAndEncrption.Name = "WhitelistsAndEncrption";
            this.WhitelistsAndEncrption.Size = new System.Drawing.Size(184, 39);
            this.WhitelistsAndEncrption.TabIndex = 24;
            this.WhitelistsAndEncrption.Text = "Whitelists And Encrption";
            this.WhitelistsAndEncrption.UseVisualStyleBackColor = true;
            this.WhitelistsAndEncrption.Visible = false;
            // 
            // NetworkFirewalls
            // 
            this.NetworkFirewalls.Location = new System.Drawing.Point(516, 431);
            this.NetworkFirewalls.Name = "NetworkFirewalls";
            this.NetworkFirewalls.Size = new System.Drawing.Size(184, 39);
            this.NetworkFirewalls.TabIndex = 23;
            this.NetworkFirewalls.Text = "Network Firewalls";
            this.NetworkFirewalls.UseVisualStyleBackColor = true;
            this.NetworkFirewalls.Visible = false;
            // 
            // PublicWifi
            // 
            this.PublicWifi.Location = new System.Drawing.Point(516, 386);
            this.PublicWifi.Name = "PublicWifi";
            this.PublicWifi.Size = new System.Drawing.Size(184, 39);
            this.PublicWifi.TabIndex = 22;
            this.PublicWifi.Text = "Public Wifi";
            this.PublicWifi.UseVisualStyleBackColor = true;
            this.PublicWifi.Visible = false;
            // 
            // PhysicalHacking
            // 
            this.PhysicalHacking.Location = new System.Drawing.Point(516, 343);
            this.PhysicalHacking.Name = "PhysicalHacking";
            this.PhysicalHacking.Size = new System.Drawing.Size(184, 37);
            this.PhysicalHacking.TabIndex = 21;
            this.PhysicalHacking.Text = "Physical Hacking";
            this.PhysicalHacking.UseVisualStyleBackColor = true;
            this.PhysicalHacking.Visible = false;
            // 
            // NetworkSecurity
            // 
            this.NetworkSecurity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NetworkSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetworkSecurity.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NetworkSecurity.Location = new System.Drawing.Point(500, 233);
            this.NetworkSecurity.Name = "NetworkSecurity";
            this.NetworkSecurity.Size = new System.Drawing.Size(238, 91);
            this.NetworkSecurity.TabIndex = 20;
            this.NetworkSecurity.Text = "Network Security";
            this.NetworkSecurity.UseVisualStyleBackColor = false;
            this.NetworkSecurity.Click += new System.EventHandler(this.NetworkSecurity_Click);
            // 
            // Quiz
            // 
            this.Quiz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Quiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quiz.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Quiz.Location = new System.Drawing.Point(741, 233);
            this.Quiz.Name = "Quiz";
            this.Quiz.Size = new System.Drawing.Size(238, 91);
            this.Quiz.TabIndex = 25;
            this.Quiz.Text = "Quiz";
            this.Quiz.UseVisualStyleBackColor = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 336);
            this.Controls.Add(this.Quiz);
            this.Controls.Add(this.WhitelistsAndEncrption);
            this.Controls.Add(this.NetworkFirewalls);
            this.Controls.Add(this.PublicWifi);
            this.Controls.Add(this.PhysicalHacking);
            this.Controls.Add(this.NetworkSecurity);
            this.Controls.Add(this.TwoFactorAuthentication);
            this.Controls.Add(this.DigitalCertificatesAndHttps);
            this.Controls.Add(this.PasswordManagers);
            this.Controls.Add(this.PasswordStrength);
            this.Controls.Add(this.PasswordsAndDigitalSecurity);
            this.Controls.Add(this.PublicAndPrivateKeys);
            this.Controls.Add(this.SymetricalKeys);
            this.Controls.Add(this.CeasarShiftContinued);
            this.Controls.Add(this.CeasarShift);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Cryptography);
            this.Controls.Add(this.textBoxIntro);
            this.Controls.Add(this.imageLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edu-cyber scelus";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainMenuClose);
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageLogo;
        private System.Windows.Forms.TextBox textBoxIntro;
        private System.Windows.Forms.Button Cryptography;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jumpToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button CeasarShift;
        private System.Windows.Forms.Button CeasarShiftContinued;
        private System.Windows.Forms.Button SymetricalKeys;
        private System.Windows.Forms.Button PublicAndPrivateKeys;
        private System.Windows.Forms.Button TwoFactorAuthentication;
        private System.Windows.Forms.Button DigitalCertificatesAndHttps;
        private System.Windows.Forms.Button PasswordManagers;
        private System.Windows.Forms.Button PasswordStrength;
        private System.Windows.Forms.Button PasswordsAndDigitalSecurity;
        private System.Windows.Forms.Button WhitelistsAndEncrption;
        private System.Windows.Forms.Button NetworkFirewalls;
        private System.Windows.Forms.Button PublicWifi;
        private System.Windows.Forms.Button PhysicalHacking;
        private System.Windows.Forms.Button NetworkSecurity;
        private System.Windows.Forms.Button Quiz;

    }
}

