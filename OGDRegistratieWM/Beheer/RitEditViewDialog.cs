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
    public partial class RitEditViewDialog : Form
    {
        public RitEditViewDialog()
        {
            InitializeComponent();
        }

        private void RitEditViewDialog_Closing(object sender, CancelEventArgs e)
        {
            this.ritBindingSource.EndEdit();
        }

        private void RitEditViewDialog_Load(object sender, EventArgs e)
        {
            this.adresTableAdapter.Fill(this.oGDRegistratieDataSet.Adres);
            this.vervoermiddelTableAdapter.Fill(this.oGDRegistratieDataSet.Vervoermiddel);
        }
    }
}