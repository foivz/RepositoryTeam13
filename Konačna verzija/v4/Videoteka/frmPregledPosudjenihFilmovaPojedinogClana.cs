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
    public partial class frmPregledPosudjenihFilmovaPojedinogClana : Form
    {
        public frmPregledPosudjenihFilmovaPojedinogClana()
        {
            InitializeComponent();
        }

        private void frmPregledPosudjenihFilmovaPojedinogClana_Load(object sender, EventArgs e)
        {
            try
            {
                // učitava članove
                dgvClanovi.Rows.Clear();
                List<pogledClanovi> listaClanova = pogledClanovi.DohvatiClanove();
                foreach (pogledClanovi clan in listaClanova)
                {
                    dgvClanovi.Rows.Add(clan.idClan, clan.ToString());
                }
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

        /// <summary>
        /// Promjena selekcije člana
        /// </summary>
        private void dgvClanovi_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvClanovi.Rows.Count > 0 && dgvClanovi.DisplayedRowCount(false) > 0) // postoje članovi i u skladu su s pretraživačem
                {
                    // dohvat podataka preko pogleda zato što imamo nekoliko vezanih tablica
                    List<pogledPosudba> listaPosudbi = pogledPosudba.DohvatiSvePosudbePremaClanu(dgvClanovi.SelectedRows[0].Cells["id"].Value.ToString());
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

                    this.Text = "Pregled posuđenih filmova člana: " + dgvClanovi.SelectedRows[0].Cells["colImePrezime"].Value.ToString();
                }
            }
            catch
            {
                // pogreška pri selekciji člana
            }
        }

        /// <summary>
        /// Pretraživanje članova
        /// </summary>
        private void txtPretraziClanove_TextChanged(object sender, EventArgs e)
        {
            if (txtPretraziClanove.TextLength > 0) // postoji unos
            {
                foreach (DataGridViewRow red in dgvClanovi.Rows)
                {
                    if (red.Cells["colImePrezime"].Value.ToString().StartsWith(txtPretraziClanove.Text, StringComparison.CurrentCultureIgnoreCase))
                    {
                        red.Visible = true; // ako riječ počinje s unesem tekstom (neovisno o velikim/malim slovima) ostaje pokazano
                    }
                    else 
                    { 
                        red.Visible = false; // u suprotnom sakrivamo taj red
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow red in dgvClanovi.Rows) red.Visible = true; // svi redovi pokazani ako nema unosa
            }
        }

    }
}
