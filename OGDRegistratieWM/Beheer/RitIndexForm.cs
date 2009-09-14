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
    public partial class RitIndexForm : Form
    {
        public RitIndexForm()
        {
            InitializeComponent();
        }

        private void frmRittenIndex_Load(object sender, EventArgs e)
        {
            if (OGDRegistratieDataSetUtil.DesignerUtil.IsRunTime())
            {
                this.ritTableAdapter.Fill(this.oGDRegistratieDataSet.Rit);
            }

        }

        private void newMenuItemMenuItem_Click(object sender, EventArgs e)
        {
            ritBindingSource.AddNew();
            OGDRegistratieWM.RitEditViewDialog ritEditViewDialog = OGDRegistratieWM.RitEditViewDialog.Instance(this.ritBindingSource);
            ritEditViewDialog.ShowDialog();

        }

        private void ritDataGrid_Click(object sender, EventArgs e)
        {
            OGDRegistratieWM.RitSummaryViewDialog ritSummaryViewDialog = OGDRegistratieWM.RitSummaryViewDialog.Instance(this.ritBindingSource);
            ritSummaryViewDialog.ShowDialog();

        }

        private void RitIndexForm_Closing(object sender, CancelEventArgs e)
        {
            if (this.oGDRegistratieDataSet.HasChanges())
            {
                this.ritTableAdapter.Update(this.oGDRegistratieDataSet);
            }
        }
    }
}