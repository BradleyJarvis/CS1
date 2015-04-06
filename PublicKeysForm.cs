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

            FirstPrimeNumberLabel.ForeColor = Color.Red;
            SecondPrimeNumberLabel.ForeColor = Color.Red;
            FirstPrimeNumberTimesSecondPrimeNumberLabel.ForeColor = Color.Red;

            FirstPrimeNumberLabel.Text = "71";
            SecondPrimeNumberLabel.Text = "59";
            FirstPrimeNumberTimesSecondPrimeNumberLabel.Text = Convert.ToString(71 * 59);

            

         }

        


    }
}
