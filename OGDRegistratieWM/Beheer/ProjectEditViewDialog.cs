using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OGDRegistratieWM
{
    public partial class ProjectEditViewDialog : Form
    {
        public ProjectEditViewDialog()
        {
            InitializeComponent();
        }

        private void ProjectEditViewDialog_Closing(object sender, CancelEventArgs e)
        {
            this.projectBindingSource.EndEdit();

        }
    }
}