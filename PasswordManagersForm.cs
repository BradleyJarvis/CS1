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
        }
    }
}
