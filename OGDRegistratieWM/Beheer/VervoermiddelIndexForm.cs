using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OGDRegistratieWM.Beheer
{
    public partial class VervoermiddelIndexForm : Form
    {
        public VervoermiddelIndexForm()
        {
            InitializeComponent();
        }

        private void frmVervoermiddelIndex_Load(object sender, EventArgs e)
        {
            if (OGDRegistratieDataSetUtil.DesignerUtil.IsRunTime())
            {
                // TODO: Delete this line of code to remove the default AutoFill for 'oGDRegistratieDataSet.Vervoermiddel'.
                this.vervoermiddelTableAdapter.Fill(this.oGDRegistratieDataSet.Vervoermiddel);
            }

        }

        private void newMenuItemMenuItem_Click(object sender, EventArgs e)
        {
            vervoermiddelBindingSource.AddNew();
            OGDRegistratieWM.VervoermiddelEditViewDialog vervoermiddelEditViewDialog = OGDRegistratieWM.VervoermiddelEditViewDialog.Instance(this.vervoermiddelBindingSource);
            vervoermiddelEditViewDialog.ShowDialog();

        }

        private void vervoermiddelDataGrid_Click(object sender, EventArgs e)
        {
            OGDRegistratieWM.VervoermiddelSummaryViewDialog vervoermiddelSummaryViewDialog = OGDRegistratieWM.VervoermiddelSummaryViewDialog.Instance(this.vervoermiddelBindingSource);
            vervoermiddelSummaryViewDialog.ShowDialog();

        }
    }
}