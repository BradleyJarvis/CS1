using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Group_project
{
    public partial class PasswordStrengthForm : Group_project.InteractionBase
    {
        double timeToGuess;
        bool lowerCaseFlag, upperCaseFlag, numberFlag, specialFlag1, specialFlag2;
        string inputPassword;
        int passLength, textNumber = 0;
        const uint guessRate = 4000000000; //  A constant used to hold the speed that guesses can be made, represented as guesses/second
        
        public PasswordStrengthForm()
        {
            InitializeComponent();
            resetFlags();
        }

        void checkPassword()
        {// This function is called whenever the input in the text box changes. It checks the entered text, calculates the time and updates the display as needed
            inputPassword = passInputBox.Text;
            resetFlags();
            passLength = inputPassword.Length;
            foreach (char character in inputPassword)
            {
                checkChar(character);
            }
            setBoxes();
            timeToGuess = calculateTime();
            timeTakenLabel.Text = "YOUR PASSWORD WOULD TAKE " + findTime(timeToGuess) + " TO GUESS";
            this.Refresh();
        }
        void resetFlags()
        {// Function used to reset all flags to false and variables to a default value
            lowerCaseFlag = false;
            upperCaseFlag = false;
            numberFlag = false;
            specialFlag1 = false;
            specialFlag2 = false;
            passLength = 0;
        }        
        void checkChar(char character)
        {// A function that will check a character and set flags to indicate what it is
            if (char.IsLetter(character) == true)
            {
                if (char.IsLower(character) == true)
                {
                    lowerCaseFlag = true;
                }
                else
                    upperCaseFlag = true;
                return;// Char is letter, can stop checking
            }
            if (char.IsNumber(character) == true)
            {
                numberFlag = true;
                return;// Char is number, can stop checking
            }
            // Arrays holding the special characters that will be recognised, set 1 is chars on top row, set 2 is all others
            char[] special1 = new char[] {'!','"','£','$','%','^','&','*','(',')','_','-','=','+'};
            char[] special2 = new char[] { '[', '{', ']', '}', ';', ':', '\'', '@', '#', '~', '/', '?', '.', '>', ',', '<', '\\', '|' , ' '};
            
            if (special1.Contains(character) == true)
            {
                specialFlag1 = true;
                return;
            }

            if (special2.Contains(character) == true)
            {
                specialFlag2 = true;
                return;
            }
        }
        void setBoxes()
        {// Checks all flags and checks boxes on UI as needed
            if (upperCaseFlag == true)
                imgUpperCase.Image = Properties.Resources.greenTick;
            else imgUpperCase.Image = Properties.Resources.redCross;

            if (lowerCaseFlag == true)
                imgLowerCase.Image = Properties.Resources.greenTick;
            else imgLowerCase.Image = Properties.Resources.redCross;

            if (numberFlag == true)
                imgNumberPresent.Image = Properties.Resources.greenTick;
            else imgNumberPresent.Image = Properties.Resources.redCross;

            if (specialFlag1 == true || specialFlag2 == true)
                imgSpecialChar.Image = Properties.Resources.greenTick;
            else imgSpecialChar.Image = Properties.Resources.redCross;

            if (upperCaseFlag == true && lowerCaseFlag == true && numberFlag == true && (specialFlag1 == true || specialFlag2 == true))
                imgPadlock.Visible = true;
            else imgPadlock.Visible = false;

            this.Refresh();
        }
        double calculateTime()
        {// This function is used to calculate and return the time taken to crack the password, represented as the number of seconds needed to guess it
            int chars = 0;// The sets of characters included in the password, lower and upper case letters as well as numbers and special characters are included

            if (lowerCaseFlag == true)
                chars += 26;
            if (upperCaseFlag == true)
                chars += 26;
            if (numberFlag == true)
                chars += 10;
            if (specialFlag1 == true)
                chars += 14;
            if (specialFlag2 == true)
                chars += 19;

            double combos = Math.Pow(chars, passLength);// Calculate the number of possible combinations available, found using the set of characters possible and the number of characters in the password
            return combos/guessRate;
        }
        string findTime(double secs)
        {// This function takes a number of seconds and returns a string converting the time into the largest unit e.g. 150 seconds would be returned as 2 minutes
            if (secs < 1)
                return "LESS THAN ONE SECOND";
            if (secs > 31536000000000000)
                return "OVER ONE BILLION YEARS";

            long time = Convert.ToInt64(Math.Floor(secs)); ;// A variable used to hold the time required, here set in seconds rounded to a whole number. long used to ensure number can be stored, smaller types can't hold maximum possible value
            //time = seconds
            if (time < 60)
            {
                if (time == 1)
                    return "1 SECOND";
                else
                {
                    return time + " SECONDS";
                }
            }
            time /= 60;
            //time = minutes
            if (time < 60)
            {
                if (time == 1)
                    return "1 MINUTE";
                else
                    return time + " MINUTES";
            }
            time /= 60;
            //time = hours
            if (time < 24)
            {
                if (time == 1)
                    return "1 HOUR";
                else
                    return time + " HOUR";
            }

            time /= 24;
            //time = days
            if (time < 365)
            {
                if (time == 1)
                    return "1 DAY";
                else
                    return time + " DAYS";
            }

            time /= 365;
            //time = years
            if (time < 1000)
            {
                if (time == 1)
                    return "1 YEAR";
                else
                    return time + " YEARS";
            }

            time /= 1000;
            //time = 1000 years
            if (time < 1000)
                return time + " THOUSAND YEARS";

            time /= 1000;
            //time = million years
            return time + " MILLION YEARS";
        }
        

        private void checkInfoText()
        {
            switch (textNumber)
            {
                case 0:
                    explainationText.Text = "A simple way of accessing an account is to use brute force guessing to try every possible combination of characters until the correct password is found.";
                    break;
                case 1:
                    explainationText.Text = "If a password is short and only has a few characters it will be guessed quickly by this method.";
                    break;
                case 2:
                    explainationText.Text = "A long password with a mixture of different character types however will take much longer to guess, effectively becoming immune to this type of hacking.";
                    break;
                case 3:
                    explainationText.Text = "Below is a tool to check to see approximately how long it would take to guess a password based on its length and the types of characters used.";
                    break;
                case 4:
                    explainationText.Text = "This is only a rough guide, based on a computer able to make 4 billion attempts per second.";
                    break;
                case 5:
                    explainationText.Text = "The checkboxes indicate what type of characters you have included in the password that has been entered.";
                    break;
            }

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

        private void passInputBox_TextChanged(object sender, EventArgs e)
        {
            checkPassword();
        }



    }
}
