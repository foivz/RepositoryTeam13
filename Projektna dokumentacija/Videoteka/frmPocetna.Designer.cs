namespace Videoteka
{
    partial class frmPocetna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusnaTraka = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMeni = new System.Windows.Forms.MenuStrip();
            this.posudbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posudbaNovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posudbaVracanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.unosClanovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosFilmovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledZaposlenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledClanovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pregledSvihFilmovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledPosudjenihFilmovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledPosudSvihFilmovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledPosudPremaClanuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocDokumentacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pomocONamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.msMeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusnaTraka});
            this.statusStrip1.Location = new System.Drawing.Point(0, 325);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(689, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusnaTraka
            // 
            this.statusnaTraka.Name = "statusnaTraka";
            this.statusnaTraka.Size = new System.Drawing.Size(98, 17);
            this.statusnaTraka.Text = "Spremno za rad...";
            // 
            // msMeni
            // 
            this.msMeni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posudbaToolStripMenuItem,
            this.unosToolStripMenu,
            this.pregledToolStripMenuItem,
            this.pomocToolStripMenuItem,
            this.odjavaToolStripMenuItem});
            this.msMeni.Location = new System.Drawing.Point(0, 0);
            this.msMeni.Name = "msMeni";
            this.msMeni.Size = new System.Drawing.Size(689, 24);
            this.msMeni.TabIndex = 1;
            this.msMeni.Text = "menuStrip1";
            // 
            // posudbaToolStripMenuItem
            // 
            this.posudbaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posudbaNovaToolStripMenuItem,
            this.posudbaVracanjeToolStripMenuItem});
            this.posudbaToolStripMenuItem.Name = "posudbaToolStripMenuItem";
            this.posudbaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.posudbaToolStripMenuItem.Text = "Posudba";
            // 
            // posudbaNovaToolStripMenuItem
            // 
            this.posudbaNovaToolStripMenuItem.Name = "posudbaNovaToolStripMenuItem";
            this.posudbaNovaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.posudbaNovaToolStripMenuItem.Text = "Nova";
            this.posudbaNovaToolStripMenuItem.Click += new System.EventHandler(this.posudbaNovaToolStripMenuItem_Click);
            // 
            // posudbaVracanjeToolStripMenuItem
            // 
            this.posudbaVracanjeToolStripMenuItem.Name = "posudbaVracanjeToolStripMenuItem";
            this.posudbaVracanjeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.posudbaVracanjeToolStripMenuItem.Text = "Vraćanje";
            this.posudbaVracanjeToolStripMenuItem.Click += new System.EventHandler(this.posudbaVracanjeToolStripMenuItem_Click);
            // 
            // unosToolStripMenu
            // 
            this.unosToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosClanovaToolStripMenuItem,
            this.unosFilmovaToolStripMenuItem});
            this.unosToolStripMenu.Name = "unosToolStripMenu";
            this.unosToolStripMenu.Size = new System.Drawing.Size(46, 20);
            this.unosToolStripMenu.Text = "Unos";
            // 
            // unosClanovaToolStripMenuItem
            // 
            this.unosClanovaToolStripMenuItem.Name = "unosClanovaToolStripMenuItem";
            this.unosClanovaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.unosClanovaToolStripMenuItem.Text = "Članova";
            this.unosClanovaToolStripMenuItem.Click += new System.EventHandler(this.unosClanovaToolStripMenuItem_Click);
            // 
            // unosFilmovaToolStripMenuItem
            // 
            this.unosFilmovaToolStripMenuItem.Name = "unosFilmovaToolStripMenuItem";
            this.unosFilmovaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.unosFilmovaToolStripMenuItem.Text = "Filmova";
            this.unosFilmovaToolStripMenuItem.Click += new System.EventHandler(this.unosFilmovaToolStripMenuItem_Click);
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledZaposlenikaToolStripMenuItem,
            this.pregledClanovaToolStripMenuItem,
            this.toolStripSeparator1,
            this.pregledSvihFilmovaToolStripMenuItem,
            this.pregledPosudjenihFilmovaToolStripMenuItem});
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.pregledToolStripMenuItem.Text = "Pregled";
            // 
            // pregledZaposlenikaToolStripMenuItem
            // 
            this.pregledZaposlenikaToolStripMenuItem.Name = "pregledZaposlenikaToolStripMenuItem";
            this.pregledZaposlenikaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.pregledZaposlenikaToolStripMenuItem.Text = "Zaposlenika";
            this.pregledZaposlenikaToolStripMenuItem.Click += new System.EventHandler(this.pregledZaposlenikaToolStripMenuItem_Click);
            // 
            // pregledClanovaToolStripMenuItem
            // 
            this.pregledClanovaToolStripMenuItem.Name = "pregledClanovaToolStripMenuItem";
            this.pregledClanovaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.pregledClanovaToolStripMenuItem.Text = "Članova";
            this.pregledClanovaToolStripMenuItem.Click += new System.EventHandler(this.pregledClanovaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // pregledSvihFilmovaToolStripMenuItem
            // 
            this.pregledSvihFilmovaToolStripMenuItem.Name = "pregledSvihFilmovaToolStripMenuItem";
            this.pregledSvihFilmovaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.pregledSvihFilmovaToolStripMenuItem.Text = "Svih filmova";
            this.pregledSvihFilmovaToolStripMenuItem.Click += new System.EventHandler(this.pregledSvihFilmovaToolStripMenuItem_Click);
            // 
            // pregledPosudjenihFilmovaToolStripMenuItem
            // 
            this.pregledPosudjenihFilmovaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledPosudSvihFilmovaToolStripMenuItem,
            this.pregledPosudPremaClanuToolStripMenuItem});
            this.pregledPosudjenihFilmovaToolStripMenuItem.Name = "pregledPosudjenihFilmovaToolStripMenuItem";
            this.pregledPosudjenihFilmovaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.pregledPosudjenihFilmovaToolStripMenuItem.Text = "Posuđenih filmova";
            // 
            // pregledPosudSvihFilmovaToolStripMenuItem
            // 
            this.pregledPosudSvihFilmovaToolStripMenuItem.Name = "pregledPosudSvihFilmovaToolStripMenuItem";
            this.pregledPosudSvihFilmovaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.pregledPosudSvihFilmovaToolStripMenuItem.Text = "Svih članova";
            this.pregledPosudSvihFilmovaToolStripMenuItem.Click += new System.EventHandler(this.pregledPosudSvihFilmovaToolStripMenuItem_Click);
            // 
            // pregledPosudPremaClanuToolStripMenuItem
            // 
            this.pregledPosudPremaClanuToolStripMenuItem.Name = "pregledPosudPremaClanuToolStripMenuItem";
            this.pregledPosudPremaClanuToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.pregledPosudPremaClanuToolStripMenuItem.Text = "Pojedinog člana";
            this.pregledPosudPremaClanuToolStripMenuItem.Click += new System.EventHandler(this.pregledPosudPremaClanuToolStripMenuItem_Click);
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomocDokumentacijaToolStripMenuItem,
            this.toolStripSeparator2,
            this.pomocONamaToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoć";
            // 
            // pomocDokumentacijaToolStripMenuItem
            // 
            this.pomocDokumentacijaToolStripMenuItem.Name = "pomocDokumentacijaToolStripMenuItem";
            this.pomocDokumentacijaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.pomocDokumentacijaToolStripMenuItem.Text = "Dokumentacija";
            this.pomocDokumentacijaToolStripMenuItem.Click += new System.EventHandler(this.pomocDokumentacijaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(151, 6);
            // 
            // pomocONamaToolStripMenuItem
            // 
            this.pomocONamaToolStripMenuItem.Name = "pomocONamaToolStripMenuItem";
            this.pomocONamaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.pomocONamaToolStripMenuItem.Text = "O nama";
            this.pomocONamaToolStripMenuItem.Click += new System.EventHandler(this.pomocONamaToolStripMenuItem_Click);
            // 
            // frmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 347);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.msMeni);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMeni;
            this.Name = "frmPocetna";
            this.Text = "Videoteka";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPocetna_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.msMeni.ResumeLayout(false);
            this.msMeni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip msMeni;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem unosClanovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosFilmovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledZaposlenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledClanovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem pregledSvihFilmovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posudbaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posudbaNovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posudbaVracanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledPosudjenihFilmovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledPosudSvihFilmovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledPosudPremaClanuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusnaTraka;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocDokumentacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem pomocONamaToolStripMenuItem;
    }
}

