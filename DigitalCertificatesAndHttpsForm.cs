using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Group_project
{
    public partial class DigitalCertificatesAndHttpsForm : Group_project.InteractionBase
    {
        int textNumber = 0;

        public DigitalCertificatesAndHttpsForm()
        {
            InitializeComponent();
        }
        private void checkInfoText()
        {
            switch (textNumber)
            {
                case 0:
                    explainationText.Text = "HTTPS is a protocol that can be used to securely transfer data over a network. It works by using the SSL encryption technique combined with the HTTP data transfer protocol to encrypt all data sent.";
                    break;
                case 1:
                    explainationText.Text = "It is commonly used as a way of securely transferring sensitive information over the internet, such as emails and financial information.";
                    break;
                case 2:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 17);
                    explainationText.Text = "There are also many websites that use it simply to improve privacy of people visiting the website. Because all information is encrypted, including the URL accessed, an eavesdropper wouldn't be able to tell what web page the user was visiting.";
                    break;
                case 3:
                    explainationText.Text = "Another benefit of using HTTPS is that it lets users be sure they are connecting to the service they are intending to, not an imposter. This is because of the use of authentication certificates.";
                    break;
                case 4:
                    explainationText.Text = "These are provided by an independent certification authority and these allow data transfers to be secured (using public key cryptography) as well as verifying the identity of the website.";
                    break;
                case 5:
                    explainationText.Text = "If the provided certificate doesn't match with the website being accessed most internet browsers will show a warning message.";
                    break;
                case 6:
                    explainationText.Text = "Users can also manually check the details of the certificates provided to get more information, as shown on the right (demonstrated using Internet Explorer, Firefox and Google Chrome visiting paypal.com)";
                    break;
            }

            this.Refresh();
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

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (textNumber != 6)
            {
                textNumber++;
                checkInfoText();
                this.Refresh();
            }
        }

        private void DigitalCertificatesAndHttpsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
