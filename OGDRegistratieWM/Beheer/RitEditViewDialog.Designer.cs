namespace OGDRegistratieWM
{
    partial class RitEditViewDialog
    {
        public static RitEditViewDialog Instance(System.Windows.Forms.BindingSource bindingSource)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if ((defaultInstance == null))
            {
                defaultInstance = new OGDRegistratieWM.RitEditViewDialog();
                defaultInstance.ritBindingSource.DataSource = bindingSource;
            }
            defaultInstance.startTijdTextBox.Focus();
            defaultInstance.AutoScrollPosition = new System.Drawing.Point(0, 0);
            defaultInstance.ritBindingSource.Position = bindingSource.Position;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            return defaultInstance;
        }
    
        private static RitEditViewDialog defaultInstance;
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
            System.Windows.Forms.Label startTijdLabel;
            System.Windows.Forms.Label startIdAdresLabel;
            System.Windows.Forms.Label startStandLabel;
            System.Windows.Forms.Label eindTijdLabel;
            System.Windows.Forms.Label eindIdAdresLabel;
            System.Windows.Forms.Label eindStandLabel;
            System.Windows.Forms.Label idVervoermiddelLabel;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.ritBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.startTijdTextBox = new System.Windows.Forms.TextBox();
            this.startIdAdresTextBox = new System.Windows.Forms.TextBox();
            this.startStandTextBox = new System.Windows.Forms.TextBox();
            this.eindTijdTextBox = new System.Windows.Forms.TextBox();
            this.eindIdAdresTextBox = new System.Windows.Forms.TextBox();
            this.eindStandTextBox = new System.Windows.Forms.TextBox();
            this.idVervoermiddelTextBox = new System.Windows.Forms.TextBox();
            this.topBorderPanel = new System.Windows.Forms.Panel();
            this.leftBorderPanel = new System.Windows.Forms.Panel();
            this.rightBorderPanel = new System.Windows.Forms.Panel();
            this.vervoermiddelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oGDRegistratieDataSet = new OGDRegistratieWM.OGDRegistratieDataSet();
            this.idVervoermiddelComboBox = new System.Windows.Forms.ComboBox();
            this.vervoermiddelTableAdapter = new OGDRegistratieWM.OGDRegistratieDataSetTableAdapters.VervoermiddelTableAdapter();
            this.startAdresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eindAdresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eindIdAdresComboBox = new System.Windows.Forms.ComboBox();
            this.adresTableAdapter = new OGDRegistratieWM.OGDRegistratieDataSetTableAdapters.AdresTableAdapter();
            this.startIdAdresComboBox = new System.Windows.Forms.ComboBox();
            startTijdLabel = new System.Windows.Forms.Label();
            startIdAdresLabel = new System.Windows.Forms.Label();
            startStandLabel = new System.Windows.Forms.Label();
            eindTijdLabel = new System.Windows.Forms.Label();
            eindIdAdresLabel = new System.Windows.Forms.Label();
            eindStandLabel = new System.Windows.Forms.Label();
            idVervoermiddelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ritBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vervoermiddelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGDRegistratieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startAdresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eindAdresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // startTijdLabel
            // 
            startTijdLabel.Dock = System.Windows.Forms.DockStyle.Top;
            startTijdLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            startTijdLabel.Location = new System.Drawing.Point(4, 2);
            startTijdLabel.Name = "startTijdLabel";
            startTijdLabel.Size = new System.Drawing.Size(219, 18);
            startTijdLabel.Text = "Start Tijd:";
            // 
            // startIdAdresLabel
            // 
            startIdAdresLabel.Dock = System.Windows.Forms.DockStyle.Top;
            startIdAdresLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            startIdAdresLabel.Location = new System.Drawing.Point(4, 41);
            startIdAdresLabel.Name = "startIdAdresLabel";
            startIdAdresLabel.Size = new System.Drawing.Size(219, 21);
            startIdAdresLabel.Text = "Start Id Adres:";
            // 
            // startStandLabel
            // 
            startStandLabel.Dock = System.Windows.Forms.DockStyle.Top;
            startStandLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            startStandLabel.Location = new System.Drawing.Point(4, 105);
            startStandLabel.Name = "startStandLabel";
            startStandLabel.Size = new System.Drawing.Size(219, 21);
            startStandLabel.Text = "Start Stand:";
            // 
            // eindTijdLabel
            // 
            eindTijdLabel.Dock = System.Windows.Forms.DockStyle.Top;
            eindTijdLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            eindTijdLabel.Location = new System.Drawing.Point(4, 147);
            eindTijdLabel.Name = "eindTijdLabel";
            eindTijdLabel.Size = new System.Drawing.Size(219, 21);
            eindTijdLabel.Text = "Eind Tijd:";
            // 
            // eindIdAdresLabel
            // 
            eindIdAdresLabel.Dock = System.Windows.Forms.DockStyle.Top;
            eindIdAdresLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            eindIdAdresLabel.Location = new System.Drawing.Point(4, 189);
            eindIdAdresLabel.Name = "eindIdAdresLabel";
            eindIdAdresLabel.Size = new System.Drawing.Size(219, 21);
            eindIdAdresLabel.Text = "Eind Id Adres:";
            // 
            // eindStandLabel
            // 
            eindStandLabel.Dock = System.Windows.Forms.DockStyle.Top;
            eindStandLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            eindStandLabel.Location = new System.Drawing.Point(4, 253);
            eindStandLabel.Name = "eindStandLabel";
            eindStandLabel.Size = new System.Drawing.Size(219, 21);
            eindStandLabel.Text = "Eind Stand:";
            // 
            // idVervoermiddelLabel
            // 
            idVervoermiddelLabel.Dock = System.Windows.Forms.DockStyle.Top;
            idVervoermiddelLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            idVervoermiddelLabel.Location = new System.Drawing.Point(4, 295);
            idVervoermiddelLabel.Name = "idVervoermiddelLabel";
            idVervoermiddelLabel.Size = new System.Drawing.Size(219, 21);
            idVervoermiddelLabel.Text = "Id Vervoermiddel:";
            // 
            // ritBindingSource
            // 
            this.ritBindingSource.DataMember = "Rit";
            this.ritBindingSource.DataSource = typeof(OGDRegistratieWM.OGDRegistratieDataSet);
            // 
            // startTijdTextBox
            // 
            this.startTijdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ritBindingSource, "StartTijd", true));
            this.startTijdTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.startTijdTextBox.Location = new System.Drawing.Point(4, 20);
            this.startTijdTextBox.Name = "startTijdTextBox";
            this.startTijdTextBox.Size = new System.Drawing.Size(219, 21);
            this.startTijdTextBox.TabIndex = 1;
            // 
            // startIdAdresTextBox
            // 
            this.startIdAdresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ritBindingSource, "StartIdAdres", true));
            this.startIdAdresTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.startIdAdresTextBox.Location = new System.Drawing.Point(4, 62);
            this.startIdAdresTextBox.Name = "startIdAdresTextBox";
            this.startIdAdresTextBox.Size = new System.Drawing.Size(219, 21);
            this.startIdAdresTextBox.TabIndex = 3;
            // 
            // startStandTextBox
            // 
            this.startStandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ritBindingSource, "StartStand", true));
            this.startStandTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.startStandTextBox.Location = new System.Drawing.Point(4, 126);
            this.startStandTextBox.Name = "startStandTextBox";
            this.startStandTextBox.Size = new System.Drawing.Size(219, 21);
            this.startStandTextBox.TabIndex = 5;
            // 
            // eindTijdTextBox
            // 
            this.eindTijdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ritBindingSource, "EindTijd", true));
            this.eindTijdTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.eindTijdTextBox.Location = new System.Drawing.Point(4, 168);
            this.eindTijdTextBox.Name = "eindTijdTextBox";
            this.eindTijdTextBox.Size = new System.Drawing.Size(219, 21);
            this.eindTijdTextBox.TabIndex = 7;
            // 
            // eindIdAdresTextBox
            // 
            this.eindIdAdresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ritBindingSource, "EindIdAdres", true));
            this.eindIdAdresTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.eindIdAdresTextBox.Location = new System.Drawing.Point(4, 210);
            this.eindIdAdresTextBox.Name = "eindIdAdresTextBox";
            this.eindIdAdresTextBox.Size = new System.Drawing.Size(219, 21);
            this.eindIdAdresTextBox.TabIndex = 9;
            // 
            // eindStandTextBox
            // 
            this.eindStandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ritBindingSource, "EindStand", true));
            this.eindStandTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.eindStandTextBox.Location = new System.Drawing.Point(4, 274);
            this.eindStandTextBox.Name = "eindStandTextBox";
            this.eindStandTextBox.Size = new System.Drawing.Size(219, 21);
            this.eindStandTextBox.TabIndex = 11;
            // 
            // idVervoermiddelTextBox
            // 
            this.idVervoermiddelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ritBindingSource, "IdVervoermiddel", true));
            this.idVervoermiddelTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.idVervoermiddelTextBox.Location = new System.Drawing.Point(4, 316);
            this.idVervoermiddelTextBox.Name = "idVervoermiddelTextBox";
            this.idVervoermiddelTextBox.Size = new System.Drawing.Size(219, 21);
            this.idVervoermiddelTextBox.TabIndex = 13;
            // 
            // topBorderPanel
            // 
            this.topBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBorderPanel.Location = new System.Drawing.Point(4, 0);
            this.topBorderPanel.Name = "topBorderPanel";
            this.topBorderPanel.Size = new System.Drawing.Size(219, 2);
            // 
            // leftBorderPanel
            // 
            this.leftBorderPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.leftBorderPanel.Name = "leftBorderPanel";
            this.leftBorderPanel.Size = new System.Drawing.Size(4, 359);
            // 
            // rightBorderPanel
            // 
            this.rightBorderPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightBorderPanel.Location = new System.Drawing.Point(223, 0);
            this.rightBorderPanel.Name = "rightBorderPanel";
            this.rightBorderPanel.Size = new System.Drawing.Size(4, 359);
            // 
            // vervoermiddelBindingSource
            // 
            this.vervoermiddelBindingSource.DataMember = "Vervoermiddel";
            this.vervoermiddelBindingSource.DataSource = this.oGDRegistratieDataSet;
            // 
            // oGDRegistratieDataSet
            // 
            this.oGDRegistratieDataSet.DataSetName = "OGDRegistratieDataSet";
            this.oGDRegistratieDataSet.Prefix = "";
            this.oGDRegistratieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idVervoermiddelComboBox
            // 
            this.idVervoermiddelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ritBindingSource, "IdVervoermiddel", true));
            this.idVervoermiddelComboBox.DataSource = this.vervoermiddelBindingSource;
            this.idVervoermiddelComboBox.DisplayMember = "Naam";
            this.idVervoermiddelComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.idVervoermiddelComboBox.Location = new System.Drawing.Point(4, 337);
            this.idVervoermiddelComboBox.Name = "idVervoermiddelComboBox";
            this.idVervoermiddelComboBox.Size = new System.Drawing.Size(219, 22);
            this.idVervoermiddelComboBox.TabIndex = 24;
            this.idVervoermiddelComboBox.ValueMember = "Id";
            // 
            // vervoermiddelTableAdapter
            // 
            this.vervoermiddelTableAdapter.ClearBeforeFill = true;
            // 
            // startAdresBindingSource
            // 
            this.startAdresBindingSource.DataMember = "Adres";
            this.startAdresBindingSource.DataSource = this.oGDRegistratieDataSet;
            // 
            // eindAdresBindingSource
            // 
            this.eindAdresBindingSource.DataMember = "Adres";
            this.eindAdresBindingSource.DataSource = this.oGDRegistratieDataSet;
            // 
            // eindIdAdresComboBox
            // 
            this.eindIdAdresComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ritBindingSource, "EindIdAdres", true));
            this.eindIdAdresComboBox.DataSource = this.eindAdresBindingSource;
            this.eindIdAdresComboBox.DisplayMember = "Naam";
            this.eindIdAdresComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.eindIdAdresComboBox.Location = new System.Drawing.Point(4, 231);
            this.eindIdAdresComboBox.Name = "eindIdAdresComboBox";
            this.eindIdAdresComboBox.Size = new System.Drawing.Size(219, 22);
            this.eindIdAdresComboBox.TabIndex = 35;
            this.eindIdAdresComboBox.ValueMember = "Id";
            // 
            // adresTableAdapter
            // 
            this.adresTableAdapter.ClearBeforeFill = true;
            // 
            // startIdAdresComboBox
            // 
            this.startIdAdresComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ritBindingSource, "StartIdAdres", true));
            this.startIdAdresComboBox.DataSource = this.startAdresBindingSource;
            this.startIdAdresComboBox.DisplayMember = "Naam";
            this.startIdAdresComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.startIdAdresComboBox.Location = new System.Drawing.Point(4, 83);
            this.startIdAdresComboBox.Name = "startIdAdresComboBox";
            this.startIdAdresComboBox.Size = new System.Drawing.Size(219, 22);
            this.startIdAdresComboBox.TabIndex = 44;
            this.startIdAdresComboBox.ValueMember = "Id";
            // 
            // RitEditViewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.idVervoermiddelComboBox);
            this.Controls.Add(this.idVervoermiddelTextBox);
            this.Controls.Add(idVervoermiddelLabel);
            this.Controls.Add(this.eindStandTextBox);
            this.Controls.Add(eindStandLabel);
            this.Controls.Add(this.eindIdAdresComboBox);
            this.Controls.Add(this.eindIdAdresTextBox);
            this.Controls.Add(eindIdAdresLabel);
            this.Controls.Add(this.eindTijdTextBox);
            this.Controls.Add(eindTijdLabel);
            this.Controls.Add(this.startStandTextBox);
            this.Controls.Add(startStandLabel);
            this.Controls.Add(this.startIdAdresComboBox);
            this.Controls.Add(this.startIdAdresTextBox);
            this.Controls.Add(startIdAdresLabel);
            this.Controls.Add(this.startTijdTextBox);
            this.Controls.Add(startTijdLabel);
            this.Controls.Add(this.topBorderPanel);
            this.Controls.Add(this.leftBorderPanel);
            this.Controls.Add(this.rightBorderPanel);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "RitEditViewDialog";
            this.Text = "RitEditViewDialog";
            this.Load += new System.EventHandler(this.RitEditViewDialog_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.RitEditViewDialog_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.ritBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vervoermiddelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGDRegistratieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startAdresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eindAdresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource ritBindingSource;
        private System.Windows.Forms.TextBox startTijdTextBox;
        private System.Windows.Forms.TextBox startIdAdresTextBox;
        private System.Windows.Forms.TextBox startStandTextBox;
        private System.Windows.Forms.TextBox eindTijdTextBox;
        private System.Windows.Forms.TextBox eindIdAdresTextBox;
        private System.Windows.Forms.TextBox eindStandTextBox;
        private System.Windows.Forms.TextBox idVervoermiddelTextBox;
        private System.Windows.Forms.Panel topBorderPanel;
        private System.Windows.Forms.Panel leftBorderPanel;
        private System.Windows.Forms.Panel rightBorderPanel;
        private System.Windows.Forms.ComboBox idVervoermiddelComboBox;
        private OGDRegistratieDataSet oGDRegistratieDataSet;
        private System.Windows.Forms.BindingSource vervoermiddelBindingSource;
        private OGDRegistratieWM.OGDRegistratieDataSetTableAdapters.VervoermiddelTableAdapter vervoermiddelTableAdapter;
        private System.Windows.Forms.ComboBox eindIdAdresComboBox;
        private System.Windows.Forms.BindingSource startAdresBindingSource;
        private OGDRegistratieWM.OGDRegistratieDataSetTableAdapters.AdresTableAdapter adresTableAdapter;
        private System.Windows.Forms.ComboBox startIdAdresComboBox;
        private System.Windows.Forms.BindingSource eindAdresBindingSource;
    }
}