using System;
using System.Text;
using System.Collections.Generic;
using System.Data.Common;


namespace Videoteka.Baza_podataka
{
    class tablicaVrsta_filma
    {
        private int p_idVrsta_filma;
        private string p_naziv;



        /// <summary>
        /// Konstruktor klase
        /// </summary>
        public tablicaVrsta_filma()
        {
            
        }

        /// <summary>
        /// Puni objekt sa podacima iz tablice Vrsta_filma
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima iz tablice Vrsta_filma</param>
        public tablicaVrsta_filma(DbDataReader dr)
        {
            if (dr != null)
            {
                p_idVrsta_filma = int.Parse(dr["idVrsta_filma"].ToString());
                p_naziv = dr["naziv"].ToString();
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
            private set
            {
                if (p_idVrsta_filma != value) p_idVrsta_filma = value;
            }
        }

        /// <summary>
        /// Naziv vrste filma
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
        /// Sprema vrijednosti objekta u bazu
        /// </summary>
        /// <returns>Broj redaka koji su izmijenjeni ili dodani</returns>
        public int Spremi()
        {
            string sqlUpit = "";
            if (idVrsta_filma == 0) // Unos
            {
                sqlUpit = "INSERT INTO Vrsta_filma (naziv) VALUES ('" + naziv + "')";
            }
            else // Ažuriranje
            {
                sqlUpit = "UPDATE Vrsta_filma SET naziv = '" + naziv
               + "' WHERE idVrsta_filma = " + idVrsta_filma;
            }

            return Baza_podataka.Instance.IzvrsiUpit(sqlUpit);
        }

        /// <summary>
        /// Briše objekt iz baze
        /// </summary>
        /// <returns>Broj obrisanih redaka</returns>
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Vrsta_filma WHERE idVrsta_filma = " + idVrsta_filma;
            return Baza_podataka.Instance.IzvrsiUpit(sqlDelete);
        }

        /// <summary>
        /// Dohvaća sve vrste filmova iz baze i vraća ih u obliku generičke liste
        /// </summary>
        /// <returns>Lista vrsta filmova</returns>
        public static List<tablicaVrsta_filma> DohvatiVrste_filma()
        {
            List<tablicaVrsta_filma> lista = new List<tablicaVrsta_filma>();
            string sqlUpit = "SELECT * FROM Vrsta_filma";
            DbDataReader dr = Baza_podataka.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                tablicaVrsta_filma vrFilma = new tablicaVrsta_filma(dr);
                lista.Add(vrFilma);
            }            
            dr.Close();
            return lista;
        }

        /// <summary>
        /// Dohvaća vrstu filma i njezin naziv prema trazenom jedinstvenom identifikatoru vrste filma
        /// </summary>
        /// <param name="trazeniID">Jedinstveni identifikator vrste filma</param>
        /// <returns>Trazena vrsta filma s nazivom</returns>
        public static tablicaVrsta_filma DohvatiVrstu_filmaPrekoID(int trazeniID)
        {
            string sqlUpit = "SELECT * FROM Vrsta_filma WHERE idVrsta_filma = " + trazeniID.ToString();
            tablicaVrsta_filma vrFilma = new tablicaVrsta_filma(Baza_podataka.Instance.DohvatiDataReader(sqlUpit));
            return vrFilma;
        }


        /// <summary>
        /// Metoda koja nadjačava ToString metodu
        /// </summary>
        /// <returns>Naziv vrste filma</returns>
        public override string ToString()
        {
            return naziv.ToString();
        }



    }
}
