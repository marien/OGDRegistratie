namespace OGDRegistratieWM
{
    partial class AdresSummaryViewDialog
    {
        public void AttachVisibilityBindings(ControlCollection controls)
        {
            for (int i = 0; (i < controls.Count); i = (i + 1))
            {
                if ((controls[i].DataBindings["Visible"] != null))
                {
                    // Attach event handlers to auto-hide controls.
                    controls[i].DataBindings["Visible"].Format += new System.Windows.Forms.ConvertEventHandler(this.Visibility_Format);
                    controls[i].DataBindings["Visible"].DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
                }
            }

        }
    
        public void Visibility_Format(object sender, System.Windows.Forms.ConvertEventArgs e)
        {
            if ((e.Value == System.DBNull.Value))
            {
                e.Value = false;
            }
            else
            {
                e.Value = true;
            }

        }
    
        public static AdresSummaryViewDialog Instance(System.Windows.Forms.BindingSource bindingSource)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if ((defaultInstance == null))
            {
                defaultInstance = new OGDRegistratieWM.AdresSummaryViewDialog();
                defaultInstance.adresBindingSource.DataSource = bindingSource;
            }
            defaultInstance.AutoScrollPosition = new System.Drawing.Point(0, 0);
            defaultInstance.adresBindingSource.Position = bindingSource.Position;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            return defaultInstance;
        }
    
        private static AdresSummaryViewDialog defaultInstance;
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label idProjectLabel;
            System.Windows.Forms.Label straatLabel;
            System.Windows.Forms.Label huisnummerLabel;
            System.Windows.Forms.Label postcodeLabel;
            System.Windows.Forms.Label plaatsLabel;
            System.Windows.Forms.Label actiefLabel;
            System.Windows.Forms.Label naamLabel;
            this.adresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.editMenuItemMenuItem = new System.Windows.Forms.MenuItem();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.idProjectLabel1 = new System.Windows.Forms.Label();
            this.straatLabel1 = new System.Windows.Forms.Label();
            this.huisnummerLabel1 = new System.Windows.Forms.Label();
            this.postcodeLabel1 = new System.Windows.Forms.Label();
            this.plaatsLabel1 = new System.Windows.Forms.Label();
            this.actiefLabel1 = new System.Windows.Forms.Label();
            this.naamLabel1 = new System.Windows.Forms.Label();
            this.topBorderPanel = new System.Windows.Forms.Panel();
            this.leftBorderPanel = new System.Windows.Forms.Panel();
            this.rightBorderPanel = new System.Windows.Forms.Panel();
            idLabel = new System.Windows.Forms.Label();
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
            // idLabel
            // 
            idLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.adresBindingSource, "Id", true));
            idLabel.Dock = System.Windows.Forms.DockStyle.Top;
            idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            idLabel.Location = new System.Drawing.Point(4, 2);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(219, 21);
            idLabel.Text = "Id:";
            // 
            // adresBindingSource
            // 
            this.adresBindingSource.DataMember = "Adres";
            this.adresBindingSource.DataSource = typeof(OGDRegistratieWM.OGDRegistratieDataSet);
            // 
            // idProjectLabel
            // 
            idProjectLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.adresBindingSource, "IdProject", true));
            idProjectLabel.Dock = System.Windows.Forms.DockStyle.Top;
            idProjectLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            idProjectLabel.Location = new System.Drawing.Point(4, 43);
            idProjectLabel.Name = "idProjectLabel";
            idProjectLabel.Size = new System.Drawing.Size(219, 21);
            idProjectLabel.Text = "Id Project:";
            // 
            // straatLabel
            // 
            straatLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.adresBindingSource, "Straat", true));
            straatLabel.Dock = System.Windows.Forms.DockStyle.Top;
            straatLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            straatLabel.Location = new System.Drawing.Point(4, 84);
            straatLabel.Name = "straatLabel";
            straatLabel.Size = new System.Drawing.Size(219, 21);
            straatLabel.Text = "Straat:";
            // 
            // huisnummerLabel
            // 
            huisnummerLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.adresBindingSource, "Huisnummer", true));
            huisnummerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            huisnummerLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            huisnummerLabel.Location = new System.Drawing.Point(4, 125);
            huisnummerLabel.Name = "huisnummerLabel";
            huisnummerLabel.Size = new System.Drawing.Size(219, 21);
            huisnummerLabel.Text = "Huisnummer:";
            // 
            // postcodeLabel
            // 
            postcodeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.adresBindingSource, "Postcode", true));
            postcodeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            postcodeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            postcodeLabel.Location = new System.Drawing.Point(4, 166);
            postcodeLabel.Name = "postcodeLabel";
            postcodeLabel.Size = new System.Drawing.Size(219, 21);
            postcodeLabel.Text = "Postcode:";
            // 
            // plaatsLabel
            // 
            plaatsLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.adresBindingSource, "Plaats", true));
            plaatsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            plaatsLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            plaatsLabel.Location = new System.Drawing.Point(4, 207);
            plaatsLabel.Name = "plaatsLabel";
            plaatsLabel.Size = new System.Drawing.Size(219, 21);
            plaatsLabel.Text = "Plaats:";
            // 
            // actiefLabel
            // 
            actiefLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.adresBindingSource, "Actief", true));
            actiefLabel.Dock = System.Windows.Forms.DockStyle.Top;
            actiefLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            actiefLabel.Location = new System.Drawing.Point(4, 248);
            actiefLabel.Name = "actiefLabel";
            actiefLabel.Size = new System.Drawing.Size(219, 21);
            actiefLabel.Text = "Actief:";
            // 
            // naamLabel
            // 
            naamLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.adresBindingSource, "Naam", true));
            naamLabel.Dock = System.Windows.Forms.DockStyle.Top;
            naamLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            naamLabel.Location = new System.Drawing.Point(4, 289);
            naamLabel.Name = "naamLabel";
            naamLabel.Size = new System.Drawing.Size(219, 21);
            naamLabel.Text = "Naam:";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.editMenuItemMenuItem);
            // 
            // editMenuItemMenuItem
            // 
            this.editMenuItemMenuItem.Text = "Edit";
            this.editMenuItemMenuItem.Click += new System.EventHandler(this.editMenuItemMenuItem_Click);
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "Id", true));
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.adresBindingSource, "Id", true));
            this.idLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.idLabel1.Location = new System.Drawing.Point(4, 23);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(219, 20);
            // 
            // idProjectLabel1
            // 
            this.idProjectLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "IdProject", true));
            this.idProjectLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.adresBindingSource, "IdProject", true));
            this.idProjectLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.idProjectLabel1.Location = new System.Drawing.Point(4, 64);
            this.idProjectLabel1.Name = "idProjectLabel1";
            this.idProjectLabel1.Size = new System.Drawing.Size(219, 20);
            // 
            // straatLabel1
            // 
            this.straatLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "Straat", true));
            this.straatLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.adresBindingSource, "Straat", true));
            this.straatLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.straatLabel1.Location = new System.Drawing.Point(4, 105);
            this.straatLabel1.Name = "straatLabel1";
            this.straatLabel1.Size = new System.Drawing.Size(219, 20);
            // 
            // huisnummerLabel1
            // 
            this.huisnummerLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "Huisnummer", true));
            this.huisnummerLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.adresBindingSource, "Huisnummer", true));
            this.huisnummerLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.huisnummerLabel1.Location = new System.Drawing.Point(4, 146);
            this.huisnummerLabel1.Name = "huisnummerLabel1";
            this.huisnummerLabel1.Size = new System.Drawing.Size(219, 20);
            // 
            // postcodeLabel1
            // 
            this.postcodeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "Postcode", true));
            this.postcodeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.adresBindingSource, "Postcode", true));
            this.postcodeLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.postcodeLabel1.Location = new System.Drawing.Point(4, 187);
            this.postcodeLabel1.Name = "postcodeLabel1";
            this.postcodeLabel1.Size = new System.Drawing.Size(219, 20);
            // 
            // plaatsLabel1
            // 
            this.plaatsLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "Plaats", true));
            this.plaatsLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.adresBindingSource, "Plaats", true));
            this.plaatsLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.plaatsLabel1.Location = new System.Drawing.Point(4, 228);
            this.plaatsLabel1.Name = "plaatsLabel1";
            this.plaatsLabel1.Size = new System.Drawing.Size(219, 20);
            // 
            // actiefLabel1
            // 
            this.actiefLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "Actief", true));
            this.actiefLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.adresBindingSource, "Actief", true));
            this.actiefLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.actiefLabel1.Location = new System.Drawing.Point(4, 269);
            this.actiefLabel1.Name = "actiefLabel1";
            this.actiefLabel1.Size = new System.Drawing.Size(219, 20);
            // 
            // naamLabel1
            // 
            this.naamLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "Naam", true));
            this.naamLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.adresBindingSource, "Naam", true));
            this.naamLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.naamLabel1.Location = new System.Drawing.Point(4, 310);
            this.naamLabel1.Name = "naamLabel1";
            this.naamLabel1.Size = new System.Drawing.Size(219, 20);
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
            this.leftBorderPanel.Size = new System.Drawing.Size(4, 330);
            // 
            // rightBorderPanel
            // 
            this.rightBorderPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightBorderPanel.Location = new System.Drawing.Point(223, 0);
            this.rightBorderPanel.Name = "rightBorderPanel";
            this.rightBorderPanel.Size = new System.Drawing.Size(4, 330);
            // 
            // AdresSummaryViewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.naamLabel1);
            this.Controls.Add(naamLabel);
            this.Controls.Add(this.actiefLabel1);
            this.Controls.Add(actiefLabel);
            this.Controls.Add(this.plaatsLabel1);
            this.Controls.Add(plaatsLabel);
            this.Controls.Add(this.postcodeLabel1);
            this.Controls.Add(postcodeLabel);
            this.Controls.Add(this.huisnummerLabel1);
            this.Controls.Add(huisnummerLabel);
            this.Controls.Add(this.straatLabel1);
            this.Controls.Add(straatLabel);
            this.Controls.Add(this.idProjectLabel1);
            this.Controls.Add(idProjectLabel);
            this.Controls.Add(this.idLabel1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.topBorderPanel);
            this.Controls.Add(this.leftBorderPanel);
            this.Controls.Add(this.rightBorderPanel);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "AdresSummaryViewDialog";
            this.Text = "AdresSummaryViewDialog";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdresSummaryViewDialog_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.adresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem editMenuItemMenuItem;
        private System.Windows.Forms.BindingSource adresBindingSource;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.Label idProjectLabel1;
        private System.Windows.Forms.Label straatLabel1;
        private System.Windows.Forms.Label huisnummerLabel1;
        private System.Windows.Forms.Label postcodeLabel1;
        private System.Windows.Forms.Label plaatsLabel1;
        private System.Windows.Forms.Label actiefLabel1;
        private System.Windows.Forms.Label naamLabel1;
        private System.Windows.Forms.Panel topBorderPanel;
        private System.Windows.Forms.Panel leftBorderPanel;
        private System.Windows.Forms.Panel rightBorderPanel;
    }
}