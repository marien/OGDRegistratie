namespace OGDRegistratieWM.Beheer
{
    partial class RitIndexForm
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
            System.Windows.Forms.DataGridTextBoxColumn startTijdDataGridColumnStyleDataGridTextBoxColumn1;
            System.Windows.Forms.DataGridTextBoxColumn startIdAdresDataGridColumnStyleDataGridTextBoxColumn1;
            System.Windows.Forms.DataGridTextBoxColumn startStandDataGridColumnStyleDataGridTextBoxColumn1;
            System.Windows.Forms.DataGridTextBoxColumn eindTijdDataGridColumnStyleDataGridTextBoxColumn1;
            System.Windows.Forms.DataGridTextBoxColumn eindIdAdresDataGridColumnStyleDataGridTextBoxColumn1;
            System.Windows.Forms.DataGridTextBoxColumn eindStandDataGridColumnStyleDataGridTextBoxColumn1;
            System.Windows.Forms.DataGridTextBoxColumn idVervoermiddelDataGridColumnStyleDataGridTextBoxColumn1;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.newMenuItemMenuItem = new System.Windows.Forms.MenuItem();
            this.oGDRegistratieDataSet = new OGDRegistratieWM.OGDRegistratieDataSet();
            this.ritBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ritTableAdapter = new OGDRegistratieWM.OGDRegistratieDataSetTableAdapters.RitTableAdapter();
            this.ritDataGrid = new System.Windows.Forms.DataGrid();
            this.ritTableStyleDataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            startTijdDataGridColumnStyleDataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            startIdAdresDataGridColumnStyleDataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            startStandDataGridColumnStyleDataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            eindTijdDataGridColumnStyleDataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            eindIdAdresDataGridColumnStyleDataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            eindStandDataGridColumnStyleDataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            idVervoermiddelDataGridColumnStyleDataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.oGDRegistratieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // startTijdDataGridColumnStyleDataGridTextBoxColumn1
            // 
            startTijdDataGridColumnStyleDataGridTextBoxColumn1.Format = "";
            startTijdDataGridColumnStyleDataGridTextBoxColumn1.FormatInfo = null;
            startTijdDataGridColumnStyleDataGridTextBoxColumn1.HeaderText = "StartTijd";
            startTijdDataGridColumnStyleDataGridTextBoxColumn1.MappingName = "StartTijd";
            // 
            // startIdAdresDataGridColumnStyleDataGridTextBoxColumn1
            // 
            startIdAdresDataGridColumnStyleDataGridTextBoxColumn1.Format = "";
            startIdAdresDataGridColumnStyleDataGridTextBoxColumn1.FormatInfo = null;
            startIdAdresDataGridColumnStyleDataGridTextBoxColumn1.HeaderText = "StartIdAdres";
            startIdAdresDataGridColumnStyleDataGridTextBoxColumn1.MappingName = "StartIdAdres";
            // 
            // startStandDataGridColumnStyleDataGridTextBoxColumn1
            // 
            startStandDataGridColumnStyleDataGridTextBoxColumn1.Format = "";
            startStandDataGridColumnStyleDataGridTextBoxColumn1.FormatInfo = null;
            startStandDataGridColumnStyleDataGridTextBoxColumn1.HeaderText = "StartStand";
            startStandDataGridColumnStyleDataGridTextBoxColumn1.MappingName = "StartStand";
            // 
            // eindTijdDataGridColumnStyleDataGridTextBoxColumn1
            // 
            eindTijdDataGridColumnStyleDataGridTextBoxColumn1.Format = "";
            eindTijdDataGridColumnStyleDataGridTextBoxColumn1.FormatInfo = null;
            eindTijdDataGridColumnStyleDataGridTextBoxColumn1.HeaderText = "EindTijd";
            eindTijdDataGridColumnStyleDataGridTextBoxColumn1.MappingName = "EindTijd";
            // 
            // eindIdAdresDataGridColumnStyleDataGridTextBoxColumn1
            // 
            eindIdAdresDataGridColumnStyleDataGridTextBoxColumn1.Format = "";
            eindIdAdresDataGridColumnStyleDataGridTextBoxColumn1.FormatInfo = null;
            eindIdAdresDataGridColumnStyleDataGridTextBoxColumn1.HeaderText = "EindIdAdres";
            eindIdAdresDataGridColumnStyleDataGridTextBoxColumn1.MappingName = "EindIdAdres";
            // 
            // eindStandDataGridColumnStyleDataGridTextBoxColumn1
            // 
            eindStandDataGridColumnStyleDataGridTextBoxColumn1.Format = "";
            eindStandDataGridColumnStyleDataGridTextBoxColumn1.FormatInfo = null;
            eindStandDataGridColumnStyleDataGridTextBoxColumn1.HeaderText = "EindStand";
            eindStandDataGridColumnStyleDataGridTextBoxColumn1.MappingName = "EindStand";
            // 
            // idVervoermiddelDataGridColumnStyleDataGridTextBoxColumn1
            // 
            idVervoermiddelDataGridColumnStyleDataGridTextBoxColumn1.Format = "";
            idVervoermiddelDataGridColumnStyleDataGridTextBoxColumn1.FormatInfo = null;
            idVervoermiddelDataGridColumnStyleDataGridTextBoxColumn1.HeaderText = "IdVervoermiddel";
            idVervoermiddelDataGridColumnStyleDataGridTextBoxColumn1.MappingName = "IdVervoermiddel";
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
            // ritBindingSource
            // 
            this.ritBindingSource.DataMember = "Rit";
            this.ritBindingSource.DataSource = this.oGDRegistratieDataSet;
            // 
            // ritTableAdapter
            // 
            this.ritTableAdapter.ClearBeforeFill = true;
            // 
            // ritDataGrid
            // 
            this.ritDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ritDataGrid.DataSource = this.ritBindingSource;
            this.ritDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ritDataGrid.Location = new System.Drawing.Point(0, 0);
            this.ritDataGrid.Name = "ritDataGrid";
            this.ritDataGrid.Size = new System.Drawing.Size(240, 268);
            this.ritDataGrid.TabIndex = 0;
            this.ritDataGrid.TableStyles.Add(this.ritTableStyleDataGridTableStyle);
            this.ritDataGrid.Click += new System.EventHandler(this.ritDataGrid_Click);
            // 
            // ritTableStyleDataGridTableStyle
            // 
            this.ritTableStyleDataGridTableStyle.GridColumnStyles.Add(startTijdDataGridColumnStyleDataGridTextBoxColumn1);
            this.ritTableStyleDataGridTableStyle.GridColumnStyles.Add(startIdAdresDataGridColumnStyleDataGridTextBoxColumn1);
            this.ritTableStyleDataGridTableStyle.GridColumnStyles.Add(startStandDataGridColumnStyleDataGridTextBoxColumn1);
            this.ritTableStyleDataGridTableStyle.GridColumnStyles.Add(eindTijdDataGridColumnStyleDataGridTextBoxColumn1);
            this.ritTableStyleDataGridTableStyle.GridColumnStyles.Add(eindIdAdresDataGridColumnStyleDataGridTextBoxColumn1);
            this.ritTableStyleDataGridTableStyle.GridColumnStyles.Add(eindStandDataGridColumnStyleDataGridTextBoxColumn1);
            this.ritTableStyleDataGridTableStyle.GridColumnStyles.Add(idVervoermiddelDataGridColumnStyleDataGridTextBoxColumn1);
            this.ritTableStyleDataGridTableStyle.MappingName = "Rit";
            // 
            // RitIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.ritDataGrid);
            this.Menu = this.mainMenu1;
            this.Name = "RitIndexForm";
            this.Text = "Ritten";
            this.Load += new System.EventHandler(this.frmRittenIndex_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.RitIndexForm_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.oGDRegistratieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OGDRegistratieDataSet oGDRegistratieDataSet;
        private System.Windows.Forms.BindingSource ritBindingSource;
        private OGDRegistratieWM.OGDRegistratieDataSetTableAdapters.RitTableAdapter ritTableAdapter;
        private System.Windows.Forms.DataGridTableStyle ritTableStyleDataGridTableStyle;
        private System.Windows.Forms.MenuItem newMenuItemMenuItem;
        private System.Windows.Forms.DataGrid ritDataGrid;
    }
}