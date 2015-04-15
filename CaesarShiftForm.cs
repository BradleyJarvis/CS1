using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Group_project
{
    public partial class CaesarShiftForm : Group_project.InteractionBase
    {
        int textNumber = 0;

        public CaesarShiftForm()
        {
            InitializeComponent();
        }

        private void ShiftButton_Click(object sender, EventArgs e)   //When the user presses shift
        {
            if ((UnshiftedTextBox.Text != "") && (ShiftAmountNumericUpDown.Value < 27) && (ShiftAmountNumericUpDown.Value > -1))  //Check that the user has put text in and that the value of the number to be shifted by is between 0 and 26 (It should be imposwsible to select a different number).
            {
                ShiftedTextBox.Text = UnshiftedTextBox.Text;    //Copy the unshifted text into the shifted text textbox.  The shifted text box will then be edited.
                for(int i = 0;i < ShiftedTextBox.Text.Length ;i++)  //For each letter in the text.
                {
                    if(Char.IsLetter(ShiftedTextBox.Text[i])) //If it is a letter
                    {
                        for(int j = 0; j < ShiftAmountNumericUpDown.Value;j++) //For each time that it must be shiftd.
                        {
                            if ((ShiftedTextBox.Text[i] != 'z') && (ShiftedTextBox.Text[i] != 'Z')) //If it is not the last character in the alphabet
                            {
                                char tempChar = ShiftedTextBox.Text[i]; //Copy the character thet is being changed.
                                tempChar++; //Increment the chararcter                           
                                StringBuilder tempString = new StringBuilder(ShiftedTextBox.Text); //Make a copy of the current string (use String Builder because strings cannot be eddited).
                                tempString[i] = tempChar; //Replace the old value with the new one
                                ShiftedTextBox.Text = tempString.ToString(); //Replace the Textbox's text with the new text.
                            }
                            else //If it is a Z or z.
                            { 
                            if(ShiftedTextBox.Text[i] == 'z') //Check what case it is in.
                            {
                                StringBuilder tempString = new StringBuilder(ShiftedTextBox.Text); //Make a copy of the current string (use String Builder because strings cannot be eddited).
                                tempString[i] = 'a'; //Set the new value of the char.
                                ShiftedTextBox.Text = tempString.ToString(); //Replace the Textbox's text with the new text.
                            }
                            else //If it is uppercase.
                            {
                                StringBuilder tempString = new StringBuilder(ShiftedTextBox.Text); //Make a copy of the current string (use String Builder because strings cannot be eddited).
                                tempString[i] = 'A'; //Set the new value of the char.
                                ShiftedTextBox.Text = tempString.ToString(); //Replace the Textbox's text with the new text.
                            }
                            }
                        }                       
                    }
                }
            }
            else //If there was no text or the shift value was out of bounds.
            {
                MessageBox.Show("Please type some text into the left hand side and choose an amount to shift the text by. Using the field in the middle of the two boxes","You need to fill in the fields", MessageBoxButtons.OK); //Inform the user.
            }
        }//End of shift

        private void Unshift_Click(object sender, EventArgs e)
        {
            if ((ShiftedTextBox.Text != "") && (ShiftAmountNumericUpDown.Value < 27) && (ShiftAmountNumericUpDown.Value > -1))  //Check that the user has put text in and that the value of the number to be shifted by is between 0 and 26 (It should be imposwsible to select a different number).
            {
                UnshiftedTextBox.Text = ShiftedTextBox.Text;    //Copy the unshifted text into the unshifted text textbox.  The unshifted text box will then be edited.
                for (int i = 0; i < UnshiftedTextBox.Text.Length; i++)  //For each letter in the text.
                {
                    if (Char.IsLetter(UnshiftedTextBox.Text[i])) //If it is a letter
                    {
                        for (int j = 0; j < ShiftAmountNumericUpDown.Value; j++) //For each time that it must be shiftd.
                        {
                            if ((UnshiftedTextBox.Text[i] != 'a') && (UnshiftedTextBox.Text[i] != 'A')) //If it is not the first character in the alphabet
                            {
                                char tempChar = UnshiftedTextBox.Text[i]; //Copy the character thet is being changed.
                                tempChar--; //Increment the chararcter                           
                                StringBuilder tempString = new StringBuilder(UnshiftedTextBox.Text); //Make a copy of the current string (use String Builder because strings cannot be eddited).
                                tempString[i] = tempChar; //Replace the old value with the new one
                                UnshiftedTextBox.Text = tempString.ToString(); //Replace the Textbox's text with the new text.
                            }
                            else //If it is a A or a.
                            {
                                if (UnshiftedTextBox.Text[i] == 'a') //Check what case it is in.
                                {
                                    StringBuilder tempString = new StringBuilder(UnshiftedTextBox.Text); //Make a copy of the current string (use String Builder because strings cannot be eddited).
                                    tempString[i] = 'z'; //Set the new value of the char.
                                    UnshiftedTextBox.Text = tempString.ToString(); //Replace the Textbox's text with the new text.
                                }
                                else //If it is uppercase.
                                {
                                    StringBuilder tempString = new StringBuilder(UnshiftedTextBox.Text); //Make a copy of the current string (use String Builder because strings cannot be eddited).
                                    tempString[i] = 'Z'; //Set the new value of the char.
                                    UnshiftedTextBox.Text = tempString.ToString(); //Replace the Textbox's text with the new text.
                                }
                            }
                        }
                    }
                }
            }
            else //If there was no text or the shift value was out of bounds.
            {
                MessageBox.Show("Please type some text into the left hand side and choose an amount to shift the text by. Using the field in the middle of the two boxes"); //Inform the user.
            }
        }
        //End of unshift

        private void checkInfoText()
        {
            switch (textNumber)
            {
                case 0:
                    explainationText.Text = "A Caesar shift cypher is a method of encryption that is very simple but is very resilient to brute force attacks.";
                    break;
                case 1:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 15);
                    explainationText.Text = "The way it works is that it takes a word and changes each letter in it by a certain amount. For example, if you have the letter ‘H’ and you shift it by 4 it goes to ‘I’ then to ‘J’ then to ‘K’ then to ‘L’, 4 steps.";
                    break;
                case 2:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 15);
                    explainationText.Text = "If this is done on a word like “Hello World” each letter is changed by 4 giving “Lipps Asvph”. ";
                    break;
                case 3:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 15);
                    explainationText.Text = "If you look you can see that the ‘W’ has become an ‘A’. This is because it loops round on itself and a ‘Z’ shifted by 1 becomes ‘A’. ";
                    break;
                case 4:
                    explainationText.Text = "You can try this yourself by typing the message you want to shift into the text box on the left, selecting the amount to shift using the number in the middle and pressing the shift button. ";
                    break;
                case 5:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 15);
                    explainationText.Text = "The shifted message will be shown in the right box. If you want to go the other way, type in the box on the right and select the amount it was shifted with the number in the middle, then press the Unshift button.  ";
                    break;
                case 6:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 15);
                    explainationText.Text = "This is a basic example of encrypting (shifting) and decrypting (unshifting).";
                    break;
                case 7:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 15);
                    explainationText.Text = "This method can be used to send messages in secret but both people must know how much the message was shifted; this number is called the key. ";
                    break;
                case 8:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 15);
                    explainationText.Text = "Because both people know the key but can’t let anyone else know it, this is called a private key. ";
                    break;
            }

            this.Refresh();
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (textNumber != 8)
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
