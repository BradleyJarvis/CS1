using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Group_project
{
    public partial class SymetricalKeysForm : Group_project.InteractionBase
    {
        public SymetricalKeysForm()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)  //When the user presses send
        {
            if ((UnshiftedTextBox.Text != "") && (ShiftAmountNumericUpDown.Value < 27) && (ShiftAmountNumericUpDown.Value > -1))  //Check that the user has put text in and that the value of the number to be shifted by is between 0 and 26 (It should be imposwsible to select a different number).
            {
                EncryptedTextLabel.Text = UnshiftedTextBox.Text;    //Copy the unshifted text into the shifted text textbox.  The shifted text box will then be edited.
                for(int i = 0;i < EncryptedTextLabel.Text.Length ;i++)  //For each letter in the text.
                {
                    if(Char.IsLetter(EncryptedTextLabel.Text[i])) //If it is a letter
                    {
                        for(int j = 0; j < ShiftAmountNumericUpDown.Value;j++) //For each time that it must be shiftd.
                        {
                            if ((EncryptedTextLabel.Text[i] != 'z') && (EncryptedTextLabel.Text[i] != 'Z')) //If it is not the last character in the alphabet
                            {
                                char tempChar = EncryptedTextLabel.Text[i]; //Copy the character thet is being changed.
                                tempChar++; //Increment the chararcter                           
                                StringBuilder tempString = new StringBuilder(EncryptedTextLabel.Text); //Make a copy of the current string (use String Builder because strings cannot be eddited).
                                tempString[i] = tempChar; //Replace the old value with the new one
                                EncryptedTextLabel.Text = tempString.ToString(); //Replace the Textbox's text with the new text.
                            }
                            else //If it is a Z or z.
                            { 
                            if(EncryptedTextLabel.Text[i] == 'z') //Check what case it is in.
                            {
                                StringBuilder tempString = new StringBuilder(EncryptedTextLabel.Text); //Make a copy of the current string (use String Builder because strings cannot be eddited).
                                tempString[i] = 'a'; //Set the new value of the char.
                                EncryptedTextLabel.Text = tempString.ToString(); //Replace the Textbox's text with the new text.
                            }
                            else //If it is uppercase.
                            {
                                StringBuilder tempString = new StringBuilder(EncryptedTextLabel.Text); //Make a copy of the current string (use String Builder because strings cannot be eddited).
                                tempString[i] = 'A'; //Set the new value of the char.
                                EncryptedTextLabel.Text = tempString.ToString(); //Replace the Textbox's text with the new text.
                            }
                            }
                        }                       
                    }
                }

                HackerTextLabel.Text = EncryptedTextLabel.Text; // once the text has been encypered update the labels on the page
                RecieverTextLabel.Text = UnshiftedTextBox.Text;
                SenderTextLabel.Text = UnshiftedTextBox.Text;


            }
            else //If there was no text or the shift value was out of bounds.
            {
                MessageBox.Show("Please type some text into the left hand side text box and choose an amount to shift the text by. Using the field next to the text box"); //Inform the user.
            }



        }



    }
}
