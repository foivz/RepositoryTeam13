using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Baza_podataka;

namespace Videoteka
{
    public partial class frmPregledZaposlenika : Form
    {
        public frmPregledZaposlenika()
        {
            InitializeComponent();
        }
        
        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        /// <summary>
        /// Učitavanje podataka
        /// </summary>
        private void frmPregledZaposlenika_Load(object sender, EventArgs e)
        {
            try
            {
                // dohvat podataka preko pogleda zato sto imamo 2 tablice za spojiti
                List<pogledZaposlenici> listaZap = pogledZaposlenici.DohvatiZaposlenike();
                dgvZaposlenici.DataSource = listaZap;
                // preimenovanje stupaca i skrivanje identifikatora
                dgvZaposlenici.Columns["idZaposlenik"].Visible = false;
                dgvZaposlenici.Columns["idOsoba"].Visible = false;
                dgvZaposlenici.Columns["datum_zaposljenja"].HeaderText = "Datum zapošljenja";
                dgvZaposlenici.Columns["prezime"].HeaderText = "Prezime";
                dgvZaposlenici.Columns["email"].HeaderText = "Email";
                dgvZaposlenici.Columns["telefon"].HeaderText = "Telefon";
                dgvZaposlenici.Columns["ime"].HeaderText = "Ime";

            }
            catch
            {
                this.Text = "Pogreška pri učitavanju podataka";
            }
        }
    }
}
