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
    public partial class frmPregledPosudjenihFilmovaSvihClanova : Form
    {
        public frmPregledPosudjenihFilmovaSvihClanova()
        {
            InitializeComponent();
        }

        private void frmPregledPosudjenihFilmovaSvihClanova_Load(object sender, EventArgs e)
        {
            try
            {
                // dohvat podataka preko pogleda zato što imamo nekoliko vezanih tablica
                List<pogledPosudba> listaPosudbi = pogledPosudba.DohvatiSvePosudbe();
                dgvPosudjeniFilmovi.DataSource = listaPosudbi;
                // preimenovanje stupaca i skrivanje identifikatora
                dgvPosudjeniFilmovi.Columns["idPosudba"].Visible = false;
                dgvPosudjeniFilmovi.Columns["Clan_idClan"].Visible = false;
                dgvPosudjeniFilmovi.Columns["Film_idFilm"].Visible = false;
                dgvPosudjeniFilmovi.Columns["naziv"].HeaderText = "Naziv filma";
                dgvPosudjeniFilmovi.Columns["datum_posudbe"].HeaderText = "Datum posudbe";
                dgvPosudjeniFilmovi.Columns["posudjen_do"].HeaderText = "Istek posudbe";
                dgvPosudjeniFilmovi.Columns["datum_vracanja"].HeaderText = "Film vraćen";
                dgvPosudjeniFilmovi.Columns["ime"].HeaderText = "Ime";
                dgvPosudjeniFilmovi.Columns["prezime"].HeaderText = "Prezime";
                dgvPosudjeniFilmovi.Columns["email"].HeaderText = "Email";
                dgvPosudjeniFilmovi.Columns["telefon"].HeaderText = "Telefon";

            }
            catch
            {
                this.Text = "Pogreška pri učitavanju podataka";
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
