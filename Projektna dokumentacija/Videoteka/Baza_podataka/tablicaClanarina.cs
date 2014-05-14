using System;
using System.Text;
using System.Collections.Generic;
using System.Data.Common;


namespace Videoteka.Baza_podataka
{
    class tablicaClanarina
    {
        private int p_idMjClanarina;
        private float p_cijena;



        /// <summary>
        /// Konstruktor klase
        /// </summary>
        public tablicaClanarina()
        {
            
        }

        /// <summary>
        /// Puni objekt sa podacima iz tablice Clanarina
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima iz tablice Clanarina</param>
        public tablicaClanarina(DbDataReader dr)
        {
            if (dr != null)
            {
                p_idMjClanarina = int.Parse(dr["idMjClanarina"].ToString());
                p_cijena = int.Parse(dr["cijena"].ToString());
            }

        }

        /// <summary>
        /// Jedinstveni identifikator mjesecne clanarine
        /// </summary>
        public int idMjClanarina
        {
            get
            {
                return p_idMjClanarina;
            }
            private set
            {
                if (p_idMjClanarina != value) p_idMjClanarina = value;
            }
        }

        /// <summary>
        /// Cijena mjesecne clanarine
        /// </summary>
        public float cijena
        {
            get
            {
                return p_cijena;
            }
            set
            {
                if (p_cijena != value) p_cijena = value;
            }
        }


        /// <summary>
        /// Sprema vrijednosti objekta u bazu
        /// </summary>
        /// <returns>Broj redaka koji su izmijenjeni ili dodani</returns>
        public int Spremi()
        {
            string sqlUpit = "";
            if (idMjClanarina == 0) // Unos
            {
                sqlUpit = "INSERT INTO Clanarina (cijena) VALUES ('" + cijena + "')";
            }
            else // Ažuriranje
            {
                sqlUpit = "UPDATE Clanarina SET cijena = '" + cijena
               + "' WHERE idMjClanarina = " + idMjClanarina;
            }

            return Baza_podataka.Instance.IzvrsiUpit(sqlUpit);
        }

        /// <summary>
        /// Briše objekt iz baze
        /// </summary>
        /// <returns>Broj obrisanih redaka</returns>
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Clanarina WHERE idMjClanarina = " + idMjClanarina;
            return Baza_podataka.Instance.IzvrsiUpit(sqlDelete);
        }

        /// <summary>
        /// Dohvaća sve mjesecne clanarine i cijene iz baze i vraća ih u obliku generičke liste
        /// </summary>
        /// <returns>Lista mjesecnih clanarina s cijenama</returns>
        public static List<tablicaClanarina> DohvatiClanarine()
        {
            List<tablicaClanarina> lista = new List<tablicaClanarina>();
            string sqlUpit = "SELECT * FROM Clanarina";
            DbDataReader dr = Baza_podataka.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                tablicaClanarina zClana = new tablicaClanarina(dr);
                lista.Add(zClana);
            }            
            dr.Close();
            return lista;
        }

        /// <summary>
        /// Dohvaća clanarinu i cijenu prema trazenom jedinstvenom identifikatoru mjesecne clanarine
        /// </summary>
        /// <param name="trazeniID">Jedinstveni identifikator mjesecne clanarine</param>
        /// <returns>Trazena clanarina i cijena iste</returns>
        public static tablicaClanarina DohvatiClanarinuPrekoID(int trazeniID)
        {
            string sqlUpit = "SELECT * FROM Clanarina WHERE idMjClanarina = " + trazeniID.ToString();
            tablicaClanarina clanarina = new tablicaClanarina(Baza_podataka.Instance.DohvatiDataReader(sqlUpit));
            return clanarina;
        }


        /// <summary>
        /// Metoda koja nadjačava ToString metodu
        /// </summary>
        /// <returns>Cijena mjesecne clanarine</returns>
        public override string ToString()
        {
            return cijena.ToString();
        }



    }
}
