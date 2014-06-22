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
    public partial class frmPosudbaVracanje : Form
    {
        DateTime datum = DateTime.Now; // današnji datum
        public frmPosudbaVracanje()
        {
            InitializeComponent();
        }

        private void btnVrati_Click(object sender, EventArgs e)
        {
            try
            {
                // stvaranje objekta za rad s tablicom Posudba
                tablicaPosudba posudba = tablicaPosudba.DohvatiPosudbuPrekoID(dgvFilmovi.SelectedRows[0].Cells["posudbaID"].Value.ToString());

                // spremanje u tablicu posudba
                posudba.datum_vracanja = datum.ToShortDateString();
                posudba.Spremi();

                int trenutni_id = int.Parse(dgvFilmovi.SelectedRows[0].Cells["posudbaID"].Value.ToString());

                // ucitavanje forme za ispis potvrde za vracanje
                frmIzvjesaji frmIzvjesaji = new frmIzvjesaji(8, trenutni_id); // 8 - potvrda vracanja
                //frmIzvjesaji.MdiParent = this.ParentForm;
                frmIzvjesaji.ShowDialog();

                if (MessageBox.Show("Film je vraćen, želite li vratiti još filmova?", "Informacija", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.Close();
                }
                else
                {
                    frmPosudbaVracanje_Load(null, null); // ponovno učitavanje podataka
                }
            }
            catch
            {
                // u slučaju pogreške ispis poruke
                MessageBox.Show("Posudba nije pohranjena, dogodila se pogreška pri spremanju!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmPosudbaVracanje_Load(object sender, EventArgs e)
        {
            // učitava članove
            dgvClanovi.Rows.Clear();
            List<pogledClanovi> listaClanova = pogledClanovi.DohvatiClanove();
            foreach (pogledClanovi clan in listaClanova)
            {
                dgvClanovi.Rows.Add(clan.idClan, clan.ToString());
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvClanovi_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvClanovi.Rows.Count > 0 && dgvClanovi.DisplayedRowCount(false) > 0) // postoje članovi i u skladu su s pretraživačem
                {
                    // dohvat podataka preko pogleda zato što imamo nekoliko vezanih tablica
                    dgvFilmovi.Rows.Clear();
                    List<pogledPosudba> listaPosudbi = pogledPosudba.DohvatiSvePosudbePremaClanu(dgvClanovi.SelectedRows[0].Cells["id"].Value.ToString(),true);
                    foreach (pogledPosudba pos in listaPosudbi)
                    {
                        dgvFilmovi.Rows.Add(pos.Film_idFilm, pos.naziv,pos.idPosudba,pos.datum_posudbe,pos.posudjen_do);
                    }
                }
            }
            catch
            {
                // pogreška pri selekciji člana
            }
            provjeriSelekciju();
        }

        /// <summary>
        /// Funkcija provjerava unos/selekciju te dopuštanje vraćanje filma ukoliko su zahtjevi zadovoljeni
        /// </summary>
        private void provjeriSelekciju()
        {
            try
            {
                if (dgvClanovi.Rows.Count > 0 && dgvClanovi.DisplayedRowCount(false) > 0 && dgvFilmovi.Rows.Count > 0 && dgvFilmovi.DisplayedRowCount(false) > 0 && dgvClanovi.SelectedRows.Count == 1 && dgvFilmovi.SelectedRows.Count == 1 && dgvClanovi.SelectedRows[0].Visible==true && dgvFilmovi.SelectedRows[0].Visible==true) // postoje članovi,filmovi i u skladu su s pretraživačima, označen samo po 1 član i film
                {
                    lblPosudjenDoBaza.Text = dgvFilmovi.SelectedRows[0].Cells["posudjenDo"].Value.ToString();
                    lblPosudjenOdBaza.Text = dgvFilmovi.SelectedRows[0].Cells["posudjenOd"].Value.ToString();
                    DateTime pDo = DateTime.Parse(lblPosudjenDoBaza.Text);

                    if (pDo > datum)
                    {
                        lblStatusBaza.Text = "Nema kašnjenja";
                    }
                    else
                    {
                        lblStatusBaza.Text = "Kasni: " + (datum-pDo).Days.ToString() + " dan(a)";
                    }
                    
                    btnVrati.Enabled = true;
                }
                else
                {
                    btnVrati.Enabled = false;
                }
            }
            catch
            {
                // pogreška pri selekciji
            }
        }

        private void dgvFilmovi_SelectionChanged(object sender, EventArgs e)
        {
            provjeriSelekciju();
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



    }
}
