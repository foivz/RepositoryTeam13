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

        private void novaPosudbaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPosudbaNova frmPosudbaNova = new frmPosudbaNova();
            frmPosudbaNova.MdiParent = this;
            frmPosudbaNova.Show();
        }

        private void vracanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPosudbaVracanje frmPosudbaVracanje = new frmPosudbaVracanje();
            frmPosudbaVracanje.MdiParent = this;
            frmPosudbaVracanje.Show();
        }

        private void svihFilmovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledPosudjenihFilmovaSvihClanova frmPregledPosudjenihFilmovaSvihClanova = new frmPregledPosudjenihFilmovaSvihClanova();
            frmPregledPosudjenihFilmovaSvihClanova.MdiParent = this;
            frmPregledPosudjenihFilmovaSvihClanova.Show();
        }

        private void premaClanuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledPosudjenihFilmovaPojedinogClana frmPregledPosudjenihFilmovaPojedinogClana = new frmPregledPosudjenihFilmovaPojedinogClana();
            frmPregledPosudjenihFilmovaPojedinogClana.MdiParent = this;
            frmPregledPosudjenihFilmovaPojedinogClana.Show();
        }

        private void filmovaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPregledSvihFilmova frmPregledSvihFilmova = new frmPregledSvihFilmova();
            frmPregledSvihFilmova.MdiParent = this;
            frmPregledSvihFilmova.Show();
        }

        private void zaposlenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledZaposlenika frmPregledZaposlenika = new frmPregledZaposlenika();
            frmPregledZaposlenika.MdiParent = this;
            frmPregledZaposlenika.Show();
        }

        private void clanovaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPregledClanova frmPregledClanova = new frmPregledClanova();
            frmPregledClanova.MdiParent = this;
            frmPregledClanova.Show();
        }

        private void clanovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnosClana frmUnosClana = new frmUnosClana();
            frmUnosClana.MdiParent = this;
            frmUnosClana.Show();
        }

        private void filmovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnosFilma frmUnosFilma = new frmUnosFilma();
            frmUnosFilma.MdiParent = this;
            frmUnosFilma.Show();
        }

    }
}
