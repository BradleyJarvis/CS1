using System;
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
    public partial class InteractionBase : Form
    {
        public InteractionBase()
        {
            InitializeComponent();
        }

        private void returnToMenu(object sender, FormClosedEventArgs e)
        {
            MainMenuForm menuForm = new MainMenuForm();
            menuForm.Show();
        }

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

    }
}
