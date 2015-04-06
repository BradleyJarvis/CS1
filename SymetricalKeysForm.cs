using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Group_project
{
    public partial class SymetricalKeysForm : Group_project.InteractionBase //takes the menu strip and basic properties of the interaction base
    {
        public SymetricalKeysForm()// generic initilisation
        {
            InitializeComponent(); 
        }

        /*  
         * For the following buttons upto restart button the methods are layed out in the following order:
         *      any random numbers that must be determined
         *      change font that was red to black and font that was black to red such that only areas that have changed in the currrent step are red 
         *      (order is reverced for back buttons)
         *      make any changes to the labels that are needed
         *      hide the current textbox and show the next one. (also show/hide the relevent buttons and any labels that are new)
         *      (order is reverced for back buttons)
         *      change selection to a more logical one.
         */

        private void GenerateSecretNumbersButton_Click(object sender, EventArgs e) //pressing the first "next" button 
        {
            Random RandomNumber = new Random();
            int SenderSecretKeyNumber = RandomNumber.Next(1, 100);
            int RecieverSecretKeyNumber = RandomNumber.Next(1, 100); //generate 2 numbers between 1 and 100 randomly (being truely random is not vital for this program)

            SenderSecretKeyNumberLabel.ForeColor = Color.Red; //make red the to be changed fields
            RecieverSecretKeyNumberLabel.ForeColor = Color.Red;

            SenderSecretKeyNumberLabel.Text = Convert.ToString(SenderSecretKeyNumber); //change the secret numbers for each party to the values that where just created
            RecieverSecretKeyNumberLabel.Text = Convert.ToString(RecieverSecretKeyNumber);

            GeneraterandomtextBox.Visible = false; //hide this section
            GenerateSecretNumbersButton.Visible = false;

            FindModtextbox.Visible = true; //show the next section
            FindAnswerbutton.Visible = true;
            Backbutton.Visible = true;

            FindAnswerbutton.Select(); //select the next button
        }

        private void FindAnswerbutton_Click(object sender, EventArgs e) //pressing the second "next" button 
        {
            SenderSecretKeyNumberLabel.ForeColor = Color.Black;//make black the previously changed fields
            RecieverSecretKeyNumberLabel.ForeColor = Color.Black;
       
            SenderTextLabel.ForeColor = Color.Red;//make red the to be changed fields

            SenderTextLabel.Text = Convert.ToString((Math.Pow(3, Convert.ToInt64(SenderSecretKeyNumberLabel.Text))) % 17); //find 3^SecretSenderNumber MOD 17 and put that in the senders text label

            FindModtextbox.Visible = false;//hide this section
            FindAnswerbutton.Visible = false;
            Backbutton.Visible = false;

            Send1textBox.Visible = true;//show the next section
            Send1button.Visible = true;
            Back2button.Visible = true;

            Send1button.Select(); //select the next button
        }

        private void Send1button_Click(object sender, EventArgs e) //pressing the third "next" button 
        {
            SenderTextLabel.ForeColor = Color.Black;//make black the previously changed fields

            MessageSentLabel.ForeColor = Color.Red;//make red the to be changed fields
            RecieverTextLabel.ForeColor = Color.Red;
            HackerTextLabel.ForeColor = Color.Red;

            MessageSentLabel.Text = SenderTextLabel.Text; //duplicate the sent text to the recipients
            RecieverTextLabel.Text = SenderTextLabel.Text;
            HackerTextLabel.Text = SenderTextLabel.Text;

            Send1textBox.Visible = false;//hide this section
            Send1button.Visible = false;
            Back2button.Visible = false;

            Replybutton.Visible = true;//show the next section
            Back3button.Visible = true;
            ReplytextBox.Visible = true;

            Replybutton.Select(); //select the next button
        }

        private void Replybutton_Click(object sender, EventArgs e) //pressing the fourth "next" button 
        {
            MessageSentLabel.ForeColor = Color.Black;//make black the previously changed fields
            RecieverTextLabel.ForeColor = Color.Black;
            HackerTextLabel.ForeColor = Color.Black;

            MessageReplyLabel.ForeColor = Color.Red;//make red the to be changed fields
            RecieverReplyLabel.ForeColor = Color.Red;
            HackerReplyLabel.ForeColor = Color.Red;
            SenderReplyLabel.ForeColor = Color.Red;

            RecieverReplyLabel.Text = Convert.ToString((Math.Pow(3, Convert.ToInt64(RecieverSecretKeyNumberLabel.Text))) % 17); //find 3^RecieverSecretNumber MOD 17 and put that in the recievers text label

            MessageReplyLabel.Text = RecieverReplyLabel.Text;//duplicate the replyed text to the recipients
            HackerReplyLabel.Text = RecieverReplyLabel.Text;
            SenderReplyLabel.Text = RecieverReplyLabel.Text;

            Replybutton.Visible = false;//hide this section
            Back3button.Visible = false;
            ReplytextBox.Visible = false;


            MessageReplyLabel.Visible = true;//show the newly filled labels
            SenderReplyLabel.Visible = true;
            RecieverReplyLabel.Visible = true;
            HackerReplyLabel.Visible = true;

            Back4button.Visible = true;//show the next section
            FindCommonNumberButton.Visible = true;
            FindCommontextBox.Visible = true;

            FindCommonNumberButton.Select();//select the next button
        }

        private void FindCommonNumberButton_Click(object sender, EventArgs e) //pressing the fifth "next" button 
        {

            MessageReplyLabel.ForeColor = Color.Black;//make black the previously changed fields
            RecieverReplyLabel.ForeColor = Color.Black;
            HackerReplyLabel.ForeColor = Color.Black;
            SenderReplyLabel.ForeColor = Color.Black;

            SharedSecretNumberLabel.ForeColor = Color.Red;//make red the to be changed fields

            SharedSecretNumberLabel.Text = Convert.ToString((Math.Pow(Convert.ToInt64(SenderReplyLabel.Text), Convert.ToInt64(SenderSecretKeyNumberLabel.Text))) % 17);
            //find SendersSecretNumber^RecieverSentNumber MOD 17 and put that in the recievers text label (would work if the recievers secret number was used and the senders sent number) place that value in the shared secret number field.

            Back4button.Visible = false;//hide this section
            FindCommonNumberButton.Visible = false;
            FindCommontextBox.Visible = false;

            Back5button.Visible = true;//show the next section
            FinnishedTextBox.Visible = true;
            RestartButton.Visible = true;

            RestartButton.Select(); //select the next button
        }

        private void Backbutton_Click(object sender, EventArgs e) //pressing the first "back" button 
        {
            SenderSecretKeyNumberLabel.ForeColor = Color.Black;//make black the previously changed fields
            RecieverSecretKeyNumberLabel.ForeColor = Color.Black;

            SenderSecretKeyNumberLabel.Text = "_";//reset all the labels to there initial values
            RecieverSecretKeyNumberLabel.Text = "_";

            GeneraterandomtextBox.Visible = true;//show the previous section
            GenerateSecretNumbersButton.Visible = true;

            FindModtextbox.Visible = false;//hide this section
            FindAnswerbutton.Visible = false;
            Backbutton.Visible = false;

            GenerateSecretNumbersButton.Select(); //select the next button
        }

        private void Back2button_Click(object sender, EventArgs e)//pressing the second "back" button 
        {
            SenderSecretKeyNumberLabel.ForeColor = Color.Red;//make red the previously changed fields
            RecieverSecretKeyNumberLabel.ForeColor = Color.Red;

            SenderTextLabel.ForeColor = Color.Black;//make black the recently changed fields

            SenderTextLabel.Text = "Sender Text";//reset all the labels to there initial values

            FindModtextbox.Visible = true;//show the previous section
            FindAnswerbutton.Visible = true;
            Backbutton.Visible = true;

            Send1textBox.Visible = false;//hide this section
            Send1button.Visible = false;
            Back2button.Visible = false;

            FindAnswerbutton.Select(); //select the next button
        }

        private void Back3button_Click(object sender, EventArgs e)//pressing the third "back" button 
        {
            SenderTextLabel.ForeColor = Color.Red;//make red the previously changed fields

            MessageSentLabel.ForeColor = Color.Black;//make black the recently changed fields
            RecieverTextLabel.ForeColor = Color.Black;
            HackerTextLabel.ForeColor = Color.Black;

            MessageSentLabel.Text = "Message Sent";//reset all the labels to there initial values
            RecieverTextLabel.Text = "Reciever Text";
            HackerTextLabel.Text = "Hacker Text";

            Send1textBox.Visible = true;//show the previous section
            Send1button.Visible = true;
            Back2button.Visible = true;

            Replybutton.Visible = false;//hide this section
            Back3button.Visible = false;
            ReplytextBox.Visible = false;

            Send1button.Select(); //select the next button
        }

        private void Back4button_Click(object sender, EventArgs e)//pressing the fourth "back" button 
        {
            MessageSentLabel.ForeColor = Color.Red;//make red the previously changed fields
            RecieverTextLabel.ForeColor = Color.Red;
            HackerTextLabel.ForeColor = Color.Red;

            MessageReplyLabel.ForeColor = Color.Black;//make black the recently changed fields
            RecieverReplyLabel.ForeColor = Color.Black;
            HackerReplyLabel.ForeColor = Color.Black;
            SenderReplyLabel.ForeColor = Color.Black;

            MessageReplyLabel.Text = "Message Reply";//reset all the labels to there initial values
            RecieverReplyLabel.Text = "Reciever Reply";
            HackerReplyLabel.Text = "Hacker Reply";
            SenderReplyLabel.Text = "Sender Reply";

            Replybutton.Visible = true;//show the previous section
            Back3button.Visible = true;
            ReplytextBox.Visible = true;

            MessageReplyLabel.Visible = false;//hide the newly revealed labels
            SenderReplyLabel.Visible = false;
            RecieverReplyLabel.Visible = false;
            HackerReplyLabel.Visible = false;

            Back4button.Visible = false;//hide this section
            FindCommonNumberButton.Visible = false;
            FindCommontextBox.Visible = false;

            Replybutton.Select(); //select the next button
        }

        private void Back5button_Click(object sender, EventArgs e)//pressing the fifth "back" button 
        {
            MessageReplyLabel.ForeColor = Color.Red;//make red the previously changed fields
            RecieverReplyLabel.ForeColor = Color.Red;
            HackerReplyLabel.ForeColor = Color.Red;
            SenderReplyLabel.ForeColor = Color.Red;

            SharedSecretNumberLabel.ForeColor = Color.Black;//make black the recently changed fields

            SharedSecretNumberLabel.Text = "_";//reset label to its initial values

            Back4button.Visible = true;//show the previous section
            FindCommonNumberButton.Visible = true;
            FindCommontextBox.Visible = true;

            Back5button.Visible = false;//hide this section
            FinnishedTextBox.Visible = false;
            RestartButton.Visible = false;

            FindCommonNumberButton.Select();//select the next button
        }

        private void RestartButton_Click(object sender, EventArgs e)//pressing the "restart" button 
        {
            SharedSecretNumberLabel.ForeColor = Color.Black;//make black the recently changed fields

            SenderSecretKeyNumberLabel.Text = "_";//reset all the labels to there initial values
            RecieverSecretKeyNumberLabel.Text = "_";

            SenderTextLabel.Text = "Sender Text";
            MessageSentLabel.Text = "Message Sent";
            RecieverTextLabel.Text = "Reciever Text";
            HackerTextLabel.Text = "Hacker Text";

            RecieverReplyLabel.Text = "_";
            MessageReplyLabel.Text = "_";
            HackerReplyLabel.Text = "_";
            SenderReplyLabel.Text = "_";

            SharedSecretNumberLabel.Text = "_";


            GeneraterandomtextBox.Visible = true;//show the previous section
            GenerateSecretNumbersButton.Visible = true;
            

            Back5button.Visible = false;//hide this section
            FinnishedTextBox.Visible = false;
            RestartButton.Visible = false;

            MessageReplyLabel.Visible = false;//hide the revealed labels
            SenderReplyLabel.Visible = false;
            RecieverReplyLabel.Visible = false;
            HackerReplyLabel.Visible = false;

            GenerateSecretNumbersButton.Select();//select the next button
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
