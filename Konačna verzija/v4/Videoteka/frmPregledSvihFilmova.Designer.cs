namespace Videoteka
{
    partial class frmPregledSvihFilmova
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
            this.panelPozadina = new System.Windows.Forms.Panel();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.dgvFilmovi = new System.Windows.Forms.DataGridView();
            this.panelPozadina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmovi)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPozadina
            // 
            this.panelPozadina.Controls.Add(this.btnBrisi);
            this.panelPozadina.Controls.Add(this.btnZatvori);
            this.panelPozadina.Controls.Add(this.dgvFilmovi);
            this.panelPozadina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPozadina.Location = new System.Drawing.Point(0, 0);
            this.panelPozadina.Name = "panelPozadina";
            this.panelPozadina.Padding = new System.Windows.Forms.Padding(10, 10, 10, 50);
            this.panelPozadina.Size = new System.Drawing.Size(755, 282);
            this.panelPozadina.TabIndex = 10;
            // 
            // btnBrisi
            // 
            this.btnBrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrisi.Location = new System.Drawing.Point(586, 247);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(75, 23);
            this.btnBrisi.TabIndex = 8;
            this.btnBrisi.Text = "Briši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZatvori.Location = new System.Drawing.Point(667, 247);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 9;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // dgvFilmovi
            // 
            this.dgvFilmovi.AllowUserToAddRows = false;
            this.dgvFilmovi.AllowUserToDeleteRows = false;
            this.dgvFilmovi.AllowUserToOrderColumns = true;
            this.dgvFilmovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmovi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFilmovi.Location = new System.Drawing.Point(10, 10);
            this.dgvFilmovi.Name = "dgvFilmovi";
            this.dgvFilmovi.ReadOnly = true;
            this.dgvFilmovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilmovi.ShowEditingIcon = false;
            this.dgvFilmovi.Size = new System.Drawing.Size(735, 222);
            this.dgvFilmovi.TabIndex = 2;
            this.dgvFilmovi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilmovi_CellDoubleClick);
            // 
            // frmPregledSvihFilmova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnZatvori;
            this.ClientSize = new System.Drawing.Size(755, 282);
            this.Controls.Add(this.panelPozadina);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimumSize = new System.Drawing.Size(694, 252);
            this.Name = "frmPregledSvihFilmova";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Pregled svih filmova";
            this.Load += new System.EventHandler(this.frmPregledSvihFilmova_Load);
            this.panelPozadina.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPozadina;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.DataGridView dgvFilmovi;
        private System.Windows.Forms.Button btnBrisi;
    }
}