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
        int timeToGuess;
        bool lowerCaseFlag, upperCaseFlag, numberFlag, specialFlag;
        string inputPassword;
        int passLength;
        
        public PasswordStrengthForm()
        {
            InitializeComponent();
            resetFlags();
        }

        void checkPassword()
        {
            inputPassword = passInputBox.Text;
            resetFlags();
            passLength = inputPassword.Length;
            foreach (char character in inputPassword)
            {
                checkChar(character);
            }
            setBoxes();
        }

        void checkChar(char character)
        {
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
                return;
            }
            if (character != ' ')
            {
                specialFlag = true;
                return;
            }
        }

        void setBoxes()
        {//Checks all flags and checks boxes as needed
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
        
        void resetFlags()
        {//Function used to reset all flags to false and variables to a default value
            lowerCaseFlag = false;
            upperCaseFlag = false;
            numberFlag = false;
            specialFlag = false;
            passLength = 0;
        }

        private void passInputBox_TextChanged(object sender, EventArgs e)
        {
            checkPassword();
        }
    }
}
