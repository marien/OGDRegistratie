namespace OGDRegistratieWM
{
    partial class RitSummaryViewDialog
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
    
        public static RitSummaryViewDialog Instance(System.Windows.Forms.BindingSource bindingSource)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if ((defaultInstance == null))
            {
                defaultInstance = new OGDRegistratieWM.RitSummaryViewDialog();
                defaultInstance.ritBindingSource.DataSource = bindingSource;
            }
            defaultInstance.AutoScrollPosition = new System.Drawing.Point(0, 0);
            defaultInstance.ritBindingSource.Position = bindingSource.Position;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            return defaultInstance;
        }
    
        private static RitSummaryViewDialog defaultInstance;
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
            System.Windows.Forms.Label startTijdLabel;
            System.Windows.Forms.Label startIdAdresLabel;
            System.Windows.Forms.Label startStandLabel;
            System.Windows.Forms.Label eindTijdLabel;
            System.Windows.Forms.Label eindIdAdresLabel;
            System.Windows.Forms.Label eindStandLabel;
            System.Windows.Forms.Label idVervoermiddelLabel;
            this.ritBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.editMenuItemMenuItem = new System.Windows.Forms.MenuItem();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.startTijdLabel1 = new System.Windows.Forms.Label();
            this.startIdAdresLabel1 = new System.Windows.Forms.Label();
            this.startStandLabel1 = new System.Windows.Forms.Label();
            this.eindTijdLabel1 = new System.Windows.Forms.Label();
            this.eindIdAdresLabel1 = new System.Windows.Forms.Label();
            this.eindStandLabel1 = new System.Windows.Forms.Label();
            this.idVervoermiddelLabel1 = new System.Windows.Forms.Label();
            this.topBorderPanel = new System.Windows.Forms.Panel();
            this.leftBorderPanel = new System.Windows.Forms.Panel();
            this.rightBorderPanel = new System.Windows.Forms.Panel();
            idLabel = new System.Windows.Forms.Label();
            startTijdLabel = new System.Windows.Forms.Label();
            startIdAdresLabel = new System.Windows.Forms.Label();
            startStandLabel = new System.Windows.Forms.Label();
            eindTijdLabel = new System.Windows.Forms.Label();
            eindIdAdresLabel = new System.Windows.Forms.Label();
            eindStandLabel = new System.Windows.Forms.Label();
            idVervoermiddelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ritBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.ritBindingSource, "Id", true));
            idLabel.Dock = System.Windows.Forms.DockStyle.Top;
            idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            idLabel.Location = new System.Drawing.Point(4, 2);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(219, 21);
            idLabel.Text = "Id:";
            // 
            // ritBindingSource
            // 
            this.ritBindingSource.DataMember = "Rit";
            this.ritBindingSource.DataSource = typeof(OGDRegistratieWM.OGDRegistratieDataSet);
            // 
            // startTijdLabel
            // 
            startTijdLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.ritBindingSource, "StartTijd", true));
            startTijdLabel.Dock = System.Windows.Forms.DockStyle.Top;
            startTijdLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            startTijdLabel.Location = new System.Drawing.Point(4, 43);
            startTijdLabel.Name = "startTijdLabel";
            startTijdLabel.Size = new System.Drawing.Size(219, 21);
            startTijdLabel.Text = "Start Tijd:";
            // 
            // startIdAdresLabel
            // 
            startIdAdresLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.ritBindingSource, "StartIdAdres", true));
            startIdAdresLabel.Dock = System.Windows.Forms.DockStyle.Top;
            startIdAdresLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            startIdAdresLabel.Location = new System.Drawing.Point(4, 84);
            startIdAdresLabel.Name = "startIdAdresLabel";
            startIdAdresLabel.Size = new System.Drawing.Size(219, 21);
            startIdAdresLabel.Text = "Start Id Adres:";
            // 
            // startStandLabel
            // 
            startStandLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.ritBindingSource, "StartStand", true));
            startStandLabel.Dock = System.Windows.Forms.DockStyle.Top;
            startStandLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            startStandLabel.Location = new System.Drawing.Point(4, 125);
            startStandLabel.Name = "startStandLabel";
            startStandLabel.Size = new System.Drawing.Size(219, 21);
            startStandLabel.Text = "Start Stand:";
            // 
            // eindTijdLabel
            // 
            eindTijdLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.ritBindingSource, "EindTijd", true));
            eindTijdLabel.Dock = System.Windows.Forms.DockStyle.Top;
            eindTijdLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            eindTijdLabel.Location = new System.Drawing.Point(4, 166);
            eindTijdLabel.Name = "eindTijdLabel";
            eindTijdLabel.Size = new System.Drawing.Size(219, 21);
            eindTijdLabel.Text = "Eind Tijd:";
            // 
            // eindIdAdresLabel
            // 
            eindIdAdresLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.ritBindingSource, "EindIdAdres", true));
            eindIdAdresLabel.Dock = System.Windows.Forms.DockStyle.Top;
            eindIdAdresLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            eindIdAdresLabel.Location = new System.Drawing.Point(4, 207);
            eindIdAdresLabel.Name = "eindIdAdresLabel";
            eindIdAdresLabel.Size = new System.Drawing.Size(219, 21);
            eindIdAdresLabel.Text = "Eind Id Adres:";
            // 
            // eindStandLabel
            // 
            eindStandLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.ritBindingSource, "EindStand", true));
            eindStandLabel.Dock = System.Windows.Forms.DockStyle.Top;
            eindStandLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            eindStandLabel.Location = new System.Drawing.Point(4, 248);
            eindStandLabel.Name = "eindStandLabel";
            eindStandLabel.Size = new System.Drawing.Size(219, 21);
            eindStandLabel.Text = "Eind Stand:";
            // 
            // idVervoermiddelLabel
            // 
            idVervoermiddelLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.ritBindingSource, "IdVervoermiddel", true));
            idVervoermiddelLabel.Dock = System.Windows.Forms.DockStyle.Top;
            idVervoermiddelLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            idVervoermiddelLabel.Location = new System.Drawing.Point(4, 289);
            idVervoermiddelLabel.Name = "idVervoermiddelLabel";
            idVervoermiddelLabel.Size = new System.Drawing.Size(219, 21);
            idVervoermiddelLabel.Text = "Id Vervoermiddel:";
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
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ritBindingSource, "Id", true));
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.ritBindingSource, "Id", true));
            this.idLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.idLabel1.Location = new System.Drawing.Point(4, 23);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(219, 20);
            // 
            // startTijdLabel1
            // 
            this.startTijdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ritBindingSource, "StartTijd", true));
            this.startTijdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.ritBindingSource, "StartTijd", true));
            this.startTijdLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.startTijdLabel1.Location = new System.Drawing.Point(4, 64);
            this.startTijdLabel1.Name = "startTijdLabel1";
            this.startTijdLabel1.Size = new System.Drawing.Size(219, 20);
            // 
            // startIdAdresLabel1
            // 
            this.startIdAdresLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ritBindingSource, "StartIdAdres", true));
            this.startIdAdresLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.ritBindingSource, "StartIdAdres", true));
            this.startIdAdresLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.startIdAdresLabel1.Location = new System.Drawing.Point(4, 105);
            this.startIdAdresLabel1.Name = "startIdAdresLabel1";
            this.startIdAdresLabel1.Size = new System.Drawing.Size(219, 20);
            // 
            // startStandLabel1
            // 
            this.startStandLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ritBindingSource, "StartStand", true));
            this.startStandLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.ritBindingSource, "StartStand", true));
            this.startStandLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.startStandLabel1.Location = new System.Drawing.Point(4, 146);
            this.startStandLabel1.Name = "startStandLabel1";
            this.startStandLabel1.Size = new System.Drawing.Size(219, 20);
            // 
            // eindTijdLabel1
            // 
            this.eindTijdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ritBindingSource, "EindTijd", true));
            this.eindTijdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.ritBindingSource, "EindTijd", true));
            this.eindTijdLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.eindTijdLabel1.Location = new System.Drawing.Point(4, 187);
            this.eindTijdLabel1.Name = "eindTijdLabel1";
            this.eindTijdLabel1.Size = new System.Drawing.Size(219, 20);
            // 
            // eindIdAdresLabel1
            // 
            this.eindIdAdresLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ritBindingSource, "EindIdAdres", true));
            this.eindIdAdresLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.ritBindingSource, "EindIdAdres", true));
            this.eindIdAdresLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.eindIdAdresLabel1.Location = new System.Drawing.Point(4, 228);
            this.eindIdAdresLabel1.Name = "eindIdAdresLabel1";
            this.eindIdAdresLabel1.Size = new System.Drawing.Size(219, 20);
            // 
            // eindStandLabel1
            // 
            this.eindStandLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ritBindingSource, "EindStand", true));
            this.eindStandLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.ritBindingSource, "EindStand", true));
            this.eindStandLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.eindStandLabel1.Location = new System.Drawing.Point(4, 269);
            this.eindStandLabel1.Name = "eindStandLabel1";
            this.eindStandLabel1.Size = new System.Drawing.Size(219, 20);
            // 
            // idVervoermiddelLabel1
            // 
            this.idVervoermiddelLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ritBindingSource, "IdVervoermiddel", true));
            this.idVervoermiddelLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.ritBindingSource, "IdVervoermiddel", true));
            this.idVervoermiddelLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.idVervoermiddelLabel1.Location = new System.Drawing.Point(4, 310);
            this.idVervoermiddelLabel1.Name = "idVervoermiddelLabel1";
            this.idVervoermiddelLabel1.Size = new System.Drawing.Size(219, 20);
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
            // RitSummaryViewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.idVervoermiddelLabel1);
            this.Controls.Add(idVervoermiddelLabel);
            this.Controls.Add(this.eindStandLabel1);
            this.Controls.Add(eindStandLabel);
            this.Controls.Add(this.eindIdAdresLabel1);
            this.Controls.Add(eindIdAdresLabel);
            this.Controls.Add(this.eindTijdLabel1);
            this.Controls.Add(eindTijdLabel);
            this.Controls.Add(this.startStandLabel1);
            this.Controls.Add(startStandLabel);
            this.Controls.Add(this.startIdAdresLabel1);
            this.Controls.Add(startIdAdresLabel);
            this.Controls.Add(this.startTijdLabel1);
            this.Controls.Add(startTijdLabel);
            this.Controls.Add(this.idLabel1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.topBorderPanel);
            this.Controls.Add(this.leftBorderPanel);
            this.Controls.Add(this.rightBorderPanel);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "RitSummaryViewDialog";
            this.Text = "RitSummaryViewDialog";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RitSummaryViewDialog_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ritBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem editMenuItemMenuItem;
        private System.Windows.Forms.BindingSource ritBindingSource;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.Label startTijdLabel1;
        private System.Windows.Forms.Label startIdAdresLabel1;
        private System.Windows.Forms.Label startStandLabel1;
        private System.Windows.Forms.Label eindTijdLabel1;
        private System.Windows.Forms.Label eindIdAdresLabel1;
        private System.Windows.Forms.Label eindStandLabel1;
        private System.Windows.Forms.Label idVervoermiddelLabel1;
        private System.Windows.Forms.Panel topBorderPanel;
        private System.Windows.Forms.Panel leftBorderPanel;
        private System.Windows.Forms.Panel rightBorderPanel;
    }
}