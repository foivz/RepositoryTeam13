﻿namespace Videoteka
{
    partial class frmIzvjesaji
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
            this.rvIzvjestaj = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvIzvjestaj
            // 
            this.rvIzvjestaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvIzvjestaj.Location = new System.Drawing.Point(0, 0);
            this.rvIzvjestaj.Name = "rvIzvjestaj";
            this.rvIzvjestaj.Size = new System.Drawing.Size(711, 397);
            this.rvIzvjestaj.TabIndex = 0;
            // 
            // frmIzvjesaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 397);
            this.Controls.Add(this.rvIzvjestaj);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimumSize = new System.Drawing.Size(700, 266);
            this.Name = "frmIzvjesaji";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmIzvjesaji";
            this.Load += new System.EventHandler(this.frmIzvjesaji_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvIzvjestaj;
    }
}