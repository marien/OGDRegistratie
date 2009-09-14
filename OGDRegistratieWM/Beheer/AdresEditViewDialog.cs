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
    public partial class AdresEditViewDialog : Form
    {
        public AdresEditViewDialog()
        {
            InitializeComponent();
        }

        private void AdresEditViewDialog_Closing(object sender, CancelEventArgs e)
        {
            this.adresBindingSource.EndEdit();

        }
    }
}