namespace OGDRegistratieWM
{
    partial class RitRegistratieForm
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.mniSchrijf = new System.Windows.Forms.MenuItem();
            this.oGDRegistratieDataSet = new OGDRegistratieWM.OGDRegistratieDataSet();
            this.vervoermiddelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbVervoermiddel = new System.Windows.Forms.ComboBox();
            this.lblVervoermiddel = new System.Windows.Forms.Label();
            this.startAdresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbStartAdres = new System.Windows.Forms.ComboBox();
            this.adresTableAdapter = new OGDRegistratieWM.OGDRegistratieDataSetTableAdapters.AdresTableAdapter();
            this.eindAdresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbEindAdres = new System.Windows.Forms.ComboBox();
            this.lblStartAdres = new System.Windows.Forms.Label();
            this.lblEindAdres = new System.Windows.Forms.Label();
            this.txtStartStand = new System.Windows.Forms.TextBox();
            this.dtStartTijd = new System.Windows.Forms.DateTimePicker();
            this.lblStartTijd = new System.Windows.Forms.Label();
            this.lblStartStand = new System.Windows.Forms.Label();
            this.lblEindStand = new System.Windows.Forms.Label();
            this.lblEindTijd = new System.Windows.Forms.Label();
            this.dtEindTijd = new System.Windows.Forms.DateTimePicker();
            this.txtEindStand = new System.Windows.Forms.TextBox();
            this.vervoermiddelTableAdapter = new OGDRegistratieWM.OGDRegistratieDataSetTableAdapters.VervoermiddelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.oGDRegistratieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vervoermiddelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startAdresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eindAdresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.mniSchrijf);
            // 
            // mniSchrijf
            // 
            this.mniSchrijf.Text = "Schrijf";
            this.mniSchrijf.Click += new System.EventHandler(this.mniSchrijf_Click);
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
            // cmbVervoermiddel
            // 
            this.cmbVervoermiddel.DataSource = this.vervoermiddelBindingSource;
            this.cmbVervoermiddel.DisplayMember = "Naam";
            this.cmbVervoermiddel.Location = new System.Drawing.Point(126, 13);
            this.cmbVervoermiddel.Name = "cmbVervoermiddel";
            this.cmbVervoermiddel.Size = new System.Drawing.Size(100, 22);
            this.cmbVervoermiddel.TabIndex = 0;
            this.cmbVervoermiddel.ValueMember = "Id";
            // 
            // lblVervoermiddel
            // 
            this.lblVervoermiddel.Location = new System.Drawing.Point(4, 14);
            this.lblVervoermiddel.Name = "lblVervoermiddel";
            this.lblVervoermiddel.Size = new System.Drawing.Size(100, 20);
            this.lblVervoermiddel.Text = "Vervoermiddel";
            // 
            // startAdresBindingSource
            // 
            this.startAdresBindingSource.DataMember = "Adres";
            this.startAdresBindingSource.DataSource = this.oGDRegistratieDataSet;
            // 
            // cmbStartAdres
            // 
            this.cmbStartAdres.DataSource = this.startAdresBindingSource;
            this.cmbStartAdres.DisplayMember = "Naam";
            this.cmbStartAdres.Location = new System.Drawing.Point(126, 61);
            this.cmbStartAdres.Name = "cmbStartAdres";
            this.cmbStartAdres.Size = new System.Drawing.Size(100, 22);
            this.cmbStartAdres.TabIndex = 2;
            this.cmbStartAdres.ValueMember = "Id";
            // 
            // adresTableAdapter
            // 
            this.adresTableAdapter.ClearBeforeFill = true;
            // 
            // eindAdresBindingSource
            // 
            this.eindAdresBindingSource.DataMember = "Adres";
            this.eindAdresBindingSource.DataSource = this.oGDRegistratieDataSet;
            // 
            // cmbEindAdres
            // 
            this.cmbEindAdres.DataSource = this.eindAdresBindingSource;
            this.cmbEindAdres.DisplayMember = "Naam";
            this.cmbEindAdres.Location = new System.Drawing.Point(126, 173);
            this.cmbEindAdres.Name = "cmbEindAdres";
            this.cmbEindAdres.Size = new System.Drawing.Size(100, 22);
            this.cmbEindAdres.TabIndex = 3;
            this.cmbEindAdres.ValueMember = "Id";
            // 
            // lblStartAdres
            // 
            this.lblStartAdres.Location = new System.Drawing.Point(4, 61);
            this.lblStartAdres.Name = "lblStartAdres";
            this.lblStartAdres.Size = new System.Drawing.Size(100, 20);
            this.lblStartAdres.Text = "Start adres";
            // 
            // lblEindAdres
            // 
            this.lblEindAdres.Location = new System.Drawing.Point(4, 173);
            this.lblEindAdres.Name = "lblEindAdres";
            this.lblEindAdres.Size = new System.Drawing.Size(100, 20);
            this.lblEindAdres.Text = "Eind adres";
            // 
            // txtStartStand
            // 
            this.txtStartStand.Location = new System.Drawing.Point(126, 117);
            this.txtStartStand.Name = "txtStartStand";
            this.txtStartStand.Size = new System.Drawing.Size(100, 21);
            this.txtStartStand.TabIndex = 8;
            // 
            // dtStartTijd
            // 
            this.dtStartTijd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtStartTijd.Location = new System.Drawing.Point(126, 89);
            this.dtStartTijd.Name = "dtStartTijd";
            this.dtStartTijd.ShowUpDown = true;
            this.dtStartTijd.Size = new System.Drawing.Size(100, 22);
            this.dtStartTijd.TabIndex = 9;
            // 
            // lblStartTijd
            // 
            this.lblStartTijd.Location = new System.Drawing.Point(4, 89);
            this.lblStartTijd.Name = "lblStartTijd";
            this.lblStartTijd.Size = new System.Drawing.Size(100, 20);
            this.lblStartTijd.Text = "Start tijd";
            // 
            // lblStartStand
            // 
            this.lblStartStand.Location = new System.Drawing.Point(4, 117);
            this.lblStartStand.Name = "lblStartStand";
            this.lblStartStand.Size = new System.Drawing.Size(100, 20);
            this.lblStartStand.Text = "Start stand";
            // 
            // lblEindStand
            // 
            this.lblEindStand.Location = new System.Drawing.Point(4, 230);
            this.lblEindStand.Name = "lblEindStand";
            this.lblEindStand.Size = new System.Drawing.Size(100, 20);
            this.lblEindStand.Text = "Eind stand";
            // 
            // lblEindTijd
            // 
            this.lblEindTijd.Location = new System.Drawing.Point(4, 202);
            this.lblEindTijd.Name = "lblEindTijd";
            this.lblEindTijd.Size = new System.Drawing.Size(100, 20);
            this.lblEindTijd.Text = "Eind tijd";
            // 
            // dtEindTijd
            // 
            this.dtEindTijd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtEindTijd.Location = new System.Drawing.Point(126, 202);
            this.dtEindTijd.Name = "dtEindTijd";
            this.dtEindTijd.Size = new System.Drawing.Size(100, 22);
            this.dtEindTijd.TabIndex = 20;
            // 
            // txtEindStand
            // 
            this.txtEindStand.Location = new System.Drawing.Point(126, 230);
            this.txtEindStand.Name = "txtEindStand";
            this.txtEindStand.Size = new System.Drawing.Size(100, 21);
            this.txtEindStand.TabIndex = 19;
            // 
            // vervoermiddelTableAdapter
            // 
            this.vervoermiddelTableAdapter.ClearBeforeFill = true;
            // 
            // RitRegistratieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.lblEindStand);
            this.Controls.Add(this.lblEindTijd);
            this.Controls.Add(this.dtEindTijd);
            this.Controls.Add(this.txtEindStand);
            this.Controls.Add(this.lblStartStand);
            this.Controls.Add(this.lblStartTijd);
            this.Controls.Add(this.dtStartTijd);
            this.Controls.Add(this.txtStartStand);
            this.Controls.Add(this.lblEindAdres);
            this.Controls.Add(this.lblStartAdres);
            this.Controls.Add(this.cmbEindAdres);
            this.Controls.Add(this.cmbStartAdres);
            this.Controls.Add(this.lblVervoermiddel);
            this.Controls.Add(this.cmbVervoermiddel);
            this.Menu = this.mainMenu1;
            this.Name = "RitRegistratieForm";
            this.Text = "RitRegistratieForm";
            this.Load += new System.EventHandler(this.RitRegistratieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oGDRegistratieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vervoermiddelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startAdresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eindAdresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVervoermiddel;
        private OGDRegistratieDataSet oGDRegistratieDataSet;
        private System.Windows.Forms.Label lblVervoermiddel;
        private System.Windows.Forms.ComboBox cmbStartAdres;
        private System.Windows.Forms.BindingSource startAdresBindingSource;
        private OGDRegistratieWM.OGDRegistratieDataSetTableAdapters.AdresTableAdapter adresTableAdapter;
        private System.Windows.Forms.ComboBox cmbEindAdres;
        private System.Windows.Forms.Label lblStartAdres;
        private System.Windows.Forms.Label lblEindAdres;
        private System.Windows.Forms.TextBox txtStartStand;
        private System.Windows.Forms.DateTimePicker dtStartTijd;
        private System.Windows.Forms.Label lblStartTijd;
        private System.Windows.Forms.Label lblStartStand;
        private System.Windows.Forms.Label lblEindStand;
        private System.Windows.Forms.Label lblEindTijd;
        private System.Windows.Forms.DateTimePicker dtEindTijd;
        private System.Windows.Forms.TextBox txtEindStand;
        private System.Windows.Forms.MenuItem mniSchrijf;
        private System.Windows.Forms.BindingSource vervoermiddelBindingSource;
        private OGDRegistratieWM.OGDRegistratieDataSetTableAdapters.VervoermiddelTableAdapter vervoermiddelTableAdapter;
        private System.Windows.Forms.BindingSource eindAdresBindingSource;
    }
}