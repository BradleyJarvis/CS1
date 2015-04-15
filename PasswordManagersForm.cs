using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Group_project
{
    public partial class PasswordManagersForm : Group_project.InteractionBase
    {
        // Characters array used to hold all characters that can be chosen for the generated password
        char[] characters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '!', '"', '£', '$', '%', '^', '&', '*', '(', ')', '_', '-', '=', '+', '[', '{', ']', '}', ';', ':', '\'', '@', '#', '~', '/', '?', '.', '>', ',', '<', '\\', '|', ' '};
        Random rnd = new Random(); // Create the RNG object
        int textNumber = 0;

        public PasswordManagersForm()
        {
            InitializeComponent();
        }

        private void genPassword(object sender, EventArgs e)
        {
            string password = "";
            int charLimit = 1;// Used to limit the rangh of characters that can be selected to be included in the password

            if (specalCheckBox.Checked == false)// If special chars not wanted, limit to letters and numbers, else use full array
                charLimit = 61;
            else
                charLimit = characters.Length;

            for (int count = 0; count < passLengthBox.Value; count++)// Run as many times as needed to create password of desired length
            {// Choose a character at random from the character list and add it to the generated password
                password += characters[rnd.Next(0, charLimit)];
            }
            passOutputBox.Text = password;
            passOutputBox.Select();
        }
        private void checkInfoText()
        {
            switch (textNumber)
            {
                case 0:
                    explainationText.Text = "A good password is one that is difficult to guess. A simple way of creating one is to simply randomly generate one.";
                    break;
                case 1:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 17);
                    explainationText.Text = "The above tool allows you to generate a password of a length of your choice that will be near impossible for a human to guess and harder to crack using a brute force attack. ";
                    break;
                case 2:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 15);
                    explainationText.Text = "Many, but not all, services allow the use of special characters (such as ! and ?) in passwords so the checkbox above can be used to prevent the generated password from including these characters.";
                    break;
                case 3:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 15);
                    explainationText.Text = "These randomly generated passwords are by their random nature, very hard to remember, so it is recommended that a password manager is used as well as these generated passwords. ";
                    break;
                case 4:
                    explainationText.Text = "A password manager will store passwords for all the services you use so that you don't need to remember them all.";
                    break;
                case 5:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 15);
                    explainationText.Text = "You only need to remember the password for the password manager, then you can use a different, randomly generated password for every service you use, without needing to remember them all.";
                    break;
            }

            this.Refresh();
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (textNumber != 5)
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
