namespace OGDRegistratieWM
{
    partial class ProjectEditViewDialog
    {
        public static ProjectEditViewDialog Instance(System.Windows.Forms.BindingSource bindingSource)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if ((defaultInstance == null))
            {
                defaultInstance = new OGDRegistratieWM.ProjectEditViewDialog();
                defaultInstance.projectBindingSource.DataSource = bindingSource;
            }
            defaultInstance.naamTextBox.Focus();
            defaultInstance.AutoScrollPosition = new System.Drawing.Point(0, 0);
            defaultInstance.projectBindingSource.Position = bindingSource.Position;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            return defaultInstance;
        }
    
        private static ProjectEditViewDialog defaultInstance;
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
            System.Windows.Forms.Label naamLabel;
            System.Windows.Forms.Label nummerLabel;
            System.Windows.Forms.Label actiefLabel;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.nummerTextBox = new System.Windows.Forms.TextBox();
            this.actiefCheckBox = new System.Windows.Forms.CheckBox();
            this.topBorderPanel = new System.Windows.Forms.Panel();
            this.leftBorderPanel = new System.Windows.Forms.Panel();
            this.rightBorderPanel = new System.Windows.Forms.Panel();
            naamLabel = new System.Windows.Forms.Label();
            nummerLabel = new System.Windows.Forms.Label();
            actiefLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // naamLabel
            // 
            naamLabel.Dock = System.Windows.Forms.DockStyle.Top;
            naamLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            naamLabel.Location = new System.Drawing.Point(4, 2);
            naamLabel.Name = "naamLabel";
            naamLabel.Size = new System.Drawing.Size(232, 21);
            naamLabel.Text = "Naam:";
            // 
            // nummerLabel
            // 
            nummerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            nummerLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            nummerLabel.Location = new System.Drawing.Point(4, 44);
            nummerLabel.Name = "nummerLabel";
            nummerLabel.Size = new System.Drawing.Size(232, 21);
            nummerLabel.Text = "Nummer:";
            // 
            // actiefLabel
            // 
            actiefLabel.Dock = System.Windows.Forms.DockStyle.Top;
            actiefLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            actiefLabel.Location = new System.Drawing.Point(4, 86);
            actiefLabel.Name = "actiefLabel";
            actiefLabel.Size = new System.Drawing.Size(232, 21);
            actiefLabel.Text = "Actief:";
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "Project";
            this.projectBindingSource.DataSource = typeof(OGDRegistratieWM.OGDRegistratieDataSet);
            // 
            // naamTextBox
            // 
            this.naamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "Naam", true));
            this.naamTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.naamTextBox.Location = new System.Drawing.Point(4, 23);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(232, 21);
            this.naamTextBox.TabIndex = 1;
            // 
            // nummerTextBox
            // 
            this.nummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "Nummer", true));
            this.nummerTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.nummerTextBox.Location = new System.Drawing.Point(4, 65);
            this.nummerTextBox.Name = "nummerTextBox";
            this.nummerTextBox.Size = new System.Drawing.Size(232, 21);
            this.nummerTextBox.TabIndex = 3;
            // 
            // actiefCheckBox
            // 
            this.actiefCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.projectBindingSource, "Actief", true));
            this.actiefCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.actiefCheckBox.Location = new System.Drawing.Point(4, 107);
            this.actiefCheckBox.Name = "actiefCheckBox";
            this.actiefCheckBox.Size = new System.Drawing.Size(232, 20);
            this.actiefCheckBox.TabIndex = 5;
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
            // ProjectEditViewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.actiefCheckBox);
            this.Controls.Add(actiefLabel);
            this.Controls.Add(this.nummerTextBox);
            this.Controls.Add(nummerLabel);
            this.Controls.Add(this.naamTextBox);
            this.Controls.Add(naamLabel);
            this.Controls.Add(this.topBorderPanel);
            this.Controls.Add(this.leftBorderPanel);
            this.Controls.Add(this.rightBorderPanel);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "ProjectEditViewDialog";
            this.Text = "ProjectEditViewDialog";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.ProjectEditViewDialog_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.TextBox naamTextBox;
        private System.Windows.Forms.TextBox nummerTextBox;
        private System.Windows.Forms.CheckBox actiefCheckBox;
        private System.Windows.Forms.Panel topBorderPanel;
        private System.Windows.Forms.Panel leftBorderPanel;
        private System.Windows.Forms.Panel rightBorderPanel;
    }
}