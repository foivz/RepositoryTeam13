using System;
using System.Text;
using System.Collections.Generic;
using System.Data.Common;


namespace Videoteka.Baza_podataka
{
    class tablicaFilm
    {
        private int p_idFilm;
        private string p_naziv;
        private string p_sadrzaj;
        private int p_trajanje_u_min;
        private int p_idVrsta_filma; // vanjski kljuc



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
        /// Sprema vrijednosti objekta u bazu
        /// </summary>
        /// <returns>Broj redaka koji su izmijenjeni ili dodani</returns>
        public int Spremi()
        {
            string sqlUpit = "";
            if (idFilm == 0) // Unos
            {
                sqlUpit = "INSERT INTO Film (naziv, sadrzaj, trajanje_u_min, idVrsta_filma) VALUES ('" + naziv + "','" + sadrzaj + "','" + trajanje_u_min + "','" + idVrsta_filma + "')";
            }
            else // Ažuriranje
            {
                sqlUpit = "UPDATE Film SET naziv = '" + naziv
                + "', sadrzaj = '" + sadrzaj
                + "', trajanje_u_min = '" + trajanje_u_min
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
        /// Dohvaća film prema trazenom jedinstvenom identifikatoru
        /// </summary>
        /// <param name="trazeniID">Jedinstveni identifikator filma</param>
        /// <returns>Film</returns>
        public static tablicaFilm DohvatiFilmPrekoID(int trazeniID)
        {
            string sqlUpit = "SELECT * FROM Film WHERE idFilm = " + trazeniID.ToString();
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
