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
    public partial class VervoermiddelEditViewDialog : Form
    {
        public VervoermiddelEditViewDialog()
        {
            InitializeComponent();
        }

        private void VervoermiddelEditViewDialog_Closing(object sender, CancelEventArgs e)
        {
            this.vervoermiddelBindingSource.EndEdit();

        }
    }
}