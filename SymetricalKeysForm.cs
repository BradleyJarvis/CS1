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

        private void GenerateSecretNumbersButton_Click(object sender, EventArgs e)
        {
            Random RandomNumber = new Random();
            int SenderSecretKeyNumber = RandomNumber.Next(1, 100);
            int RecieverSecretKeyNumber = RandomNumber.Next(1, 100);


            SenderSecretKeyNumberLabel.ForeColor = Color.Red;
            RecieverSecretKeyNumberLabel.ForeColor = Color.Red;

            SenderSecretKeyNumberLabel.Text = Convert.ToString(SenderSecretKeyNumber);
            RecieverSecretKeyNumberLabel.Text = Convert.ToString(RecieverSecretKeyNumber);

            GeneraterandomtextBox.Visible = false;
            GenerateSecretNumbersButton.Visible = false;

            FindModtextbox.Visible = true;
            FindAnswerbutton.Visible = true;
            Backbutton.Visible = true;
            FindAnswerbutton.Select();
        }

        private void FindAnswerbutton_Click(object sender, EventArgs e)
        {
            SenderSecretKeyNumberLabel.ForeColor = Color.Black;
            RecieverSecretKeyNumberLabel.ForeColor = Color.Black;

            SenderTextLabel.Text = Convert.ToString((Math.Pow(3, Convert.ToInt64(SenderSecretKeyNumberLabel.Text))) % 17);
            SenderTextLabel.ForeColor = Color.Red;

            FindModtextbox.Visible = false;
            FindAnswerbutton.Visible = false;
            Backbutton.Visible = false;

            Send1textBox.Visible = true;
            Send1button.Visible = true;
            Back2button.Visible = true;
            Send1button.Select();
        }

        private void Send1button_Click(object sender, EventArgs e)
        {
            SenderTextLabel.ForeColor = Color.Black;

            MessageSentLabel.ForeColor = Color.Red;
            RecieverTextLabel.ForeColor = Color.Red;
            HackerTextLabel.ForeColor = Color.Red;

            MessageSentLabel.Text = SenderTextLabel.Text;
            RecieverTextLabel.Text = SenderTextLabel.Text;
            HackerTextLabel.Text = SenderTextLabel.Text;

            Send1textBox.Visible = false;
            Send1button.Visible = false;
            Back2button.Visible = false;

            Replybutton.Visible = true;
            Back3button.Visible = true;
            ReplytextBox.Visible = true;
            Replybutton.Select();
        }

        private void Replybutton_Click(object sender, EventArgs e)
        {
            MessageSentLabel.ForeColor = Color.Black;
            RecieverTextLabel.ForeColor = Color.Black;
            HackerTextLabel.ForeColor = Color.Black;

            MessageReplyLabel.ForeColor = Color.Red;
            RecieverReplyLabel.ForeColor = Color.Red;
            HackerReplyLabel.ForeColor = Color.Red;
            SenderReplyLabel.ForeColor = Color.Red;

            RecieverReplyLabel.Text = Convert.ToString((Math.Pow(3, Convert.ToInt64(RecieverSecretKeyNumberLabel.Text))) % 17);
            MessageReplyLabel.Text = RecieverReplyLabel.Text;
            HackerReplyLabel.Text = RecieverReplyLabel.Text;
            SenderReplyLabel.Text = RecieverReplyLabel.Text;

            Replybutton.Visible = false;
            Back3button.Visible = false;
            ReplytextBox.Visible = false;


            MessageReplyLabel.Visible = true;
            SenderReplyLabel.Visible = true;
            RecieverReplyLabel.Visible = true;
            HackerReplyLabel.Visible = true;

            Back4button.Visible = true;
            FindCommonNumberButton.Visible = true;
            FindCommontextBox.Visible = true;
            FindCommonNumberButton.Select();
        }

        private void FindCommonNumberButton_Click(object sender, EventArgs e)
        {

            MessageReplyLabel.ForeColor = Color.Black;
            RecieverReplyLabel.ForeColor = Color.Black;
            HackerReplyLabel.ForeColor = Color.Black;
            SenderReplyLabel.ForeColor = Color.Black;

            SharedSecretNumberLabel.ForeColor = Color.Red;

            SharedSecretNumberLabel.Text = Convert.ToString((Math.Pow(Convert.ToInt64(SenderReplyLabel.Text), Convert.ToInt64(SenderSecretKeyNumberLabel.Text))) % 17);

            Back4button.Visible = false;
            FindCommonNumberButton.Visible = false;
            FindCommontextBox.Visible = false;

            Back5button.Visible = true;
            FinnishedTextBox.Visible = true;
            RestartButton.Visible = true;
            RestartButton.Select();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            SenderSecretKeyNumberLabel.ForeColor = Color.Black;
            RecieverSecretKeyNumberLabel.ForeColor = Color.Black;

            SenderSecretKeyNumberLabel.Text = "_";
            RecieverSecretKeyNumberLabel.Text = "_";

            GeneraterandomtextBox.Visible = true;
            GenerateSecretNumbersButton.Visible = true;

            FindModtextbox.Visible = false;
            FindAnswerbutton.Visible = false;
            Backbutton.Visible = false;
        }

        private void Back2button_Click(object sender, EventArgs e)
        {
            SenderSecretKeyNumberLabel.ForeColor = Color.Red;
            RecieverSecretKeyNumberLabel.ForeColor = Color.Red;

            SenderTextLabel.Text = "Sender Text";
            SenderTextLabel.ForeColor = Color.Black;

            FindModtextbox.Visible = true;
            FindAnswerbutton.Visible = true;
            Backbutton.Visible = true;

            Send1textBox.Visible = false;
            Send1button.Visible = false;
            Back2button.Visible = false;
        }

        private void Back3button_Click(object sender, EventArgs e)
        {
            SenderTextLabel.ForeColor = Color.Red;

            MessageSentLabel.ForeColor = Color.Black;
            RecieverTextLabel.ForeColor = Color.Black;
            HackerTextLabel.ForeColor = Color.Black;

            MessageSentLabel.Text = "Message Sent";
            RecieverTextLabel.Text = "Reciever Text";
            HackerTextLabel.Text = "Hacker Text";

            Send1textBox.Visible = true;
            Send1button.Visible = true;
            Back2button.Visible = true;

            Replybutton.Visible = false;
            Back3button.Visible = false;
            ReplytextBox.Visible = false;
        }

        private void Back4button_Click(object sender, EventArgs e)
        {
            MessageSentLabel.ForeColor = Color.Red;
            RecieverTextLabel.ForeColor = Color.Red;
            HackerTextLabel.ForeColor = Color.Red;

            MessageReplyLabel.ForeColor = Color.Black;
            RecieverReplyLabel.ForeColor = Color.Black;
            HackerReplyLabel.ForeColor = Color.Black;
            SenderReplyLabel.ForeColor = Color.Black;

            MessageReplyLabel.Text = "Message Reply";
            RecieverReplyLabel.Text = "Reciever Reply";
            HackerReplyLabel.Text = "Hacker Reply";
            SenderReplyLabel.Text = "Sender Reply";

            Replybutton.Visible = true;
            Back3button.Visible = true;
            ReplytextBox.Visible = true;

            MessageReplyLabel.Visible = false;
            SenderReplyLabel.Visible = false;
            RecieverReplyLabel.Visible = false;
            HackerReplyLabel.Visible = false;

            Back4button.Visible = false;
            FindCommonNumberButton.Visible = false;
            FindCommontextBox.Visible = false;

        }

        private void Back5button_Click(object sender, EventArgs e)
        {
            MessageReplyLabel.ForeColor = Color.Red;
            RecieverReplyLabel.ForeColor = Color.Red;
            HackerReplyLabel.ForeColor = Color.Red;
            SenderReplyLabel.ForeColor = Color.Red;

            SharedSecretNumberLabel.ForeColor = Color.Black;

            SharedSecretNumberLabel.Text = "_";

            Back4button.Visible = true;
            FindCommonNumberButton.Visible = true;
            FindCommontextBox.Visible = true;

            Back5button.Visible = false;
            FinnishedTextBox.Visible = false;
            RestartButton.Visible = false;
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {


            SenderSecretKeyNumberLabel.Text = "_";
            RecieverSecretKeyNumberLabel.Text = "_";

            SenderTextLabel.Text = "Sender Text";
            MessageSentLabel.Text = "Message Sent";
            RecieverTextLabel.Text = "Reciever Text";
            HackerTextLabel.Text = "Hacker Text";

            RecieverReplyLabel.Text = "_";
            MessageReplyLabel.Text = "_";
            HackerReplyLabel.Text = "_";
            SenderReplyLabel.Text = "_";


            SharedSecretNumberLabel.ForeColor = Color.Black;

            SharedSecretNumberLabel.Text = "_";


            GeneraterandomtextBox.Visible = true;
            GenerateSecretNumbersButton.Visible = true;
            GenerateSecretNumbersButton.Select();

            Back5button.Visible = false;
            FinnishedTextBox.Visible = false;
            RestartButton.Visible = false;

            MessageReplyLabel.Visible = false;
            SenderReplyLabel.Visible = false;
            RecieverReplyLabel.Visible = false;
            HackerReplyLabel.Visible = false;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {

            if ((UnshiftedTextBox.Text != "") && (ShiftAmountNumericUpDown.Value < 27) && (ShiftAmountNumericUpDown.Value > -1))  //Check that the user has put text in and that the value of the number to be shifted by is between 0 and 26 (It should be imposwsible to select a different number).
            {
                EncryptedTextLabel.Text = UnshiftedTextBox.Text;    //Copy the unshifted text into the shifted text textbox.  The shifted text box will then be edited.
                for (int i = 0; i < EncryptedTextLabel.Text.Length; i++)  //For each letter in the text.
                {
                    if (Char.IsLetter(EncryptedTextLabel.Text[i])) //If it is a letter
                    {
                        for (int j = 0; j < ShiftAmountNumericUpDown.Value; j++) //For each time that it must be shiftd.
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
                                if (EncryptedTextLabel.Text[i] == 'z') //Check what case it is in.
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

                TopHackerTextLabel.Text = EncryptedTextLabel.Text; // once the text has been encypered update the labels on the page
                TopRecieverTextLabel.Text = UnshiftedTextBox.Text;
                TopSenderTextLabel.Text = UnshiftedTextBox.Text;


            }
            else //If there was no text or the shift value was out of bounds.
            {
                MessageBox.Show("Please type some text into the left hand side text box and choose an amount to shift the text by. Using the field next to the text box"); //Inform the user.
            }


        }








    }
}
