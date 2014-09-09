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
    public partial class frmUnosFilma : Form
    {
        // inicjalizacija koristenih tablica iz baze
        private tablicaFilm film = null;

        public frmUnosFilma()
        {
            InitializeComponent();
            dohvatiPodatke(); // popunjavanje Vrste filma
        }

        public frmUnosFilma(tablicaFilm p_film)
        {
            InitializeComponent();
            // učitavaju se podaci za odabrani film kako bi se vršila promjena filma
            film = p_film;
            dohvatiPodatke();
        }

        private void dohvatiPodatke()
        {
            if (film != null)
            {
                txtNaziv.Text = film.naziv;
                txtTrajanje.Text = film.trajanje_u_min.ToString();
                txtKolicina.Text = film.kolicina_zaliha.ToString();
                txtSadrzaj.Text = film.sadrzaj;
                cbVrsta.SelectedValue = film.idVrsta_filma;
            }

            try
            {
                List<tablicaVrsta_filma> listaVrsta_filma = tablicaVrsta_filma.DohvatiVrste_filma();
                cbVrsta.DataSource = listaVrsta_filma;
                cbVrsta.DisplayMember = "naziv";
                cbVrsta.ValueMember = "idVrsta_filma";
            }
            catch
            {
                // greška pri dohvatu podataka
            }

        }

        private void txtTrajanje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true; // dopušta unos samo brojeva i korištenje backspace
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text == "" || txtKolicina.Text == "" || txtTrajanje.Text == "" || txtSadrzaj.Text == "")
            {
                MessageBox.Show("Prije pohrane morate popuniti sva polja!", "Pogreška...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {

                bool novi = false;
                // iniciranje objekata za unos novog filma
                if (film == null)
                {
                    film = new tablicaFilm();
                    novi = true;
                }

                // spremanje u tablicu film
                film.naziv = txtNaziv.Text;
                film.sadrzaj = txtSadrzaj.Text;
                film.trajanje_u_min = int.Parse(txtTrajanje.Text);
                film.kolicina_zaliha = int.Parse(txtKolicina.Text);
                film.idVrsta_filma = int.Parse(cbVrsta.SelectedValue.ToString());

                film.Spremi();

                if (novi) // nakon unosa pitanje za dodavanje jos jednog filma
                {
                    switch (MessageBox.Show("Želite li dodati još jedan film?", "Informacija...", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        case DialogResult.Yes:
                            film = null; // resetiramo objekte i brisemo polja
                            btnPobrisi_Click(null, null);
                            return; // preskacemo zatvaranje prozora odnosno nastavak izvrasavanja funkcije
                    }
                }
                // zatvaramo prozor nakon ažuriranja ili dodavanja
                this.Close();
            }
            catch (Exception)
            {
                // u slučaju pogreške ispis poruke
                MessageBox.Show("Film nije pohranjen, dogodila se pogreška pri spremanju filma!", "Pogreška...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPobrisi_Click(object sender, EventArgs e)
        {
            // ako se vrsi promjena podataka nekog filma dohvacaju se podaci iz baze
            if (film != null)
            {
                dohvatiPodatke();
            }
            else // brise sva polja ako se dodaje novi film
            {
                txtNaziv.Text = "";
                txtTrajanje.Text = "120";
                txtKolicina.Text = "1";
                txtSadrzaj.Text = "";
                cbVrsta.SelectedIndex = 0;
                txtNaziv.Focus();
            }
        }

    }
}
