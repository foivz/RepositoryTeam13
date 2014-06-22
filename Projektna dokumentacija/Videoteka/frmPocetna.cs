using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using Baza_podataka;

namespace Videoteka
{
    public partial class frmPocetna : Form
    {
        int poslano = 0;
        public frmPocetna()
        {
            InitializeComponent();
        }

        private void frmPocetna_Load(object sender, EventArgs e)
        {
            // ucitavanje forme za prijavu
            frmPrijava frmPrijava = new frmPrijava();
            frmPrijava.ShowDialog();

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
            if (poslano == 0)
            {
                try
                {
                    List<pogledClanovi> listaClanova = pogledClanovi.DohvatiClanoveIstekClanarine();
                    if (listaClanova.Count > 0)
                    {
                        string naMailove = "";
                        foreach (pogledClanovi red in listaClanova)
                        {
                            naMailove = naMailove + red.email + ",";
                        }

                        if (MessageBox.Show("Poštovani, postoji " + listaClanova.Count.ToString() + " člana kojima ističe članarina u roku 2 dana, želite li okinuti slanje maila?", "Informacija", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // šalji mail
                            string sMaila = "nominasuntdiosag@gmail.com";
                            string lozinkaMail = "Lozinka1";
                            
                            MailMessage mail = new MailMessage();
                            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                            mail.From = new MailAddress(sMaila);

                            mail.To.Add(naMailove);
                            mail.Subject = "Notifikacijski mail";
                            mail.Body = "Poštovani ističe Vam članarina u videoteci!";

                            SmtpServer.Port = 587;
                            SmtpServer.Credentials = new System.Net.NetworkCredential(sMaila, lozinkaMail);
                            SmtpServer.EnableSsl = true;

                            SmtpServer.Send(mail);

                            MessageBox.Show("Email-ovi su poslani!");
                            
                        }
                        poslano = 1;
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Problem s slanjem e-maila!");
                }
            }

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
            poslano = 0;
            frmPocetna_Load(null, null);
        }

        private void pomocONamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // pokazi poruku o nama
            MessageBox.Show("Aplikaciju za kolegij Programsko inženjerstvo izradili članovi tima „Nomina sunt odiosa“.", "O nama", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void izvjestajStanjeVideotekeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ucitavanje forme
            frmIzvjesaji frmIzvjesaji = new frmIzvjesaji(5); // 4 - stanje videoteke
            frmIzvjesaji.MdiParent = this;
            frmIzvjesaji.Show();
        }

        private void izvjestajPosudjeniFilmoviZaNekogClanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ucitavanje forme
            frmPregledClanova frmPregledClanova = new frmPregledClanova(6); // 6-posudjeni
            frmPregledClanova.MdiParent = this;
            frmPregledClanova.Show();
        }

        private void izvjestajVraceniFilmoviZaNekogClanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ucitavanje forme
            frmPregledClanova frmPregledClanova = new frmPregledClanova(7); // 7-vraceni
            frmPregledClanova.MdiParent = this;
            frmPregledClanova.Show();
        }

        private void izvjestajPosudjeniFilmoviRok1danToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ucitavanje forme
            frmIzvjesaji frmIzvjesaji = new frmIzvjesaji(10, 1); // 10 - ispis posuđenih do roka od 1 dana
            frmIzvjesaji.MdiParent = this;
            frmIzvjesaji.Show();
        }

        private void izvjestajPosudjeniFilmoviRok2danaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ucitavanje forme
            frmIzvjesaji frmIzvjesaji = new frmIzvjesaji(10, 2); // 10 - ispis posuđenih do roka od 2 dana
            frmIzvjesaji.MdiParent = this;
            frmIzvjesaji.Show();
        }

        private void izvjestajPosudjeniFilmoviRok3danaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ucitavanje forme
            frmIzvjesaji frmIzvjesaji = new frmIzvjesaji(10, 3); // 10 - ispis posuđenih do roka od 3 dana
            frmIzvjesaji.MdiParent = this;
            frmIzvjesaji.Show();
        }

    }
}
