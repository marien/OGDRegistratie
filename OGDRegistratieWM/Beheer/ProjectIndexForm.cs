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
    public partial class ProjectIndexForm : Form
    {
        public ProjectIndexForm()
        {
            InitializeComponent();
        }

        private void frmProjectIndex_Load(object sender, EventArgs e)
        {

        }

        private void newMenuItemMenuItem_Click(object sender, EventArgs e)
        {
            projectBindingSource.AddNew();
            OGDRegistratieWM.ProjectEditViewDialog projectEditViewDialog = OGDRegistratieWM.ProjectEditViewDialog.Instance(this.projectBindingSource);
            projectEditViewDialog.ShowDialog();

        }

        private void projectDataGrid_Click(object sender, EventArgs e)
        {
            OGDRegistratieWM.ProjectSummaryViewDialog projectSummaryViewDialog = OGDRegistratieWM.ProjectSummaryViewDialog.Instance(this.projectBindingSource);
            projectSummaryViewDialog.ShowDialog();

        }
    }
}