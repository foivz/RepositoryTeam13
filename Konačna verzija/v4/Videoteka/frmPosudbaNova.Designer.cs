namespace Videoteka
{
    partial class frmPosudbaNova
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPosudi = new System.Windows.Forms.Button();
            this.panelClanovi = new System.Windows.Forms.Panel();
            this.txtPretraziClanove = new System.Windows.Forms.TextBox();
            this.lblPretraziClanove = new System.Windows.Forms.Label();
            this.dgvClanovi = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFilmovi = new System.Windows.Forms.Panel();
            this.txtPretraziFilm = new System.Windows.Forms.TextBox();
            this.lblPretraziFilm = new System.Windows.Forms.Label();
            this.dgvFilmovi = new System.Windows.Forms.DataGridView();
            this.panelPosudba = new System.Windows.Forms.Panel();
            this.lblOdabirDatum = new System.Windows.Forms.Label();
            this.lblOdabirFilm = new System.Windows.Forms.Label();
            this.lblOdabirClan = new System.Windows.Forms.Label();
            this.pickerPosudjenDo = new System.Windows.Forms.DateTimePicker();
            this.lblOdabir = new System.Windows.Forms.Label();
            this.lblPosudjenDo = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.colIDFilma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNazivFilma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelClanovi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).BeginInit();
            this.panelFilmovi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmovi)).BeginInit();
            this.panelPosudba.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPosudi
            // 
            this.btnPosudi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPosudi.Enabled = false;
            this.btnPosudi.Location = new System.Drawing.Point(49, 167);
            this.btnPosudi.Name = "btnPosudi";
            this.btnPosudi.Size = new System.Drawing.Size(130, 34);
            this.btnPosudi.TabIndex = 8;
            this.btnPosudi.Text = "POSUDI";
            this.btnPosudi.UseVisualStyleBackColor = true;
            this.btnPosudi.Click += new System.EventHandler(this.btnPosudi_Click);
            // 
            // panelClanovi
            // 
            this.panelClanovi.Controls.Add(this.txtPretraziClanove);
            this.panelClanovi.Controls.Add(this.lblPretraziClanove);
            this.panelClanovi.Controls.Add(this.dgvClanovi);
            this.panelClanovi.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelClanovi.Location = new System.Drawing.Point(0, 0);
            this.panelClanovi.Name = "panelClanovi";
            this.panelClanovi.Size = new System.Drawing.Size(210, 272);
            this.panelClanovi.TabIndex = 0;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClanovi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dgvClanovi.Size = new System.Drawing.Size(210, 225);
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
            // panelFilmovi
            // 
            this.panelFilmovi.Controls.Add(this.txtPretraziFilm);
            this.panelFilmovi.Controls.Add(this.lblPretraziFilm);
            this.panelFilmovi.Controls.Add(this.dgvFilmovi);
            this.panelFilmovi.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFilmovi.Location = new System.Drawing.Point(210, 0);
            this.panelFilmovi.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.panelFilmovi.Name = "panelFilmovi";
            this.panelFilmovi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelFilmovi.Size = new System.Drawing.Size(220, 272);
            this.panelFilmovi.TabIndex = 3;
            // 
            // txtPretraziFilm
            // 
            this.txtPretraziFilm.Location = new System.Drawing.Point(13, 19);
            this.txtPretraziFilm.Name = "txtPretraziFilm";
            this.txtPretraziFilm.ShortcutsEnabled = false;
            this.txtPretraziFilm.Size = new System.Drawing.Size(186, 21);
            this.txtPretraziFilm.TabIndex = 4;
            this.txtPretraziFilm.TextChanged += new System.EventHandler(this.txtPretraziFilm_TextChanged);
            // 
            // lblPretraziFilm
            // 
            this.lblPretraziFilm.AutoSize = true;
            this.lblPretraziFilm.Location = new System.Drawing.Point(13, 3);
            this.lblPretraziFilm.Name = "lblPretraziFilm";
            this.lblPretraziFilm.Size = new System.Drawing.Size(100, 13);
            this.lblPretraziFilm.TabIndex = 0;
            this.lblPretraziFilm.Text = "Pretraživanje filma:";
            // 
            // dgvFilmovi
            // 
            this.dgvFilmovi.AllowUserToAddRows = false;
            this.dgvFilmovi.AllowUserToDeleteRows = false;
            this.dgvFilmovi.AllowUserToResizeColumns = false;
            this.dgvFilmovi.AllowUserToResizeRows = false;
            this.dgvFilmovi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvFilmovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFilmovi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDFilma,
            this.colNazivFilma,
            this.kolicina});
            this.dgvFilmovi.Location = new System.Drawing.Point(10, 44);
            this.dgvFilmovi.MultiSelect = false;
            this.dgvFilmovi.Name = "dgvFilmovi";
            this.dgvFilmovi.ReadOnly = true;
            this.dgvFilmovi.RowHeadersVisible = false;
            this.dgvFilmovi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFilmovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilmovi.ShowCellToolTips = false;
            this.dgvFilmovi.ShowEditingIcon = false;
            this.dgvFilmovi.Size = new System.Drawing.Size(210, 225);
            this.dgvFilmovi.TabIndex = 5;
            this.dgvFilmovi.SelectionChanged += new System.EventHandler(this.dgvFilmovi_SelectionChanged);
            // 
            // panelPosudba
            // 
            this.panelPosudba.Controls.Add(this.lblOdabirDatum);
            this.panelPosudba.Controls.Add(this.lblOdabirFilm);
            this.panelPosudba.Controls.Add(this.lblOdabirClan);
            this.panelPosudba.Controls.Add(this.pickerPosudjenDo);
            this.panelPosudba.Controls.Add(this.lblOdabir);
            this.panelPosudba.Controls.Add(this.lblPosudjenDo);
            this.panelPosudba.Controls.Add(this.btnPosudi);
            this.panelPosudba.Location = new System.Drawing.Point(436, 19);
            this.panelPosudba.Name = "panelPosudba";
            this.panelPosudba.Size = new System.Drawing.Size(229, 228);
            this.panelPosudba.TabIndex = 6;
            // 
            // lblOdabirDatum
            // 
            this.lblOdabirDatum.AutoSize = true;
            this.lblOdabirDatum.BackColor = System.Drawing.Color.Pink;
            this.lblOdabirDatum.Location = new System.Drawing.Point(4, 126);
            this.lblOdabirDatum.Name = "lblOdabirDatum";
            this.lblOdabirDatum.Padding = new System.Windows.Forms.Padding(2);
            this.lblOdabirDatum.Size = new System.Drawing.Size(96, 17);
            this.lblOdabirDatum.TabIndex = 10;
            this.lblOdabirDatum.Text = "Odaberite datum!";
            // 
            // lblOdabirFilm
            // 
            this.lblOdabirFilm.AutoSize = true;
            this.lblOdabirFilm.BackColor = System.Drawing.Color.Pink;
            this.lblOdabirFilm.Location = new System.Drawing.Point(4, 104);
            this.lblOdabirFilm.Name = "lblOdabirFilm";
            this.lblOdabirFilm.Padding = new System.Windows.Forms.Padding(2);
            this.lblOdabirFilm.Size = new System.Drawing.Size(82, 17);
            this.lblOdabirFilm.TabIndex = 10;
            this.lblOdabirFilm.Text = "Odaberite film!";
            // 
            // lblOdabirClan
            // 
            this.lblOdabirClan.AutoSize = true;
            this.lblOdabirClan.BackColor = System.Drawing.Color.Pink;
            this.lblOdabirClan.Location = new System.Drawing.Point(4, 82);
            this.lblOdabirClan.Name = "lblOdabirClan";
            this.lblOdabirClan.Padding = new System.Windows.Forms.Padding(2);
            this.lblOdabirClan.Size = new System.Drawing.Size(91, 17);
            this.lblOdabirClan.TabIndex = 10;
            this.lblOdabirClan.Text = "Odaberite člana!";
            // 
            // pickerPosudjenDo
            // 
            this.pickerPosudjenDo.Location = new System.Drawing.Point(7, 24);
            this.pickerPosudjenDo.MinDate = new System.DateTime(2014, 5, 29, 0, 0, 0, 0);
            this.pickerPosudjenDo.Name = "pickerPosudjenDo";
            this.pickerPosudjenDo.Size = new System.Drawing.Size(200, 21);
            this.pickerPosudjenDo.TabIndex = 7;
            this.pickerPosudjenDo.Value = new System.DateTime(2014, 5, 29, 0, 0, 0, 0);
            this.pickerPosudjenDo.ValueChanged += new System.EventHandler(this.pickerPosudjenDo_ValueChanged);
            // 
            // lblOdabir
            // 
            this.lblOdabir.AutoSize = true;
            this.lblOdabir.Location = new System.Drawing.Point(4, 60);
            this.lblOdabir.Name = "lblOdabir";
            this.lblOdabir.Size = new System.Drawing.Size(69, 13);
            this.lblOdabir.TabIndex = 0;
            this.lblOdabir.Text = "Odabrali ste:";
            // 
            // lblPosudjenDo
            // 
            this.lblPosudjenDo.AutoSize = true;
            this.lblPosudjenDo.Location = new System.Drawing.Point(4, 7);
            this.lblPosudjenDo.Name = "lblPosudjenDo";
            this.lblPosudjenDo.Size = new System.Drawing.Size(112, 13);
            this.lblPosudjenDo.TabIndex = 0;
            this.lblPosudjenDo.Text = "Datum vraćanja filma:";
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZatvori.Location = new System.Drawing.Point(589, 237);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 10;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // colIDFilma
            // 
            this.colIDFilma.HeaderText = "ID";
            this.colIDFilma.Name = "colIDFilma";
            this.colIDFilma.ReadOnly = true;
            this.colIDFilma.Visible = false;
            // 
            // colNazivFilma
            // 
            this.colNazivFilma.HeaderText = "Naziv filma";
            this.colNazivFilma.Name = "colNazivFilma";
            this.colNazivFilma.ReadOnly = true;
            // 
            // kolicina
            // 
            this.kolicina.HeaderText = "kolicina";
            this.kolicina.Name = "kolicina";
            this.kolicina.ReadOnly = true;
            this.kolicina.Visible = false;
            // 
            // frmPosudbaNova
            // 
            this.AcceptButton = this.btnPosudi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 272);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.panelPosudba);
            this.Controls.Add(this.panelFilmovi);
            this.Controls.Add(this.panelClanovi);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimumSize = new System.Drawing.Size(692, 310);
            this.Name = "frmPosudbaNova";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Unos posudbe";
            this.Load += new System.EventHandler(this.frmPosudbaNova_Load);
            this.panelClanovi.ResumeLayout(false);
            this.panelClanovi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).EndInit();
            this.panelFilmovi.ResumeLayout(false);
            this.panelFilmovi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmovi)).EndInit();
            this.panelPosudba.ResumeLayout(false);
            this.panelPosudba.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPosudi;
        internal System.Windows.Forms.Panel panelClanovi;
        private System.Windows.Forms.TextBox txtPretraziClanove;
        private System.Windows.Forms.Label lblPretraziClanove;
        internal System.Windows.Forms.DataGridView dgvClanovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImePrezime;
        internal System.Windows.Forms.Panel panelFilmovi;
        private System.Windows.Forms.TextBox txtPretraziFilm;
        private System.Windows.Forms.Label lblPretraziFilm;
        internal System.Windows.Forms.DataGridView dgvFilmovi;
        private System.Windows.Forms.Panel panelPosudba;
        private System.Windows.Forms.DateTimePicker pickerPosudjenDo;
        private System.Windows.Forms.Label lblPosudjenDo;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Label lblOdabirDatum;
        private System.Windows.Forms.Label lblOdabirFilm;
        private System.Windows.Forms.Label lblOdabirClan;
        private System.Windows.Forms.Label lblOdabir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDFilma;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNazivFilma;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;

    }
}