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
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.posudbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posudbaNovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posudbaVracanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuUnos = new System.Windows.Forms.ToolStripMenuItem();
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
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 325);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(689, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posudbaToolStripMenuItem,
            this.toolStripMenuUnos,
            this.pregledToolStripMenuItem,
            this.odjavaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(689, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
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
            // toolStripMenuUnos
            // 
            this.toolStripMenuUnos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosClanovaToolStripMenuItem,
            this.unosFilmovaToolStripMenuItem});
            this.toolStripMenuUnos.Name = "toolStripMenuUnos";
            this.toolStripMenuUnos.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuUnos.Text = "Unos";
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
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            // 
            // frmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 347);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPocetna";
            this.Text = "Videoteka";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPocetna_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuUnos;
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
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

