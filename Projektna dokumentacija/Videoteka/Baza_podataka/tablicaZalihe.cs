using System;
using System.Text;
using System.Collections.Generic;
using System.Data.Common;


namespace Videoteka.Baza_podataka
{
    class tablicaZalihe
    {
        private int p_idFilm;
        private int p_kolicina;



        /// <summary>
        /// Konstruktor klase
        /// </summary>
        public tablicaZalihe()
        {
            
        }

        /// <summary>
        /// Puni objekt sa podacima iz tablice Zalihe
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima iz tablice Zalihe</param>
        public tablicaZalihe(DbDataReader dr)
        {
            if (dr != null)
            {
                p_idFilm = int.Parse(dr["idFilm"].ToString());
                p_kolicina = int.Parse(dr["kolicina"].ToString());
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
        /// Kolicina filmova u zalihama
        /// </summary>
        public int kolicina
        {
            get
            {
                return p_kolicina;
            }
            set
            {
                if (p_kolicina != value) p_kolicina = value;
            }
        }


        /// <summary>
        /// Sprema vrijednosti objekta u bazu
        /// </summary>
        /// <returns>Broj redaka koji su izmijenjeni ili dodani</returns>
        public int Spremi()
        {
            string sqlUpit = "";
            if (DohvatiZalihePrekoID(idFilm) == null) // Unos
            {
                sqlUpit = "INSERT INTO Zalihe (idFilm, kolicina) VALUES ('" + idFilm + "','" + kolicina + "')";
            }
            else // Ažuriranje
            {
                sqlUpit = "UPDATE Zalihe SET kolicina = '" + kolicina
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
            string sqlDelete = "DELETE FROM Zalihe WHERE idFilm = " + idFilm;
            return Baza_podataka.Instance.IzvrsiUpit(sqlDelete);
        }

        /// <summary>
        /// Dohvaća sve filmove i njihove količine iz baze i vraća ih u obliku generičke liste
        /// </summary>
        /// <returns>Lista filmova s kolicinama u zalihama</returns>
        public static List<tablicaZalihe> DohvatiZalihe()
        {
            List<tablicaZalihe> lista = new List<tablicaZalihe>();
            string sqlUpit = "SELECT * FROM Zalihe";
            DbDataReader dr = Baza_podataka.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                tablicaZalihe zFilm = new tablicaZalihe(dr);
                lista.Add(zFilm);
            }            
            dr.Close();
            return lista;
        }

        /// <summary>
        /// Dohvaća film s njegovim zalihama prema trazenom jedinstvenom identifikatoru filma
        /// </summary>
        /// <param name="trazeniID">Jedinstveni identifikator filma</param>
        /// <returns>Trazeni film i njegova kolicina u zalihama</returns>
        public static tablicaZalihe DohvatiZalihePrekoID(int trazeniID)
        {
            string sqlUpit = "SELECT * FROM Zalihe WHERE idFilm = " + trazeniID.ToString();
            tablicaZalihe zFilm = new tablicaZalihe(Baza_podataka.Instance.DohvatiDataReader(sqlUpit));
            return zFilm;
        }


        /// <summary>
        /// Metoda koja nadjačava ToString metodu
        /// </summary>
        /// <returns>Kolicina na zalihi</returns>
        public override string ToString()
        {
            return kolicina.ToString();
        }




    }
}
