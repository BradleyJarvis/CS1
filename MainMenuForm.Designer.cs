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
            this.CeasarShift = new System.Windows.Forms.Button();
            this.CeasarShiftContinued = new System.Windows.Forms.Button();
            this.SymetricalKeys = new System.Windows.Forms.Button();
            this.PublicAndPrivateKeys = new System.Windows.Forms.Button();
            this.TwoFactorAuthentication = new System.Windows.Forms.Button();
            this.DigitalCertificatesAndHttps = new System.Windows.Forms.Button();
            this.PasswordManagers = new System.Windows.Forms.Button();
            this.PasswordStrength = new System.Windows.Forms.Button();
            this.PasswordsAndDigitalSecurity = new System.Windows.Forms.Button();
            this.WhitelistsAndEncryption = new System.Windows.Forms.Button();
            this.NetworkFirewalls = new System.Windows.Forms.Button();
            this.PublicWifi = new System.Windows.Forms.Button();
            this.PhysicalHacking = new System.Windows.Forms.Button();
            this.NetworkSecurity = new System.Windows.Forms.Button();
            this.Quiz = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jumpToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cryptographyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ceasarShiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ceasarShiftContToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.symetricalKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicAndPrivateKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitalSecurityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordStrengthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordManagersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitalCertificatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factorAuthenticationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkSecurityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.physicalHackingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicWifiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firewallsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whitelistsEncryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).BeginInit();
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
            // CeasarShift
            // 
            this.CeasarShift.Location = new System.Drawing.Point(28, 343);
            this.CeasarShift.Name = "CeasarShift";
            this.CeasarShift.Size = new System.Drawing.Size(184, 37);
            this.CeasarShift.TabIndex = 7;
            this.CeasarShift.Text = "Ceasar Shift";
            this.CeasarShift.UseVisualStyleBackColor = true;
            this.CeasarShift.Visible = false;
            this.CeasarShift.Click += new System.EventHandler(this.CeasarShift_Click);
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
            this.CeasarShiftContinued.Click += new System.EventHandler(this.CeasarShiftContinued_Click);
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
            this.SymetricalKeys.Click += new System.EventHandler(this.SymetricalKeys_Click);
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
            this.PublicAndPrivateKeys.Click += new System.EventHandler(this.PublicAndPrivateKeys_Click);
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
            this.TwoFactorAuthentication.Click += new System.EventHandler(this.TwoFactorAuthentication_Click);
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
            this.DigitalCertificatesAndHttps.Click += new System.EventHandler(this.DigitalCertificatesAndHttps_Click);
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
            this.PasswordManagers.Click += new System.EventHandler(this.PasswordManagers_Click);
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
            this.PasswordStrength.Click += new System.EventHandler(this.PasswordStrength_Click);
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
            // WhitelistsAndEncryption
            // 
            this.WhitelistsAndEncryption.Location = new System.Drawing.Point(516, 476);
            this.WhitelistsAndEncryption.Name = "WhitelistsAndEncryption";
            this.WhitelistsAndEncryption.Size = new System.Drawing.Size(184, 39);
            this.WhitelistsAndEncryption.TabIndex = 24;
            this.WhitelistsAndEncryption.Text = "Whitelists And Encryption";
            this.WhitelistsAndEncryption.UseVisualStyleBackColor = true;
            this.WhitelistsAndEncryption.Visible = false;
            this.WhitelistsAndEncryption.Click += new System.EventHandler(this.WhitelistsAndEncrption_Click);
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
            this.NetworkFirewalls.Click += new System.EventHandler(this.NetworkFirewalls_Click);
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
            this.PublicWifi.Click += new System.EventHandler(this.PublicWifi_Click);
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
            this.PhysicalHacking.Click += new System.EventHandler(this.PhysicalHacking_Click);
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
            this.Quiz.Click += new System.EventHandler(this.Quiz_Click);
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
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jumpToToolStripMenuItem
            // 
            this.jumpToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.cryptographyToolStripMenuItem,
            this.digitalSecurityToolStripMenuItem,
            this.networkSecurityToolStripMenuItem});
            this.jumpToToolStripMenuItem.Name = "jumpToToolStripMenuItem";
            this.jumpToToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.jumpToToolStripMenuItem.Text = "Jump to";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.mainMenuToolStripMenuItem.Text = "Main menu";
            // 
            // cryptographyToolStripMenuItem
            // 
            this.cryptographyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ceasarShiftToolStripMenuItem,
            this.ceasarShiftContToolStripMenuItem,
            this.symetricalKeysToolStripMenuItem,
            this.publicAndPrivateKeysToolStripMenuItem});
            this.cryptographyToolStripMenuItem.Name = "cryptographyToolStripMenuItem";
            this.cryptographyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cryptographyToolStripMenuItem.Text = "Cryptography";
            // 
            // ceasarShiftToolStripMenuItem
            // 
            this.ceasarShiftToolStripMenuItem.Name = "ceasarShiftToolStripMenuItem";
            this.ceasarShiftToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.ceasarShiftToolStripMenuItem.Text = "Ceasar Shift";
            this.ceasarShiftToolStripMenuItem.Click += new System.EventHandler(this.CeasarShift_Click);
            // 
            // ceasarShiftContToolStripMenuItem
            // 
            this.ceasarShiftContToolStripMenuItem.Name = "ceasarShiftContToolStripMenuItem";
            this.ceasarShiftContToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.ceasarShiftContToolStripMenuItem.Text = "Ceasar Shift cont.";
            this.ceasarShiftContToolStripMenuItem.Click += new System.EventHandler(this.CeasarShiftContinued_Click);
            // 
            // symetricalKeysToolStripMenuItem
            // 
            this.symetricalKeysToolStripMenuItem.Name = "symetricalKeysToolStripMenuItem";
            this.symetricalKeysToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.symetricalKeysToolStripMenuItem.Text = "Symetrical Keys";
            this.symetricalKeysToolStripMenuItem.Click += new System.EventHandler(this.SymetricalKeys_Click);
            // 
            // publicAndPrivateKeysToolStripMenuItem
            // 
            this.publicAndPrivateKeysToolStripMenuItem.Name = "publicAndPrivateKeysToolStripMenuItem";
            this.publicAndPrivateKeysToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.publicAndPrivateKeysToolStripMenuItem.Text = "Public And Private Keys";
            this.publicAndPrivateKeysToolStripMenuItem.Click += new System.EventHandler(this.PublicAndPrivateKeys_Click);
            // 
            // digitalSecurityToolStripMenuItem
            // 
            this.digitalSecurityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passwordStrengthToolStripMenuItem,
            this.passwordManagersToolStripMenuItem,
            this.digitalCertificatesToolStripMenuItem,
            this.factorAuthenticationToolStripMenuItem});
            this.digitalSecurityToolStripMenuItem.Name = "digitalSecurityToolStripMenuItem";
            this.digitalSecurityToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.digitalSecurityToolStripMenuItem.Text = "Digital Security";
            // 
            // passwordStrengthToolStripMenuItem
            // 
            this.passwordStrengthToolStripMenuItem.Name = "passwordStrengthToolStripMenuItem";
            this.passwordStrengthToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.passwordStrengthToolStripMenuItem.Text = "Password Strength";
            this.passwordStrengthToolStripMenuItem.Click += new System.EventHandler(this.PasswordStrength_Click);
            // 
            // passwordManagersToolStripMenuItem
            // 
            this.passwordManagersToolStripMenuItem.Name = "passwordManagersToolStripMenuItem";
            this.passwordManagersToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.passwordManagersToolStripMenuItem.Text = "Password managers";
            this.passwordManagersToolStripMenuItem.Click += new System.EventHandler(this.PasswordManagers_Click);
            // 
            // digitalCertificatesToolStripMenuItem
            // 
            this.digitalCertificatesToolStripMenuItem.Name = "digitalCertificatesToolStripMenuItem";
            this.digitalCertificatesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.digitalCertificatesToolStripMenuItem.Text = "Digital certificates";
            this.digitalCertificatesToolStripMenuItem.Click += new System.EventHandler(this.DigitalCertificatesAndHttps_Click);
            // 
            // factorAuthenticationToolStripMenuItem
            // 
            this.factorAuthenticationToolStripMenuItem.Name = "factorAuthenticationToolStripMenuItem";
            this.factorAuthenticationToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.factorAuthenticationToolStripMenuItem.Text = "2 Factor Authentication";
            this.factorAuthenticationToolStripMenuItem.Click += new System.EventHandler(this.TwoFactorAuthentication_Click);
            // 
            // networkSecurityToolStripMenuItem
            // 
            this.networkSecurityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.physicalHackingToolStripMenuItem,
            this.publicWifiToolStripMenuItem,
            this.firewallsToolStripMenuItem,
            this.whitelistsEncryptionToolStripMenuItem});
            this.networkSecurityToolStripMenuItem.Name = "networkSecurityToolStripMenuItem";
            this.networkSecurityToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.networkSecurityToolStripMenuItem.Text = "Network Security";
            // 
            // physicalHackingToolStripMenuItem
            // 
            this.physicalHackingToolStripMenuItem.Name = "physicalHackingToolStripMenuItem";
            this.physicalHackingToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.physicalHackingToolStripMenuItem.Text = "Physical hacking";
            this.physicalHackingToolStripMenuItem.Click += new System.EventHandler(this.PhysicalHacking_Click);
            // 
            // publicWifiToolStripMenuItem
            // 
            this.publicWifiToolStripMenuItem.Name = "publicWifiToolStripMenuItem";
            this.publicWifiToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.publicWifiToolStripMenuItem.Text = "Public Wifi";
            this.publicWifiToolStripMenuItem.Click += new System.EventHandler(this.PublicWifi_Click);
            // 
            // firewallsToolStripMenuItem
            // 
            this.firewallsToolStripMenuItem.Name = "firewallsToolStripMenuItem";
            this.firewallsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.firewallsToolStripMenuItem.Text = "Firewalls";
            this.firewallsToolStripMenuItem.Click += new System.EventHandler(this.NetworkFirewalls_Click);
            // 
            // whitelistsEncryptionToolStripMenuItem
            // 
            this.whitelistsEncryptionToolStripMenuItem.Name = "whitelistsEncryptionToolStripMenuItem";
            this.whitelistsEncryptionToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.whitelistsEncryptionToolStripMenuItem.Text = "Whitelists and Encryption";
            this.whitelistsEncryptionToolStripMenuItem.Click += new System.EventHandler(this.WhitelistsAndEncrption_Click);
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
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.openHelp);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.openAbout);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitProgram);
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
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 338);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Quiz);
            this.Controls.Add(this.WhitelistsAndEncryption);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageLogo;
        private System.Windows.Forms.TextBox textBoxIntro;
        private System.Windows.Forms.Button Cryptography;
        private System.Windows.Forms.Button CeasarShift;
        private System.Windows.Forms.Button CeasarShiftContinued;
        private System.Windows.Forms.Button SymetricalKeys;
        private System.Windows.Forms.Button PublicAndPrivateKeys;
        private System.Windows.Forms.Button TwoFactorAuthentication;
        private System.Windows.Forms.Button DigitalCertificatesAndHttps;
        private System.Windows.Forms.Button PasswordManagers;
        private System.Windows.Forms.Button PasswordStrength;
        private System.Windows.Forms.Button PasswordsAndDigitalSecurity;
        private System.Windows.Forms.Button WhitelistsAndEncryption;
        private System.Windows.Forms.Button NetworkFirewalls;
        private System.Windows.Forms.Button PublicWifi;
        private System.Windows.Forms.Button PhysicalHacking;
        private System.Windows.Forms.Button NetworkSecurity;
        private System.Windows.Forms.Button Quiz;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jumpToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cryptographyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ceasarShiftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ceasarShiftContToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem symetricalKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicAndPrivateKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitalSecurityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordStrengthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordManagersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitalCertificatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factorAuthenticationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem networkSecurityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem physicalHackingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicWifiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firewallsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whitelistsEncryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

    }
}

