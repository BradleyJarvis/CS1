using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_project
{
    public partial class TwoFactorAuthCode : Form
    {
        public TwoFactorAuthCode()
        {
            InitializeComponent();
        }

        private void hideAuthenticator(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
