using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Group_project
{
    public partial class PasswordStrengthForm : Group_project.InteractionBase
    {
        double timeToGuess;
        bool lowerCaseFlag, upperCaseFlag, numberFlag, specialFlag;
        string inputPassword;
        int passLength;
        
        public PasswordStrengthForm()
        {
            InitializeComponent();
            resetFlags();
        }

        void checkPassword()
        {//This function is called whenever the input in the text box changes. It checks the entered text, calculates the time and updates the display as needed
            inputPassword = passInputBox.Text;
            resetFlags();
            passLength = inputPassword.Length;
            foreach (char character in inputPassword)
            {
                checkChar(character);
            }
            setBoxes();
            timeToGuess = calculateTime();
            timeTakenLabel.Text = "Your password would take " + findTime(timeToGuess) + " to guess";
            setBar();
        }
        void resetFlags()
        {//Function used to reset all flags to false and variables to a default value
            lowerCaseFlag = false;
            upperCaseFlag = false;
            numberFlag = false;
            specialFlag = false;
            passLength = 0;
        }        
        void checkChar(char character)
        {//A function that will check a character and set flags to indicate what it is
            if (char.IsLetter(character) == true)
            {
                if (char.IsLower(character) == true)
                {
                    lowerCaseFlag = true;
                }
                else
                    upperCaseFlag = true;
                return;//Char is letter, can stop checking
            }
            if (char.IsNumber(character) == true)
            {
                numberFlag = true;
                return;//Char is number, can stop checking
            }

            specialFlag = true;//Char must be a special character
            return;
        }
        void setBoxes()
        {//Checks all flags and checks boxes on UI as needed
            if (upperCaseFlag == true)
                upperCaseBox.Checked = true;
            else upperCaseBox.Checked = false;

            if (lowerCaseFlag == true)
                lowerCaseBox.Checked = true;
            else lowerCaseBox.Checked = false;

            if (numberFlag == true)
                numberBox.Checked = true;
            else numberBox.Checked = false;

            if (specialFlag == true)
                specialBox.Checked = true;
            else specialBox.Checked = false;
        }
        double calculateTime()
        {//This function is used to calculate and return the time taken to crack the password, represented as the number of seconds needed to guess it
            int chars = 0;//The sets of characters included in the password, lower and upper case letters as well as numbers are included
            const uint guessRate = 4000000000; // A constant used to hold the speed that guesses can be made, represented as guesses/second

            if (lowerCaseFlag == true)
                chars += 26;
            if (upperCaseFlag == true)
                chars += 26;
            if (numberFlag == true)
                chars += 10;
            if (specialFlag == true)
                chars += 20;

            double combos = Math.Pow(chars, passLength);//Calculate the number of possible combinations available, found using the set of characters possible and the number of characters
            return combos/guessRate;
        }
        string findTime(double secs)
        {//This function takes a number of seconds and returns a string converting the time into the largest unit e.g. 150 seconds would be returned as 2 minutes
            if (secs < 1)
                return "less than one second";
            if (secs > 31536000000)
                return "over 1000 years";

            long time = Convert.ToInt64(Math.Floor(secs)); ;// A variable used to hold the time required, here set in seconds rounded to a whole number. long used to ensure number can be stored, smaller types can't hold maximum possible value
            //time = seconds
            if (time < 60)
            {
                if (time == 1)
                    return "1 second";
                else
                {
                    return time + " seconds";
                }
            }
            time /= 60;
            //time = minutes
            if (time < 60)
            {
                if (time == 1)
                    return "1 minute";
                else
                    return time + " minutes";
            }
            time /= 60;
            //time = hours
            if (time < 24)
            {
                if (time == 1)
                    return "1 hour";
                else
                    return time + " hours";
            }

            time /= 24;
            //time = days
            if (time < 365)
            {
                if (time == 1)
                    return "1 day";
                else
                    return time + " days";
            }

            time /= 365;
            //time = years
            if (time == 1)
                return "1 year";
            else
                return time + " years";
        }
        void setBar()
        {//Sets the displayed bar to be filled to show the time required to crack password, bar maxes out at 20 years

           //This section needs making still

        }
        private void passInputBox_TextChanged(object sender, EventArgs e)
        {
            checkPassword();
        }
    }
}
