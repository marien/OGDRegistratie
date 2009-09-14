namespace OGDRegistratieWM.Beheer
{
    partial class VervoermiddelIndexForm
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
            System.Windows.Forms.DataGridTextBoxColumn kentekenDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn actiefDataGridColumnStyleDataGridTextBoxColumn;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.newMenuItemMenuItem = new System.Windows.Forms.MenuItem();
            this.oGDRegistratieDataSet = new OGDRegistratieWM.OGDRegistratieDataSet();
            this.vervoermiddelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vervoermiddelTableAdapter = new OGDRegistratieWM.OGDRegistratieDataSetTableAdapters.VervoermiddelTableAdapter();
            this.vervoermiddelDataGrid = new System.Windows.Forms.DataGrid();
            this.vervoermiddelTableStyleDataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            naamDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            kentekenDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            actiefDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.oGDRegistratieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vervoermiddelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // naamDataGridColumnStyleDataGridTextBoxColumn
            // 
            naamDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            naamDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            naamDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Naam";
            naamDataGridColumnStyleDataGridTextBoxColumn.MappingName = "Naam";
            // 
            // kentekenDataGridColumnStyleDataGridTextBoxColumn
            // 
            kentekenDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            kentekenDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            kentekenDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Kenteken";
            kentekenDataGridColumnStyleDataGridTextBoxColumn.MappingName = "Kenteken";
            // 
            // actiefDataGridColumnStyleDataGridTextBoxColumn
            // 
            actiefDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            actiefDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            actiefDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Actief";
            actiefDataGridColumnStyleDataGridTextBoxColumn.MappingName = "Actief";
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
            // vervoermiddelBindingSource
            // 
            this.vervoermiddelBindingSource.DataMember = "Vervoermiddel";
            this.vervoermiddelBindingSource.DataSource = this.oGDRegistratieDataSet;
            // 
            // vervoermiddelTableAdapter
            // 
            this.vervoermiddelTableAdapter.ClearBeforeFill = true;
            // 
            // vervoermiddelDataGrid
            // 
            this.vervoermiddelDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.vervoermiddelDataGrid.DataSource = this.vervoermiddelBindingSource;
            this.vervoermiddelDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vervoermiddelDataGrid.Location = new System.Drawing.Point(0, 0);
            this.vervoermiddelDataGrid.Name = "vervoermiddelDataGrid";
            this.vervoermiddelDataGrid.Size = new System.Drawing.Size(240, 268);
            this.vervoermiddelDataGrid.TabIndex = 0;
            this.vervoermiddelDataGrid.TableStyles.Add(this.vervoermiddelTableStyleDataGridTableStyle);
            this.vervoermiddelDataGrid.Click += new System.EventHandler(this.vervoermiddelDataGrid_Click);
            // 
            // vervoermiddelTableStyleDataGridTableStyle
            // 
            this.vervoermiddelTableStyleDataGridTableStyle.GridColumnStyles.Add(naamDataGridColumnStyleDataGridTextBoxColumn);
            this.vervoermiddelTableStyleDataGridTableStyle.GridColumnStyles.Add(kentekenDataGridColumnStyleDataGridTextBoxColumn);
            this.vervoermiddelTableStyleDataGridTableStyle.GridColumnStyles.Add(actiefDataGridColumnStyleDataGridTextBoxColumn);
            this.vervoermiddelTableStyleDataGridTableStyle.MappingName = "Vervoermiddel";
            // 
            // VervoermiddelIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.vervoermiddelDataGrid);
            this.Menu = this.mainMenu1;
            this.Name = "VervoermiddelIndexForm";
            this.Text = "Vervoermiddelen";
            this.Load += new System.EventHandler(this.frmVervoermiddelIndex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oGDRegistratieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vervoermiddelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OGDRegistratieDataSet oGDRegistratieDataSet;
        private System.Windows.Forms.BindingSource vervoermiddelBindingSource;
        private OGDRegistratieWM.OGDRegistratieDataSetTableAdapters.VervoermiddelTableAdapter vervoermiddelTableAdapter;
        private System.Windows.Forms.DataGrid vervoermiddelDataGrid;
        private System.Windows.Forms.DataGridTableStyle vervoermiddelTableStyleDataGridTableStyle;
        private System.Windows.Forms.MenuItem newMenuItemMenuItem;
    }
}