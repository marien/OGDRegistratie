namespace OGDRegistratieWM
{
    partial class VervoermiddelSummaryViewDialog
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
    
        public static VervoermiddelSummaryViewDialog Instance(System.Windows.Forms.BindingSource bindingSource)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if ((defaultInstance == null))
            {
                defaultInstance = new OGDRegistratieWM.VervoermiddelSummaryViewDialog();
                defaultInstance.vervoermiddelBindingSource.DataSource = bindingSource;
            }
            defaultInstance.AutoScrollPosition = new System.Drawing.Point(0, 0);
            defaultInstance.vervoermiddelBindingSource.Position = bindingSource.Position;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            return defaultInstance;
        }
    
        private static VervoermiddelSummaryViewDialog defaultInstance;
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
            System.Windows.Forms.Label naamLabel;
            System.Windows.Forms.Label kentekenLabel;
            System.Windows.Forms.Label actiefLabel;
            this.vervoermiddelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.editMenuItemMenuItem = new System.Windows.Forms.MenuItem();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.naamLabel1 = new System.Windows.Forms.Label();
            this.kentekenLabel1 = new System.Windows.Forms.Label();
            this.actiefLabel1 = new System.Windows.Forms.Label();
            this.topBorderPanel = new System.Windows.Forms.Panel();
            this.leftBorderPanel = new System.Windows.Forms.Panel();
            this.rightBorderPanel = new System.Windows.Forms.Panel();
            idLabel = new System.Windows.Forms.Label();
            naamLabel = new System.Windows.Forms.Label();
            kentekenLabel = new System.Windows.Forms.Label();
            actiefLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vervoermiddelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.vervoermiddelBindingSource, "Id", true));
            idLabel.Dock = System.Windows.Forms.DockStyle.Top;
            idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            idLabel.Location = new System.Drawing.Point(4, 2);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(232, 21);
            idLabel.Text = "Id:";
            // 
            // vervoermiddelBindingSource
            // 
            this.vervoermiddelBindingSource.DataMember = "Vervoermiddel";
            this.vervoermiddelBindingSource.DataSource = typeof(OGDRegistratieWM.OGDRegistratieDataSet);
            // 
            // naamLabel
            // 
            naamLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.vervoermiddelBindingSource, "Naam", true));
            naamLabel.Dock = System.Windows.Forms.DockStyle.Top;
            naamLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            naamLabel.Location = new System.Drawing.Point(4, 43);
            naamLabel.Name = "naamLabel";
            naamLabel.Size = new System.Drawing.Size(232, 21);
            naamLabel.Text = "Naam:";
            // 
            // kentekenLabel
            // 
            kentekenLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.vervoermiddelBindingSource, "Kenteken", true));
            kentekenLabel.Dock = System.Windows.Forms.DockStyle.Top;
            kentekenLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            kentekenLabel.Location = new System.Drawing.Point(4, 84);
            kentekenLabel.Name = "kentekenLabel";
            kentekenLabel.Size = new System.Drawing.Size(232, 21);
            kentekenLabel.Text = "Kenteken:";
            // 
            // actiefLabel
            // 
            actiefLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.vervoermiddelBindingSource, "Actief", true));
            actiefLabel.Dock = System.Windows.Forms.DockStyle.Top;
            actiefLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            actiefLabel.Location = new System.Drawing.Point(4, 125);
            actiefLabel.Name = "actiefLabel";
            actiefLabel.Size = new System.Drawing.Size(232, 21);
            actiefLabel.Text = "Actief:";
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
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vervoermiddelBindingSource, "Id", true));
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.vervoermiddelBindingSource, "Id", true));
            this.idLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.idLabel1.Location = new System.Drawing.Point(4, 23);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(232, 20);
            // 
            // naamLabel1
            // 
            this.naamLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vervoermiddelBindingSource, "Naam", true));
            this.naamLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.vervoermiddelBindingSource, "Naam", true));
            this.naamLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.naamLabel1.Location = new System.Drawing.Point(4, 64);
            this.naamLabel1.Name = "naamLabel1";
            this.naamLabel1.Size = new System.Drawing.Size(232, 20);
            // 
            // kentekenLabel1
            // 
            this.kentekenLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vervoermiddelBindingSource, "Kenteken", true));
            this.kentekenLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.vervoermiddelBindingSource, "Kenteken", true));
            this.kentekenLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kentekenLabel1.Location = new System.Drawing.Point(4, 105);
            this.kentekenLabel1.Name = "kentekenLabel1";
            this.kentekenLabel1.Size = new System.Drawing.Size(232, 20);
            // 
            // actiefLabel1
            // 
            this.actiefLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vervoermiddelBindingSource, "Actief", true));
            this.actiefLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.vervoermiddelBindingSource, "Actief", true));
            this.actiefLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.actiefLabel1.Location = new System.Drawing.Point(4, 146);
            this.actiefLabel1.Name = "actiefLabel1";
            this.actiefLabel1.Size = new System.Drawing.Size(232, 20);
            // 
            // topBorderPanel
            // 
            this.topBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBorderPanel.Location = new System.Drawing.Point(4, 0);
            this.topBorderPanel.Name = "topBorderPanel";
            this.topBorderPanel.Size = new System.Drawing.Size(232, 2);
            // 
            // leftBorderPanel
            // 
            this.leftBorderPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.leftBorderPanel.Name = "leftBorderPanel";
            this.leftBorderPanel.Size = new System.Drawing.Size(4, 268);
            // 
            // rightBorderPanel
            // 
            this.rightBorderPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightBorderPanel.Location = new System.Drawing.Point(236, 0);
            this.rightBorderPanel.Name = "rightBorderPanel";
            this.rightBorderPanel.Size = new System.Drawing.Size(4, 268);
            // 
            // VervoermiddelSummaryViewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.actiefLabel1);
            this.Controls.Add(actiefLabel);
            this.Controls.Add(this.kentekenLabel1);
            this.Controls.Add(kentekenLabel);
            this.Controls.Add(this.naamLabel1);
            this.Controls.Add(naamLabel);
            this.Controls.Add(this.idLabel1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.topBorderPanel);
            this.Controls.Add(this.leftBorderPanel);
            this.Controls.Add(this.rightBorderPanel);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "VervoermiddelSummaryViewDialog";
            this.Text = "VervoermiddelSummaryViewDialog";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VervoermiddelSummaryViewDialog_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.vervoermiddelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem editMenuItemMenuItem;
        private System.Windows.Forms.BindingSource vervoermiddelBindingSource;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.Label naamLabel1;
        private System.Windows.Forms.Label kentekenLabel1;
        private System.Windows.Forms.Label actiefLabel1;
        private System.Windows.Forms.Panel topBorderPanel;
        private System.Windows.Forms.Panel leftBorderPanel;
        private System.Windows.Forms.Panel rightBorderPanel;
    }
}