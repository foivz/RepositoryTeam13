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
    public partial class frmPregledClanova : Form
    {
        int pregled;
        public frmPregledClanova()
        {
            InitializeComponent();
            pregled = -1;
        }

        public frmPregledClanova(int p_pregled)
        {
            InitializeComponent();
            pregled = p_pregled;
            btnIspis.Visible = btnBrisi.Visible = false;

        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Učitavanje podataka
        /// </summary>
        private void frmPregledClanova_Load(object sender, EventArgs e)
        {
            try
            {
                // dohvat podataka preko pogleda zato sto imamo 2 tablice za spojiti
                List<pogledClanovi> listaClanova = pogledClanovi.DohvatiClanove();
                dgvClanovi.DataSource = listaClanova;
                // preimenovanje stupaca i skrivanje identifikatora
                dgvClanovi.Columns["idClan"].Visible = false;
                dgvClanovi.Columns["idOsoba"].Visible = false;
                dgvClanovi.Columns["ime"].HeaderText = "Ime";
                dgvClanovi.Columns["prezime"].HeaderText = "Prezime";
                dgvClanovi.Columns["email"].HeaderText = "Email";
                dgvClanovi.Columns["telefon"].HeaderText = "Telefon"; 
                dgvClanovi.Columns["MjClanarina"].HeaderText = "Iznos mjesečne članarine";
                dgvClanovi.Columns["datum_uclanjenja"].HeaderText = "Datum učlanjenja";
                dgvClanovi.Columns["datum_isteka_clanarine"].HeaderText = "Datum isteka članarine";


            }
            catch
            {
                this.Text = "Pogreška pri učitavanju podataka";
            }
        }
        
        /// <summary>
        /// Brisanje člana
        /// </summary>
        private void btnBrisi_Click(object sender, EventArgs e)
        {
            if (dgvClanovi.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Jeste li sigurni da želite obrisati označenog člana?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        tablicaClan clan = tablicaClan.DohvatiClanaPrekoID(dgvClanovi.SelectedRows[0].Cells["idClan"].Value.ToString());
                        tablicaOsoba osoba = tablicaOsoba.DohvatiOsobuPrekoID(clan.idOsoba);
                        clan.Obrisi();
                        osoba.Obrisi(); // brisanje iz obadvije tablice
                        frmPregledClanova_Load(null, null); // ponovno učitavanje podataka
                    }
                    catch
                    {
                        this.Text = "Pogreška pri brisanju člana";
                    }
                }
            }
        }

        /// <summary>
        /// Izmjena podataka
        /// </summary>
        private void dgvClanovi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClanovi.SelectedRows.Count == 1)
            {
                if (pregled == -1)
                {
                    tablicaClan clan = tablicaClan.DohvatiClanaPrekoID(dgvClanovi.SelectedRows[0].Cells["idClan"].Value.ToString());
                    frmUnosClana frmUnosClana = new frmUnosClana(clan);
                    frmUnosClana.ShowDialog();
                    frmPregledClanova_Load(null, null); // ponovno učitavanje podataka
                }
                else
                {
                    // ucitavanje forme
                    frmIzvjesaji frmIzvjesaji = new frmIzvjesaji(pregled,int.Parse(dgvClanovi.SelectedRows[0].Cells["idClan"].Value.ToString()));
                    frmIzvjesaji.MdiParent = this.ParentForm;
                    frmIzvjesaji.Show();
                }
            }
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            if (dgvClanovi.SelectedRows.Count == 1)
            {
                // ucitavanje forme
                frmIzvjesaji frmIzvjesaji = new frmIzvjesaji(9, int.Parse(dgvClanovi.SelectedRows[0].Cells["idClan"].Value.ToString()));
                frmIzvjesaji.MdiParent = this.ParentForm;
                frmIzvjesaji.Show();
            }
        }





    }
}
