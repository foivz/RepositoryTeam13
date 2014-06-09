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
    public partial class frmPocetna : Form
    {
        public frmPocetna()
        {
            InitializeComponent();
        }

        private void frmPocetna_Load(object sender, EventArgs e)
        {
            // ucitavanje forme za prijavu
            frmPrijava frmPrijava = new frmPrijava();
            frmPrijava.ShowDialog();

            string br = "2";
            if (MessageBox.Show("Poštovani, " + br + " članova ističe članarina okinuti slanje maila?", "Informacija", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // šalji mail
            }
        }

        private void posudbaNovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ucitavanje forme
            frmPosudbaNova frmPosudbaNova = new frmPosudbaNova();
            frmPosudbaNova.MdiParent = this;
            frmPosudbaNova.Show();
        }

        private void posudbaVracanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ucitavanje forme
            frmPosudbaVracanje frmPosudbaVracanje = new frmPosudbaVracanje();
            frmPosudbaVracanje.MdiParent = this;
            frmPosudbaVracanje.Show();
        }

        private void pregledPosudSvihFilmovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ucitavanje forme
            frmPregledPosudjenihFilmovaSvihClanova frmPregledPosudjenihFilmovaSvihClanova = new frmPregledPosudjenihFilmovaSvihClanova();
            frmPregledPosudjenihFilmovaSvihClanova.MdiParent = this;
            frmPregledPosudjenihFilmovaSvihClanova.Show();
        }

        private void pregledPosudPremaClanuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ucitavanje forme
            frmPregledPosudjenihFilmovaPojedinogClana frmPregledPosudjenihFilmovaPojedinogClana = new frmPregledPosudjenihFilmovaPojedinogClana();
            frmPregledPosudjenihFilmovaPojedinogClana.MdiParent = this;
            frmPregledPosudjenihFilmovaPojedinogClana.Show();
        }

        private void pregledSvihFilmovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ucitavanje forme
            frmPregledSvihFilmova frmPregledSvihFilmova = new frmPregledSvihFilmova();
            frmPregledSvihFilmova.MdiParent = this;
            frmPregledSvihFilmova.Show();
        }

        private void pregledZaposlenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ucitavanje forme
            frmPregledZaposlenika frmPregledZaposlenika = new frmPregledZaposlenika();
            frmPregledZaposlenika.MdiParent = this;
            frmPregledZaposlenika.Show();
        }

        private void pregledClanovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ucitavanje forme
            frmPregledClanova frmPregledClanova = new frmPregledClanova();
            frmPregledClanova.MdiParent = this;
            frmPregledClanova.Show();
        }

        private void unosClanovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ucitavanje forme
            frmUnosClana frmUnosClana = new frmUnosClana();
            frmUnosClana.MdiParent = this;
            frmUnosClana.Show();
        }

        private void unosFilmovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ucitavanje forme
            frmUnosFilma frmUnosFilma = new frmUnosFilma();
            frmUnosFilma.MdiParent = this;
            frmUnosFilma.Show();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // odjava -> prikaz forme za ponovnu prijavu
            frmPocetna_Load(null, null);
        }

        private void pomocONamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // pokazi poruku o nama
            MessageBox.Show("Aplikaciju za kolegij Programsko inženjerstvo izradili članovi tima CC.", "O nama", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pomocDokumentacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // pokreni dokumentaciju
                System.Diagnostics.Process.Start("dokumentacija.pdf");
            }
            catch // u slucaju pogreske
            {
                pomocONamaToolStripMenuItem_Click(null,null);
            }
        }

        private void izvjestajSviClanoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ucitavanje forme
            frmIzvjesaji frmIzvjesaji = new frmIzvjesaji(0); // 0 - svi clanovi
            frmIzvjesaji.MdiParent = this;
            frmIzvjesaji.Show();
        }

        private void izvjestajSviFilmoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ucitavanje forme
            frmIzvjesaji frmIzvjesaji = new frmIzvjesaji(1); // 1 - svi filmovi
            frmIzvjesaji.MdiParent = this;
            frmIzvjesaji.Show();
        }

        private void izvjestajSviZaposleniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ucitavanje forme
            frmIzvjesaji frmIzvjesaji = new frmIzvjesaji(2); // 2 - svi zaposlenici
            frmIzvjesaji.MdiParent = this;
            frmIzvjesaji.Show();
        }

        private void izvjestajSviPosudjeniFilmoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ucitavanje forme
            frmIzvjesaji frmIzvjesaji = new frmIzvjesaji(3); // 3 - svi posuđeni filmovi
            frmIzvjesaji.MdiParent = this;
            frmIzvjesaji.Show();
        }

        private void izvjestajSviVraceniFilmoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ucitavanje forme
            frmIzvjesaji frmIzvjesaji = new frmIzvjesaji(4); // 4 - svi vraćeni filmovi
            frmIzvjesaji.MdiParent = this;
            frmIzvjesaji.Show();
        }

    }
}
