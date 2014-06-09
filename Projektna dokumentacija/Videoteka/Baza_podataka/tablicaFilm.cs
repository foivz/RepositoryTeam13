using System;
using System.Text;
using System.Collections.Generic;
using System.Data.Common;

namespace Baza_podataka
{
    public class tablicaFilm
    {
        private int p_idFilm;
        private string p_naziv;
        private string p_sadrzaj;
        private int p_trajanje_u_min;
        private int p_kolicina_zaliha;
        private int p_idVrsta_filma; // vanjski kljuc
        // dodatak za pogled -> atribut iz druge tablice vrsta
        private string p_vrsta;



        /// <summary>
        /// Konstruktor klase
        /// </summary>
        public tablicaFilm()
        {
            
        }

        /// <summary>
        /// Puni objekt sa podacima iz tablice Film
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima iz tablice Film</param>
        public tablicaFilm(DbDataReader dr)
        {
            if (dr != null)
            {
                p_idFilm = int.Parse(dr["idFilm"].ToString());
                p_naziv = dr["naziv"].ToString();
                p_sadrzaj = dr["sadrzaj"].ToString();
                p_trajanje_u_min = int.Parse(dr["trajanje_u_min"].ToString());
                p_idVrsta_filma = int.Parse(dr["idVrsta_filma"].ToString());
                p_kolicina_zaliha = int.Parse(dr["kolicina_zaliha"].ToString());
            }
        }

        /// <summary>
        /// Puni objekt sa podacima iz tablice Film i Vrsta filma
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima iz tablice Film i Vrsta filma</param>
        public tablicaFilm(DbDataReader dr, bool pogled)
        {
            if (dr != null)
            {
                p_idFilm = int.Parse(dr["idFilm"].ToString());
                p_naziv = dr["naziv"].ToString();
                p_sadrzaj = dr["sadrzaj"].ToString();
                p_trajanje_u_min = int.Parse(dr["trajanje_u_min"].ToString());
                p_kolicina_zaliha = int.Parse(dr["kolicina_zaliha"].ToString());
                p_idVrsta_filma = int.Parse(dr["idVrsta_filma"].ToString());
                p_vrsta = dr["vrsta"].ToString();
            }
        }

        /// <summary>
        /// Jedinstveni identifikator filma
        /// </summary>
        public int idFilm
        {
            get
            {
                return p_idFilm;
            }
            private set
            {
                if (p_idFilm != value) p_idFilm = value;
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
            set
            {
                if (p_naziv != value) p_naziv = value;
            }
        }

        /// <summary>
        /// Jedinstveni identifikator vrste filma
        /// </summary>
        public int idVrsta_filma
        {
            get
            {
                return p_idVrsta_filma;
            }
            set
            {
                if (p_idVrsta_filma != value) p_idVrsta_filma = value;
            }
        }

        /// <summary>
        /// Vrsta filma uključena iz tablice Vrsta_filma
        /// </summary>
        public string vrsta
        {
            get
            {
                return p_vrsta;
            }
        }

        /// <summary>
        /// Trajanje filma u minutama
        /// </summary>
        public int trajanje_u_min
        {
            get
            {
                return p_trajanje_u_min;
            }
            set
            {
                if (p_trajanje_u_min != value) p_trajanje_u_min = value;
            }
        }

        /// <summary>
        /// Količina zaliha
        /// </summary>
        public int kolicina_zaliha
        {
            get
            {
                return p_kolicina_zaliha;
            }
            set
            {
                if (p_kolicina_zaliha != value) p_kolicina_zaliha = value;
            }
        }

        /// <summary>
        /// Kratki sadrzaj filma
        /// </summary>
        public string sadrzaj
        {
            get
            {
                return p_sadrzaj;
            }
            set
            {
                if (p_sadrzaj != value) p_sadrzaj = value;
            }
        }

        /// <summary>
        /// Sprema vrijednosti objekta u bazu
        /// </summary>
        /// <returns>Broj redaka koji su izmijenjeni ili dodani</returns>
        public int Spremi()
        {
            string sqlUpit = "";
            if (idFilm == 0) // Unos
            {
                sqlUpit = "INSERT INTO Film (naziv, sadrzaj, trajanje_u_min, kolicina_zaliha, idVrsta_filma) VALUES ('" + naziv + "','" + sadrzaj + "','" + trajanje_u_min + "', '" + kolicina_zaliha + "','" + idVrsta_filma + "')";
            }
            else // Ažuriranje
            {
                sqlUpit = "UPDATE Film SET naziv = '" + naziv
                + "', sadrzaj = '" + sadrzaj
                + "', trajanje_u_min = '" + trajanje_u_min
                + "', kolicina_zaliha = '" + kolicina_zaliha
                + "', idVrsta_filma = '" + idVrsta_filma
               + "' WHERE idFilm = " + idFilm;
            }

            return Baza_podataka.Instance.IzvrsiUpit(sqlUpit);
        }

        /// <summary>
        /// Briše objekt iz baze
        /// </summary>
        /// <returns>Broj obrisanih redaka</returns>
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Film WHERE idFilm = " + idFilm;
            return Baza_podataka.Instance.IzvrsiUpit(sqlDelete);
        }

        /// <summary>
        /// Dohvaća sve filmove iz baze i vraća ih u obliku generičke liste
        /// </summary>
        /// <returns>Lista filmova</returns>
        public static List<tablicaFilm> DohvatiFilmove()
        {
            List<tablicaFilm> lista = new List<tablicaFilm>();
            string sqlUpit = "SELECT * FROM Film";
            DbDataReader dr = Baza_podataka.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                tablicaFilm film = new tablicaFilm(dr);
                lista.Add(film);
            }            
            dr.Close();
            return lista;
        }

        /// <summary>
        /// Dohvaća sve filmove iz baze i vraća ih u obliku generičke liste
        /// </summary>
        /// <returns>Lista filmova s dodatkom vrste filma dohvaćene iz druge tablice</returns>
        public static List<tablicaFilm> pogledDohvatiFilmove()
        {
            List<tablicaFilm> lista = new List<tablicaFilm>();
            string sqlUpit = "SELECT idFilm,Film.naziv,sadrzaj,trajanje_u_min,kolicina_zaliha,Film.idVrsta_filma,v.naziv as 'vrsta' FROM Film LEFT OUTER JOIN Vrsta_filma v ON Film.idVrsta_filma = v.idVrsta_filma Group by 1;";
            DbDataReader dr = Baza_podataka.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                tablicaFilm film = new tablicaFilm(dr,true);
                lista.Add(film);
            }
            dr.Close();
            return lista;
        }

        /// <summary>
        /// Dohvaća film prema trazenom jedinstvenom identifikatoru
        /// </summary>
        /// <param name="trazeniID">Jedinstveni identifikator filma kao string</param>
        /// <returns>Film</returns>
        public static tablicaFilm DohvatiFilmPrekoID(string trazeniID)
        {
            string sqlUpit = "SELECT * FROM Film WHERE idFilm = " + trazeniID;
            tablicaFilm film = new tablicaFilm(Baza_podataka.Instance.DohvatiDataReader(sqlUpit));
            return film;
        }

        /// <summary>
        /// Metoda koja nadjačava ToString metodu
        /// </summary>
        /// <returns>Naziv filma</returns>
        public override string ToString()
        {
            return naziv.ToString();
        }




    }
}
