namespace Videoteka
{
    partial class frmPregledPosudjenihFilmovaSvihClanova
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
            this.btnZatvori = new System.Windows.Forms.Button();
            this.dgvPosudjeniFilmovi = new System.Windows.Forms.DataGridView();
            this.panelPozadina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosudjeniFilmovi)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPozadina
            // 
            this.panelPozadina.Controls.Add(this.btnZatvori);
            this.panelPozadina.Controls.Add(this.dgvPosudjeniFilmovi);
            this.panelPozadina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPozadina.Location = new System.Drawing.Point(0, 0);
            this.panelPozadina.Name = "panelPozadina";
            this.panelPozadina.Padding = new System.Windows.Forms.Padding(10, 10, 10, 50);
            this.panelPozadina.Size = new System.Drawing.Size(748, 293);
            this.panelPozadina.TabIndex = 10;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZatvori.Location = new System.Drawing.Point(660, 258);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 8;
            this.btnZatvori.Text = "&Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            // 
            // dgvPosudjeniFilmovi
            // 
            this.dgvPosudjeniFilmovi.AllowUserToAddRows = false;
            this.dgvPosudjeniFilmovi.AllowUserToDeleteRows = false;
            this.dgvPosudjeniFilmovi.AllowUserToOrderColumns = true;
            this.dgvPosudjeniFilmovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPosudjeniFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosudjeniFilmovi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPosudjeniFilmovi.Location = new System.Drawing.Point(10, 10);
            this.dgvPosudjeniFilmovi.Name = "dgvPosudjeniFilmovi";
            this.dgvPosudjeniFilmovi.ReadOnly = true;
            this.dgvPosudjeniFilmovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPosudjeniFilmovi.ShowEditingIcon = false;
            this.dgvPosudjeniFilmovi.Size = new System.Drawing.Size(728, 233);
            this.dgvPosudjeniFilmovi.TabIndex = 2;
            // 
            // frmPregledPosudjenihFilmovaSvihClanova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnZatvori;
            this.ClientSize = new System.Drawing.Size(748, 293);
            this.Controls.Add(this.panelPozadina);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "frmPregledPosudjenihFilmovaSvihClanova";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Pregled posuđenih filmova";
            this.panelPozadina.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosudjeniFilmovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPozadina;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.DataGridView dgvPosudjeniFilmovi;
    }
}