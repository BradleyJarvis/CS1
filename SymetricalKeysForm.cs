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
        int textNumber = 0;

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

            GenerateSecretNumbersButton.Visible = false;

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

            FindAnswerbutton.Visible = false;
            Backbutton.Visible = false;

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

            Send1button.Visible = false;
            Back2button.Visible = false;

            Replybutton.Visible = true;//show the next section
            Back3button.Visible = true;

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

            MessageReplyLabel.Visible = true;//show the newly filled labels
            SenderReplyLabel.Visible = true;
            RecieverReplyLabel.Visible = true;
            HackerReplyLabel.Visible = true;

            Back4button.Visible = true;//show the next section
            FindCommonNumberButton.Visible = true;

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

            Back5button.Visible = true;//show the next section
            RestartButton.Visible = true;

            RestartButton.Select(); //select the next button
        }

        private void Backbutton_Click(object sender, EventArgs e) //pressing the first "back" button 
        {
            SenderSecretKeyNumberLabel.ForeColor = Color.Black;//make black the previously changed fields
            RecieverSecretKeyNumberLabel.ForeColor = Color.Black;

            SenderSecretKeyNumberLabel.Text = "_";//reset all the labels to there initial values
            RecieverSecretKeyNumberLabel.Text = "_";

            GenerateSecretNumbersButton.Visible = true;

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

            FindAnswerbutton.Visible = true;
            Backbutton.Visible = true;

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

            Send1button.Visible = true;
            Back2button.Visible = true;

            Replybutton.Visible = false;//hide this section
            Back3button.Visible = false;

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

            MessageReplyLabel.Visible = false;//hide the newly revealed labels
            SenderReplyLabel.Visible = false;
            RecieverReplyLabel.Visible = false;
            HackerReplyLabel.Visible = false;

            Back4button.Visible = false;//hide this section
            FindCommonNumberButton.Visible = false;

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

            Back5button.Visible = false;//hide this section
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

            GenerateSecretNumbersButton.Visible = true;
            

            Back5button.Visible = false;//hide this section
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

        private void SymetricalKeysForm_Load(object sender, EventArgs e)
        {

        }

        private void checkInfoText()
        {
            switch (textNumber)
            {
                case 0:
                    explainationText.Text = "Now we have looked at how a simple substitution cipher can be used to protect information. We used symmetrical key algorithms. What this means is that both parties require a copy of the key in order to read the message. ";
                    break;
                case 1:
                    explainationText.Text = "Any person who intercepts a message between the two will not know what it says. While it is true that they can break through this encryption, it will take time (the amount of time depends on the algorithm). ";
                    break;
                case 2:
                    explainationText.Text = "The example to the right uses a Caesar Shift, enter the text, choose the amount to shift by and click send to see how it works with a hacker listening in.";
                    break;
                case 3:
                    explainationText.Text = "In the previous section we have two people who each had a access to a secret key that they both used, however the problem with this is both parties must secretly decide what the key will be and they must also ensure that no one else knows it. ";
                    break;
                case 4:
                    explainationText.Text = "This is fine if you want to communicate to a friend but if you are wanting to communicate with someone you can’t physically exchange the key with, how will you be able tell it to each other without the hacker also finding it.";
                    break;
                case 5:
                    explainationText.Text = "To solve this problem computer scientists came up with an algorithm that is easy to compute an answer for but that is difficult to undo unless you are the person who the message was intended for or the person it was sent by. ";
                    break;
                case 6:
                    explainationText.Text = "What's more the algorithm must still be hard to undo even when someone knows what the algorithm is. This may sound impossible but the maths involved is quite simple. It is called the Diffie–Hellman key exchange.";
                    break;
                case 7:
                    explainationText.Text = "If you look to the bottom of the page there is an example of the solution to this conundrum. The algorithm in this case uses the numbers 3 and 17 because they share no common factors. It is very important that they are prime numbers. ";
                    break;
                case 8:
                    explainationText.Text = "The reason is because of a mathematical operation called MOD. What this operation does is find out what the remainder is when two numbers are divided. For example 20 divided by 6 would be 3 remainder 2 because 6 x 3 is 18 and 18 is 2 away from 20, therefore we can say that 20 MOD 6 = 2. ";
                    break;
                case 9:
                    explainationText.Text = "The interesting thing about this function is that when you take a prime number raised to a power and MOD it with another prime number the result changes a lot depending on what the power was. For example: 3^4 MOD 17 = 13		3^5 MOD 17 = 5		3^6 MOD 17 = 15";
                    break;
                case 10:
                    explainationText.Text = "These results are very different and the most important thing is that given the number 15 it is very hard to find out what the power of 3 was.";
                    break;
                case 11:
                    explainationText.Text = " Using the numbers 3 and 17 means that a number between 0 and 16 can be stored (because of the 17) and that the answer can probably be found relatively quickly due to the fact 3 is a small number. ";
                    break;
                case 12:
                    explainationText.Text = "However in real applications prime numbers that are thousands bits, truly huge numbers. This way, even though it is possible to crack, the time required is extreme and more importantly there is no quick way to do it.";
                    break;
                case 13:
                    explainationText.Text = "Let’s look at how this works with an example. 1st both parties randomly select a number. Press 'Generate' to do this.";
                    break;
                case 14:
                    explainationText.Text = "Now that both sides have their secret numbers the sender uses it in the function 3^x MOD 17 where x is its secret number. Press 'Find' to generate the answer to that sum.";
                    break;
                case 15:
                    explainationText.Text = "This number is then sent to the receiver, however a hacker is listening in on their communications and they also receive the number. Press 'Send' to send the number.";
                    break;
                case 16:
                    explainationText.Text = "The receiver then does the same by finding the 3^x MOD 17 where x is his secret number. and sends this as a response. Once again the hacker listens in on this communication. Press 'Reply' to work out the answer to the MOD equation and send it.";
                    break;
                case 17:
                    explainationText.Text = "Now comes the most important part. Both the sender and the receiver take the number that they received and raise it to the power of their secret number then find the remainder when divided by 17 , so that’s Received^Secret MOD 17. ";
                    break;
                case 18:
                    explainationText.Text = "This will give the same result for both the sender and the receiver. Press 'Find' to find the number that the sender and receiver now know. It is worth noting that the hacker has received the same information that was sent but without either secret number they cannot know the commonly found number without a very large amount of computing time.";
                    break;
                case 19:
                    explainationText.Text = "Now that the shared secret message has been sent it can be used with private key cryptography to protect data. If you would like to start again and try using different numbers press 'Restart'";
                    break;
            }

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (textNumber != 19)
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
