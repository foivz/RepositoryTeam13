namespace Videoteka
{
    partial class frmUnosClana
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
            this.lblIme = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.gbOsoba = new System.Windows.Forms.GroupBox();
            this.gbClanarina = new System.Windows.Forms.GroupBox();
            this.pickerMjClanarina = new System.Windows.Forms.DateTimePicker();
            this.lblClanarinaDo = new System.Windows.Forms.Label();
            this.txtMjClanarina = new System.Windows.Forms.TextBox();
            this.lblMjClanarina = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnPobrisi = new System.Windows.Forms.Button();
            this.gbOsoba.SuspendLayout();
            this.gbClanarina.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(17, 23);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(25, 13);
            this.lblIme.TabIndex = 4;
            this.lblIme.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(98, 20);
            this.txtIme.MaxLength = 45;
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(197, 21);
            this.txtIme.TabIndex = 1;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(17, 50);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(44, 13);
            this.lblPrezime.TabIndex = 6;
            this.lblPrezime.Text = "Prezime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(98, 47);
            this.txtPrezime.MaxLength = 45;
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(197, 21);
            this.txtPrezime.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(98, 73);
            this.txtEmail.MaxLength = 45;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(197, 21);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(17, 76);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(98, 99);
            this.txtTelefon.MaxLength = 45;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(197, 21);
            this.txtTelefon.TabIndex = 4;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(17, 102);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(43, 13);
            this.lblTelefon.TabIndex = 6;
            this.lblTelefon.Text = "Telefon";
            // 
            // gbOsoba
            // 
            this.gbOsoba.Controls.Add(this.txtTelefon);
            this.gbOsoba.Controls.Add(this.lblTelefon);
            this.gbOsoba.Controls.Add(this.txtIme);
            this.gbOsoba.Controls.Add(this.lblEmail);
            this.gbOsoba.Controls.Add(this.lblIme);
            this.gbOsoba.Controls.Add(this.lblPrezime);
            this.gbOsoba.Controls.Add(this.txtPrezime);
            this.gbOsoba.Controls.Add(this.txtEmail);
            this.gbOsoba.Location = new System.Drawing.Point(12, 12);
            this.gbOsoba.Name = "gbOsoba";
            this.gbOsoba.Size = new System.Drawing.Size(314, 158);
            this.gbOsoba.TabIndex = 0;
            this.gbOsoba.TabStop = false;
            this.gbOsoba.Text = "Osobni podaci";
            // 
            // gbClanarina
            // 
            this.gbClanarina.Controls.Add(this.pickerMjClanarina);
            this.gbClanarina.Controls.Add(this.lblClanarinaDo);
            this.gbClanarina.Controls.Add(this.txtMjClanarina);
            this.gbClanarina.Controls.Add(this.lblMjClanarina);
            this.gbClanarina.Location = new System.Drawing.Point(332, 12);
            this.gbClanarina.Name = "gbClanarina";
            this.gbClanarina.Size = new System.Drawing.Size(290, 158);
            this.gbClanarina.TabIndex = 1;
            this.gbClanarina.TabStop = false;
            this.gbClanarina.Text = "Podaci o članarini";
            // 
            // pickerMjClanarina
            // 
            this.pickerMjClanarina.Location = new System.Drawing.Point(19, 76);
            this.pickerMjClanarina.Name = "pickerMjClanarina";
            this.pickerMjClanarina.Size = new System.Drawing.Size(200, 21);
            this.pickerMjClanarina.TabIndex = 6;
            // 
            // lblClanarinaDo
            // 
            this.lblClanarinaDo.AutoSize = true;
            this.lblClanarinaDo.Location = new System.Drawing.Point(16, 55);
            this.lblClanarinaDo.Name = "lblClanarinaDo";
            this.lblClanarinaDo.Size = new System.Drawing.Size(77, 13);
            this.lblClanarinaDo.TabIndex = 6;
            this.lblClanarinaDo.Text = "Istek članarine";
            // 
            // txtMjClanarina
            // 
            this.txtMjClanarina.Location = new System.Drawing.Point(151, 20);
            this.txtMjClanarina.Name = "txtMjClanarina";
            this.txtMjClanarina.Size = new System.Drawing.Size(124, 21);
            this.txtMjClanarina.TabIndex = 5;
            this.txtMjClanarina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMjClanarina_KeyPress);
            // 
            // lblMjClanarina
            // 
            this.lblMjClanarina.AutoSize = true;
            this.lblMjClanarina.Location = new System.Drawing.Point(16, 23);
            this.lblMjClanarina.Name = "lblMjClanarina";
            this.lblMjClanarina.Size = new System.Drawing.Size(129, 13);
            this.lblMjClanarina.TabIndex = 6;
            this.lblMjClanarina.Text = "Mjesečna članarina (HRK)";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpremi.Location = new System.Drawing.Point(449, 199);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(97, 23);
            this.btnSpremi.TabIndex = 7;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnPobrisi
            // 
            this.btnPobrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPobrisi.Location = new System.Drawing.Point(552, 199);
            this.btnPobrisi.Name = "btnPobrisi";
            this.btnPobrisi.Size = new System.Drawing.Size(97, 23);
            this.btnPobrisi.TabIndex = 8;
            this.btnPobrisi.Text = "Pobriši";
            this.btnPobrisi.UseVisualStyleBackColor = true;
            this.btnPobrisi.Click += new System.EventHandler(this.btnPobrisi_Click);
            // 
            // frmUnosClana
            // 
            this.AcceptButton = this.btnSpremi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 234);
            this.Controls.Add(this.btnPobrisi);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.gbClanarina);
            this.Controls.Add(this.gbOsoba);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(670, 253);
            this.Name = "frmUnosClana";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Unos člana";
            this.gbOsoba.ResumeLayout(false);
            this.gbOsoba.PerformLayout();
            this.gbClanarina.ResumeLayout(false);
            this.gbClanarina.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.GroupBox gbOsoba;
        private System.Windows.Forms.GroupBox gbClanarina;
        private System.Windows.Forms.TextBox txtMjClanarina;
        private System.Windows.Forms.Label lblMjClanarina;
        private System.Windows.Forms.Label lblClanarinaDo;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnPobrisi;
        private System.Windows.Forms.DateTimePicker pickerMjClanarina;
    }
}