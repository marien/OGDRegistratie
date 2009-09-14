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
    public partial class AdresIndexForm : Form
    {
        public AdresIndexForm()
        {
            InitializeComponent();
        }

        private void frmAdresIndex_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oGDRegistratieDataSet.Rit' table. You can move, or remove it, as needed.
            this.ritTableAdapter.Fill(this.oGDRegistratieDataSet.Rit);
            if (OGDRegistratieDataSetUtil.DesignerUtil.IsRunTime())
            {
                // TODO: Delete this line of code to remove the default AutoFill for 'oGDRegistratieDataSet.Adres'.
                this.adresTableAdapter.Fill(this.oGDRegistratieDataSet.Adres);
            }

        }

        private void newMenuItemMenuItem_Click(object sender, EventArgs e)
        {
            adresBindingSource.AddNew();
            OGDRegistratieWM.AdresEditViewDialog adresEditViewDialog = OGDRegistratieWM.AdresEditViewDialog.Instance(this.adresBindingSource);
            adresEditViewDialog.ShowDialog();

        }

        private void adresDataGrid_Click(object sender, EventArgs e)
        {
            OGDRegistratieWM.AdresSummaryViewDialog adresSummaryViewDialog = OGDRegistratieWM.AdresSummaryViewDialog.Instance(this.adresBindingSource);
            adresSummaryViewDialog.ShowDialog();

        }

        private void adresDataGrid_CurrentCellChanged(object sender, EventArgs e)
        {

        }
    }
}