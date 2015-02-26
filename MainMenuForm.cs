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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void buttonSection1Click(object sender, EventArgs e)
        {
            Section1 Section1 = new Section1();
            Section1.Show();
            this.Hide();
        }

        private void mainMenuClose(object sender, FormClosedEventArgs e)
        {//Ensures program exits correctly
            Environment.Exit(0);
        }

        private void exitProgram(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
