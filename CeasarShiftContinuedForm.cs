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
            if ((FirstCharracterShiftedTextBox.Text != "") && (Char.IsLetter(FirstCharracterShiftedTextBox.Text[0])))
            {               
                for (int i = 0; i < FirstNumericUpDown.Value; i++)
                {
                    if ((FirstCharracterShiftedTextBox.Text != "z") && (FirstCharracterShiftedTextBox.Text != "Z")) //If it is not the first character in the alphabet
                    {
                        char tempChar = FirstCharracterShiftedTextBox.Text[0];
                        tempChar++;
                        FirstCharracterShiftedTextBox.Text = Char.ToString(tempChar);
                    }
                    else //If it is a A or a.
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
            if ((SecondCharracterShiftedTextBox.Text != "") && (Char.IsLetter(SecondCharracterShiftedTextBox.Text[0])))
            {
                for (int i = 0; i < SecondNumericUpDown.Value; i++)
                {
                    if ((SecondCharracterShiftedTextBox.Text != "z") && (SecondCharracterShiftedTextBox.Text != "Z")) //If it is not the first character in the alphabet
                    {
                        char tempChar = SecondCharracterShiftedTextBox.Text[0];
                        tempChar++;
                        SecondCharracterShiftedTextBox.Text = Char.ToString(tempChar);
                    }
                    else //If it is a A or a.
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
            if ((ThirdCharracterShiftedTextBox.Text != "") && (Char.IsLetter(ThirdCharracterShiftedTextBox.Text[0])))
            {
                for (int i = 0; i < ThirdNumericUpDown.Value; i++)
                {
                    if ((ThirdCharracterShiftedTextBox.Text != "z") && (ThirdCharracterShiftedTextBox.Text != "Z")) //If it is not the first character in the alphabet
                    {
                        char tempChar = ThirdCharracterShiftedTextBox.Text[0];
                        tempChar++;
                        ThirdCharracterShiftedTextBox.Text = Char.ToString(tempChar);
                    }
                    else //If it is a A or a.
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
            if ((ForthCharracterShiftedTextBox.Text != "") && (Char.IsLetter(ForthCharracterShiftedTextBox.Text[0])))
            {
                for (int i = 0; i < ForthNumericUpDown.Value; i++)
                {
                    if ((ForthCharracterShiftedTextBox.Text != "z") && (ForthCharracterShiftedTextBox.Text != "Z")) //If it is not the first character in the alphabet
                    {
                        char tempChar = ForthCharracterShiftedTextBox.Text[0];
                        tempChar++;
                        ForthCharracterShiftedTextBox.Text = Char.ToString(tempChar);
                    }
                    else //If it is a A or a.
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
            if ((FifthCharracterShiftedTextBox.Text != "") && (Char.IsLetter(FifthCharracterShiftedTextBox.Text[0])))
            {
                for (int i = 0; i < FifthNumericUpDown.Value; i++)
                {
                    if ((FifthCharracterShiftedTextBox.Text != "z") && (FifthCharracterShiftedTextBox.Text != "Z")) //If it is not the first character in the alphabet
                    {
                        char tempChar = FifthCharracterShiftedTextBox.Text[0];
                        tempChar++;
                        FifthCharracterShiftedTextBox.Text = Char.ToString(tempChar);
                    }
                    else //If it is a A or a.
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
            if ((SixthCharracterShiftedTextBox.Text != "") && (Char.IsLetter(SixthCharracterShiftedTextBox.Text[0])))
            {
                for (int i = 0; i < SixthNumericUpDown.Value; i++)
                {
                    if ((SixthCharracterShiftedTextBox.Text != "z") && (SixthCharracterShiftedTextBox.Text != "Z")) //If it is not the first character in the alphabet
                    {
                        char tempChar = SixthCharracterShiftedTextBox.Text[0];
                        tempChar++;
                        SixthCharracterShiftedTextBox.Text = Char.ToString(tempChar);
                    }
                    else //If it is a A or a.
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
            if ((SeventhCharracterShiftedTextBox.Text != "") && (Char.IsLetter(SeventhCharracterShiftedTextBox.Text[0])))
            {
                for (int i = 0; i < SeventhNumericUpDown.Value; i++)
                {
                    if ((SeventhCharracterShiftedTextBox.Text != "z") && (SeventhCharracterShiftedTextBox.Text != "Z")) //If it is not the first character in the alphabet
                    {
                        char tempChar = SeventhCharracterShiftedTextBox.Text[0];
                        tempChar++;
                        SeventhCharracterShiftedTextBox.Text = Char.ToString(tempChar);
                    }
                    else //If it is a A or a.
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
            if ((EigthCharracterShiftedTextBox.Text != "") && (Char.IsLetter(EigthCharracterShiftedTextBox.Text[0])))
            {
                for (int i = 0; i < EigthNumericUpDown.Value; i++)
                {
                    if ((EigthCharracterShiftedTextBox.Text != "z") && (EigthCharracterShiftedTextBox.Text != "Z")) //If it is not the first character in the alphabet
                    {
                        char tempChar = EigthCharracterShiftedTextBox.Text[0];
                        tempChar++;
                        EigthCharracterShiftedTextBox.Text = Char.ToString(tempChar);
                    }
                    else //If it is a A or a.
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
            if ((NinethCharracterShiftedTextBox.Text != "") && (Char.IsLetter(NinethCharracterShiftedTextBox.Text[0])))
            {
                for (int i = 0; i < NinethNumericUpDown.Value; i++)
                {
                    if ((NinethCharracterShiftedTextBox.Text != "z") && (NinethCharracterShiftedTextBox.Text != "Z")) //If it is not the first character in the alphabet
                    {
                        char tempChar = NinethCharracterShiftedTextBox.Text[0];
                        tempChar++;
                        NinethCharracterShiftedTextBox.Text = Char.ToString(tempChar);
                    }
                    else //If it is a A or a.
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
            if ((TenthCharracterShiftedTextBox.Text != "") && (Char.IsLetter(TenthCharracterShiftedTextBox.Text[0])))
            {
                for (int i = 0; i < TenthNumericUpDown.Value; i++)
                {
                    if ((TenthCharracterShiftedTextBox.Text != "z") && (TenthCharracterShiftedTextBox.Text != "Z")) //If it is not the first character in the alphabet
                    {
                        char tempChar = TenthCharracterShiftedTextBox.Text[0];
                        tempChar++;
                        TenthCharracterShiftedTextBox.Text = Char.ToString(tempChar);
                    }
                    else //If it is a A or a.
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











    }
}
