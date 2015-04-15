using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Group_project
{
    public partial class TwoFactorAuthenticationForm : Group_project.InteractionBase
    {
        int textNumber = 0;
        string authCode = "0";
        Random rnd = new Random(); //Create the RNG object
        TwoFactorAuthCode authenticator;
        public TwoFactorAuthenticationForm()
        {
            InitializeComponent();
            authenticator = new TwoFactorAuthCode();//Create the authenticator object, starts hidden, should be shown/hidden, not closed
        }

        private void genAuthCode(object sender, EventArgs e)
        {
            string newCode = "";
            for (int count = 0; count < 8; count++)
            {//Create a new code to be used by the authenticator, 8 digits long
                newCode += rnd.Next(0, 10);//Add a new digit to the code
            }
            authCode = newCode;
            authenticator.AuthCodeLabel.Text = authCode;
        }

        private void showAuth(object sender, EventArgs e)
        {
            authenticator.Show();//Show the authenticator window
            this.Select();
        }

        private void attemptLogin(object sender, EventArgs e)
        {
            loginResultLabel.Visible = true;//Make the login result lable visible, if not already
            if (codeInputBox.Text == authCode)//If the code entered matches the latest code generated, show success message
                loginResultLabel.Text = "Code correct, login succesful";
            else
                loginResultLabel.Text = "Code incorrect, please try again";
        }

        private void closeAuth(object sender, FormClosedEventArgs e)
        {
            authenticator.Close();
        }

        private void TwoFactorAuthenticationForm_Load(object sender, EventArgs e)
        {

        }

        private void checkInfoText()
        {
            switch (textNumber)
            {
                case 0:
                    explainationText.Text = "Two factor authentication (2FA) is an excellent way of improving account security, without adding inconvenience to using the account.";
                    break;
                case 1:
                    explainationText.Text = "In addition to requiring a username and password to sign into the account, a code will also be needed.";
                    break;
                case 2:
                    explainationText.Text = "Rather than being memorised like a password, the code will be sent to the user in some manner.";
                    break;
                case 3:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 16);
                    explainationText.Text = "One of the most common ways of doing this is to send a text message to a pre-determined number, meaning an attacker would also need access to their targets phone in order to access the account.";
                    break;
                case 4:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 14);
                    explainationText.Text = "Another common method of delivering the codes is to use a dedicated mobile app, that can be configured to generate codes as required, so mobile signal is not needed. A list showing many of the accounts that can use 2FA can be found at twofactorauth.org.";
                    break;
                case 5:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 15);
                    explainationText.Text = "Below is a simple demonstration of how 2FA works, after the account login details have been entered. Clicking the send code button will generate a code and the open authenticator button will show the sent code.";
                    break;
                case 6:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 18);
                    explainationText.Text = "Entering the displayed code into the box will grant access while an incorrect code will not. Try it now!";
                    break;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (textNumber != 6)
            {
                textNumber++;
                checkInfoText();
                this.Refresh();
            }

        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (textNumber != 0)
            {
                textNumber--;
                checkInfoText();
                this.Refresh();
            }
        }
    }
}
