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
    public partial class InteractionBase : Form
    {
        public InteractionBase()
        {
            InitializeComponent();
        }

        private void returnToMenu(object sender, FormClosedEventArgs e)
        {
            MainMenuForm menuForm = new MainMenuForm();
            menuForm.Show();
        }

        private void exitProgram(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
