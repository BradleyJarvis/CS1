using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Group_project
{
    public partial class NetworkFirewallsForm : Group_project.InteractionBase
    {
        int textNumber = 0;
        public NetworkFirewallsForm()
        {
            InitializeComponent();
        }

        private void checkInfoText()
        {
            switch (textNumber)
            {
                case 0:
                    explainationText.Text = "A firewall system is a form of network security put in place to monitor traffic flow, both being received and sent through the network.";
                    break;
                case 1:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 16);
                    explainationText.Text = "A firewall will abide by a specific rule set to the network in which it is being implemented. It effectively constructs a barrier between networks; preventing any unauthorized access. ";
                    break;
                case 2:
                    explainationText.Font = new Font(explainationText.Font.FontFamily, 16);
                    explainationText.Text = "With these features, it may be confusing as to whether a firewall is either software or a hardware appliance. The answer to that is simple; it can be both! Despite this, the most common Firewall configuration will consist of both.";
                    break;
            }

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (textNumber != 2)
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
