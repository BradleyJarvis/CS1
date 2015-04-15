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
            this.Quiz = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jumpToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cryptographyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caesarShiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caesarShiftContToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.WhitelistsAndEncryption = new System.Windows.Forms.Button();
            this.NetworkFirewalls = new System.Windows.Forms.Button();
            this.PublicWifi = new System.Windows.Forms.Button();
            this.PhysicalHacking = new System.Windows.Forms.Button();
            this.NetworkSecurity = new System.Windows.Forms.Button();
            this.TwoFactorAuthentication = new System.Windows.Forms.Button();
            this.DigitalCertificatesAndHttps = new System.Windows.Forms.Button();
            this.PasswordManagers = new System.Windows.Forms.Button();
            this.PasswordStrength = new System.Windows.Forms.Button();
            this.PasswordsAndDigitalSecurity = new System.Windows.Forms.Button();
            this.PublicKeys = new System.Windows.Forms.Button();
            this.SymetricalKeys = new System.Windows.Forms.Button();
            this.CaesarShiftContinued = new System.Windows.Forms.Button();
            this.CaesarShift = new System.Windows.Forms.Button();
            this.Cryptography = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Quiz
            // 
            this.Quiz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Quiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quiz.Image = global::Group_project.Properties.Resources.btnMenuQuiz;
            this.Quiz.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Quiz.Location = new System.Drawing.Point(9, 542);
            this.Quiz.Name = "Quiz";
            this.Quiz.Size = new System.Drawing.Size(285, 79);
            this.Quiz.TabIndex = 25;
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
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
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
            this.caesarShiftToolStripMenuItem,
            this.caesarShiftContToolStripMenuItem,
            this.symetricalKeysToolStripMenuItem,
            this.publicAndPrivateKeysToolStripMenuItem});
            this.cryptographyToolStripMenuItem.Name = "cryptographyToolStripMenuItem";
            this.cryptographyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cryptographyToolStripMenuItem.Text = "Cryptography";
            // 
            // caesarShiftToolStripMenuItem
            // 
            this.caesarShiftToolStripMenuItem.Name = "caesarShiftToolStripMenuItem";
            this.caesarShiftToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.caesarShiftToolStripMenuItem.Text = "Caesar Shift";
            this.caesarShiftToolStripMenuItem.Click += new System.EventHandler(this.CeasarShift_Click);
            // 
            // caesarShiftContToolStripMenuItem
            // 
            this.caesarShiftContToolStripMenuItem.Name = "caesarShiftContToolStripMenuItem";
            this.caesarShiftContToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.caesarShiftContToolStripMenuItem.Text = "Ceasar Shift cont.";
            this.caesarShiftContToolStripMenuItem.Click += new System.EventHandler(this.CeasarShiftContinued_Click);
            // 
            // symetricalKeysToolStripMenuItem
            // 
            this.symetricalKeysToolStripMenuItem.Name = "symetricalKeysToolStripMenuItem";
            this.symetricalKeysToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.symetricalKeysToolStripMenuItem.Text = "Symmetrical Keys";
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
            this.passwordStrengthToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.passwordStrengthToolStripMenuItem.Text = "Password Strength";
            this.passwordStrengthToolStripMenuItem.Click += new System.EventHandler(this.PasswordStrength_Click);
            // 
            // passwordManagersToolStripMenuItem
            // 
            this.passwordManagersToolStripMenuItem.Name = "passwordManagersToolStripMenuItem";
            this.passwordManagersToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.passwordManagersToolStripMenuItem.Text = "Password managers";
            this.passwordManagersToolStripMenuItem.Click += new System.EventHandler(this.PasswordManagers_Click);
            // 
            // digitalCertificatesToolStripMenuItem
            // 
            this.digitalCertificatesToolStripMenuItem.Name = "digitalCertificatesToolStripMenuItem";
            this.digitalCertificatesToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.digitalCertificatesToolStripMenuItem.Text = "Digital certificates and HTTPS";
            this.digitalCertificatesToolStripMenuItem.Click += new System.EventHandler(this.DigitalCertificatesAndHttps_Click);
            // 
            // factorAuthenticationToolStripMenuItem
            // 
            this.factorAuthenticationToolStripMenuItem.Name = "factorAuthenticationToolStripMenuItem";
            this.factorAuthenticationToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
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
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.openHelp);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
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
            // WhitelistsAndEncryption
            // 
            this.WhitelistsAndEncryption.Image = global::Group_project.Properties.Resources.btnNetworkEncyrpt;
            this.WhitelistsAndEncryption.Location = new System.Drawing.Point(426, 521);
            this.WhitelistsAndEncryption.Name = "WhitelistsAndEncryption";
            this.WhitelistsAndEncryption.Size = new System.Drawing.Size(300, 59);
            this.WhitelistsAndEncryption.TabIndex = 24;
            this.WhitelistsAndEncryption.UseVisualStyleBackColor = true;
            this.WhitelistsAndEncryption.Visible = false;
            this.WhitelistsAndEncryption.Click += new System.EventHandler(this.WhitelistsAndEncrption_Click);
            // 
            // NetworkFirewalls
            // 
            this.NetworkFirewalls.Image = global::Group_project.Properties.Resources.btnNetworkFirewall;
            this.NetworkFirewalls.Location = new System.Drawing.Point(426, 444);
            this.NetworkFirewalls.Name = "NetworkFirewalls";
            this.NetworkFirewalls.Size = new System.Drawing.Size(300, 59);
            this.NetworkFirewalls.TabIndex = 23;
            this.NetworkFirewalls.UseVisualStyleBackColor = true;
            this.NetworkFirewalls.Visible = false;
            this.NetworkFirewalls.Click += new System.EventHandler(this.NetworkFirewalls_Click);
            // 
            // PublicWifi
            // 
            this.PublicWifi.Image = global::Group_project.Properties.Resources.btnNetworkWiFi;
            this.PublicWifi.Location = new System.Drawing.Point(426, 370);
            this.PublicWifi.Name = "PublicWifi";
            this.PublicWifi.Size = new System.Drawing.Size(300, 59);
            this.PublicWifi.TabIndex = 22;
            this.PublicWifi.UseVisualStyleBackColor = true;
            this.PublicWifi.Visible = false;
            this.PublicWifi.Click += new System.EventHandler(this.PublicWifi_Click);
            // 
            // PhysicalHacking
            // 
            this.PhysicalHacking.Image = global::Group_project.Properties.Resources.btnNetworkHacking;
            this.PhysicalHacking.Location = new System.Drawing.Point(426, 298);
            this.PhysicalHacking.Name = "PhysicalHacking";
            this.PhysicalHacking.Size = new System.Drawing.Size(300, 59);
            this.PhysicalHacking.TabIndex = 21;
            this.PhysicalHacking.UseVisualStyleBackColor = true;
            this.PhysicalHacking.Visible = false;
            this.PhysicalHacking.Click += new System.EventHandler(this.PhysicalHacking_Click);
            // 
            // NetworkSecurity
            // 
            this.NetworkSecurity.BackColor = System.Drawing.SystemColors.Control;
            this.NetworkSecurity.FlatAppearance.BorderSize = 0;
            this.NetworkSecurity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NetworkSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetworkSecurity.Image = global::Group_project.Properties.Resources.btnMenuNetwork;
            this.NetworkSecurity.Location = new System.Drawing.Point(385, 191);
            this.NetworkSecurity.Name = "NetworkSecurity";
            this.NetworkSecurity.Size = new System.Drawing.Size(387, 77);
            this.NetworkSecurity.TabIndex = 20;
            this.NetworkSecurity.UseVisualStyleBackColor = false;
            this.NetworkSecurity.Click += new System.EventHandler(this.NetworkSecurity_Click);
            // 
            // TwoFactorAuthentication
            // 
            this.TwoFactorAuthentication.Image = global::Group_project.Properties.Resources.btnDigitalAuthentication;
            this.TwoFactorAuthentication.Location = new System.Drawing.Point(426, 518);
            this.TwoFactorAuthentication.Name = "TwoFactorAuthentication";
            this.TwoFactorAuthentication.Size = new System.Drawing.Size(300, 59);
            this.TwoFactorAuthentication.TabIndex = 19;
            this.TwoFactorAuthentication.UseVisualStyleBackColor = true;
            this.TwoFactorAuthentication.Visible = false;
            this.TwoFactorAuthentication.Click += new System.EventHandler(this.TwoFactorAuthentication_Click);
            // 
            // DigitalCertificatesAndHttps
            // 
            this.DigitalCertificatesAndHttps.Image = global::Group_project.Properties.Resources.btnDigitalCertificates;
            this.DigitalCertificatesAndHttps.Location = new System.Drawing.Point(426, 444);
            this.DigitalCertificatesAndHttps.Name = "DigitalCertificatesAndHttps";
            this.DigitalCertificatesAndHttps.Size = new System.Drawing.Size(300, 59);
            this.DigitalCertificatesAndHttps.TabIndex = 18;
            this.DigitalCertificatesAndHttps.UseVisualStyleBackColor = true;
            this.DigitalCertificatesAndHttps.Visible = false;
            this.DigitalCertificatesAndHttps.Click += new System.EventHandler(this.DigitalCertificatesAndHttps_Click);
            // 
            // PasswordManagers
            // 
            this.PasswordManagers.Image = global::Group_project.Properties.Resources.btnDigitalManager;
            this.PasswordManagers.Location = new System.Drawing.Point(426, 370);
            this.PasswordManagers.Name = "PasswordManagers";
            this.PasswordManagers.Size = new System.Drawing.Size(300, 59);
            this.PasswordManagers.TabIndex = 17;
            this.PasswordManagers.UseVisualStyleBackColor = true;
            this.PasswordManagers.Visible = false;
            this.PasswordManagers.Click += new System.EventHandler(this.PasswordManagers_Click);
            // 
            // PasswordStrength
            // 
            this.PasswordStrength.Image = global::Group_project.Properties.Resources.btnDigitalStrength;
            this.PasswordStrength.Location = new System.Drawing.Point(426, 296);
            this.PasswordStrength.Name = "PasswordStrength";
            this.PasswordStrength.Size = new System.Drawing.Size(300, 59);
            this.PasswordStrength.TabIndex = 16;
            this.PasswordStrength.UseVisualStyleBackColor = true;
            this.PasswordStrength.Visible = false;
            this.PasswordStrength.Click += new System.EventHandler(this.PasswordStrength_Click);
            // 
            // PasswordsAndDigitalSecurity
            // 
            this.PasswordsAndDigitalSecurity.BackColor = System.Drawing.SystemColors.Control;
            this.PasswordsAndDigitalSecurity.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.PasswordsAndDigitalSecurity.FlatAppearance.BorderSize = 0;
            this.PasswordsAndDigitalSecurity.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.PasswordsAndDigitalSecurity.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.PasswordsAndDigitalSecurity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordsAndDigitalSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordsAndDigitalSecurity.Image = global::Group_project.Properties.Resources.btnMenuDigital;
            this.PasswordsAndDigitalSecurity.Location = new System.Drawing.Point(385, 108);
            this.PasswordsAndDigitalSecurity.Name = "PasswordsAndDigitalSecurity";
            this.PasswordsAndDigitalSecurity.Size = new System.Drawing.Size(387, 77);
            this.PasswordsAndDigitalSecurity.TabIndex = 15;
            this.PasswordsAndDigitalSecurity.UseVisualStyleBackColor = false;
            this.PasswordsAndDigitalSecurity.Click += new System.EventHandler(this.PasswordsAndDigitalSecurity_Click);
            // 
            // PublicKeys
            // 
            this.PublicKeys.Image = global::Group_project.Properties.Resources.btnCryptKeys;
            this.PublicKeys.Location = new System.Drawing.Point(426, 521);
            this.PublicKeys.Name = "PublicKeys";
            this.PublicKeys.Size = new System.Drawing.Size(300, 59);
            this.PublicKeys.TabIndex = 14;
            this.PublicKeys.UseVisualStyleBackColor = true;
            this.PublicKeys.Visible = false;
            this.PublicKeys.Click += new System.EventHandler(this.PublicAndPrivateKeys_Click);
            // 
            // SymetricalKeys
            // 
            this.SymetricalKeys.Image = global::Group_project.Properties.Resources.btnCryptSymmetrical;
            this.SymetricalKeys.Location = new System.Drawing.Point(426, 447);
            this.SymetricalKeys.Name = "SymetricalKeys";
            this.SymetricalKeys.Size = new System.Drawing.Size(300, 59);
            this.SymetricalKeys.TabIndex = 13;
            this.SymetricalKeys.UseVisualStyleBackColor = true;
            this.SymetricalKeys.Visible = false;
            this.SymetricalKeys.Click += new System.EventHandler(this.SymetricalKeys_Click);
            // 
            // CaesarShiftContinued
            // 
            this.CaesarShiftContinued.Image = global::Group_project.Properties.Resources.btnCryptCaesarCont;
            this.CaesarShiftContinued.Location = new System.Drawing.Point(426, 372);
            this.CaesarShiftContinued.Name = "CaesarShiftContinued";
            this.CaesarShiftContinued.Size = new System.Drawing.Size(300, 59);
            this.CaesarShiftContinued.TabIndex = 8;
            this.CaesarShiftContinued.UseVisualStyleBackColor = true;
            this.CaesarShiftContinued.Visible = false;
            this.CaesarShiftContinued.Click += new System.EventHandler(this.CeasarShiftContinued_Click);
            // 
            // CaesarShift
            // 
            this.CaesarShift.Image = global::Group_project.Properties.Resources.btnCryptCaesar;
            this.CaesarShift.Location = new System.Drawing.Point(426, 298);
            this.CaesarShift.Name = "CaesarShift";
            this.CaesarShift.Size = new System.Drawing.Size(300, 59);
            this.CaesarShift.TabIndex = 7;
            this.CaesarShift.UseVisualStyleBackColor = true;
            this.CaesarShift.Visible = false;
            this.CaesarShift.Click += new System.EventHandler(this.CeasarShift_Click);
            // 
            // Cryptography
            // 
            this.Cryptography.BackColor = System.Drawing.SystemColors.Control;
            this.Cryptography.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.Cryptography.FlatAppearance.BorderSize = 0;
            this.Cryptography.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.Cryptography.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.Cryptography.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cryptography.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cryptography.Image = global::Group_project.Properties.Resources.btnMenuCryptography;
            this.Cryptography.Location = new System.Drawing.Point(385, 25);
            this.Cryptography.Name = "Cryptography";
            this.Cryptography.Size = new System.Drawing.Size(387, 77);
            this.Cryptography.TabIndex = 1;
            this.Cryptography.UseVisualStyleBackColor = false;
            this.Cryptography.Click += new System.EventHandler(this.buttonSection1Click);
            // 
            // infoBox
            // 
            this.infoBox.BackColor = System.Drawing.Color.LightGray;
            this.infoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.infoBox.Location = new System.Drawing.Point(12, 361);
            this.infoBox.Multiline = true;
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(275, 167);
            this.infoBox.TabIndex = 27;
            this.infoBox.Text = "Welcome to Edu Cyber Scelus, this program will help you understand the world of c" +
    "yber-crime and cyber security so that you can lead a safer life online.";
            this.infoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Group_project.Properties.Resources.backgroundLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.infoBox);
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
            this.Controls.Add(this.PublicKeys);
            this.Controls.Add(this.SymetricalKeys);
            this.Controls.Add(this.CaesarShiftContinued);
            this.Controls.Add(this.CaesarShift);
            this.Controls.Add(this.Cryptography);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenuForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edu-cyber scelus";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainMenuClose);
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cryptography;
        private System.Windows.Forms.Button CaesarShift;
        private System.Windows.Forms.Button CaesarShiftContinued;
        private System.Windows.Forms.Button SymetricalKeys;
        private System.Windows.Forms.Button PublicKeys;
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
        private System.Windows.Forms.ToolStripMenuItem caesarShiftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caesarShiftContToolStripMenuItem;
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
        private System.Windows.Forms.TextBox infoBox;

    }
}

