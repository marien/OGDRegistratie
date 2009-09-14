namespace OGDRegistratieWM.Beheer
{
    partial class ProjectIndexForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridTextBoxColumn naamDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn nummerDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn actiefDataGridColumnStyleDataGridTextBoxColumn;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.newMenuItemMenuItem = new System.Windows.Forms.MenuItem();
            this.oGDRegistratieDataSet = new OGDRegistratieWM.OGDRegistratieDataSet();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectTableAdapter = new OGDRegistratieWM.OGDRegistratieDataSetTableAdapters.ProjectTableAdapter();
            this.projectDataGrid = new System.Windows.Forms.DataGrid();
            this.projectTableStyleDataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            naamDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            nummerDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            actiefDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.oGDRegistratieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // naamDataGridColumnStyleDataGridTextBoxColumn
            // 
            naamDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            naamDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            // 
            // nummerDataGridColumnStyleDataGridTextBoxColumn
            // 
            nummerDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            nummerDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            // 
            // actiefDataGridColumnStyleDataGridTextBoxColumn
            // 
            actiefDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            actiefDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.newMenuItemMenuItem);
            // 
            // newMenuItemMenuItem
            // 
            this.newMenuItemMenuItem.Text = "New";
            this.newMenuItemMenuItem.Click += new System.EventHandler(this.newMenuItemMenuItem_Click);
            // 
            // oGDRegistratieDataSet
            // 
            this.oGDRegistratieDataSet.DataSetName = "OGDRegistratieDataSet";
            this.oGDRegistratieDataSet.Prefix = "";
            this.oGDRegistratieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "Project";
            this.projectBindingSource.DataSource = this.oGDRegistratieDataSet;
            // 
            // projectTableAdapter
            // 
            this.projectTableAdapter.ClearBeforeFill = true;
            // 
            // projectDataGrid
            // 
            this.projectDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.projectDataGrid.DataSource = this.projectBindingSource;
            this.projectDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectDataGrid.Location = new System.Drawing.Point(0, 0);
            this.projectDataGrid.Name = "projectDataGrid";
            this.projectDataGrid.Size = new System.Drawing.Size(240, 268);
            this.projectDataGrid.TabIndex = 0;
            this.projectDataGrid.TableStyles.Add(this.projectTableStyleDataGridTableStyle);
            this.projectDataGrid.Click += new System.EventHandler(this.projectDataGrid_Click);
            // 
            // projectTableStyleDataGridTableStyle
            // 
            this.projectTableStyleDataGridTableStyle.GridColumnStyles.Add(naamDataGridColumnStyleDataGridTextBoxColumn);
            this.projectTableStyleDataGridTableStyle.GridColumnStyles.Add(nummerDataGridColumnStyleDataGridTextBoxColumn);
            this.projectTableStyleDataGridTableStyle.GridColumnStyles.Add(actiefDataGridColumnStyleDataGridTextBoxColumn);
            // 
            // ProjectIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.projectDataGrid);
            this.Menu = this.mainMenu1;
            this.Name = "ProjectIndexForm";
            this.Text = "Projecten";
            this.Load += new System.EventHandler(this.frmProjectIndex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oGDRegistratieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OGDRegistratieDataSet oGDRegistratieDataSet;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private OGDRegistratieWM.OGDRegistratieDataSetTableAdapters.ProjectTableAdapter projectTableAdapter;
        private System.Windows.Forms.DataGrid projectDataGrid;
        private System.Windows.Forms.DataGridTableStyle projectTableStyleDataGridTableStyle;
        private System.Windows.Forms.MenuItem newMenuItemMenuItem;

    }
}