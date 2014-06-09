namespace Videoteka
{
    partial class frmPregledPosudjenihFilmovaPojedinogClana
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelPozadina = new System.Windows.Forms.Panel();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.dgvPosudjeniFilmovi = new System.Windows.Forms.DataGridView();
            this.panelClanovi = new System.Windows.Forms.Panel();
            this.txtPretraziClanove = new System.Windows.Forms.TextBox();
            this.lblPretraziClanove = new System.Windows.Forms.Label();
            this.dgvClanovi = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPozadina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosudjeniFilmovi)).BeginInit();
            this.panelClanovi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPozadina
            // 
            this.panelPozadina.Controls.Add(this.btnZatvori);
            this.panelPozadina.Controls.Add(this.dgvPosudjeniFilmovi);
            this.panelPozadina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPozadina.Location = new System.Drawing.Point(0, 0);
            this.panelPozadina.Name = "panelPozadina";
            this.panelPozadina.Padding = new System.Windows.Forms.Padding(220, 10, 10, 50);
            this.panelPozadina.Size = new System.Drawing.Size(756, 341);
            this.panelPozadina.TabIndex = 10;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZatvori.Location = new System.Drawing.Point(668, 306);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 8;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // dgvPosudjeniFilmovi
            // 
            this.dgvPosudjeniFilmovi.AllowUserToAddRows = false;
            this.dgvPosudjeniFilmovi.AllowUserToDeleteRows = false;
            this.dgvPosudjeniFilmovi.AllowUserToOrderColumns = true;
            this.dgvPosudjeniFilmovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPosudjeniFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosudjeniFilmovi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPosudjeniFilmovi.Location = new System.Drawing.Point(220, 10);
            this.dgvPosudjeniFilmovi.Name = "dgvPosudjeniFilmovi";
            this.dgvPosudjeniFilmovi.ReadOnly = true;
            this.dgvPosudjeniFilmovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPosudjeniFilmovi.ShowEditingIcon = false;
            this.dgvPosudjeniFilmovi.Size = new System.Drawing.Size(526, 281);
            this.dgvPosudjeniFilmovi.TabIndex = 2;
            // 
            // panelClanovi
            // 
            this.panelClanovi.Controls.Add(this.txtPretraziClanove);
            this.panelClanovi.Controls.Add(this.lblPretraziClanove);
            this.panelClanovi.Controls.Add(this.dgvClanovi);
            this.panelClanovi.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelClanovi.Location = new System.Drawing.Point(0, 0);
            this.panelClanovi.Name = "panelClanovi";
            this.panelClanovi.Size = new System.Drawing.Size(210, 341);
            this.panelClanovi.TabIndex = 11;
            // 
            // txtPretraziClanove
            // 
            this.txtPretraziClanove.Location = new System.Drawing.Point(3, 19);
            this.txtPretraziClanove.Name = "txtPretraziClanove";
            this.txtPretraziClanove.ShortcutsEnabled = false;
            this.txtPretraziClanove.Size = new System.Drawing.Size(186, 21);
            this.txtPretraziClanove.TabIndex = 1;
            this.txtPretraziClanove.TextChanged += new System.EventHandler(this.txtPretraziClanove_TextChanged);
            // 
            // lblPretraziClanove
            // 
            this.lblPretraziClanove.AutoSize = true;
            this.lblPretraziClanove.Location = new System.Drawing.Point(3, 3);
            this.lblPretraziClanove.Name = "lblPretraziClanove";
            this.lblPretraziClanove.Size = new System.Drawing.Size(103, 13);
            this.lblPretraziClanove.TabIndex = 0;
            this.lblPretraziClanove.Text = "Pretraživanje člana:";
            // 
            // dgvClanovi
            // 
            this.dgvClanovi.AllowUserToAddRows = false;
            this.dgvClanovi.AllowUserToDeleteRows = false;
            this.dgvClanovi.AllowUserToResizeColumns = false;
            this.dgvClanovi.AllowUserToResizeRows = false;
            this.dgvClanovi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvClanovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClanovi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClanovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.colImePrezime});
            this.dgvClanovi.Location = new System.Drawing.Point(0, 44);
            this.dgvClanovi.MultiSelect = false;
            this.dgvClanovi.Name = "dgvClanovi";
            this.dgvClanovi.ReadOnly = true;
            this.dgvClanovi.RowHeadersVisible = false;
            this.dgvClanovi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvClanovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClanovi.ShowCellToolTips = false;
            this.dgvClanovi.ShowEditingIcon = false;
            this.dgvClanovi.Size = new System.Drawing.Size(210, 294);
            this.dgvClanovi.TabIndex = 2;
            this.dgvClanovi.SelectionChanged += new System.EventHandler(this.dgvClanovi_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // colImePrezime
            // 
            this.colImePrezime.HeaderText = "Ime i prezime";
            this.colImePrezime.Name = "colImePrezime";
            this.colImePrezime.ReadOnly = true;
            // 
            // frmPregledPosudjenihFilmovaPojedinogClana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnZatvori;
            this.ClientSize = new System.Drawing.Size(756, 341);
            this.Controls.Add(this.panelClanovi);
            this.Controls.Add(this.panelPozadina);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimumSize = new System.Drawing.Size(694, 252);
            this.Name = "frmPregledPosudjenihFilmovaPojedinogClana";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Pregled posuđenih filmova nekog člana";
            this.Load += new System.EventHandler(this.frmPregledPosudjenihFilmovaPojedinogClana_Load);
            this.panelPozadina.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosudjeniFilmovi)).EndInit();
            this.panelClanovi.ResumeLayout(false);
            this.panelClanovi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPozadina;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.DataGridView dgvPosudjeniFilmovi;
        internal System.Windows.Forms.Panel panelClanovi;
        private System.Windows.Forms.TextBox txtPretraziClanove;
        private System.Windows.Forms.Label lblPretraziClanove;
        internal System.Windows.Forms.DataGridView dgvClanovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImePrezime;
    }
}