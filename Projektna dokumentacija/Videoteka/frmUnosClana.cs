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
    public partial class frmUnosClana : Form
    {
        // inicjalizacija koristenih tablica iz baze
        private tablicaClan clan = null;
        private tablicaOsoba osoba = null;

        public frmUnosClana()
        {
            InitializeComponent();
            btnPobrisi_Click(null,null); // zbog korekcije isteka clanarine +1 mjesec
        }

        public frmUnosClana(tablicaClan p_clan)
        {
            InitializeComponent();
            // učitavaju se podaci za odabranog člana kako bi se vršila promjena istih
            clan = p_clan;
            osoba = tablicaOsoba.DohvatiOsobuPrekoID(clan.idOsoba);
            dohvatiPodatke();
        }

        private void dohvatiPodatke()
        {
            if (clan != null)
            {
                txtIme.Text = osoba.ime;
                txtPrezime.Text = osoba.prezime;
                txtEmail.Text = osoba.email;
                txtTelefon.Text = osoba.telefon;
                txtMjClanarina.Text = clan.MjClanarina.ToString();
                try
                {
                    pickerMjClanarina.Value = DateTime.Parse(clan.datum_isteka_clanarine);
                }
                catch
                {
                    // pogreška pri parsiranju datuma **
                }
            }
        }

        private void btnPobrisi_Click(object sender, EventArgs e)
        {
            // ako se vrsi promjena podataka nekog člana dohvacaju se podaci iz baze
            if (clan != null)
            {
                dohvatiPodatke();
            }
            else // brise sva polja ako se dodaje novi clan
            {
                txtIme.Text = "";
                txtPrezime.Text = "";
                txtEmail.Text = "";
                txtTelefon.Text = "";
                txtMjClanarina.Text = "50";
                DateTime datum = DateTime.Now.AddMonths(1); // današnji datum uvećan za 1 mjesec
                datum = new DateTime(datum.Year, datum.Month, 1);
                pickerMjClanarina.Value = datum;
                txtIme.Focus();
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (txtIme.Text == "" || txtPrezime.Text == "" || txtEmail.Text == "" || txtTelefon.Text == "" || txtMjClanarina.Text == "")
            {
                MessageBox.Show("Prije pohrane morate popuniti sva polja!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            float provjera;
            float.TryParse(txtMjClanarina.Text, out provjera); // provjera unosa mjesečne članarine da su samo brojevi
            if (provjera == 0) // 0 pogreska
            {
                MessageBox.Show("Neispravan unos iznosa mjesečne članarine!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMjClanarina.Focus();
                return;
            }
            
            try
            {

                bool novi = false;
                // iniciranje objekata za unos novog člana
                if (clan == null)
                {
                    osoba = new tablicaOsoba();
                    clan = new tablicaClan();
                    DateTime datum = DateTime.Now; // današnji datum
                    clan.datum_uclanjenja = datum.ToShortDateString();
                    novi = true;
                }

                // spremanje u tablicu osoba
                osoba.ime = txtIme.Text;
                osoba.prezime = txtPrezime.Text;
                osoba.email = txtEmail.Text;
                osoba.telefon = txtTelefon.Text;

                osoba.Spremi();

                if (novi)
                {
                    // dohvaca automatski generirani id za osobu
                    int osobaID = osoba.DohvatiZadnjiID();
                    // spremanje u tablicu clan
                    clan.idOsoba = osobaID;
                }

                clan.datum_isteka_clanarine = pickerMjClanarina.Value.ToShortDateString();
                clan.MjClanarina = float.Parse(txtMjClanarina.Text);
                    
                clan.Spremi();

                if (novi) // nakon unosa pitanje za dodavanje jos jednog člana
                {
                    switch (MessageBox.Show("Želite li dodati još jednog člana?", "Informacija", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        case DialogResult.Yes:
                            osoba = null; // resetiramo objekte i brisemo polja
                            clan = null;
                            btnPobrisi_Click(null,null);
                            return; // preskacemo zatvaranje prozora odnosno nastavak izvrasavanja funkcije
                    }
                }
                // zatvaramo prozor nakon ažuriranja ili dodavanja
                this.Close();
            }
            catch (Exception)
            {
                // u slučaju pogreške ispis poruke
                MessageBox.Show("Član nije pohranjen, dogodila se pogreška pri spremanju člana!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMjClanarina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar!=Convert.ToChar(Keys.Back)) 
            {
                e.Handled = true; // dopušta unos samo brojeva i korištenje backspace
            }
        }

    }
}
