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
            this.btnPobrisi = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPobrisi
            // 
            this.btnPobrisi.Location = new System.Drawing.Point(561, 339);
            this.btnPobrisi.Name = "btnPobrisi";
            this.btnPobrisi.Size = new System.Drawing.Size(97, 23);
            this.btnPobrisi.TabIndex = 10;
            this.btnPobrisi.Text = "Pobriši";
            this.btnPobrisi.UseVisualStyleBackColor = true;
            this.btnPobrisi.Click += new System.EventHandler(this.btnPobrisi_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(458, 339);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(97, 23);
            this.btnSpremi.TabIndex = 9;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // frmPosudbaNova
            // 
            this.AcceptButton = this.btnSpremi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 396);
            this.Controls.Add(this.btnPobrisi);
            this.Controls.Add(this.btnSpremi);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPosudbaNova";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Unos posudbe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPobrisi;
        private System.Windows.Forms.Button btnSpremi;

    }
}