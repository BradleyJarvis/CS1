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

            if (WhitelistsAndEncrption.Visible == true)
            {
                WhitelistsAndEncrption.Visible = false;
            }
            else
            {
                WhitelistsAndEncrption.Visible = true;
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
    }
}
