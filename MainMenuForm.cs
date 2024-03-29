﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_project
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void mainMenuClose(object sender, FormClosedEventArgs e)
        {//Ensures program exits correctly
            Environment.Exit(0);
        }

        #region Window resize code
        private void buttonSection1Click(object sender, EventArgs e)
        {

            CaesarShift.BringToFront();
            CaesarShift.Visible = true;
            CaesarShiftContinued.BringToFront();
            CaesarShiftContinued.Visible = true;
            SymetricalKeys.BringToFront();
            SymetricalKeys.Visible = true;
            PublicKeys.Visible = true;
            PublicKeys.BringToFront();
            this.Refresh();
        }

        private void PasswordsAndDigitalSecurity_Click(object sender, EventArgs e)
        {
            PasswordStrength.Visible = true;
            PasswordStrength.BringToFront();
            PasswordManagers.Visible = true;
            PasswordManagers.BringToFront();
            DigitalCertificatesAndHttps.Visible = true;
            DigitalCertificatesAndHttps.BringToFront();
            TwoFactorAuthentication.Visible = true;
            TwoFactorAuthentication.BringToFront();

            this.Refresh();

        }
        private void NetworkSecurity_Click(object sender, EventArgs e)
        {

            PhysicalHacking.BringToFront();
            PhysicalHacking.Visible = true;
            PublicWifi.BringToFront();
            PublicWifi.Visible = true;
            NetworkFirewalls.BringToFront();
            NetworkFirewalls.Visible = true;
            WhitelistsAndEncryption.BringToFront();
            WhitelistsAndEncryption.Visible = true;

            this.Refresh();
        }
        #endregion

        #region Navigation code
        private void CeasarShift_Click(object sender, EventArgs e)
        {
            CaesarShiftForm CeasarShiftF = new CaesarShiftForm();
            CeasarShiftF.Show();
            this.Hide();
        }

        private void CeasarShiftContinued_Click(object sender, EventArgs e)
        {
            CaesarShiftContinuedForm CeasarShiftContinuedF = new CaesarShiftContinuedForm();
            CeasarShiftContinuedF.Show();
            this.Hide();
        }

        private void SymetricalKeys_Click(object sender, EventArgs e)
        {
            SymetricalKeysForm SymetricalKeysF = new SymetricalKeysForm();
            SymetricalKeysF.Show();
            this.Hide();
        }

        private void PublicAndPrivateKeys_Click(object sender, EventArgs e)
        {
            PublicKeysForm PublicAndPrivateKeysF = new PublicKeysForm();
            PublicAndPrivateKeysF.Show();
            this.Hide();
        }

        private void PasswordStrength_Click(object sender, EventArgs e)
        {
            PasswordStrengthForm PasswordStrengthF = new PasswordStrengthForm();
            PasswordStrengthF.Show();
            this.Hide();
        }

        private void PasswordManagers_Click(object sender, EventArgs e)
        {
            PasswordManagersForm PasswordManagersF = new PasswordManagersForm();
            PasswordManagersF.Show();
            this.Hide();
        }

        private void DigitalCertificatesAndHttps_Click(object sender, EventArgs e)
        {
            DigitalCertificatesAndHttpsForm DigitalCertificatesAndHttpsF = new DigitalCertificatesAndHttpsForm();
            DigitalCertificatesAndHttpsF.Show();
            this.Hide();
        }

        private void TwoFactorAuthentication_Click(object sender, EventArgs e)
        {
            TwoFactorAuthenticationForm TwoFactorAuthenticationF = new TwoFactorAuthenticationForm();
            TwoFactorAuthenticationF.Show();
            this.Hide();

        }

        private void PhysicalHacking_Click(object sender, EventArgs e)
        {
            PhysicalHackingForm PhysicalHackingF = new PhysicalHackingForm();
            PhysicalHackingF.Show();
            this.Hide();
        }

        private void PublicWifi_Click(object sender, EventArgs e)
        {
            PublicWifiForm PublicWifiF = new PublicWifiForm();
            PublicWifiF.Show();
            this.Hide();
        }

        private void NetworkFirewalls_Click(object sender, EventArgs e)
        {
            NetworkFirewallsForm NetworkFirewallsF = new NetworkFirewallsForm();
            NetworkFirewallsF.Show();
            this.Hide();
        }

        private void WhitelistsAndEncrption_Click(object sender, EventArgs e)
        {
            WhitelistsAndEncryptionForm WhitelistsAndEncrptionF = new WhitelistsAndEncryptionForm();
            WhitelistsAndEncrptionF.Show();
            this.Hide();

        }

        private void Quiz_Click(object sender, EventArgs e)
        {
            QuizForm QuizF = new QuizForm();
            QuizF.Show();
            this.Hide();
        }
        #endregion

        #region menuStrip code
        private void exitProgram(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void openHelp(object sender, EventArgs e)
        {
            HelpForm helpF = new HelpForm();
            helpF.Show();
        }
        private void openAbout(object sender, EventArgs e)
        {
            AboutForm aboutF = new AboutForm();
            aboutF.Show();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ceasarShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CaesarShiftForm CeasarShiftF = new CaesarShiftForm();
            CeasarShiftF.Show();
        }

        private void ceasarShiftContToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CaesarShiftContinuedForm CeaserShiftContF = new CaesarShiftContinuedForm();
            CeaserShiftContF.Show();
        }

        private void symetricalKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SymetricalKeysForm SymetricaKeysF = new SymetricalKeysForm();
            SymetricaKeysF.Show();
        }

        private void publicAndPrivateKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PublicKeysForm PubPrivKeysF = new PublicKeysForm();
            PubPrivKeysF.Show();
        }

        private void passwordStrengthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PasswordStrengthForm PassStrF = new PasswordStrengthForm();
            PassStrF.Show();
        }

        private void passwordManagersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PasswordManagersForm PassManF = new PasswordManagersForm();
            PassManF.Show();
        }

        private void digitalCertificatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DigitalCertificatesAndHttpsForm DigitalCertF = new DigitalCertificatesAndHttpsForm();
            DigitalCertF.Show();
        }

        private void factorAuthenticationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TwoFactorAuthenticationForm TwoFactorF = new TwoFactorAuthenticationForm();
            TwoFactorF.Show();
        }

        private void physicalHackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhysicalHackingForm HackF = new PhysicalHackingForm();
            HackF.Show();
        }

        private void publicWifiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PublicWifiForm PubWifiF = new PublicWifiForm();
            PubWifiF.Show();
        }

        private void firewallsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NetworkFirewallsForm FirewallF = new NetworkFirewallsForm();
            FirewallF.Show();
        }

        private void whitelistsEncryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            WhitelistsAndEncryptionForm WhitelistF = new WhitelistsAndEncryptionForm();
            WhitelistF.Show();
        }
        #endregion

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

    }
}
