using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OGDRegistratieWM.Beheer;

namespace OGDRegistratieWM
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //label1.Text = "";
            //var ds = new OGDRegistratieDataSet();
            //(new OGDRegistratieDataSetTableAdapters.AdresTableAdapter()).Fill(ds.Adres);
            //foreach (var item in ds.Adres)
            //{
            //    if (!label1.Text.Equals(""))
            //        label1.Text += "\r\n";
            //    label1.Text += item.Naam;
            //}

            //(new OGDRegistratieDataSetTableAdapters.ProjectTableAdapter()).Fill(ds.Project);
            //foreach (var item in ds.Project)
            //{
            //    if (!label1.Text.Equals(""))
            //        label1.Text += "\r\n";
            //    label1.Text += item.Naam;
            //}
        }

        private void mniAdressenBeheer_Click(object sender, EventArgs e)
        {
            var adresIndexForm = new AdresIndexForm();
            adresIndexForm.ShowDialog();
            adresIndexForm.Dispose();
        }

        private void mniProjectenBeheer_Click(object sender, EventArgs e)
        {
            var projectIndexForm = new ProjectIndexForm();
            projectIndexForm.ShowDialog();
            projectIndexForm.Dispose();
        }

        private void mniRittenBeheer_Click(object sender, EventArgs e)
        {
            var ritIndexForm = new RitIndexForm();
            ritIndexForm.ShowDialog();
            ritIndexForm.Dispose();
        }

        private void mniVervoermiddelenBeheer_Click(object sender, EventArgs e)
        {
            var vervoermiddelIndexForm = new VervoermiddelIndexForm();
            vervoermiddelIndexForm.ShowDialog();
            vervoermiddelIndexForm.Dispose();
        }

        private void mniRitRegistratie_Click(object sender, EventArgs e)
        {
            var ritRegistratieForm = new RitRegistratieForm();
            ritRegistratieForm.ShowDialog();
            ritRegistratieForm.Dispose();
        }
    }
}