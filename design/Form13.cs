using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace design
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            
        }


    }
}
