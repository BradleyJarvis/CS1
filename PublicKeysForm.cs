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

            PhiPublicLabel.ForeColor = Color.Red;

            PhiPublicLabel.Text = Convert.ToString((Convert.ToInt32(FirstPrimeNumberLabel.Text) - 1) * (Convert.ToInt32(SecondPrimeNumberLabel.Text) - 1));


            PhiPrivateTextLabel.Visible = true;
            PhiPublicLabel.Visible = true;

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

            PhiPublicLabel.ForeColor = Color.Black;

            PhiPublicLabel.Text = "_";

            PhiPrivateTextLabel.Visible = false;
            PhiPublicLabel.Visible = false;

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

            PhiPublicLabel.ForeColor = Color.Black;

            DLabel.ForeColor = Color.Red;
            ExponentLabel.ForeColor = Color.Red;

            ExponentLabel.Text = Convert.ToString(Exponent);
            DLabel.Text = Convert.ToString((2 * Convert.ToInt32(PhiPublicLabel.Text) + 1) / Exponent);

            DTextLabel.Visible = true;
            DLabel.Visible = true;
            ExponentTextLabel.Visible = true;
            ExponentLabel.Visible = true;

            FindDButton.Visible = false;
            DTextBox.Visible = false;
            Back2Button.Visible = false;
        }

    }
}
