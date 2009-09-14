namespace OGDRegistratieWM
{
    partial class AdresEditViewDialog
    {
        public static AdresEditViewDialog Instance(System.Windows.Forms.BindingSource bindingSource)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if ((defaultInstance == null))
            {
                defaultInstance = new OGDRegistratieWM.AdresEditViewDialog();
                defaultInstance.adresBindingSource.DataSource = bindingSource;
            }
            defaultInstance.idProjectTextBox.Focus();
            defaultInstance.AutoScrollPosition = new System.Drawing.Point(0, 0);
            defaultInstance.adresBindingSource.Position = bindingSource.Position;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            return defaultInstance;
        }
    
        private static AdresEditViewDialog defaultInstance;
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
            System.Windows.Forms.Label idProjectLabel;
            System.Windows.Forms.Label straatLabel;
            System.Windows.Forms.Label huisnummerLabel;
            System.Windows.Forms.Label postcodeLabel;
            System.Windows.Forms.Label plaatsLabel;
            System.Windows.Forms.Label actiefLabel;
            System.Windows.Forms.Label naamLabel;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.adresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idProjectTextBox = new System.Windows.Forms.TextBox();
            this.straatTextBox = new System.Windows.Forms.TextBox();
            this.huisnummerTextBox = new System.Windows.Forms.TextBox();
            this.postcodeTextBox = new System.Windows.Forms.TextBox();
            this.plaatsTextBox = new System.Windows.Forms.TextBox();
            this.actiefCheckBox = new System.Windows.Forms.CheckBox();
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.topBorderPanel = new System.Windows.Forms.Panel();
            this.leftBorderPanel = new System.Windows.Forms.Panel();
            this.rightBorderPanel = new System.Windows.Forms.Panel();
            idProjectLabel = new System.Windows.Forms.Label();
            straatLabel = new System.Windows.Forms.Label();
            huisnummerLabel = new System.Windows.Forms.Label();
            postcodeLabel = new System.Windows.Forms.Label();
            plaatsLabel = new System.Windows.Forms.Label();
            actiefLabel = new System.Windows.Forms.Label();
            naamLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idProjectLabel
            // 
            idProjectLabel.Dock = System.Windows.Forms.DockStyle.Top;
            idProjectLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            idProjectLabel.Location = new System.Drawing.Point(4, 2);
            idProjectLabel.Name = "idProjectLabel";
            idProjectLabel.Size = new System.Drawing.Size(219, 21);
            idProjectLabel.Text = "Id Project:";
            // 
            // straatLabel
            // 
            straatLabel.Dock = System.Windows.Forms.DockStyle.Top;
            straatLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            straatLabel.Location = new System.Drawing.Point(4, 44);
            straatLabel.Name = "straatLabel";
            straatLabel.Size = new System.Drawing.Size(219, 21);
            straatLabel.Text = "Straat:";
            // 
            // huisnummerLabel
            // 
            huisnummerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            huisnummerLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            huisnummerLabel.Location = new System.Drawing.Point(4, 86);
            huisnummerLabel.Name = "huisnummerLabel";
            huisnummerLabel.Size = new System.Drawing.Size(219, 21);
            huisnummerLabel.Text = "Huisnummer:";
            // 
            // postcodeLabel
            // 
            postcodeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            postcodeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            postcodeLabel.Location = new System.Drawing.Point(4, 128);
            postcodeLabel.Name = "postcodeLabel";
            postcodeLabel.Size = new System.Drawing.Size(219, 21);
            postcodeLabel.Text = "Postcode:";
            // 
            // plaatsLabel
            // 
            plaatsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            plaatsLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            plaatsLabel.Location = new System.Drawing.Point(4, 170);
            plaatsLabel.Name = "plaatsLabel";
            plaatsLabel.Size = new System.Drawing.Size(219, 21);
            plaatsLabel.Text = "Plaats:";
            // 
            // actiefLabel
            // 
            actiefLabel.Dock = System.Windows.Forms.DockStyle.Top;
            actiefLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            actiefLabel.Location = new System.Drawing.Point(4, 212);
            actiefLabel.Name = "actiefLabel";
            actiefLabel.Size = new System.Drawing.Size(219, 21);
            actiefLabel.Text = "Actief:";
            // 
            // naamLabel
            // 
            naamLabel.Dock = System.Windows.Forms.DockStyle.Top;
            naamLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            naamLabel.Location = new System.Drawing.Point(4, 253);
            naamLabel.Name = "naamLabel";
            naamLabel.Size = new System.Drawing.Size(219, 21);
            naamLabel.Text = "Naam:";
            // 
            // adresBindingSource
            // 
            this.adresBindingSource.DataMember = "Adres";
            this.adresBindingSource.DataSource = typeof(OGDRegistratieWM.OGDRegistratieDataSet);
            // 
            // idProjectTextBox
            // 
            this.idProjectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "IdProject", true));
            this.idProjectTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.idProjectTextBox.Location = new System.Drawing.Point(4, 23);
            this.idProjectTextBox.Name = "idProjectTextBox";
            this.idProjectTextBox.Size = new System.Drawing.Size(219, 21);
            this.idProjectTextBox.TabIndex = 1;
            // 
            // straatTextBox
            // 
            this.straatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "Straat", true));
            this.straatTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.straatTextBox.Location = new System.Drawing.Point(4, 65);
            this.straatTextBox.Name = "straatTextBox";
            this.straatTextBox.Size = new System.Drawing.Size(219, 21);
            this.straatTextBox.TabIndex = 3;
            // 
            // huisnummerTextBox
            // 
            this.huisnummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "Huisnummer", true));
            this.huisnummerTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.huisnummerTextBox.Location = new System.Drawing.Point(4, 107);
            this.huisnummerTextBox.Name = "huisnummerTextBox";
            this.huisnummerTextBox.Size = new System.Drawing.Size(219, 21);
            this.huisnummerTextBox.TabIndex = 5;
            // 
            // postcodeTextBox
            // 
            this.postcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "Postcode", true));
            this.postcodeTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.postcodeTextBox.Location = new System.Drawing.Point(4, 149);
            this.postcodeTextBox.Name = "postcodeTextBox";
            this.postcodeTextBox.Size = new System.Drawing.Size(219, 21);
            this.postcodeTextBox.TabIndex = 7;
            // 
            // plaatsTextBox
            // 
            this.plaatsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "Plaats", true));
            this.plaatsTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.plaatsTextBox.Location = new System.Drawing.Point(4, 191);
            this.plaatsTextBox.Name = "plaatsTextBox";
            this.plaatsTextBox.Size = new System.Drawing.Size(219, 21);
            this.plaatsTextBox.TabIndex = 9;
            // 
            // actiefCheckBox
            // 
            this.actiefCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.adresBindingSource, "Actief", true));
            this.actiefCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.actiefCheckBox.Location = new System.Drawing.Point(4, 233);
            this.actiefCheckBox.Name = "actiefCheckBox";
            this.actiefCheckBox.Size = new System.Drawing.Size(219, 20);
            this.actiefCheckBox.TabIndex = 11;
            // 
            // naamTextBox
            // 
            this.naamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "Naam", true));
            this.naamTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.naamTextBox.Location = new System.Drawing.Point(4, 274);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(219, 21);
            this.naamTextBox.TabIndex = 13;
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
            this.leftBorderPanel.Size = new System.Drawing.Size(4, 295);
            // 
            // rightBorderPanel
            // 
            this.rightBorderPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightBorderPanel.Location = new System.Drawing.Point(223, 0);
            this.rightBorderPanel.Name = "rightBorderPanel";
            this.rightBorderPanel.Size = new System.Drawing.Size(4, 295);
            // 
            // AdresEditViewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.naamTextBox);
            this.Controls.Add(naamLabel);
            this.Controls.Add(this.actiefCheckBox);
            this.Controls.Add(actiefLabel);
            this.Controls.Add(this.plaatsTextBox);
            this.Controls.Add(plaatsLabel);
            this.Controls.Add(this.postcodeTextBox);
            this.Controls.Add(postcodeLabel);
            this.Controls.Add(this.huisnummerTextBox);
            this.Controls.Add(huisnummerLabel);
            this.Controls.Add(this.straatTextBox);
            this.Controls.Add(straatLabel);
            this.Controls.Add(this.idProjectTextBox);
            this.Controls.Add(idProjectLabel);
            this.Controls.Add(this.topBorderPanel);
            this.Controls.Add(this.leftBorderPanel);
            this.Controls.Add(this.rightBorderPanel);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "AdresEditViewDialog";
            this.Text = "AdresEditViewDialog";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.AdresEditViewDialog_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.adresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource adresBindingSource;
        private System.Windows.Forms.TextBox idProjectTextBox;
        private System.Windows.Forms.TextBox straatTextBox;
        private System.Windows.Forms.TextBox huisnummerTextBox;
        private System.Windows.Forms.TextBox postcodeTextBox;
        private System.Windows.Forms.TextBox plaatsTextBox;
        private System.Windows.Forms.CheckBox actiefCheckBox;
        private System.Windows.Forms.TextBox naamTextBox;
        private System.Windows.Forms.Panel topBorderPanel;
        private System.Windows.Forms.Panel leftBorderPanel;
        private System.Windows.Forms.Panel rightBorderPanel;
    }
}