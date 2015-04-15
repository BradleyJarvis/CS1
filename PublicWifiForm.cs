using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Group_project
{
    public partial class PublicWifiForm : Group_project.InteractionBase
    {
        int textNumber = 0;

        public PublicWifiForm()
        {
            InitializeComponent();
        }

        private void checkInfoText()
        {
            switch (textNumber)
            {
                case 0:
                    explainationText.Text = "Public Wi-fi is available everywhere now day. You could easily find or connect to public wifi in the coffee shops, restaurants, even convenience shops. ";
                    break;
                case 1:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 15);
                    explainationText.Text = "Although public wi-fi is extremely convenient when you want to access Internet outside of your property, but the security could be an issue. ";
                    break;
                case 2:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 15);
                    explainationText.Text = "The open nature of public wi-fi network allows for snooping, the network could be full of compromised machines, or most worrying, the public wi-fi hotspot itself could be malicious. ";
                    break;
                case 3:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 15);
                    explainationText.Text = "Sometime, it could be tricky to tell whether if it is a legitimate Wi-Fi network or it is a set-up by an attacker in an attempt to trick people into connecting.";
                    break;
                case 4:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 16);
                    explainationText.Text = "There are plenty of ways that you could do to secure yourself while using public Wi-Fi:";
                    break;
                case 5:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 15);
                    explainationText.Text = "- Disable the file sharing setting in your wireless device so your file could not be shared with unknown people while connecting to public Wi-Fi.";
                    break;
                case 6:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 16);
                    explainationText.Text = "- Make sure that the websites you visiting start with HTTPS.";
                    break;
                case 7:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 16);
                    explainationText.Text = "- Make sure your antivirus and firewall are turned on before connect to public Wi-Fi.";
                    break;
                case 8:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 16);
                    explainationText.Text = "- Try to avoid to use unsecured or suspicious public Wi-Fi";
                    break;
            }

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (textNumber != 8)
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
