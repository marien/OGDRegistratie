using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OGDRegistratieWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            var ds = new OGDRegistratieDataSet();
            (new OGDRegistratieDataSetTableAdapters.AdresTableAdapter()).Fill(ds.Adres);
            foreach (var item in ds.Adres)
            {
                if (!label1.Text.Equals(""))
                    label1.Text += "\r\n";
                label1.Text += item.Naam;
            }

            (new OGDRegistratieDataSetTableAdapters.ProjectTableAdapter()).Fill(ds.Project);
            foreach (var item in ds.Project)
            {
                if (!label1.Text.Equals(""))
                    label1.Text += "\r\n";
                label1.Text += item.Naam;
            }
        }
    }
}
