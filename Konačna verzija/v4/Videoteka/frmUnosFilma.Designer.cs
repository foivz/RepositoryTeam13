namespace Videoteka
{
    partial class frmUnosFilma
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblTrajanje = new System.Windows.Forms.Label();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.lblVrsta = new System.Windows.Forms.Label();
            this.lblSadrzaj = new System.Windows.Forms.Label();
            this.btnPobrisi = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.cbVrsta = new System.Windows.Forms.ComboBox();
            this.txtSadrzaj = new System.Windows.Forms.RichTextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(109, 23);
            this.txtNaziv.MaxLength = 70;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(377, 21);
            this.txtNaziv.TabIndex = 1;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(18, 26);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(33, 13);
            this.lblNaziv.TabIndex = 6;
            this.lblNaziv.Text = "Naziv";
            // 
            // lblTrajanje
            // 
            this.lblTrajanje.AutoSize = true;
            this.lblTrajanje.Location = new System.Drawing.Point(18, 52);
            this.lblTrajanje.Name = "lblTrajanje";
            this.lblTrajanje.Size = new System.Drawing.Size(90, 13);
            this.lblTrajanje.TabIndex = 6;
            this.lblTrajanje.Text = "Trajanje (minute)";
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Location = new System.Drawing.Point(109, 49);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(124, 21);
            this.txtTrajanje.TabIndex = 2;
            this.txtTrajanje.Text = "120";
            this.txtTrajanje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrajanje_KeyPress);
            // 
            // lblVrsta
            // 
            this.lblVrsta.AutoSize = true;
            this.lblVrsta.Location = new System.Drawing.Point(18, 105);
            this.lblVrsta.Name = "lblVrsta";
            this.lblVrsta.Size = new System.Drawing.Size(32, 13);
            this.lblVrsta.TabIndex = 6;
            this.lblVrsta.Text = "Vrsta";
            // 
            // lblSadrzaj
            // 
            this.lblSadrzaj.AutoSize = true;
            this.lblSadrzaj.Location = new System.Drawing.Point(18, 130);
            this.lblSadrzaj.Name = "lblSadrzaj";
            this.lblSadrzaj.Size = new System.Drawing.Size(43, 13);
            this.lblSadrzaj.TabIndex = 6;
            this.lblSadrzaj.Text = "Sadržaj";
            // 
            // btnPobrisi
            // 
            this.btnPobrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPobrisi.Location = new System.Drawing.Point(427, 316);
            this.btnPobrisi.Name = "btnPobrisi";
            this.btnPobrisi.Size = new System.Drawing.Size(97, 23);
            this.btnPobrisi.TabIndex = 6;
            this.btnPobrisi.Text = "Pobriši";
            this.btnPobrisi.UseVisualStyleBackColor = true;
            this.btnPobrisi.Click += new System.EventHandler(this.btnPobrisi_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpremi.Location = new System.Drawing.Point(324, 316);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(97, 23);
            this.btnSpremi.TabIndex = 5;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // cbVrsta
            // 
            this.cbVrsta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVrsta.FormattingEnabled = true;
            this.cbVrsta.Location = new System.Drawing.Point(109, 103);
            this.cbVrsta.Name = "cbVrsta";
            this.cbVrsta.Size = new System.Drawing.Size(218, 21);
            this.cbVrsta.TabIndex = 3;
            // 
            // txtSadrzaj
            // 
            this.txtSadrzaj.Location = new System.Drawing.Point(109, 130);
            this.txtSadrzaj.MaxLength = 300;
            this.txtSadrzaj.Name = "txtSadrzaj";
            this.txtSadrzaj.Size = new System.Drawing.Size(377, 158);
            this.txtSadrzaj.TabIndex = 4;
            this.txtSadrzaj.Text = "";
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(18, 79);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(72, 13);
            this.lblKolicina.TabIndex = 6;
            this.lblKolicina.Text = "Količina zaliha";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(109, 76);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(124, 21);
            this.txtKolicina.TabIndex = 2;
            this.txtKolicina.Text = "1";
            this.txtKolicina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrajanje_KeyPress);
            // 
            // frmUnosFilma
            // 
            this.AcceptButton = this.btnSpremi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 351);
            this.Controls.Add(this.txtSadrzaj);
            this.Controls.Add(this.cbVrsta);
            this.Controls.Add(this.btnPobrisi);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.lblSadrzaj);
            this.Controls.Add(this.lblVrsta);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.txtTrajanje);
            this.Controls.Add(this.lblTrajanje);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(488, 383);
            this.Name = "frmUnosFilma";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Unos filma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblTrajanje;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.Label lblVrsta;
        private System.Windows.Forms.Label lblSadrzaj;
        private System.Windows.Forms.Button btnPobrisi;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.ComboBox cbVrsta;
        private System.Windows.Forms.RichTextBox txtSadrzaj;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.TextBox txtKolicina;
    }
}