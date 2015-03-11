using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Group_project
{
    public partial class CeasarShiftContinuedForm : Group_project.InteractionBase
    {
        public CeasarShiftContinuedForm()
        {
            InitializeComponent();
        }

        private void ShiftButton_Click(object sender, EventArgs e)
        {



            FirstCharracterShiftedTextBox.Text = FirstCharracterUnshiftedTextBox.Text;
            if ((FirstCharracterShiftedTextBox.Text != "") && (Char.IsLetter(FirstCharracterShiftedTextBox.Text[0])))  //If the text is a letter
            {               
                for (int i = 0; i < FirstNumericUpDown.Value; i++) //For each time it must be shifted
                {
                    if ((FirstCharracterShiftedTextBox.Text != "z") && (FirstCharracterShiftedTextBox.Text != "Z")) //If it is not the first character in the alphabet
                    {
                        char tempChar = FirstCharracterShiftedTextBox.Text[0]; //Make a copy of the unshifted character
                        tempChar++; //Increment the character
                        FirstCharracterShiftedTextBox.Text = Char.ToString(tempChar); //Overight the previous value
                    }
                    else //If it is a Z or z.
                    {
                        if (FirstCharracterShiftedTextBox.Text == "z") //Check what case it is in.
                        {
                            FirstCharracterShiftedTextBox.Text = "a"; //Set the new value of the char.
                        }
                        else //If it is uppercase.
                        {
                            FirstCharracterShiftedTextBox.Text = "A";
                        }
                    }
                }
            }

            SecondCharracterShiftedTextBox.Text = SecondCharracterUnshiftedTextBox.Text;
            if ((SecondCharracterShiftedTextBox.Text != "") && (Char.IsLetter(SecondCharracterShiftedTextBox.Text[0]))) //If the text is a letter
            {
                for (int i = 0; i < SecondNumericUpDown.Value; i++) //For each time it must be shifted
                {
                    if ((SecondCharracterShiftedTextBox.Text != "z") && (SecondCharracterShiftedTextBox.Text != "Z")) //If it is not the first character in the alphabet
                    {
                        char tempChar = SecondCharracterShiftedTextBox.Text[0];//Make a copy of the unshifted character
                        tempChar++;//Increment the character
                        SecondCharracterShiftedTextBox.Text = Char.ToString(tempChar);//Overight the previous value
                    }
                    else //If it is a Z or z.
                    {
                        if (SecondCharracterShiftedTextBox.Text == "z") //Check what case it is in.
                        {
                            SecondCharracterShiftedTextBox.Text = "a"; //Set the new value of the char.
                        }
                        else //If it is uppercase.
                        {
                            SecondCharracterShiftedTextBox.Text = "A";
                        }
                    }
                }
            }


            ThirdCharracterShiftedTextBox.Text = ThirdCharracterUnshiftedTextBox.Text;
            if ((ThirdCharracterShiftedTextBox.Text != "") && (Char.IsLetter(ThirdCharracterShiftedTextBox.Text[0]))) //If the text is a letter
            {
                for (int i = 0; i < ThirdNumericUpDown.Value; i++)//For each time it must be shifted
                {
                    if ((ThirdCharracterShiftedTextBox.Text != "z") && (ThirdCharracterShiftedTextBox.Text != "Z")) //If it is not the first character in the alphabet
                    {
                        char tempChar = ThirdCharracterShiftedTextBox.Text[0];//Make a copy of the unshifted character
                        tempChar++;//Increment the character
                        ThirdCharracterShiftedTextBox.Text = Char.ToString(tempChar);//Overight the previous value
                    }
                    else //If it is a Z or z.
                    {
                        if (ThirdCharracterShiftedTextBox.Text == "z") //Check what case it is in.
                        {
                            ThirdCharracterShiftedTextBox.Text = "a"; //Set the new value of the char.
                        }
                        else //If it is uppercase.
                        {
                            ThirdCharracterShiftedTextBox.Text = "A";
                        }
                    }
                }
            }

            ForthCharracterShiftedTextBox.Text = ForthCharracterUnshiftedTextBox.Text;
            if ((ForthCharracterShiftedTextBox.Text != "") && (Char.IsLetter(ForthCharracterShiftedTextBox.Text[0]))) //If the text is a letter
            {
                for (int i = 0; i < ForthNumericUpDown.Value; i++)//For each time it must be shifted
                {
                    if ((ForthCharracterShiftedTextBox.Text != "z") && (ForthCharracterShiftedTextBox.Text != "Z")) //If it is not the first character in the alphabet
                    {
                        char tempChar = ForthCharracterShiftedTextBox.Text[0];//Make a copy of the unshifted character
                        tempChar++;//Increment the character
                        ForthCharracterShiftedTextBox.Text = Char.ToString(tempChar);//Overight the previous value
                    }
                    else //If it is a Z or z.
                    {
                        if (ForthCharracterShiftedTextBox.Text == "z") //Check what case it is in.
                        {
                            ForthCharracterShiftedTextBox.Text = "a"; //Set the new value of the char.
                        }
                        else //If it is uppercase.
                        {
                            ForthCharracterShiftedTextBox.Text = "A";
                        }
                    }
                }
            }

            FifthCharracterShiftedTextBox.Text = FifthCharracterUnshiftedTextBox.Text;
            if ((FifthCharracterShiftedTextBox.Text != "") && (Char.IsLetter(FifthCharracterShiftedTextBox.Text[0]))) //If the text is a letter
            {
                for (int i = 0; i < FifthNumericUpDown.Value; i++)//For each time it must be shifted
                {
                    if ((FifthCharracterShiftedTextBox.Text != "z") && (FifthCharracterShiftedTextBox.Text != "Z")) //If it is not the first character in the alphabet
                    {
                        char tempChar = FifthCharracterShiftedTextBox.Text[0];//Make a copy of the unshifted character
                        tempChar++;//Increment the character
                        FifthCharracterShiftedTextBox.Text = Char.ToString(tempChar);//Overight the previous value
                    }
                    else //If it is a Z or z.
                    {
                        if (FifthCharracterShiftedTextBox.Text == "z") //Check what case it is in.
                        {
                            FifthCharracterShiftedTextBox.Text = "a"; //Set the new value of the char.
                        }
                        else //If it is uppercase.
                        {
                            FifthCharracterShiftedTextBox.Text = "A";
                        }
                    }
                }
            }

            SixthCharracterShiftedTextBox.Text = SixthCharracterUnshiftedTextBox.Text;
            if ((SixthCharracterShiftedTextBox.Text != "") && (Char.IsLetter(SixthCharracterShiftedTextBox.Text[0]))) //If the text is a letter
            {
                for (int i = 0; i < SixthNumericUpDown.Value; i++)//For each time it must be shifted
                {
                    if ((SixthCharracterShiftedTextBox.Text != "z") && (SixthCharracterShiftedTextBox.Text != "Z")) //If it is not the first character in the alphabet
                    {
                        char tempChar = SixthCharracterShiftedTextBox.Text[0];//Make a copy of the unshifted character
                        tempChar++;//Increment the character
                        SixthCharracterShiftedTextBox.Text = Char.ToString(tempChar);//Overight the previous value
                    }
                    else //If it is a Z or z..
                    {
                        if (SixthCharracterShiftedTextBox.Text == "z") //Check what case it is in.
                        {
                            SixthCharracterShiftedTextBox.Text = "a"; //Set the new value of the char.
                        }
                        else //If it is uppercase.
                        {
                            SixthCharracterShiftedTextBox.Text = "A";
                        }
                    }
                }
            }

            SeventhCharracterShiftedTextBox.Text = SeventhCharracterUnshiftedTextBox.Text;
            if ((SeventhCharracterShiftedTextBox.Text != "") && (Char.IsLetter(SeventhCharracterShiftedTextBox.Text[0]))) //If the text is a letter
            {
                for (int i = 0; i < SeventhNumericUpDown.Value; i++)//For each time it must be shifted
                {
                    if ((SeventhCharracterShiftedTextBox.Text != "z") && (SeventhCharracterShiftedTextBox.Text != "Z")) //If it is not the first character in the alphabet
                    {
                        char tempChar = SeventhCharracterShiftedTextBox.Text[0];//Make a copy of the unshifted character
                        tempChar++;//Increment the character
                        SeventhCharracterShiftedTextBox.Text = Char.ToString(tempChar);//Overight the previous value
                    }
                    else //If it is a Z or z.
                    {
                        if (SeventhCharracterShiftedTextBox.Text == "z") //Check what case it is in.
                        {
                            SeventhCharracterShiftedTextBox.Text = "a"; //Set the new value of the char.
                        }
                        else //If it is uppercase.
                        {
                            SeventhCharracterShiftedTextBox.Text = "A";
                        }
                    }
                }
            }

            EigthCharracterShiftedTextBox.Text = EigthCharracterUnshiftedTextBox.Text;
            if ((EigthCharracterShiftedTextBox.Text != "") && (Char.IsLetter(EigthCharracterShiftedTextBox.Text[0]))) //If the text is a letter
            {
                for (int i = 0; i < EigthNumericUpDown.Value; i++)//For each time it must be shifted
                {
                    if ((EigthCharracterShiftedTextBox.Text != "z") && (EigthCharracterShiftedTextBox.Text != "Z")) //If it is not the first character in the alphabet
                    {
                        char tempChar = EigthCharracterShiftedTextBox.Text[0];//Make a copy of the unshifted character
                        tempChar++;//Increment the character
                        EigthCharracterShiftedTextBox.Text = Char.ToString(tempChar);//Overight the previous value
                    }
                    else //If it is a Z or z.
                    {
                        if (EigthCharracterShiftedTextBox.Text == "z") //Check what case it is in.
                        {
                            EigthCharracterShiftedTextBox.Text = "a"; //Set the new value of the char.
                        }
                        else //If it is uppercase.
                        {
                            EigthCharracterShiftedTextBox.Text = "A";
                        }
                    }
                }
            }

            NinethCharracterShiftedTextBox.Text = NinethCharracterUnshiftedTextBox.Text;
            if ((NinethCharracterShiftedTextBox.Text != "") && (Char.IsLetter(NinethCharracterShiftedTextBox.Text[0]))) //If the text is a letter
            {
                for (int i = 0; i < NinethNumericUpDown.Value; i++)//For each time it must be shifted
                {
                    if ((NinethCharracterShiftedTextBox.Text != "z") && (NinethCharracterShiftedTextBox.Text != "Z")) //If it is not the first character in the alphabet
                    {
                        char tempChar = NinethCharracterShiftedTextBox.Text[0];//Make a copy of the unshifted character
                        tempChar++;//Increment the character
                        NinethCharracterShiftedTextBox.Text = Char.ToString(tempChar);//Overight the previous value
                    }
                    else //If it is a Z or z.
                    {
                        if (NinethCharracterShiftedTextBox.Text == "z") //Check what case it is in.
                        {
                            NinethCharracterShiftedTextBox.Text = "a"; //Set the new value of the char.
                        }
                        else //If it is uppercase.
                        {
                            NinethCharracterShiftedTextBox.Text = "A";
                        }
                    }
                }
            }

            TenthCharracterShiftedTextBox.Text = TenthCharracterUnshiftedTextBox.Text;
            if ((TenthCharracterShiftedTextBox.Text != "") && (Char.IsLetter(TenthCharracterShiftedTextBox.Text[0]))) //If the text is a letter
            {
                for (int i = 0; i < TenthNumericUpDown.Value; i++)//For each time it must be shifted
                {
                    if ((TenthCharracterShiftedTextBox.Text != "z") && (TenthCharracterShiftedTextBox.Text != "Z")) //If it is not the first character in the alphabet
                    {
                        char tempChar = TenthCharracterShiftedTextBox.Text[0];//Make a copy of the unshifted character
                        tempChar++;//Increment the character
                        TenthCharracterShiftedTextBox.Text = Char.ToString(tempChar);//Overight the previous value
                    }
                    else //If it is a Z or z.
                    {
                        if (TenthCharracterShiftedTextBox.Text == "z") //Check what case it is in.
                        {
                            TenthCharracterShiftedTextBox.Text = "a"; //Set the new value of the char.
                        }
                        else //If it is uppercase.
                        {
                            TenthCharracterShiftedTextBox.Text = "A";
                        }
                    }
                }
            }

        }

        private void Unshift_Click(object sender, EventArgs e)
        {





            FirstCharracterUnshiftedTextBox.Text = TenthCharracterShiftedTextBox.Text;
            if ((FirstCharracterUnshiftedTextBox.Text != "") && (Char.IsLetter(FirstCharracterUnshiftedTextBox.Text[0]))) //If the text is a letter
            {
                for (int i = 0; i < FirstNumericUpDown.Value; i++)//For each time it must be shifted
                {
                    if ((FirstCharracterUnshiftedTextBox.Text != "a") && (FirstCharracterUnshiftedTextBox.Text != "A")) //If it is not the first character in the alphabet
                    {
                        char tempChar = FirstCharracterUnshiftedTextBox.Text[0];//Make a copy of the unshifted character
                        tempChar--;//Decrement the character
                        FirstCharracterUnshiftedTextBox.Text = Char.ToString(tempChar);//Overight the previous value
                    }
                    else //If it is a A or a.
                    {
                        if (FirstCharracterUnshiftedTextBox.Text == "a") //Check what case it is in.
                        {
                            FirstCharracterUnshiftedTextBox.Text = "z"; //Set the new value of the char.
                        }
                        else //If it is uppercase.
                        {
                            FirstCharracterUnshiftedTextBox.Text = "Z";
                        }
                    }
                }

            }
                SecondCharracterUnshiftedTextBox.Text = SecondCharracterShiftedTextBox.Text;
            if ((SecondCharracterUnshiftedTextBox.Text != "") && (Char.IsLetter(SecondCharracterUnshiftedTextBox.Text[0]))) //If the text is a letter
            {
                for (int i = 0; i < TenthNumericUpDown.Value; i++)//For each time it must be shifted
                {
                    if ((SecondCharracterUnshiftedTextBox.Text != "a") && (SecondCharracterUnshiftedTextBox.Text != "A")) //If it is not the first character in the alphabet
                    {
                        char tempChar = SecondCharracterUnshiftedTextBox.Text[0];//Make a copy of the unshifted character
                        tempChar--;//Decrement the character
                        SecondCharracterUnshiftedTextBox.Text = Char.ToString(tempChar);//Overight the previous value
                    }
                    else //If it is a A or a.
                    {
                        if (SecondCharracterUnshiftedTextBox.Text == "a") //Check what case it is in.
                        {
                            SecondCharracterUnshiftedTextBox.Text = "z"; //Set the new value of the char.
                        }
                        else //If it is uppercase.
                        {
                            SecondCharracterUnshiftedTextBox.Text = "Z";
                        }
                    }
                }
            }

                ThirdCharracterUnshiftedTextBox.Text = ThirdCharracterShiftedTextBox.Text;
            if ((ThirdCharracterUnshiftedTextBox.Text != "") && (Char.IsLetter(ThirdCharracterUnshiftedTextBox.Text[0]))) //If the text is a letter
            {
                for (int i = 0; i < ThirdNumericUpDown.Value; i++)//For each time it must be shifted
                {
                    if ((ThirdCharracterUnshiftedTextBox.Text != "a") && (ThirdCharracterUnshiftedTextBox.Text != "A")) //If it is not the first character in the alphabet
                    {
                        char tempChar = ThirdCharracterUnshiftedTextBox.Text[0];//Make a copy of the unshifted character
                        tempChar--;//Decrement the character
                        ThirdCharracterUnshiftedTextBox.Text = Char.ToString(tempChar);//Overight the previous value
                    }
                    else //If it is a A or a.
                    {
                        if (ThirdCharracterUnshiftedTextBox.Text == "a") //Check what case it is in.
                        {
                            ThirdCharracterUnshiftedTextBox.Text = "z"; //Set the new value of the char.
                        }
                        else //If it is uppercase.
                        {
                            ThirdCharracterUnshiftedTextBox.Text = "Z";
                        }
                    }
                }

            }
                ForthCharracterUnshiftedTextBox.Text = ForthCharracterShiftedTextBox.Text;
            if ((ForthCharracterUnshiftedTextBox.Text != "") && (Char.IsLetter(ForthCharracterUnshiftedTextBox.Text[0]))) //If the text is a letter
            {
                for (int i = 0; i < ForthNumericUpDown.Value; i++)//For each time it must be shifted
                {
                    if ((ForthCharracterUnshiftedTextBox.Text != "a") && (ForthCharracterUnshiftedTextBox.Text != "A")) //If it is not the first character in the alphabet
                    {
                        char tempChar = ForthCharracterUnshiftedTextBox.Text[0];//Make a copy of the unshifted character
                        tempChar--;//Decrement the character
                        ForthCharracterUnshiftedTextBox.Text = Char.ToString(tempChar);//Overight the previous value
                    }
                    else //If it is a A or a.
                    {
                        if (ForthCharracterUnshiftedTextBox.Text == "a") //Check what case it is in.
                        {
                            ForthCharracterUnshiftedTextBox.Text = "z"; //Set the new value of the char.
                        }
                        else //If it is uppercase.
                        {
                            ForthCharracterUnshiftedTextBox.Text = "Z";
                        }
                    }
                }
            }

                FifthCharracterUnshiftedTextBox.Text = FifthCharracterShiftedTextBox.Text;
            if ((FifthCharracterUnshiftedTextBox.Text != "") && (Char.IsLetter(FifthCharracterUnshiftedTextBox.Text[0]))) //If the text is a letter
            {
                for (int i = 0; i < FifthNumericUpDown.Value; i++)//For each time it must be shifted
                {
                    if ((FifthCharracterUnshiftedTextBox.Text != "a") && (FifthCharracterUnshiftedTextBox.Text != "A")) //If it is not the first character in the alphabet
                    {
                        char tempChar = FifthCharracterUnshiftedTextBox.Text[0];//Make a copy of the unshifted character
                        tempChar--;//Decrement the character
                        FifthCharracterUnshiftedTextBox.Text = Char.ToString(tempChar);//Overight the previous value
                    }
                    else //If it is a A or a.
                    {
                        if (FifthCharracterUnshiftedTextBox.Text == "a") //Check what case it is in.
                        {
                            FifthCharracterUnshiftedTextBox.Text = "z"; //Set the new value of the char.
                        }
                        else //If it is uppercase.
                        {
                            FifthCharracterUnshiftedTextBox.Text = "Z";
                        }
                    }
                }
            }

                SixthCharracterUnshiftedTextBox.Text = SixthCharracterShiftedTextBox.Text;
            if ((SixthCharracterUnshiftedTextBox.Text != "") && (Char.IsLetter(SixthCharracterUnshiftedTextBox.Text[0]))) //If the text is a letter
            {
                for (int i = 0; i < SixthNumericUpDown.Value; i++)//For each time it must be shifted
                {
                    if ((SixthCharracterUnshiftedTextBox.Text != "a") && (SixthCharracterUnshiftedTextBox.Text != "A")) //If it is not the first character in the alphabet
                    {
                        char tempChar = SixthCharracterUnshiftedTextBox.Text[0];//Make a copy of the unshifted character
                        tempChar--;//Decrement the character
                        SixthCharracterUnshiftedTextBox.Text = Char.ToString(tempChar);//Overight the previous value
                    }
                    else //If it is a A or a.
                    {
                        if (SixthCharracterUnshiftedTextBox.Text == "a") //Check what case it is in.
                        {
                            SixthCharracterUnshiftedTextBox.Text = "z"; //Set the new value of the char.
                        }
                        else //If it is uppercase.
                        {
                            SixthCharracterUnshiftedTextBox.Text = "Z";
                        }
                    }
                }
            }

                SeventhCharracterUnshiftedTextBox.Text = SeventhCharracterShiftedTextBox.Text;
            if ((SeventhCharracterUnshiftedTextBox.Text != "") && (Char.IsLetter(SeventhCharracterUnshiftedTextBox.Text[0]))) //If the text is a letter
            {
                for (int i = 0; i < SeventhNumericUpDown.Value; i++)//For each time it must be shifted
                {
                    if ((SeventhCharracterUnshiftedTextBox.Text != "a") && (SeventhCharracterUnshiftedTextBox.Text != "A")) //If it is not the first character in the alphabet
                    {
                        char tempChar = SeventhCharracterUnshiftedTextBox.Text[0];//Make a copy of the unshifted character
                        tempChar--;//Decrement the character
                        SeventhCharracterUnshiftedTextBox.Text = Char.ToString(tempChar);//Overight the previous value
                    }
                    else //If it is a A or a.
                    {
                        if (SeventhCharracterUnshiftedTextBox.Text == "a") //Check what case it is in.
                        {
                            SeventhCharracterUnshiftedTextBox.Text = "z"; //Set the new value of the char.
                        }
                        else //If it is uppercase.
                        {
                            SeventhCharracterUnshiftedTextBox.Text = "Z";
                        }
                    }
                }
            }

                EigthCharracterUnshiftedTextBox.Text = EigthCharracterShiftedTextBox.Text;
            if ((EigthCharracterUnshiftedTextBox.Text != "") && (Char.IsLetter(EigthCharracterUnshiftedTextBox.Text[0]))) //If the text is a letter
            {
                for (int i = 0; i < EigthNumericUpDown.Value; i++)//For each time it must be shifted
                {
                    if ((EigthCharracterUnshiftedTextBox.Text != "a") && (EigthCharracterUnshiftedTextBox.Text != "A")) //If it is not the first character in the alphabet
                    {
                        char tempChar = EigthCharracterUnshiftedTextBox.Text[0];//Make a copy of the unshifted character
                        tempChar--;//Decrement the character
                        EigthCharracterUnshiftedTextBox.Text = Char.ToString(tempChar);//Overight the previous value
                    }
                    else //If it is a A or a.
                    {
                        if (EigthCharracterUnshiftedTextBox.Text == "a") //Check what case it is in.
                        {
                            EigthCharracterUnshiftedTextBox.Text = "z"; //Set the new value of the char.
                        }
                        else //If it is uppercase.
                        {
                            EigthCharracterUnshiftedTextBox.Text = "Z";
                        }
                    }
                }
            }

                NinethCharracterUnshiftedTextBox.Text =  NinethCharracterShiftedTextBox.Text;
            if (( NinethCharracterUnshiftedTextBox.Text != "") && (Char.IsLetter(NinethCharracterUnshiftedTextBox.Text[0]))) //If the text is a letter
            {
                for (int i = 0; i <  NinethNumericUpDown.Value; i++)//For each time it must be shifted
                {
                    if (( NinethCharracterUnshiftedTextBox.Text != "a") && ( NinethCharracterUnshiftedTextBox.Text != "A")) //If it is not the first character in the alphabet
                    {
                        char tempChar =  NinethCharracterUnshiftedTextBox.Text[0];//Make a copy of the unshifted character
                        tempChar--;//Decrement the character
                         NinethCharracterUnshiftedTextBox.Text = Char.ToString(tempChar);//Overight the previous value
                    }
                    else //If it is a A or a.
                    {
                        if ( NinethCharracterUnshiftedTextBox.Text == "a") //Check what case it is in.
                        {
                             NinethCharracterUnshiftedTextBox.Text = "z"; //Set the new value of the char.
                        }
                        else //If it is uppercase.
                        {
                             NinethCharracterUnshiftedTextBox.Text = "Z";
                        }
                    }
                }

            }

            TenthCharracterUnshiftedTextBox.Text = TenthCharracterShiftedTextBox.Text;
            if ((TenthCharracterUnshiftedTextBox.Text != "") && (Char.IsLetter(TenthCharracterUnshiftedTextBox.Text[0]))) //If the text is a letter
            {
                for (int i = 0; i < TenthNumericUpDown.Value; i++)//For each time it must be shifted
                {
                    if ((TenthCharracterUnshiftedTextBox.Text != "a") && (TenthCharracterUnshiftedTextBox.Text != "A")) //If it is not the first character in the alphabet
                    {
                        char tempChar = TenthCharracterUnshiftedTextBox.Text[0];//Make a copy of the unshifted character
                        tempChar--;//Decrement the character
                        TenthCharracterUnshiftedTextBox.Text = Char.ToString(tempChar);//Overight the previous value
                    }
                    else //If it is a A or a.
                    {
                        if (TenthCharracterUnshiftedTextBox.Text == "a") //Check what case it is in.
                        {
                            TenthCharracterUnshiftedTextBox.Text = "z"; //Set the new value of the char.
                        }
                        else //If it is uppercase.
                        {
                            TenthCharracterUnshiftedTextBox.Text = "Z";
                        }
                    }
                }
            }






        }











    }
}
            
