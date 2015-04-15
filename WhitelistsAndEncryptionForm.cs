using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Group_project
{
    public partial class WhitelistsAndEncryptionForm : Group_project.InteractionBase
    {
        int textNumber = 0;

        public WhitelistsAndEncryptionForm()
        {
            InitializeComponent();
        }

        private void checkInfoText()
        {
            switch (textNumber)
            {
                case 0:
                    explainationText.Text = "A whitelist is usually handled by the router and is a list of all the MAC addresses (A MAC address is a unique series of twelve hexadecimal characters that identify a device) that are allowed to use a router. So if a laptop for example wanted to connect to a router, the router would look at the laptops MAC address and see if it was on the list. If it was not, the router would simply refuse to let that device connect.";
                    break;
                case 1:
                    explainationText.Text = "Using a whitelist is a good idea because it is extra security that is cheap and does not slow down the network like other security options. However, if you for instance buy a new laptop you will have to add a new MAC address to the whitelist. This is fine on a small scale but for a universities student Wi-Fi for example it would be impractical due to the need to update so often.";
                    break;
                case 2:
                    explainationText.Text = "Adding a whitelist is different for different routers so if you want to set up a whitelist of your own you should be able to find it in the user manual. Encryption is a very important part of network security and it is an area which can easily be improved. There are 3 main protocols used to protect and encrypt data sent over a network. ";
                    break;
                case 3:
                    explainationText.Text = "WEP, WPA and WPA2. WEP is a rather old system of protection that uses a small number of bits to encrypt data, often only 128 bits or even as low as 64 in some instances. If possible you want to avoid WEP encryption as it has been shown to be easily hackable. ";
                    break;
                case 4:
                    explainationText.Text = "WPA is a vast improvement over WEP as it has more security features and a 256 bit encryption, far larger that most WEP networks, that being said vulnerabilities were still found and WPA is no longer considered secure. There are also 2 types of WPA, TKIP and AES. ";
                    break;
                case 5:
                    explainationText.Text = "AES is a more secure encryption protocol and it should be used when possible. WPA2 is an improvement over WPA that fixed several security flaws. It is the best security encryption of the 3 and should always be used over them if possible. It however is not flawless and a sustained attack by someone on the network could compromise the encryption, however this is not something that you should worry about.";
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
    }
}
