using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Group_project
{
    public partial class SectionFormBase : Group_project.BaseForm
    {//This form is used as a template that catagory forms should inherit from, containing the elements that will be required
        public SectionFormBase()
        {
            InitializeComponent();
        }

        private void backToMain(object sender, EventArgs e)
        {//Closes this form, doing so will reopen the main menu due to BaseForm behaviour
            this.Close();
        }
    }
}
