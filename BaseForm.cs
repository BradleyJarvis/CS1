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
    public partial class BaseForm : Form
    {//This form contains anything that all forms will use, such as the menu strip and returning to main menu when closed
        public BaseForm()
        {
            InitializeComponent();
        }

        private void formClose(object sender, FormClosedEventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
        }

        private void exitProgram(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
