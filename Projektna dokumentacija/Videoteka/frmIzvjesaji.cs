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
    public partial class frmIzvjesaji : Form
    {
        private int izvjestaj;
        public frmIzvjesaji()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor izvjestaja
        /// </summary>
        /// <param name="p_izvjestaj">0-Clanovi,1-</param>
        public frmIzvjesaji(int p_izvjestaj)
        {
            InitializeComponent();
            izvjestaj = p_izvjestaj;
            pozoviIzvjestaj();
        }
        /// <summary>
        /// Postavlja odgovarajući izvještaj
        /// </summary>
        private void pozoviIzvjestaj()
        {
            Microsoft.Reporting.WinForms.ReportDataSource dsIzvjestaj = new Microsoft.Reporting.WinForms.ReportDataSource();
            dsIzvjestaj.Name = "dsBaza_podataka";
            switch (izvjestaj)
            {
                case 0: // clanovi
                    this.Text = "Izvještaj - Članovi";
                    List<pogledClanovi> listaClanova = pogledClanovi.DohvatiClanove();
                    dsIzvjestaj.Value = listaClanova;
                    rvIzvjestaj.LocalReport.DataSources.Add(dsIzvjestaj);
                    rvIzvjestaj.LocalReport.ReportEmbeddedResource = "Videoteka.rpClanovi.rdlc";
                    break;
                case 1: // filmovi
                    this.Text = "Izvještaj - Filmovi";
                    List<tablicaFilm> listaFilmova = tablicaFilm.pogledDohvatiFilmove();
                    dsIzvjestaj.Value = listaFilmova;
                    rvIzvjestaj.LocalReport.DataSources.Add(dsIzvjestaj);
                    rvIzvjestaj.LocalReport.ReportEmbeddedResource = "Videoteka.rpFilmovi.rdlc";
                    break;
                case 2: // zaposlenici
                    this.Text = "Izvještaj - Zaposlenici";
                    List<pogledZaposlenici> listaZap = pogledZaposlenici.DohvatiZaposlenike();
                    dsIzvjestaj.Value = listaZap;
                    rvIzvjestaj.LocalReport.DataSources.Add(dsIzvjestaj);
                    rvIzvjestaj.LocalReport.ReportEmbeddedResource = "Videoteka.rpZaposlenici.rdlc";
                    break;
                case 3: // svi posudjeni filmovi
                    this.Text = "Izvještaj - Svi posuđeni filmovi";
                    List<pogledPosudba> listaPosudbi = pogledPosudba.DohvatiSvePosudbe(" where datum_vracanja=''");
                    dsIzvjestaj.Value = listaPosudbi;
                    rvIzvjestaj.LocalReport.DataSources.Add(dsIzvjestaj);
                    rvIzvjestaj.LocalReport.ReportEmbeddedResource = "Videoteka.rpPosudba.rdlc";
                    break;
                case 4: // svi vraceni filmovi
                    this.Text = "Izvještaj - Svi vraćeni filmovi";
                    List<pogledPosudba> listaVraceni = pogledPosudba.DohvatiSvePosudbe(" where datum_vracanja!=''");
                    dsIzvjestaj.Value = listaVraceni;
                    rvIzvjestaj.LocalReport.DataSources.Add(dsIzvjestaj);
                    rvIzvjestaj.LocalReport.ReportEmbeddedResource = "Videoteka.rpPosudbaVraceni.rdlc";
                    break;
            }
        }

        private void frmIzvjesaji_Load(object sender, EventArgs e)
        {
            this.rvIzvjestaj.RefreshReport();
        }
    }
}
