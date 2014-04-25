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
            this.novaPosudbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaPosudbaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vracanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuUnos = new System.Windows.Forms.ToolStripMenuItem();
            this.članovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvjestajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposlenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clanovaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.filmovaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.posudjenihFilmovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.svihFilmovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.premaClanuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.novaPosudbaToolStripMenuItem,
            this.toolStripMenuUnos,
            this.izvjestajiToolStripMenuItem,
            this.odjavaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(689, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novaPosudbaToolStripMenuItem
            // 
            this.novaPosudbaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaPosudbaToolStripMenuItem1,
            this.vracanjeToolStripMenuItem});
            this.novaPosudbaToolStripMenuItem.Name = "novaPosudbaToolStripMenuItem";
            this.novaPosudbaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.novaPosudbaToolStripMenuItem.Text = "Posudba";
            // 
            // novaPosudbaToolStripMenuItem1
            // 
            this.novaPosudbaToolStripMenuItem1.Name = "novaPosudbaToolStripMenuItem1";
            this.novaPosudbaToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.novaPosudbaToolStripMenuItem1.Text = "Nova";
            this.novaPosudbaToolStripMenuItem1.Click += new System.EventHandler(this.novaPosudbaToolStripMenuItem1_Click);
            // 
            // vracanjeToolStripMenuItem
            // 
            this.vracanjeToolStripMenuItem.Name = "vracanjeToolStripMenuItem";
            this.vracanjeToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.vracanjeToolStripMenuItem.Text = "Vraćanje";
            this.vracanjeToolStripMenuItem.Click += new System.EventHandler(this.vracanjeToolStripMenuItem_Click);
            // 
            // toolStripMenuUnos
            // 
            this.toolStripMenuUnos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.članovaToolStripMenuItem,
            this.filmovaToolStripMenuItem});
            this.toolStripMenuUnos.Name = "toolStripMenuUnos";
            this.toolStripMenuUnos.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuUnos.Text = "Unos";
            // 
            // članovaToolStripMenuItem
            // 
            this.članovaToolStripMenuItem.Name = "članovaToolStripMenuItem";
            this.članovaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.članovaToolStripMenuItem.Text = "Članova";
            // 
            // filmovaToolStripMenuItem
            // 
            this.filmovaToolStripMenuItem.Name = "filmovaToolStripMenuItem";
            this.filmovaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.filmovaToolStripMenuItem.Text = "Filmova";
            // 
            // izvjestajiToolStripMenuItem
            // 
            this.izvjestajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaposlenikaToolStripMenuItem,
            this.clanovaToolStripMenuItem1,
            this.toolStripSeparator1,
            this.filmovaToolStripMenuItem1,
            this.posudjenihFilmovaToolStripMenuItem});
            this.izvjestajiToolStripMenuItem.Name = "izvjestajiToolStripMenuItem";
            this.izvjestajiToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.izvjestajiToolStripMenuItem.Text = "Pregled";
            // 
            // zaposlenikaToolStripMenuItem
            // 
            this.zaposlenikaToolStripMenuItem.Name = "zaposlenikaToolStripMenuItem";
            this.zaposlenikaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.zaposlenikaToolStripMenuItem.Text = "Zaposlenika";
            this.zaposlenikaToolStripMenuItem.Click += new System.EventHandler(this.zaposlenikaToolStripMenuItem_Click);
            // 
            // clanovaToolStripMenuItem1
            // 
            this.clanovaToolStripMenuItem1.Name = "clanovaToolStripMenuItem1";
            this.clanovaToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.clanovaToolStripMenuItem1.Text = "Članova";
            this.clanovaToolStripMenuItem1.Click += new System.EventHandler(this.clanovaToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // filmovaToolStripMenuItem1
            // 
            this.filmovaToolStripMenuItem1.Name = "filmovaToolStripMenuItem1";
            this.filmovaToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.filmovaToolStripMenuItem1.Text = "Svih filmova";
            this.filmovaToolStripMenuItem1.Click += new System.EventHandler(this.filmovaToolStripMenuItem1_Click);
            // 
            // posudjenihFilmovaToolStripMenuItem
            // 
            this.posudjenihFilmovaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.svihFilmovaToolStripMenuItem,
            this.premaClanuToolStripMenuItem});
            this.posudjenihFilmovaToolStripMenuItem.Name = "posudjenihFilmovaToolStripMenuItem";
            this.posudjenihFilmovaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.posudjenihFilmovaToolStripMenuItem.Text = "Posuđenih filmova";
            // 
            // svihFilmovaToolStripMenuItem
            // 
            this.svihFilmovaToolStripMenuItem.Name = "svihFilmovaToolStripMenuItem";
            this.svihFilmovaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.svihFilmovaToolStripMenuItem.Text = "Svih članova";
            this.svihFilmovaToolStripMenuItem.Click += new System.EventHandler(this.svihFilmovaToolStripMenuItem_Click);
            // 
            // premaClanuToolStripMenuItem
            // 
            this.premaClanuToolStripMenuItem.Name = "premaClanuToolStripMenuItem";
            this.premaClanuToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.premaClanuToolStripMenuItem.Text = "Pojedinog člana";
            this.premaClanuToolStripMenuItem.Click += new System.EventHandler(this.premaClanuToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem članovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvjestajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaposlenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clanovaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem filmovaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem novaPosudbaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaPosudbaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vracanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posudjenihFilmovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem svihFilmovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem premaClanuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

