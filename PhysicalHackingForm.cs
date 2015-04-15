using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Group_project
{
    public partial class PhysicalHackingForm : Group_project.InteractionBase
    {
        int textNumber = 0;

        public PhysicalHackingForm()
        {
            InitializeComponent();
        }

        private void checkInfoText()
        {
            switch (textNumber)
            {
                case 0:
                    explainationText.Text = "Physical Hacking, is a term in Computer Security that refers to the ability to physically gain access to a computer system.";
                    break;
                case 1:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 16);
                    explainationText.Text = "For example if you were to leave your computer unattended in a public place, that opens it up for someone to physically hack it, potentially stealing important data from you. ";
                    break;
                case 2:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 16);
                    explainationText.Text = "In order to protect yourself from Physical Hacking, be sure to leave your computer or device in a secure location and never unattended. ";
                    break;
                case 3:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 16);
                    explainationText.Text = "Make sure to not write your login information down so as someone can easily discover it and most importantly be vigilant, if you suspect someone has gained unlawful access to your computer, report it.";
                    break;
            }

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (textNumber != 3)
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
