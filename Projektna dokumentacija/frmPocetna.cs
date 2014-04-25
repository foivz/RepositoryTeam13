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

    }
}
