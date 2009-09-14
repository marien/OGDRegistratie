namespace OGDRegistratieWM
{
    partial class frmMain
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.mniBlank = new System.Windows.Forms.MenuItem();
            this.mniTools = new System.Windows.Forms.MenuItem();
            this.mniBeheer = new System.Windows.Forms.MenuItem();
            this.mniAdressenBeheer = new System.Windows.Forms.MenuItem();
            this.mniProjectenBeheer = new System.Windows.Forms.MenuItem();
            this.mniRittenBeheer = new System.Windows.Forms.MenuItem();
            this.mniVervoermiddelenBeheer = new System.Windows.Forms.MenuItem();
            this.mniRegistratie = new System.Windows.Forms.MenuItem();
            this.mniRitRegistratie = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.mniBlank);
            this.mainMenu1.MenuItems.Add(this.mniTools);
            // 
            // mniBlank
            // 
            this.mniBlank.Text = " ";
            // 
            // mniTools
            // 
            this.mniTools.MenuItems.Add(this.mniBeheer);
            this.mniTools.MenuItems.Add(this.mniRegistratie);
            this.mniTools.Text = "Tools";
            // 
            // mniBeheer
            // 
            this.mniBeheer.MenuItems.Add(this.mniAdressenBeheer);
            this.mniBeheer.MenuItems.Add(this.mniProjectenBeheer);
            this.mniBeheer.MenuItems.Add(this.mniRittenBeheer);
            this.mniBeheer.MenuItems.Add(this.mniVervoermiddelenBeheer);
            this.mniBeheer.Text = "Beheer";
            // 
            // mniAdressenBeheer
            // 
            this.mniAdressenBeheer.Text = "Adressen";
            this.mniAdressenBeheer.Click += new System.EventHandler(this.mniAdressenBeheer_Click);
            // 
            // mniProjectenBeheer
            // 
            this.mniProjectenBeheer.Text = "Projecten";
            this.mniProjectenBeheer.Click += new System.EventHandler(this.mniProjectenBeheer_Click);
            // 
            // mniRittenBeheer
            // 
            this.mniRittenBeheer.Text = "Ritten";
            this.mniRittenBeheer.Click += new System.EventHandler(this.mniRittenBeheer_Click);
            // 
            // mniVervoermiddelenBeheer
            // 
            this.mniVervoermiddelenBeheer.Text = "Vervoermiddelen";
            this.mniVervoermiddelenBeheer.Click += new System.EventHandler(this.mniVervoermiddelenBeheer_Click);
            // 
            // mniRegistratie
            // 
            this.mniRegistratie.MenuItems.Add(this.mniRitRegistratie);
            this.mniRegistratie.Text = "Registratie";
            // 
            // mniRitRegistratie
            // 
            this.mniRitRegistratie.Text = "Rit";
            this.mniRitRegistratie.Click += new System.EventHandler(this.mniRitRegistratie_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Menu = this.mainMenu1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem mniBlank;
        private System.Windows.Forms.MenuItem mniTools;
        private System.Windows.Forms.MenuItem mniBeheer;
        private System.Windows.Forms.MenuItem mniAdressenBeheer;
        private System.Windows.Forms.MenuItem mniProjectenBeheer;
        private System.Windows.Forms.MenuItem mniRittenBeheer;
        private System.Windows.Forms.MenuItem mniVervoermiddelenBeheer;
        private System.Windows.Forms.MenuItem mniRegistratie;
        private System.Windows.Forms.MenuItem mniRitRegistratie;



    }
}

