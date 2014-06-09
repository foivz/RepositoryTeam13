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
    public partial class frmPosudbaNova : Form
    {
        DateTime datum = DateTime.Now; // današnji datum
        public frmPosudbaNova()
        {
            InitializeComponent();
        }

        private void btnPosudi_Click(object sender, EventArgs e)
        {
            try
            {
                // stvaranje objekta za rad s tablicom Posudba
                tablicaPosudba posudba = new tablicaPosudba();

                // spremanje u tablicu posduba
                posudba.Clan_idClan = int.Parse(dgvClanovi.SelectedRows[0].Cells["id"].Value.ToString());
                posudba.Film_idFilm = int.Parse(dgvFilmovi.SelectedRows[0].Cells["colIDFilma"].Value.ToString());
                posudba.datum_posudbe = datum.ToShortDateString();
                posudba.posudjen_do = pickerPosudjenDo.Value.ToShortDateString();

                posudba.Spremi();

                if (MessageBox.Show("Film je posuđen, želite li posuditi još filmova?", "Informacija", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.Close();
                }
                else
                {
                    frmPosudbaNova_Load(null,null); // ponovno učitavanje podataka
                }

            }
            catch
            {
                // u slučaju pogreške ispis poruke
                MessageBox.Show("Posudba nije pohranjena, dogodila se pogreška pri spremanju!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmPosudbaNova_Load(object sender, EventArgs e)
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
                // učitava filmove
                dgvFilmovi.Rows.Clear();
                List<tablicaFilm> listaFilmova = tablicaFilm.DohvatiFilmove();
                foreach (tablicaFilm film in listaFilmova)
                {




                    dgvFilmovi.Rows.Add(film.idFilm, film.naziv,film.kolicina_zaliha);
                }
                lblOdabirDatum.Text = pickerPosudjenDo.Value.ToShortDateString();
                pickerPosudjenDo.Value = pickerPosudjenDo.MinDate = new DateTime(datum.Year, datum.Month, datum.Day);
            }
            catch
            {
                this.Text = "Pogreška pri učitavanju podataka";
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
            provjeriSelekciju();
        }

        /// <summary>
        /// Pretraživanje filmova
        /// </summary>
        private void txtPretraziFilm_TextChanged(object sender, EventArgs e)
        {
            if (txtPretraziFilm.TextLength > 0) // postoji unos
            {
                foreach (DataGridViewRow red in dgvFilmovi.Rows)
                {
                    if (red.Cells["colNazivFilma"].Value.ToString().StartsWith(txtPretraziFilm.Text, StringComparison.CurrentCultureIgnoreCase))
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
                foreach (DataGridViewRow red in dgvFilmovi.Rows) red.Visible = true; // svi redovi pokazani ako nema unosa
            }
            provjeriSelekciju();
        }

        private void dgvClanovi_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                lblOdabirClan.Text = dgvClanovi.SelectedRows[0].Cells["colImePrezime"].Value.ToString();
            }
            catch
            {
                // pogreška pri selekciji
            }

            provjeriSelekciju();
        }

        private void dgvFilmovi_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                lblOdabirFilm.Text = dgvFilmovi.SelectedRows[0].Cells["colNazivFilma"].Value.ToString();
            }
            catch
            {
                // pogreška pri selekciji
            } 
            provjeriSelekciju();
        }

        private void pickerPosudjenDo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                lblOdabirDatum.Text = pickerPosudjenDo.Value.ToShortDateString();
            }
            catch
            {
                // pogreška pri selekciji
            } 
            provjeriSelekciju();
        }

        /// <summary>
        /// Funkcija provjerava unos/selekciju te dopuštanje posuđivanje filma ukoliko su zahtjevi zadovoljeni
        /// </summary>
        private void provjeriSelekciju()
        {
            try
            {
                if (dgvClanovi.Rows.Count > 0 && dgvClanovi.DisplayedRowCount(false) > 0 && dgvFilmovi.Rows.Count > 0 && dgvFilmovi.DisplayedRowCount(false) > 0 && dgvClanovi.SelectedRows.Count == 1 && dgvFilmovi.SelectedRows.Count == 1 && dgvClanovi.SelectedRows[0].Visible == true && dgvFilmovi.SelectedRows[0].Visible == true) // postoje članovi,filmovi i u skladu su s pretraživačima, označen samo po 1 član i film
                {
                    btnPosudi.Enabled = true;
                }
                else
                {
                    btnPosudi.Enabled = false;
                }
            }
            catch
            {
                // pogreška pri selekciji
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
