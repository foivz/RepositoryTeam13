using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videoteka
{
    public partial class frmPocetna : Form
    {
        public frmPocetna()
        {
            InitializeComponent();
        }

        private void posudbaNovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPosudbaNova frmPosudbaNova = new frmPosudbaNova();
            frmPosudbaNova.MdiParent = this;
            frmPosudbaNova.Show();
        }

        private void posudbaVracanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPosudbaVracanje frmPosudbaVracanje = new frmPosudbaVracanje();
            frmPosudbaVracanje.MdiParent = this;
            frmPosudbaVracanje.Show();
        }

        private void pregledPosudSvihFilmovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledPosudjenihFilmovaSvihClanova frmPregledPosudjenihFilmovaSvihClanova = new frmPregledPosudjenihFilmovaSvihClanova();
            frmPregledPosudjenihFilmovaSvihClanova.MdiParent = this;
            frmPregledPosudjenihFilmovaSvihClanova.Show();
        }

        private void pregledPosudPremaClanuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledPosudjenihFilmovaPojedinogClana frmPregledPosudjenihFilmovaPojedinogClana = new frmPregledPosudjenihFilmovaPojedinogClana();
            frmPregledPosudjenihFilmovaPojedinogClana.MdiParent = this;
            frmPregledPosudjenihFilmovaPojedinogClana.Show();
        }

        private void pregledSvihFilmovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledSvihFilmova frmPregledSvihFilmova = new frmPregledSvihFilmova();
            frmPregledSvihFilmova.MdiParent = this;
            frmPregledSvihFilmova.Show();
        }

        private void pregledZaposlenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledZaposlenika frmPregledZaposlenika = new frmPregledZaposlenika();
            frmPregledZaposlenika.MdiParent = this;
            frmPregledZaposlenika.Show();
        }

        private void pregledClanovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledClanova frmPregledClanova = new frmPregledClanova();
            frmPregledClanova.MdiParent = this;
            frmPregledClanova.Show();
        }

        private void unosClanovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnosClana frmUnosClana = new frmUnosClana();
            frmUnosClana.MdiParent = this;
            frmUnosClana.Show();
        }

        private void unosFilmovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnosFilma frmUnosFilma = new frmUnosFilma();
            frmUnosFilma.MdiParent = this;
            frmUnosFilma.Show();
        }

        private void frmPocetna_Load(object sender, EventArgs e)
        {
            frmPrijava frmPrijava = new frmPrijava();
            frmPrijava.ShowDialog();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
