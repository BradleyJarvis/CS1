using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Group_project
{
    public partial class PublicKeysForm : Group_project.InteractionBase
    {
        public PublicKeysForm()
        {
            InitializeComponent();
        }

        private void GenerateAndMultiplyButton_Click(object sender, EventArgs e)
        {

            Random RandomNumber = new Random();
            int FirstPrime = RandomNumber.Next(21); //get two random numbers, they will be used to select from a list of 21 random numbers.
            int SecondPrime = RandomNumber.Next(21); 



            FirstPrimeNumberLabel.ForeColor = Color.Red;
            SecondPrimeNumberLabel.ForeColor = Color.Red;
            FirstPrimeNumberTimesSecondPrimeNumberLabel.ForeColor = Color.Red; //highlight what is changeing

            FirstPrimeNumberLabel.Text = Convert.ToString(selectprimefromlist(FirstPrime)); //get the prime numbers that will be used from the list (see selectprimefromlist(int i) ) for how it works.
            SecondPrimeNumberLabel.Text = Convert.ToString(selectprimefromlist(SecondPrime));
            FirstPrimeNumberTimesSecondPrimeNumberLabel.Text = Convert.ToString(Convert.ToInt32(FirstPrimeNumberLabel.Text) * Convert.ToInt32(SecondPrimeNumberLabel.Text)); //multiply them together


            FirstPrimeNumberLabel.Visible = true;
            FirstPrimeNumberTextLabel.Visible = true;
            SecondPrimeNumberLabel.Visible = true;
            SecondPrimeNumberTextLabel.Visible = true;
            FirstPrimeNumberTimesSecondPrimeNumberLabel.Visible = true;
            FirstPrimeNumberTimesSecondPrimeNumberTextLabel.Visible = true; //show what has been worked out so far

            PhiTextBox.Visible = true; // show the next section
            FindPhiButton.Visible = true;
            Back1Button.Visible = true;


            StartingTextBox.Visible = false;
            GenerateAndMultiplyButton.Visible = false; //hide this section


            FindPhiButton.Select(); //select next button
         }

        private void Back1Button_Click(object sender, EventArgs e) 
        {
            FirstPrimeNumberLabel.ForeColor = Color.Black;
            SecondPrimeNumberLabel.ForeColor = Color.Black; //unhighlight
            FirstPrimeNumberTimesSecondPrimeNumberLabel.ForeColor = Color.Black;

            FirstPrimeNumberLabel.Text = "_";
            SecondPrimeNumberLabel.Text = "_"; //reset labels
            FirstPrimeNumberTimesSecondPrimeNumberLabel.Text = "_";

            FirstPrimeNumberLabel.Visible = false;
            FirstPrimeNumberTextLabel.Visible = false; //hide now reset labels
            SecondPrimeNumberLabel.Visible = false;
            SecondPrimeNumberTextLabel.Visible = false;
            FirstPrimeNumberTimesSecondPrimeNumberLabel.Visible = false;
            FirstPrimeNumberTimesSecondPrimeNumberTextLabel.Visible = false;

            PhiTextBox.Visible = false;
            FindPhiButton.Visible = false; //hide this section
            Back1Button.Visible = false;

            StartingTextBox.Visible = true;
            GenerateAndMultiplyButton.Visible = true; //show previous section

            GenerateAndMultiplyButton.Select();//select previous button
        }

        private int selectprimefromlist(int i) //given a number, find a prime number from 7 to 97
        {
            switch (i)
            {
                case (0): return (7); 
                case (1): return (11); 
                case (2): return (13); 
                case (3): return (17); 
                case (4): return (19); 
                case (5): return (23); 
                case (6): return (29); 
                case (7): return (31);
                case (8): return (37); 
                case (9): return (41); 
                case (10): return (43);
                case (11): return (47);
                case (12): return (53); 
                case (13): return (59);
                case (14): return (61);
                case (15): return (67); 
                case (16): return (71); 
                case (17): return (73);
                case (18): return (79);
                case (19): return (83); 
                case (20): return (89); 
                case (21): return (97); 
                default: return (47); //this should never be used, but it is best to be safe.
            }
        }

        private void FindPhiButton_Click(object sender, EventArgs e)
        {
            FirstPrimeNumberLabel.ForeColor = Color.Black;
            SecondPrimeNumberLabel.ForeColor = Color.Black;//unhighlight
            FirstPrimeNumberTimesSecondPrimeNumberLabel.ForeColor = Color.Black;

            PhiPrivateLabel.ForeColor = Color.Red; //highlight what is changeing

            PhiPrivateLabel.Text = Convert.ToString((Convert.ToInt32(FirstPrimeNumberLabel.Text) - 1) * (Convert.ToInt32(SecondPrimeNumberLabel.Text) - 1)); // find the phi of the multiplication of the primes.


            PhiPrivateTextLabel.Visible = true; //show what has been worked out so far
            PhiPrivateLabel.Visible = true;

            FindDButton.Visible = true;// show the next section
            DTextBox.Visible = true;
            Back2Button.Visible = true;

            PhiTextBox.Visible = false;
            FindPhiButton.Visible = false; //hide this section
            Back1Button.Visible = false;

            FindDButton.Select();
        }

        private void Back2Button_Click(object sender, EventArgs e)
        {
            FirstPrimeNumberLabel.ForeColor = Color.Red;//highlight what is changeing
            SecondPrimeNumberLabel.ForeColor = Color.Red;
            FirstPrimeNumberTimesSecondPrimeNumberLabel.ForeColor = Color.Red;

            PhiPrivateLabel.ForeColor = Color.Black;//unhighlight

            PhiPrivateLabel.Text = "_";//reset labels

            PhiPrivateTextLabel.Visible = false;
            PhiPrivateLabel.Visible = false;//hide now reset labels

            FindDButton.Visible = false;
            DTextBox.Visible = false;//hide this section
            Back2Button.Visible = false;

            PhiTextBox.Visible = true;
            FindPhiButton.Visible = true;//show previous section
            Back1Button.Visible = true;

            FindPhiButton.Select();//select previous button
        }

        private void FindDButton_Click(object sender, EventArgs e)
        {
            Random RandomNumber = new Random();
            int Exponent = RandomNumber.Next(3,20); //select a random number from 3 to 20, this will be the exponent

            PhiPrivateLabel.ForeColor = Color.Black;

            DLabel.ForeColor = Color.Red;
            ExponentLabel.ForeColor = Color.Red;

            ExponentLabel.Text = Convert.ToString(Exponent);
            DLabel.Text = Convert.ToString((2 * Convert.ToInt32(PhiPrivateLabel.Text) + 1) / Exponent); // find D

            DTextLabel.Visible = true;
            DLabel.Visible = true;
            ExponentTextLabel.Visible = true;
            ExponentLabel.Visible = true;
            MessageCharTextBox.Visible = true;
            MessageLetterLabel.Visible = true;

            ConverToNumberTextBox.Visible = true;
            ConvertToANumberButton.Visible = true;
            Back3Button.Visible = true;

            FindDButton.Visible = false;
            DTextBox.Visible = false;
            Back2Button.Visible = false;

            ConvertToANumberButton.Select();
        }

        private void Back3Button_Click(object sender, EventArgs e)
        {
            PhiPrivateLabel.ForeColor = Color.Red;

            DLabel.ForeColor = Color.Black;
            ExponentLabel.ForeColor = Color.Black;

            ExponentLabel.Text = "_";
            DLabel.Text = "_";

            DTextLabel.Visible = false;
            DLabel.Visible = false;
            ExponentTextLabel.Visible = false;
            ExponentLabel.Visible = false;
            MessageCharTextBox.Visible = false;
            MessageLetterLabel.Visible = false;

            ConverToNumberTextBox.Visible = false;
            ConvertToANumberButton.Visible = false;
            Back3Button.Visible = false;

            FindDButton.Visible = true;
            DTextBox.Visible = true;
            Back2Button.Visible = true;

            FindDButton.Select();
        }


        private void MessageCharTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (MessageCharTextBox.Text != "") //if they did not leave it empty
            {
                if (!(Char.IsLetter(MessageCharTextBox.Text[0]))) //if the 1st (and only) character is not a letter
                {
                    MessageCharTextBox.Text = "a"; // set it to the default of a
                    MessageBox.Show("Please only use letters of the alphabet for this example."); //inform the user with a popup

                }
            }
        }

        private void ConvertToANumberButton_Click(object sender, EventArgs e)
        {
            DLabel.ForeColor = Color.Black;
            ExponentLabel.ForeColor = Color.Black;

            MessageCharTextBox.ReadOnly = true;
            MessageCharTextBox.BackColor = Color.LightGray; // stop them from edditing their message once they have chosen it without going back, turn the background grey from now on to show this.
            MessageCharTextBox.ForeColor = Color.Red;


            if (MessageCharTextBox.Text == "") //if the box is empty use the letter a
            {
                MessageCharTextBox.Text = "a";
            }
            MessageNumberLabel.Text = Convert.ToString(((Convert.ToInt16(MessageCharTextBox.Text[0])) - 64) % 32);    //convert the letter to a number with a being 1 and b being 2 etc, ignore caps lock.

            ConverToNumberTextBox.Visible = false;
            ConvertToANumberButton.Visible = false;
            Back3Button.Visible = false;

            MessageNumberLabel.Visible = true;
            MessageNumberTextLabel.Visible = true;

            EncryptAndSendTextbox.Visible = true;
            EncryptMessageAndSendButton.Visible = true;
            Back4Button.Visible = true;

            EncryptMessageAndSendButton.Select();
        }

        private void Back4Button_Click(object sender, EventArgs e)
        {
            DLabel.ForeColor = Color.Red;
            ExponentLabel.ForeColor = Color.Red;

            MessageCharTextBox.ReadOnly = false;
            MessageCharTextBox.BackColor = Color.White; 
            MessageCharTextBox.ForeColor = Color.Black;


            MessageCharTextBox.Text = "";
            MessageNumberLabel.Text = "_";

            ConverToNumberTextBox.Visible = true;
            ConvertToANumberButton.Visible = true;
            Back3Button.Visible = true;

            MessageNumberLabel.Visible = false;
            MessageNumberTextLabel.Visible = false;

            EncryptAndSendTextbox.Visible = false;
            EncryptMessageAndSendButton.Visible = false;
            Back4Button.Visible = false;

            ConvertToANumberButton.Select();
        }

        private void EncryptMessageAndSendButton_Click(object sender, EventArgs e)
        {
            EncryptedMessageLabel.ForeColor = Color.Red;
            EavesdropperELabel.ForeColor = Color.Red;
            EavesdropperELabel.ForeColor = Color.Red;
            EavesdropperELabel.ForeColor = Color.Red;
            EavesdropperELabel.ForeColor = Color.Red;
            EavesdropperMLabel.ForeColor = Color.Red;
            EavesdropperNLabel.ForeColor = Color.Red;

            MessageCharTextBox.ForeColor = Color.Black;

            EncryptedMessageLabel.Text = Convert.ToString( (Convert.ToInt32(MessageNumberLabel.Text) ^ Convert.ToInt32(ExponentLabel.Text)) % Convert.ToInt32(FirstPrimeNumberTimesSecondPrimeNumberLabel.Text) ); 
            //use the encryption algorithm to discover the encrypted message

            EavesdropperELabel.Text = ExponentLabel.Text;
            EavesdropperMLabel.Text = EncryptedMessageLabel.Text;
            EavesdropperNLabel.Text = FirstPrimeNumberTimesSecondPrimeNumberLabel.Text;

            EncryptedMessageLabel.Visible = true;
            EncryptedMessageTextLabel.Visible = true;

            EavesdropperETextLabel.Visible = true;
            EavesdropperELabel.Visible = true;
            EavesdropperMTextLabel.Visible = true;
            EavesdropperMLabel.Visible = true;
            EavesdropperNTextLabel.Visible = true;
            EavesdropperNLabel.Visible = true;

            DecryptButton.Visible = true;
            DecryptTextBox.Visible = true;
            Back5Button.Visible = true;

            EncryptAndSendTextbox.Visible = false;
            EncryptMessageAndSendButton.Visible = false;
            Back4Button.Visible = false;

            DecryptButton.Select();
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            DecryptedLabel.ForeColor = Color.Red;

            EncryptedMessageLabel.ForeColor = Color.Black;
            EavesdropperELabel.ForeColor = Color.Black;
            EavesdropperELabel.ForeColor = Color.Black;
            EavesdropperELabel.ForeColor = Color.Black;
            EavesdropperELabel.ForeColor = Color.Black;
            EavesdropperMLabel.ForeColor = Color.Black;
            EavesdropperNLabel.ForeColor = Color.Black;

            DecryptedLabel.Text = MessageCharTextBox.Text; //While this is technically cheating, the wizard of oz approach allows for faster results and the purpose of this program is only demonstration and education.

            DecryptedTextLabel.Visible = true;
            DecryptedLabel.Visible = true;

            RestartButton.Visible = true;
            RestartTextBox.Visible = true;
            Back6Button.Visible = true;

            DecryptButton.Visible = false;
            DecryptTextBox.Visible = false;
            Back5Button.Visible = false;

            RestartButton.Visible = true;

            RestartButton.Select();
          
        }

        private void Back5Button_Click(object sender, EventArgs e)
        {
            EncryptedMessageLabel.ForeColor = Color.Black;
            EavesdropperELabel.ForeColor = Color.Black;
            EavesdropperELabel.ForeColor = Color.Black;
            EavesdropperELabel.ForeColor = Color.Black;
            EavesdropperELabel.ForeColor = Color.Black;
            EavesdropperMLabel.ForeColor = Color.Black;
            EavesdropperNLabel.ForeColor = Color.Black;

            MessageCharTextBox.ForeColor = Color.Red;

            EncryptedMessageLabel.Text = "_";

            EavesdropperELabel.Text = "_";
            EavesdropperMLabel.Text = "_";
            EavesdropperNLabel.Text = "_";

            EncryptedMessageLabel.Visible = false;
            EncryptedMessageTextLabel.Visible = false;

            EavesdropperETextLabel.Visible = false;
            EavesdropperELabel.Visible = false;
            EavesdropperMTextLabel.Visible = false;
            EavesdropperMLabel.Visible = false;
            EavesdropperNTextLabel.Visible = false;
            EavesdropperNLabel.Visible = false;

            DecryptButton.Visible = false;
            DecryptTextBox.Visible = false;
            Back5Button.Visible = false;

            EncryptAndSendTextbox.Visible = true;
            EncryptMessageAndSendButton.Visible = true;
            Back4Button.Visible = true;

            EncryptMessageAndSendButton.Select();
        }

        private void Back6Button_Click(object sender, EventArgs e)
        {
            DecryptedLabel.ForeColor = Color.Black;

            EncryptedMessageLabel.ForeColor = Color.Red;
            EavesdropperELabel.ForeColor = Color.Red;
            EavesdropperELabel.ForeColor = Color.Red;
            EavesdropperELabel.ForeColor = Color.Red;
            EavesdropperELabel.ForeColor = Color.Red;
            EavesdropperMLabel.ForeColor = Color.Red;
            EavesdropperNLabel.ForeColor = Color.Red;

            DecryptedLabel.Text = "_";

            DecryptedTextLabel.Visible = false;
            DecryptedLabel.Visible = false;

            RestartButton.Visible = false;
            RestartTextBox.Visible = false;
            Back6Button.Visible = false;

            DecryptButton.Visible = true;
            DecryptTextBox.Visible = true;
            Back5Button.Visible = true;

            DecryptButton.Select();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            MessageCharTextBox.ReadOnly = false; //make the text box edditable again.
            MessageCharTextBox.BackColor = Color.White;
            MessageCharTextBox.ForeColor = Color.Black;

            DecryptedLabel.ForeColor = Color.Black;

            DecryptedLabel.Text = "_";

            EncryptedMessageLabel.Text = "_";

            EavesdropperELabel.Text = "_";
            EavesdropperMLabel.Text = "_";
            EavesdropperNLabel.Text = "_";

            MessageCharTextBox.Text = "a";
            MessageNumberLabel.Text = "_";

            ExponentLabel.Text = "_";
            DLabel.Text = "_";

            PhiPrivateLabel.Text = "_";

            FirstPrimeNumberLabel.Text = "_";
            SecondPrimeNumberLabel.Text = "_";
            FirstPrimeNumberTimesSecondPrimeNumberLabel.Text = "_";

            StartingTextBox.Visible = true;
            GenerateAndMultiplyButton.Visible = true;

            RestartButton.Visible = false;
            RestartTextBox.Visible = false;
            Back6Button.Visible = false;

            DecryptedTextLabel.Visible = false;
            DecryptedLabel.Visible = false;

            EavesdropperETextLabel.Visible = false;
            EavesdropperELabel.Visible = false;
            EavesdropperMTextLabel.Visible = false;
            EavesdropperMLabel.Visible = false;
            EavesdropperNTextLabel.Visible = false;
            EavesdropperNLabel.Visible = false;

            EncryptedMessageLabel.Visible = false;
            EncryptedMessageTextLabel.Visible = false;

            MessageNumberLabel.Visible = false;
            MessageNumberTextLabel.Visible = false;

            MessageCharTextBox.Visible = false;
            MessageLetterLabel.Visible = false;

            DTextLabel.Visible = false;
            DLabel.Visible = false;
            ExponentTextLabel.Visible = false;
            ExponentLabel.Visible = false;

            PhiPrivateTextLabel.Visible = false;
            PhiPrivateLabel.Visible = false;

            FirstPrimeNumberLabel.Visible = false;
            FirstPrimeNumberTextLabel.Visible = false;
            SecondPrimeNumberLabel.Visible = false;
            SecondPrimeNumberTextLabel.Visible = false;
            FirstPrimeNumberTimesSecondPrimeNumberLabel.Visible = false;
            FirstPrimeNumberTimesSecondPrimeNumberTextLabel.Visible = false;

            GenerateAndMultiplyButton.Select();

        }
    }
}
