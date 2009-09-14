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
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mniAdressen = new System.Windows.Forms.MenuItem();
            this.mniProjecten = new System.Windows.Forms.MenuItem();
            this.mniRitten = new System.Windows.Forms.MenuItem();
            this.mniVervoermiddelen = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = " ";
            // 
            // menuItem2
            // 
            this.menuItem2.MenuItems.Add(this.menuItem3);
            this.menuItem2.Text = "Tools";
            // 
            // menuItem3
            // 
            this.menuItem3.MenuItems.Add(this.mniAdressen);
            this.menuItem3.MenuItems.Add(this.mniProjecten);
            this.menuItem3.MenuItems.Add(this.mniRitten);
            this.menuItem3.MenuItems.Add(this.mniVervoermiddelen);
            this.menuItem3.Text = "Beheer";
            // 
            // mniAdressen
            // 
            this.mniAdressen.Text = "Adressen";
            this.mniAdressen.Click += new System.EventHandler(this.mniAdressen_Click);
            // 
            // mniProjecten
            // 
            this.mniProjecten.Text = "Projecten";
            this.mniProjecten.Click += new System.EventHandler(this.mniProjecten_Click);
            // 
            // mniRitten
            // 
            this.mniRitten.Text = "Ritten";
            this.mniRitten.Click += new System.EventHandler(this.mniRitten_Click);
            // 
            // mniVervoermiddelen
            // 
            this.mniVervoermiddelen.Text = "Vervoermiddelen";
            this.mniVervoermiddelen.Click += new System.EventHandler(this.mniVervoermiddelen_Click);
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

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem mniAdressen;
        private System.Windows.Forms.MenuItem mniProjecten;
        private System.Windows.Forms.MenuItem mniRitten;
        private System.Windows.Forms.MenuItem mniVervoermiddelen;



    }
}

