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
        private int id;
        public frmIzvjesaji()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor izvjestaja
        /// </summary>
        /// <param name="p_izvjestaj">0-Clanovi,1-filmovi,2-zaposlenici,3-svi posudjeni filmovi,4-svi vraceni filmovi,5-stanje videoteke,6-posudjeni filmovi člana</param>
        public frmIzvjesaji(int p_izvjestaj, int p_id = -1)
        {
            InitializeComponent();
            izvjestaj = p_izvjestaj;
            id = p_id;
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
                case 5: // stanje videoteke
                    this.Text = "Izvještaj - Stanje videoteke";
                    List<tablicaFilm> listaStanje = tablicaFilm.pogledDohvatiFilmove();
                    dsIzvjestaj.Value = listaStanje;
                    rvIzvjestaj.LocalReport.DataSources.Add(dsIzvjestaj);
                    rvIzvjestaj.LocalReport.ReportEmbeddedResource = "Videoteka.rpStanje.rdlc";
                    break;
                case 6: // posudjeni filmovi člana
                    this.Text = "Izvještaj - Posuđeni filmovi člana";
                    List<pogledPosudba> listaPosudbiClana = pogledPosudba.DohvatiSvePosudbePremaClanu(id.ToString(), true);
                    dsIzvjestaj.Value = listaPosudbiClana;
                    rvIzvjestaj.LocalReport.DataSources.Add(dsIzvjestaj);
                    rvIzvjestaj.LocalReport.ReportEmbeddedResource = "Videoteka.rpPosudba.rdlc";
                    break;
                case 7: // vraceni filmovi člana
                    this.Text = "Izvještaj - Vraćeni filmovi člana";
                    List<pogledPosudba> listaVraceniClana = pogledPosudba.DohvatiSvePosudbePremaClanu(id.ToString(), false);
                    dsIzvjestaj.Value = listaVraceniClana;
                    rvIzvjestaj.LocalReport.DataSources.Add(dsIzvjestaj);
                    rvIzvjestaj.LocalReport.ReportEmbeddedResource = "Videoteka.rpPosudbaVraceni.rdlc";
                    break;
                case 8: // racun posudba
                    this.Text = "Izvještaj - Potvrda za posuđeni film";
                    List<pogledPosudba> listaRacPos = pogledPosudba.DohvatiSvePosudbe(" where idPosudba='" + id.ToString() + "'");
                    dsIzvjestaj.Value = listaRacPos;
                    rvIzvjestaj.LocalReport.DataSources.Add(dsIzvjestaj);
                    rvIzvjestaj.LocalReport.ReportEmbeddedResource = "Videoteka.rpRacunPosudba.rdlc";
                    break;
                case 9: // racun clanarina
                    this.Text = "Izvještaj - Račun za članarinu";
                    List<pogledClanovi> listaRacClan = pogledClanovi.DohvatiClanaPremaID(id.ToString());
                    dsIzvjestaj.Value = listaRacClan;
                    rvIzvjestaj.LocalReport.DataSources.Add(dsIzvjestaj);
                    rvIzvjestaj.LocalReport.ReportEmbeddedResource = "Videoteka.rpRacunClanarina.rdlc";
                    break;
                case 10: // posudjeni filmovi prema roku vracanja 1-2-3 dana!
                    this.Text = "Izvještaj - Posuđeni filmovi člana";
                    List<pogledPosudba> listaPosudbaRok = pogledPosudba.DohvatiSvePosudbePremaRoku(double.Parse(id.ToString()));
                    dsIzvjestaj.Value = listaPosudbaRok;
                    rvIzvjestaj.LocalReport.DataSources.Add(dsIzvjestaj);
                    rvIzvjestaj.LocalReport.ReportEmbeddedResource = "Videoteka.rpPosudba.rdlc";
                    break;
            }
        }

        private void frmIzvjesaji_Load(object sender, EventArgs e)
        {
            this.rvIzvjestaj.RefreshReport();
        }
    }
}
