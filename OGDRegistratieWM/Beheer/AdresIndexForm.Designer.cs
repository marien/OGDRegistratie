namespace OGDRegistratieWM.Beheer
{
    partial class AdresIndexForm
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
            System.Windows.Forms.DataGridTextBoxColumn idProjectDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn straatDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn huisnummerDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn postcodeDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn plaatsDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn actiefDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn naamDataGridColumnStyleDataGridTextBoxColumn;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.newMenuItemMenuItem = new System.Windows.Forms.MenuItem();
            this.oGDRegistratieDataSet = new OGDRegistratieWM.OGDRegistratieDataSet();
            this.adresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adresTableAdapter = new OGDRegistratieWM.OGDRegistratieDataSetTableAdapters.AdresTableAdapter();
            this.adresDataGrid = new System.Windows.Forms.DataGrid();
            this.adresTableStyleDataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            this.startAdresRitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ritTableAdapter = new OGDRegistratieWM.OGDRegistratieDataSetTableAdapters.RitTableAdapter();
            idProjectDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            straatDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            huisnummerDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            postcodeDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            plaatsDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            actiefDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            naamDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.oGDRegistratieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startAdresRitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idProjectDataGridColumnStyleDataGridTextBoxColumn
            // 
            idProjectDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            idProjectDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            idProjectDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "IdProject";
            idProjectDataGridColumnStyleDataGridTextBoxColumn.MappingName = "IdProject";
            // 
            // straatDataGridColumnStyleDataGridTextBoxColumn
            // 
            straatDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            straatDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            straatDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Straat";
            straatDataGridColumnStyleDataGridTextBoxColumn.MappingName = "Straat";
            // 
            // huisnummerDataGridColumnStyleDataGridTextBoxColumn
            // 
            huisnummerDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            huisnummerDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            huisnummerDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Huisnummer";
            huisnummerDataGridColumnStyleDataGridTextBoxColumn.MappingName = "Huisnummer";
            // 
            // postcodeDataGridColumnStyleDataGridTextBoxColumn
            // 
            postcodeDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            postcodeDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            postcodeDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Postcode";
            postcodeDataGridColumnStyleDataGridTextBoxColumn.MappingName = "Postcode";
            // 
            // plaatsDataGridColumnStyleDataGridTextBoxColumn
            // 
            plaatsDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            plaatsDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            plaatsDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Plaats";
            plaatsDataGridColumnStyleDataGridTextBoxColumn.MappingName = "Plaats";
            // 
            // actiefDataGridColumnStyleDataGridTextBoxColumn
            // 
            actiefDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            actiefDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            actiefDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Actief";
            actiefDataGridColumnStyleDataGridTextBoxColumn.MappingName = "Actief";
            // 
            // naamDataGridColumnStyleDataGridTextBoxColumn
            // 
            naamDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            naamDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            naamDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Naam";
            naamDataGridColumnStyleDataGridTextBoxColumn.MappingName = "Naam";
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
            // adresBindingSource
            // 
            this.adresBindingSource.DataMember = "Adres";
            this.adresBindingSource.DataSource = this.oGDRegistratieDataSet;
            // 
            // adresTableAdapter
            // 
            this.adresTableAdapter.ClearBeforeFill = true;
            // 
            // adresDataGrid
            // 
            this.adresDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.adresDataGrid.DataSource = this.adresBindingSource;
            this.adresDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adresDataGrid.Location = new System.Drawing.Point(0, 0);
            this.adresDataGrid.Name = "adresDataGrid";
            this.adresDataGrid.Size = new System.Drawing.Size(240, 268);
            this.adresDataGrid.TabIndex = 0;
            this.adresDataGrid.TableStyles.Add(this.adresTableStyleDataGridTableStyle);
            this.adresDataGrid.CurrentCellChanged += new System.EventHandler(this.adresDataGrid_CurrentCellChanged);
            this.adresDataGrid.Click += new System.EventHandler(this.adresDataGrid_Click);
            // 
            // adresTableStyleDataGridTableStyle
            // 
            this.adresTableStyleDataGridTableStyle.GridColumnStyles.Add(naamDataGridColumnStyleDataGridTextBoxColumn);
            this.adresTableStyleDataGridTableStyle.GridColumnStyles.Add(idProjectDataGridColumnStyleDataGridTextBoxColumn);
            this.adresTableStyleDataGridTableStyle.GridColumnStyles.Add(straatDataGridColumnStyleDataGridTextBoxColumn);
            this.adresTableStyleDataGridTableStyle.GridColumnStyles.Add(huisnummerDataGridColumnStyleDataGridTextBoxColumn);
            this.adresTableStyleDataGridTableStyle.GridColumnStyles.Add(postcodeDataGridColumnStyleDataGridTextBoxColumn);
            this.adresTableStyleDataGridTableStyle.GridColumnStyles.Add(plaatsDataGridColumnStyleDataGridTextBoxColumn);
            this.adresTableStyleDataGridTableStyle.GridColumnStyles.Add(actiefDataGridColumnStyleDataGridTextBoxColumn);
            this.adresTableStyleDataGridTableStyle.MappingName = "Adres";
            // 
            // startAdresRitBindingSource
            // 
            this.startAdresRitBindingSource.DataMember = "StartAdresRit";
            this.startAdresRitBindingSource.DataSource = this.adresBindingSource;
            // 
            // ritTableAdapter
            // 
            this.ritTableAdapter.ClearBeforeFill = true;
            // 
            // AdresIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.adresDataGrid);
            this.Menu = this.mainMenu1;
            this.Name = "AdresIndexForm";
            this.Text = "Adressen";
            this.Load += new System.EventHandler(this.frmAdresIndex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oGDRegistratieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startAdresRitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OGDRegistratieDataSet oGDRegistratieDataSet;
        private System.Windows.Forms.BindingSource adresBindingSource;
        private OGDRegistratieWM.OGDRegistratieDataSetTableAdapters.AdresTableAdapter adresTableAdapter;
        private System.Windows.Forms.DataGrid adresDataGrid;
        private System.Windows.Forms.DataGridTableStyle adresTableStyleDataGridTableStyle;
        private System.Windows.Forms.MenuItem newMenuItemMenuItem;
        private System.Windows.Forms.BindingSource startAdresRitBindingSource;
        private OGDRegistratieWM.OGDRegistratieDataSetTableAdapters.RitTableAdapter ritTableAdapter;
    }
}