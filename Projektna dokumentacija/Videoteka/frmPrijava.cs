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
    public partial class frmPrijava : Form
    {
        private Boolean prijavljenKorisnik;
        List<tablicaZaposlenik> listaZaposlenika;

        public frmPrijava()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            // Provjera u listi zaposlenika
            foreach (tablicaZaposlenik zap in listaZaposlenika)
            {
                if (zap.korisnicko_ime == txtKorisnikoIme.Text && txtLozinka.Text == zap.lozinka)
                {
                    prijavljenKorisnik = true; // pronadjen u bazi -> prijavljen
                    break;
                }
            }

            // brisanje podataka iz polja za unos
            txtKorisnikoIme.Text = "";
            txtKorisnikoIme.Focus(); 
            txtLozinka.Text = "";


            if (prijavljenKorisnik == false) // I dalje nije prijavljen -> poruka
            {
                MessageBox.Show("Uneseno je krivo korisničko ime ili lozinka.", "Pogreška...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else // prijavljen -> zatvara se prozor
            {
                this.Close();
            }

        }

        private void frmPrijava_Load(object sender, EventArgs e)
        {
            // postavljanje da zaposlenik nije prijavljen prilikom ucitavanja prozora
            prijavljenKorisnik = false;
            try
            {
                // dohvacanje podataka iz baze u listu
                listaZaposlenika = tablicaZaposlenik.DohvatiZaposlenike();
            }
            catch
            {
                MessageBox.Show("Dohvat podataka iz baze nije uspješan!", "Pogreška...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void frmPrijava_FormClosing(object sender, FormClosingEventArgs e)
        {
            // zatvaramo aplikaciju ako korisnik nije prijavljen
            if (prijavljenKorisnik == false)
            {
                Application.Exit();
            }
        }

    }
}
