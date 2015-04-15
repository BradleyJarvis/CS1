namespace Group_project
{
    partial class InteractionBase
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jumpToToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 7;
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
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
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
            this.caesarShiftToolStripMenuItem.Click += new System.EventHandler(this.ceasarShiftToolStripMenuItem_Click);
            // 
            // caesarShiftContToolStripMenuItem
            // 
            this.caesarShiftContToolStripMenuItem.Name = "caesarShiftContToolStripMenuItem";
            this.caesarShiftContToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.caesarShiftContToolStripMenuItem.Text = "Caesar Shift cont.";
            this.caesarShiftContToolStripMenuItem.Click += new System.EventHandler(this.ceasarShiftContToolStripMenuItem_Click);
            // 
            // symetricalKeysToolStripMenuItem
            // 
            this.symetricalKeysToolStripMenuItem.Name = "symetricalKeysToolStripMenuItem";
            this.symetricalKeysToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.symetricalKeysToolStripMenuItem.Text = "Symmetrical Keys";
            this.symetricalKeysToolStripMenuItem.Click += new System.EventHandler(this.symetricalKeysToolStripMenuItem_Click);
            // 
            // publicAndPrivateKeysToolStripMenuItem
            // 
            this.publicAndPrivateKeysToolStripMenuItem.Name = "publicAndPrivateKeysToolStripMenuItem";
            this.publicAndPrivateKeysToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.publicAndPrivateKeysToolStripMenuItem.Text = "Public And Private Keys";
            this.publicAndPrivateKeysToolStripMenuItem.Click += new System.EventHandler(this.publicAndPrivateKeysToolStripMenuItem_Click);
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
            this.passwordStrengthToolStripMenuItem.Click += new System.EventHandler(this.passwordStrengthToolStripMenuItem_Click);
            // 
            // passwordManagersToolStripMenuItem
            // 
            this.passwordManagersToolStripMenuItem.Name = "passwordManagersToolStripMenuItem";
            this.passwordManagersToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.passwordManagersToolStripMenuItem.Text = "Password managers";
            this.passwordManagersToolStripMenuItem.Click += new System.EventHandler(this.passwordManagersToolStripMenuItem_Click);
            // 
            // digitalCertificatesToolStripMenuItem
            // 
            this.digitalCertificatesToolStripMenuItem.Name = "digitalCertificatesToolStripMenuItem";
            this.digitalCertificatesToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.digitalCertificatesToolStripMenuItem.Text = "Digital certificates and HTTPS";
            this.digitalCertificatesToolStripMenuItem.Click += new System.EventHandler(this.digitalCertificatesToolStripMenuItem_Click);
            // 
            // factorAuthenticationToolStripMenuItem
            // 
            this.factorAuthenticationToolStripMenuItem.Name = "factorAuthenticationToolStripMenuItem";
            this.factorAuthenticationToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.factorAuthenticationToolStripMenuItem.Text = "2 Factor Authentication";
            this.factorAuthenticationToolStripMenuItem.Click += new System.EventHandler(this.factorAuthenticationToolStripMenuItem_Click);
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
            this.physicalHackingToolStripMenuItem.Click += new System.EventHandler(this.physicalHackingToolStripMenuItem_Click);
            // 
            // publicWifiToolStripMenuItem
            // 
            this.publicWifiToolStripMenuItem.Name = "publicWifiToolStripMenuItem";
            this.publicWifiToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.publicWifiToolStripMenuItem.Text = "Public Wifi";
            this.publicWifiToolStripMenuItem.Click += new System.EventHandler(this.publicWifiToolStripMenuItem_Click);
            // 
            // firewallsToolStripMenuItem
            // 
            this.firewallsToolStripMenuItem.Name = "firewallsToolStripMenuItem";
            this.firewallsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.firewallsToolStripMenuItem.Text = "Firewalls";
            this.firewallsToolStripMenuItem.Click += new System.EventHandler(this.firewallsToolStripMenuItem_Click);
            // 
            // whitelistsEncryptionToolStripMenuItem
            // 
            this.whitelistsEncryptionToolStripMenuItem.Name = "whitelistsEncryptionToolStripMenuItem";
            this.whitelistsEncryptionToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.whitelistsEncryptionToolStripMenuItem.Text = "Whitelists and Encryption";
            this.whitelistsEncryptionToolStripMenuItem.Click += new System.EventHandler(this.whitelistsEncryptionToolStripMenuItem_Click);
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
            // InteractionBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InteractionBase";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edu-cyber scelus";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.returnToMenu);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jumpToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
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
    }
}