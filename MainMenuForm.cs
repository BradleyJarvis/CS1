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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void buttonSection1Click(object sender, EventArgs e)
        {
            if (CeasarShift.Visible == true)
            {
                CeasarShift.Visible = false;
            }
            else
            {
                CeasarShift.Visible = true;
            }

            if (CeasarShiftContinued.Visible == true)
            {
                CeasarShiftContinued.Visible = false;
            }
            else
            {
                CeasarShiftContinued.Visible = true;
            }

            if (SymetricalKeys.Visible == true)
            {
                SymetricalKeys.Visible = false;
            }
            else
            {
                SymetricalKeys.Visible = true;
            }

            if (PublicAndPrivateKeys.Visible == true)
            {
                PublicAndPrivateKeys.Visible = false;
            }
            else
            {
                PublicAndPrivateKeys.Visible = true;
            }
            if (this.Height < 500)
            {
                this.Height = 583;
            }
            else
            {
                if ((CeasarShift.Visible == false) && (PasswordStrength.Visible == false) && (PhysicalHacking.Visible == false))
                {
                    this.Height = 366;
                }
            }

        }

        private void mainMenuClose(object sender, FormClosedEventArgs e)
        {//Ensures program exits correctly
            Environment.Exit(0);
        }

        private void exitProgram(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }



        private void PasswordsAndDigitalSecurity_Click(object sender, EventArgs e)
        {
            if (PasswordStrength.Visible == true)
            {
                PasswordStrength.Visible = false;
            }
            else
            {
                PasswordStrength.Visible = true;
            }

            if (PasswordManagers.Visible == true)
            {
                PasswordManagers.Visible = false;
            }
            else
            {
                PasswordManagers.Visible = true;
            }

            if (DigitalCertificatesAndHttps.Visible == true)
            {
                DigitalCertificatesAndHttps.Visible = false;
            }
            else
            {
                DigitalCertificatesAndHttps.Visible = true;
            }

            if (TwoFactorAuthentication.Visible == true)
            {
                TwoFactorAuthentication.Visible = false;
            }
            else
            {
                TwoFactorAuthentication.Visible = true;
            }
            if (this.Height < 500)
            {
                this.Height = 583;
            }
            else
            {
            if ((CeasarShift.Visible == false)&&(PasswordStrength.Visible == false)&&(PhysicalHacking.Visible == false))
            {
                this.Height = 366;
            }
            }

        }

        private void NetworkSecurity_Click(object sender, EventArgs e)
        {
            if (PhysicalHacking.Visible == true)
            {
                PhysicalHacking.Visible = false;
            }
            else
            {
                PhysicalHacking.Visible = true;
            }

            if (PublicWifi.Visible == true)
            {
                PublicWifi.Visible = false;
            }
            else
            {
                PublicWifi.Visible = true;
            }

            if (NetworkFirewalls.Visible == true)
            {
                NetworkFirewalls.Visible = false;
            }
            else
            {
                NetworkFirewalls.Visible = true;
            }

            if (WhitelistsAndEncryption.Visible == true)
            {
                WhitelistsAndEncryption.Visible = false;
            }
            else
            {
                WhitelistsAndEncryption.Visible = true;
            }
            if (this.Height < 500)
            {
                this.Height = 583;
            }
            else
            {
            if ((CeasarShift.Visible == false)&&(PasswordStrength.Visible == false)&&(PhysicalHacking.Visible == false))
            {
                this.Height = 366;
            }
            }

        }

        private void CeasarShift_Click(object sender, EventArgs e)
        {
            CeasarShiftForm CeasarShiftF = new CeasarShiftForm();
            CeasarShiftF.Show();
            this.Hide();
        }

        private void CeasarShiftContinued_Click(object sender, EventArgs e)
        {
            CeasarShiftContinuedForm CeasarShiftContinuedF = new CeasarShiftContinuedForm();
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
            PublicAndPrivateKeysForm PublicAndPrivateKeysF = new PublicAndPrivateKeysForm();
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


    }
}
