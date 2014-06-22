using System;
using System.Text;
using System.Collections.Generic;
using System.Data.Common;

namespace Baza_podataka
{
    public class pogledPosudba
    {
        private int p_idPosudba;
        private int p_Clan_idClan; // vanjski kljuc
        private int p_Film_idFilm; // vanjski kljuc
        private string p_ime;
        private string p_prezime;
        private string p_email;
        private string p_telefon;
        private string p_naziv; 
        private string p_datum_posudbe;
        private string p_posudjen_do;
        private string p_datum_vracanja; 

        /// <summary>
        /// Konstruktor klase
        /// </summary>
        public pogledPosudba()
        {
            
        }

        /// <summary>
        /// Puni objekt sa podacima iz odgovorajućih tablica
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima iz tablica</param>
        public pogledPosudba(DbDataReader dr)
        {
            if (dr != null)
            {
                p_idPosudba = int.Parse(dr["idPosudba"].ToString());
                p_Clan_idClan = int.Parse(dr["Clan_idClan"].ToString());
                p_Film_idFilm = int.Parse(dr["Film_idFilm"].ToString());
                p_datum_posudbe = dr["datum_posudbe"].ToString();
                p_posudjen_do = dr["posudjen_do"].ToString();
                p_datum_vracanja = dr["datum_vracanja"].ToString();
                p_ime = dr["ime"].ToString();
                p_prezime = dr["prezime"].ToString();
                p_email = dr["email"].ToString();
                p_telefon = dr["telefon"].ToString();
                p_naziv = dr["naziv"].ToString();
            }

        }

        /// <summary>
        /// Jedinstveni identifikator posudbe
        /// </summary>
        public int idPosudba
        {
            get
            {
                return p_idPosudba;
            }
        }

        /// <summary>
        /// Jedinstveni identifikator clana
        /// </summary>
        public int Clan_idClan
        {
            get
            {
                return p_Clan_idClan;
            }
        }

        /// <summary>
        /// Jedinstveni identifikator filma
        /// </summary>
        public int Film_idFilm
        {
            get
            {
                return p_Film_idFilm;
            }
        }

        /// <summary>
        /// Ime osobe
        /// </summary>
        public string ime
        {
            get
            {
                return p_ime;
            }
        }

        /// <summary>
        /// Prezime osobe
        /// </summary>
        public string prezime
        {
            get
            {
                return p_prezime;
            }
        }

        /// <summary>
        /// Email osobe
        /// </summary>
        public string email
        {
            get
            {
                return p_email;
            }
        }

        /// <summary>
        /// Telefonski broj osobe
        /// </summary>
        public string telefon
        {
            get
            {
                return p_telefon;
            }
        }

        /// <summary>
        /// Naziv filma
        /// </summary>
        public string naziv
        {
            get
            {
                return p_naziv;
            }
        }

        /// <summary>
        /// Datum posudbe filma
        /// </summary>
        public string datum_posudbe
        {
            get
            {
                return p_datum_posudbe;
            }
        }

        /// <summary>
        /// Datum isteka posudbe filma
        /// </summary>
        public string posudjen_do
        {
            get
            {
                return p_posudjen_do;
            }
        }

        /// <summary>
        /// Datum vracanja posudjenog filma
        /// </summary>
        public string datum_vracanja
        {
            get
            {
                return p_datum_vracanja;
            }
        }

        /// <summary>
        /// Dohvaća sve posudbe i dohvaća sve potrebne podatke iz ostalih tablica i vraća ih u obliku generičke liste
        /// </summary>
        /// <param name="ne_vracene_samo">Dohvat filmova koji nisu vraćeni ako je true</param>
        /// <returns>Lista svih posudbi prosirena s atributima ostalih tablica s kojima je vezana</returns>
        public static List<pogledPosudba> DohvatiSvePosudbe(string dodatak="")
        {
            List<pogledPosudba> lista = new List<pogledPosudba>();
            string sqlUpit = "select idPosudba,p.Clan_idClan,p.Film_idFilm,ime,prezime,email,telefon,datum_posudbe,posudjen_do,datum_vracanja,f.naziv from Posudba p LEFT OUTER JOIN Clan c ON p.Clan_idClan = c.idClan LEFT OUTER JOIN Osoba o ON o.idOsoba = c.idOsoba LEFT OUTER JOIN Film f ON f.idFilm = p.Film_idFilm " + dodatak + " Group by 1;";
            DbDataReader dr = Baza_podataka.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                pogledPosudba pos = new pogledPosudba(dr);
                lista.Add(pos);
            }
            dr.Close();
            return lista;
        }

