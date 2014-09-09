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
    public partial class frmPregledSvihFilmova : Form
    {
        public frmPregledSvihFilmova()
        {
            InitializeComponent();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Brisanje filma
        /// </summary>
        private void btnBrisi_Click(object sender, EventArgs e)
        {
            if (dgvFilmovi.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Jeste li sigurni da želite obrisati označeni film?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        tablicaFilm film = tablicaFilm.DohvatiFilmPrekoID(dgvFilmovi.SelectedRows[0].Cells["idFilm"].Value.ToString());
                        film.Obrisi();
                        frmPregledSvihFilmova_Load(null, null); // ponovno učitavanje podataka
                    }
                    catch
                    {
                        this.Text = "Pogreška pri brisanju filma";
                    }
                }
            }
        }

        /// <summary>
        /// Izmjena podataka
        /// </summary>
        private void dgvFilmovi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFilmovi.SelectedRows.Count == 1)
            {
                tablicaFilm film = tablicaFilm.DohvatiFilmPrekoID(dgvFilmovi.SelectedRows[0].Cells["idFilm"].Value.ToString());
                frmUnosFilma frmUnosFilma = new frmUnosFilma(film);
                frmUnosFilma.ShowDialog();
                frmPregledSvihFilmova_Load(null, null); // ponovno učitavanje podataka
            }
        }

        /// <summary>
        /// Učitavanje podataka
        /// </summary>
        private void frmPregledSvihFilmova_Load(object sender, EventArgs e)
        {
            try
            {
                // dohvat podataka preko tablice filmova
                List<tablicaFilm> listaFilmova = tablicaFilm.pogledDohvatiFilmove();
                dgvFilmovi.DataSource = listaFilmova;
                // preimenovanje stupaca i skrivanje identifikatora
                dgvFilmovi.Columns["idFilm"].Visible = false;
                dgvFilmovi.Columns["idVrsta_filma"].Visible = false;
                dgvFilmovi.Columns["naziv"].HeaderText = "Naziv filma";
                dgvFilmovi.Columns["sadrzaj"].HeaderText = "Sadržaj filma";
                dgvFilmovi.Columns["trajanje_u_min"].HeaderText = "Trajanje filma (min)";
                dgvFilmovi.Columns["kolicina_zaliha"].HeaderText = "Ukupno zaliha";
                dgvFilmovi.Columns["vrsta"].HeaderText = "Vrsta filma";
                dgvFilmovi.Columns["stanje"].HeaderText = "Stanje zaliha";

            }
            catch
            {
                this.Text = "Pogreška pri učitavanju podataka";
            }
        }
    }
}
