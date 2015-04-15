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

        int textNumber = 0;

        public PublicKeysForm()
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

            FindPhiButton.Visible = true;
            Back1Button.Visible = true;


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

            FindPhiButton.Visible = false; //hide this section
            Back1Button.Visible = false;

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
            Back2Button.Visible = true;

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
            Back2Button.Visible = false;

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

            ConvertToANumberButton.Visible = true;
            Back3Button.Visible = true;

            FindDButton.Visible = false;
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

            ConvertToANumberButton.Visible = false;
            Back3Button.Visible = false;

            FindDButton.Visible = true;
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

            ConvertToANumberButton.Visible = false;
            Back3Button.Visible = false;

            MessageNumberLabel.Visible = true;
            MessageNumberTextLabel.Visible = true;

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

            ConvertToANumberButton.Visible = true;
            Back3Button.Visible = true;

            MessageNumberLabel.Visible = false;
            MessageNumberTextLabel.Visible = false;

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

            EncryptedMessageLabel.Text = Convert.ToString( Math.Pow(Convert.ToInt32(MessageNumberLabel.Text), Convert.ToInt32(ExponentLabel.Text)) % Convert.ToInt32(FirstPrimeNumberTimesSecondPrimeNumberLabel.Text) ); 
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
            Back5Button.Visible = true;

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
            Back6Button.Visible = true;

            DecryptButton.Visible = false;
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
            Back5Button.Visible = false;

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
            Back6Button.Visible = false;

            DecryptButton.Visible = true;
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

            GenerateAndMultiplyButton.Visible = true;

            RestartButton.Visible = false;
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

        private void PublicKeysForm_Load(object sender, EventArgs e)
        {

        }

        private void checkInfoText()
        {
            switch (textNumber)
            {
                case 0:
                    explainationText.Text = "Before we looked at how, if both users had a secret shared number, they could send information between each other safely and securely. However there are a number of problems with that system, mainly that the process must be used every time that a new person wants to communicate. ";
                    break;
                case 1:
                    explainationText.Text = "Is the sender is a bank for example the idea of having a large unique set of keys for every customer every time they connect is impractical. It would be far easier if the was only one key that the bank had to remember. This is where RSA Encryption is useful.";
                    break;
                case 2:
                    explainationText.Text = "Imagine encrypting and decrypting as separate functions. The customer would only need to know how to encrypt not how to decrypt. So is the bank where to give the customer a way to encrypt but not to decrypt they would only need one key that they could share with everyone.";
                    break;
                case 3:
                    explainationText.Text = "In the last section we saw how using  ‘ Received^Secret MOD RandomNumber= ‘ gave a result that is easy to compute in if you know all those values but given the answer and not the secret number was hard. We can call this equation ‘ m^e MOD N = c ‘.";
                    break;
                case 4:
                    explainationText.Text = "What we need is a way to change the equation so that you can undo this equation without knowing m but without letting the customer or any other ne'er do wells be able to do this.";
                    break;
                case 5:
                    explainationText.Text = "If this could be done by ‘ c^d MOD N = m ‘ where d if the key only the bank knows, and if this decryption key (d) could be used so that ‘ m^ed MOD N = m ‘it would make a hard problem easy, but only if you have d. This however requires another one way function (a function that is easy to do but hard to undo).";
                    break;
                case 6:
                    explainationText.Text = "For this problem we have to look at prime factorisation. Prime factorisation means finding how a number can be created by multiplying prime numbers (except 1). For example the prime factorisation of 30 = 5 x 3 x 2. There exactly one combination of prime numbers for each number. Prime factorisation however is a fundamentally hard problem and the time required to compute the prime factors of numbers increases exponentially.  ";
                    break;
                case 7:
                    explainationText.Text = "Let’s work through an example using two prime numbers under 100; these in reality would be thousands of bits long and randomly generated. The first step is to multiply them together. Press ‘Generate’ to fill in the prime numbers and multiply them together.";
                    break;
                case 8:
                    explainationText.Text = "Because we know the two prime numbers that multiplied to create this new number we know its prime factorisation but it would be hard to find that without knowing the 2 prime numbers we started with (especially when the numbers involved are thousands of digits long).";
                    break;
                case 9:
                    explainationText.Text = "We can use something called the Phi (Փ) function. The Phi(Փ) of a number is the amount of integers that are less than or equal to it that do not share any factors with it. For example if we look at the number 12 we would list all the numbers from 1 to 12 then we would count how many integers do not share a factor with it. (This ignores 1 as a factor) 1̲ 2 3 4 5̲ 6 7̲ 8 9 10 1̲1̲ 12";
                    break;
                case 10:
                    explainationText.Text = "The numbers that share no factor are underlined above. In this case there are 4 so the Phi(Փ) of 12 is 4.";
                    break;
                case 11:
                    explainationText.Text = "Finding the Փ of a number is hard to do unless the number is prime. If a number is prime then its Փ is itself - 1. So if we know that 21377 is prime we know Փ(21377) = 21376 easy to compute compared to non-prime numbers. However the Փ function is also multiplicative so Փ(AxB) = Փ(A) x Փ(B) so knowing this we can find the Փ of our number we made before with ease compared to someone who did not know its prime factorisation. For example is we had the prime numbers 71 and 59 we could find the Փ easily.";
                    break;
                case 12:
                    explainationText.Text = "It’s just Փ(4189) = (71 - 1) x (59 -1) = 4060. Press ‘Find’ to fill in this detail for the prime numbers we are using in the example.";
                    break;
                case 13:
                    explainationText.Text = "In order to use this in cryptography the Փ of a number was connected to the MOD function using Euler’s theorem. This theorem states that m^Փ(n) ≡ 1 MOD n. It is also known that 1 to the power of any number is 1, so 1 ^k = 1. Therefore m^k*Փ(n) ≡ 1 MOD n. It is also known that 1 * m = m where m is any number. So my multiplying both sides of the equation by m we arrive at m*m^k*Փ(n)≡ m MOD n or to simplify - ‘ m^k*Փ(n)+1≡ m MOD n ‘.";
                    break;
                case 14:
                    explainationText.Text = "This equation can be used so that in ‘ m^ed ≡ m MOD n ‘it is only easy to find d if the factorisation of n is known.  Because it can be simplified to d = (k*Փ(n)+1)/e. Therefore d should be the private key.";
                    break;
                case 15:
                    explainationText.Text = "Let’s fill out our example, say the exponent (e) is a random number between 3 and 20 that would mean that  would mean that ‘d= (2*(Phi Secret) +1 ) / Exponent’. Press ‘Find’ to do this equation.";
                    break;
                case 16:
                    explainationText.Text = "We now have D, the private key. To send the data; first the bank or whoever created this key, sends the public portion of the key to anyone who wants to send them information, remember that the public key is the  two  prime numbers multiplied together and the exponent. ";
                    break;
                case 17:
                    explainationText.Text = "Let’s say that you are a person who wants to send a message to the bank without anyone knowing. Characters are stored in binary. The letter h for example would be 104. So if the sender wanted to send the message hello, it would convert into 104, 101, 108, 108, 111 the ASCII values. They could send this all as one number or as several messages. For this example we will send one letter with 'A' being 1 and 'A' being 26. Select the letter you want to send and press 'Convert'.";
                    break;
                case 18:
                    explainationText.Text = "To encrypt there message the customer takes the message they want to send (m) raise it to the exponent in the public key (e) and then MOD by the two  prime numbers multiplied together (n) which is also part of the public key. So you have m^e MOD n = The encrypted message. This is then sent to the bank. ";
                    break;
                case 19:
                    explainationText.Text = "However there is also an eavesdropper who has been listening in the whole time as so they know all the information that has been sent. Press ‘Encrypt’ to use the encryption formula on the letter you wanted to send and also fill in the information that the eavesdropper has access to.";
                    break;
                case 20:
                    explainationText.Text = "Now for the decryption, the bank uses their private key, the phi of the prime numbers multiplied together. She uses it in the equation encrypted message ^ Phi of primes ≡ Decrypted Message MOD 3127 or rather Decrypted = Encrypted ^ The modular multiplicative inverse MOD the two primes multiplied together. Since only the bank knows this private key the eavesdropper cannot de-cypher the message unless that can discover the prime factorisation of the two prime numbers a problem that takes an extremely long time for big numbers. Press ‘Decrypt’ to find the decrypted message. (The message will be turned into the appropriate letter).";
                    break;
                case 21:
                    explainationText.Text = "Hopefully this makes sense and if it doesn't, don't worry, it’s not the maths itself that's important it is the principals behind it. The idea of having a function that is easy to do as long as you have a private key and hard to do without. ";
                    break;
                case 22:
                    explainationText.Text = "The idea of a public key being useful for encrypting messages, but not decrypting them, and the idea that the bigger the numbers used the longer it would take to simply work out what the private key is. Press ‘Restart’ if you would like to go over the example again.";
                    break;
             
            }

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (textNumber != 22)
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
