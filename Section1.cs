using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Group_project
{
    public partial class Section1 : Group_project.SectionFormBase
    {
        public Section1()
        {
            InitializeComponent();
        }

        private void openInteraction1(object sender, EventArgs e)
        {
            Interaction1 interaction = new Interaction1();
            interaction.Show();
        }
    }
}
