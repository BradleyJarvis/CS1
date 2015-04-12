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
            int FirstPrime = RandomNumber.Next(21);
            int SecondPrime = RandomNumber.Next(21); 



            FirstPrimeNumberLabel.ForeColor = Color.Red;
            SecondPrimeNumberLabel.ForeColor = Color.Red;
            FirstPrimeNumberTimesSecondPrimeNumberLabel.ForeColor = Color.Red;

            FirstPrimeNumberLabel.Text = Convert.ToString(selectprimefromlist(FirstPrime));
            SecondPrimeNumberLabel.Text = Convert.ToString(selectprimefromlist(SecondPrime));
            FirstPrimeNumberTimesSecondPrimeNumberLabel.Text = Convert.ToString(Convert.ToInt32(FirstPrimeNumberLabel.Text) * Convert.ToInt32(SecondPrimeNumberLabel.Text));

            StartingTextBox.Visible = false;
            GenerateAndMultiplyButton.Visible = false;

            PhiTextBox.Visible = true;
            FindPhiButton.Visible = true;
            Back1Button.Visible = true;


            FindPhiButton.Select();
         }

        private void Back1Button_Click(object sender, EventArgs e)
        {
            FirstPrimeNumberLabel.ForeColor = Color.Black;
            SecondPrimeNumberLabel.ForeColor = Color.Black;
            FirstPrimeNumberTimesSecondPrimeNumberLabel.ForeColor = Color.Black;

            FirstPrimeNumberLabel.Text = "_";
            SecondPrimeNumberLabel.Text = "_";
            FirstPrimeNumberTimesSecondPrimeNumberLabel.Text = "_";

            StartingTextBox.Visible = true;
            GenerateAndMultiplyButton.Visible = true;

            PhiTextBox.Visible = false;
            FindPhiButton.Visible = false;
            Back1Button.Visible = false;

            GenerateAndMultiplyButton.Select();
        }

        private int selectprimefromlist(int i)
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
                default: return (47); 
            }
        }

        private void FindPhiButton_Click(object sender, EventArgs e)
        {
            FirstPrimeNumberLabel.ForeColor = Color.Black;
            SecondPrimeNumberLabel.ForeColor = Color.Black;
            FirstPrimeNumberTimesSecondPrimeNumberLabel.ForeColor = Color.Black;

            PhiPrivateLabel.ForeColor = Color.Red;

            PhiPrivateLabel.Text = Convert.ToString((Convert.ToInt32(FirstPrimeNumberLabel.Text) - 1) * (Convert.ToInt32(SecondPrimeNumberLabel.Text) - 1));


            PhiPrivateTextLabel.Visible = true;
            PhiPrivateLabel.Visible = true;

            FindDButton.Visible = true;
            DTextBox.Visible = true;
            Back2Button.Visible = true;

            PhiTextBox.Visible = false;
            FindPhiButton.Visible = false;
            Back1Button.Visible = false;

            FindDButton.Select();
        }

        private void Back2Button_Click(object sender, EventArgs e)
        {
            FirstPrimeNumberLabel.ForeColor = Color.Red;
            SecondPrimeNumberLabel.ForeColor = Color.Red;
            FirstPrimeNumberTimesSecondPrimeNumberLabel.ForeColor = Color.Red;

            PhiPrivateLabel.ForeColor = Color.Black;

            PhiPrivateLabel.Text = "_";

            PhiPrivateTextLabel.Visible = false;
            PhiPrivateLabel.Visible = false;

            FindDButton.Visible = false;
            DTextBox.Visible = false;
            Back2Button.Visible = false;

            PhiTextBox.Visible = true;
            FindPhiButton.Visible = true;
            Back1Button.Visible = true;

            FindPhiButton.Select();
        }

        private void FindDButton_Click(object sender, EventArgs e)
        {
            Random RandomNumber = new Random();
            int Exponent = RandomNumber.Next(3,20);

            PhiPrivateLabel.ForeColor = Color.Black;

            DLabel.ForeColor = Color.Red;
            ExponentLabel.ForeColor = Color.Red;

            ExponentLabel.Text = Convert.ToString(Exponent);
            DLabel.Text = Convert.ToString((2 * Convert.ToInt32(PhiPrivateLabel.Text) + 1) / Exponent);

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
            if (MessageCharTextBox.Text != "")
            {
                if (!(Char.IsLetter(MessageCharTextBox.Text[0])))
                {
                    MessageCharTextBox.Text = "a";
                    MessageBox.Show("Please only use letters of the alphabet for this example.");

                }
            }
        }

        private void ConvertToANumberButton_Click(object sender, EventArgs e)
        {
            DLabel.ForeColor = Color.Black;
            ExponentLabel.ForeColor = Color.Black;

            MessageCharTextBox.ReadOnly = true;
            MessageCharTextBox.BackColor = Color.LightGray;
            MessageCharTextBox.ForeColor = Color.Red;


            if (MessageCharTextBox.Text == "")
            {
                MessageCharTextBox.Text = "a";
            }
            MessageNumberLabel.Text = Convert.ToString(((Convert.ToInt16(MessageCharTextBox.Text[0])) - 64) % 32);    

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
            MessageCharTextBox.ReadOnly = false;
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

            GenerateAndMultiplyButton.Select();

        }
    }
}
