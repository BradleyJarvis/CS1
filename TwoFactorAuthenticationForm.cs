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
        }

        private void attemptLogin(object sender, EventArgs e)
        {
            loginResultLabel.Visible = true;//Make the login result lable visible, if not already
            if (codeInputBox.Text == authCode)//If the code entered matches the latest code generated, show success message
                loginResultLabel.Text = "Code correct, login succesful";
            else
                loginResultLabel.Text = "Code incorrect, please try again";
        }
    }
}
