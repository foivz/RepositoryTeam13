namespace Videoteka
{
    partial class frmPosudbaVracanje
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnVrati = new System.Windows.Forms.Button();
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
            this.lblPosudjenOdBaza = new System.Windows.Forms.Label();
            this.lblPosudjenOd = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.lblPosudjenDo = new System.Windows.Forms.Label();
            this.lblPosudjenDoBaza = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusBaza = new System.Windows.Forms.Label();
            this.colIDFilma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNazivFilma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posudbaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posudjenOd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posudjenDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelClanovi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).BeginInit();
            this.panelFilmovi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmovi)).BeginInit();
            this.panelPosudba.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVrati
            // 
            this.btnVrati.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVrati.Enabled = false;
            this.btnVrati.Location = new System.Drawing.Point(48, 134);
            this.btnVrati.Name = "btnVrati";
            this.btnVrati.Size = new System.Drawing.Size(130, 34);
            this.btnVrati.TabIndex = 8;
            this.btnVrati.Text = "VRATI";
            this.btnVrati.UseVisualStyleBackColor = true;
            this.btnVrati.Click += new System.EventHandler(this.btnVrati_Click);
            // 
            // panelClanovi
            // 
            this.panelClanovi.Controls.Add(this.txtPretraziClanove);
            this.panelClanovi.Controls.Add(this.lblPretraziClanove);
            this.panelClanovi.Controls.Add(this.dgvClanovi);
            this.panelClanovi.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelClanovi.Location = new System.Drawing.Point(0, 0);
            this.panelClanovi.Name = "panelClanovi";
            this.panelClanovi.Size = new System.Drawing.Size(210, 324);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClanovi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            this.dgvClanovi.Size = new System.Drawing.Size(210, 277);
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
            this.panelFilmovi.Size = new System.Drawing.Size(220, 324);
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFilmovi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDFilma,
            this.colNazivFilma,
            this.posudbaID,
            this.posudjenOd,
            this.posudjenDo});
            this.dgvFilmovi.Location = new System.Drawing.Point(10, 44);
            this.dgvFilmovi.MultiSelect = false;
            this.dgvFilmovi.Name = "dgvFilmovi";
            this.dgvFilmovi.ReadOnly = true;
            this.dgvFilmovi.RowHeadersVisible = false;
            this.dgvFilmovi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFilmovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilmovi.ShowCellToolTips = false;
            this.dgvFilmovi.ShowEditingIcon = false;
            this.dgvFilmovi.Size = new System.Drawing.Size(210, 277);
            this.dgvFilmovi.TabIndex = 5;
            this.dgvFilmovi.SelectionChanged += new System.EventHandler(this.dgvFilmovi_SelectionChanged);
            // 
            // panelPosudba
            // 
            this.panelPosudba.Controls.Add(this.lblStatusBaza);
            this.panelPosudba.Controls.Add(this.lblStatus);
            this.panelPosudba.Controls.Add(this.lblPosudjenDoBaza);
            this.panelPosudba.Controls.Add(this.lblPosudjenDo);
            this.panelPosudba.Controls.Add(this.lblPosudjenOdBaza);
            this.panelPosudba.Controls.Add(this.lblPosudjenOd);
            this.panelPosudba.Controls.Add(this.btnVrati);
            this.panelPosudba.Location = new System.Drawing.Point(436, 19);
            this.panelPosudba.Name = "panelPosudba";
            this.panelPosudba.Size = new System.Drawing.Size(229, 182);
            this.panelPosudba.TabIndex = 6;
            // 
            // lblPosudjenOdBaza
            // 
            this.lblPosudjenOdBaza.AutoSize = true;
            this.lblPosudjenOdBaza.BackColor = System.Drawing.Color.Pink;
            this.lblPosudjenOdBaza.Location = new System.Drawing.Point(4, 25);
            this.lblPosudjenOdBaza.Name = "lblPosudjenOdBaza";
            this.lblPosudjenOdBaza.Padding = new System.Windows.Forms.Padding(2);
            this.lblPosudjenOdBaza.Size = new System.Drawing.Size(55, 17);
            this.lblPosudjenOdBaza.TabIndex = 10;
            this.lblPosudjenOdBaza.Text = "-----------";
            // 
            // lblPosudjenOd
            // 
            this.lblPosudjenOd.AutoSize = true;
            this.lblPosudjenOd.Location = new System.Drawing.Point(4, 7);
            this.lblPosudjenOd.Name = "lblPosudjenOd";
            this.lblPosudjenOd.Size = new System.Drawing.Size(128, 13);
            this.lblPosudjenOd.TabIndex = 0;
            this.lblPosudjenOd.Text = "Datum posuđivanja filma:";
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZatvori.Location = new System.Drawing.Point(589, 289);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 10;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // lblPosudjenDo
            // 
            this.lblPosudjenDo.AutoSize = true;
            this.lblPosudjenDo.Location = new System.Drawing.Point(4, 45);
            this.lblPosudjenDo.Name = "lblPosudjenDo";
            this.lblPosudjenDo.Size = new System.Drawing.Size(99, 13);
            this.lblPosudjenDo.TabIndex = 0;
            this.lblPosudjenDo.Text = "Rok vraćanja filma:";
            // 
            // lblPosudjenDoBaza
            // 
            this.lblPosudjenDoBaza.AutoSize = true;
            this.lblPosudjenDoBaza.BackColor = System.Drawing.Color.Pink;
            this.lblPosudjenDoBaza.Location = new System.Drawing.Point(4, 63);
            this.lblPosudjenDoBaza.Name = "lblPosudjenDoBaza";
            this.lblPosudjenDoBaza.Padding = new System.Windows.Forms.Padding(2);
            this.lblPosudjenDoBaza.Size = new System.Drawing.Size(55, 17);
            this.lblPosudjenDoBaza.TabIndex = 10;
            this.lblPosudjenDoBaza.Text = "-----------";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(4, 83);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status:";
            // 
            // lblStatusBaza
            // 
            this.lblStatusBaza.AutoSize = true;
            this.lblStatusBaza.BackColor = System.Drawing.Color.SkyBlue;
            this.lblStatusBaza.Location = new System.Drawing.Point(4, 101);
            this.lblStatusBaza.Name = "lblStatusBaza";
            this.lblStatusBaza.Padding = new System.Windows.Forms.Padding(5);
            this.lblStatusBaza.Size = new System.Drawing.Size(61, 23);
            this.lblStatusBaza.TabIndex = 10;
            this.lblStatusBaza.Text = "-----------";
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
            // posudbaID
            // 
            this.posudbaID.HeaderText = "Posudba ID";
            this.posudbaID.Name = "posudbaID";
            this.posudbaID.ReadOnly = true;
            this.posudbaID.Visible = false;
            // 
            // posudjenOd
            // 
            this.posudjenOd.HeaderText = "posudjenOd";
            this.posudjenOd.Name = "posudjenOd";
            this.posudjenOd.ReadOnly = true;
            this.posudjenOd.Visible = false;
            // 
            // posudjenDo
            // 
            this.posudjenDo.HeaderText = "posudjenDo";
            this.posudjenDo.Name = "posudjenDo";
            this.posudjenDo.ReadOnly = true;
            this.posudjenDo.Visible = false;
            // 
            // frmPosudbaVracanje
            // 
            this.AcceptButton = this.btnVrati;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 324);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.panelPosudba);
            this.Controls.Add(this.panelFilmovi);
            this.Controls.Add(this.panelClanovi);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimumSize = new System.Drawing.Size(692, 280);
            this.Name = "frmPosudbaVracanje";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Unos posudbe";
            this.Load += new System.EventHandler(this.frmPosudbaVracanje_Load);
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

        private System.Windows.Forms.Button btnVrati;
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
        private System.Windows.Forms.Label lblPosudjenOd;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Label lblPosudjenOdBaza;
        private System.Windows.Forms.Label lblPosudjenDoBaza;
        private System.Windows.Forms.Label lblPosudjenDo;
        private System.Windows.Forms.Label lblStatusBaza;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDFilma;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNazivFilma;
        private System.Windows.Forms.DataGridViewTextBoxColumn posudbaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn posudjenOd;
        private System.Windows.Forms.DataGridViewTextBoxColumn posudjenDo;

    }
}