        /// <summary>
        /// Dohvaća sve posudbe i dohvaća sve potrebne podatke iz ostalih tablica i vraća ih u obliku generičke liste
        /// </summary>
        /// <param name="trazeniID">Jedinstveni identifikator clana prosljedjen kao string</param>
        /// <param name="ne_vracene_samo">Dohvat filmova koji nisu vraćeni ako je true</param>
        /// <returns>Lista svih posudbi nekog clana prosirena s atributima ostalih tablica s kojima je vezana</returns>
        public static List<pogledPosudba> DohvatiSvePosudbePremaClanu(string trazeniID, bool ne_vracene_samo = false)
        {
            List<pogledPosudba> lista = new List<pogledPosudba>();
            string dodatak="";
            if (ne_vracene_samo) dodatak = " and datum_vracanja=''";
            string sqlUpit = "select idPosudba,p.Clan_idClan,p.Film_idFilm,ime,prezime,email,telefon,datum_posudbe,posudjen_do,datum_vracanja,f.naziv from Posudba p LEFT OUTER JOIN Clan c ON p.Clan_idClan = c.idClan LEFT OUTER JOIN Osoba o ON o.idOsoba = c.idOsoba LEFT OUTER JOIN Film f ON f.idFilm = p.Film_idFilm where p.Clan_idClan = " + trazeniID + dodatak + " Group by 1;";
            DbDataReader dr = Baza_podataka.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                pogledPosudba pos = new pogledPosudba(dr);
                lista.Add(pos);
            }
            dr.Close();
            return lista;
        }

        /// <summary>
        /// Dohvaća sve posudbe do odabranog datuma i dohvaća sve potrebne podatke iz ostalih tablica i vraća ih u obliku generičke liste
        /// </summary>
        /// <param name="trazeniID">Jedinstveni identifikator clana prosljedjen kao string</param>
        /// <param name="ne_vracene_samo">Dohvat filmova koji nisu vraćeni ako je true</param>
        /// <returns>Lista svih posudbi nekog clana prosirena s atributima ostalih tablica s kojima je vezana</returns>
        public static List<pogledPosudba> DohvatiSvePosudbePremaRoku(double dana)
        {
            List<pogledPosudba> lista = new List<pogledPosudba>();
            DateTime datumSada = DateTime.Now.AddDays(dana);
            string sqlUpit = "select idPosudba,p.Clan_idClan,p.Film_idFilm,ime,prezime,email,telefon,datum_posudbe,posudjen_do,datum_vracanja,f.naziv from Posudba p LEFT OUTER JOIN Clan c ON p.Clan_idClan = c.idClan LEFT OUTER JOIN Osoba o ON o.idOsoba = c.idOsoba LEFT OUTER JOIN Film f ON f.idFilm = p.Film_idFilm where datum_vracanja='' Group by 1;";
            DbDataReader dr = Baza_podataka.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                pogledPosudba pos = new pogledPosudba(dr);
                DateTime datumBaza = DateTime.Parse(pos.posudjen_do);
                if (datumSada.ToShortDateString() == datumBaza.ToShortDateString())
                {
                    lista.Add(pos);
                }
            }
            dr.Close();
            return lista;
        }

        /// <summary>
        /// Dohvaća sve posudbe i dohvaća sve potrebne podatke iz ostalih tablica i vraća ih u obliku generičke liste
        /// </summary>
        /// <param name="trazeniID">Jedinstveni identifikator filma prosljedjen kao string</param>
        /// <param name="ne_vracene_samo">Dohvat filmova koji nisu vraćeni ako je true</param>
        /// <returns>Lista svih posudbi nekog filma prosirena s atributima ostalih tablica s kojima je vezana</returns>
        public static List<pogledPosudba> DohvatiSvePosudbePremaFilmu(string trazeniID, bool ne_vracene_samo = false)
        {
            List<pogledPosudba> lista = new List<pogledPosudba>();
            string dodatak = "";
            if (ne_vracene_samo) dodatak = " and datum_vracanja=''";
            string sqlUpit = "select idPosudba,p.Clan_idClan,p.Film_idFilm,ime,prezime,email,telefon,datum_posudbe,posudjen_do,datum_vracanja,f.naziv from Posudba p LEFT OUTER JOIN Clan c ON p.Clan_idClan = c.idClan LEFT OUTER JOIN Osoba o ON o.idOsoba = c.idOsoba LEFT OUTER JOIN Film f ON f.idFilm = p.Film_idFilm where p.Film_idFilm = " + trazeniID + dodatak + " Group by 1;";
            DbDataReader dr = Baza_podataka.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                pogledPosudba pos = new pogledPosudba(dr);
                lista.Add(pos);
            }
            dr.Close();
            return lista;
        }

    }
}
