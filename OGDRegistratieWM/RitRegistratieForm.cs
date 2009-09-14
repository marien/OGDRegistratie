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
    public partial class RitRegistratieForm : Form
    {
        public RitRegistratieForm()
        {
            InitializeComponent();
        }

        private void RitRegistratieForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oGDRegistratieDataSet.Vervoermiddel' table. You can move, or remove it, as needed.
            this.vervoermiddelTableAdapter.Fill(this.oGDRegistratieDataSet.Vervoermiddel);
            this.adresTableAdapter.Fill(this.oGDRegistratieDataSet.Adres);
            this.vervoermiddelTableAdapter.Fill(this.oGDRegistratieDataSet.Vervoermiddel);
        }

        private void mniSchrijf_Click(object sender, EventArgs e)
        {
            var rit = this.oGDRegistratieDataSet.Rit.NewRitRow();
            rit.IdVervoermiddel = (int)cmbVervoermiddel.SelectedValue;
            rit.StartIdAdres = (int) cmbStartAdres.SelectedValue;
            rit.StartTijd = dtStartTijd.Value;
            rit.StartStand = int.Parse(txtStartStand.Text);
            rit.EindIdAdres = (int) cmbEindAdres.SelectedValue;
            rit.EindTijd = dtEindTijd.Value;
            rit.EindStand = int.Parse(txtEindStand.Text);
            this.oGDRegistratieDataSet.Rit.AddRitRow(rit);
            this.oGDRegistratieDataSet.AcceptChanges();
        }
    }
}