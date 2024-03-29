﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Data.Common;


namespace Videoteka.Baza_podataka
{
    class tablicaClan
    {
        private int p_idClan;
        private int p_idOsoba; // vanjski kljuc
        private int p_idMjClanarina; // vanjski kljuc
        private string p_datum_uclanjenja;
        private string p_datum_isteka_clanarine;



        /// <summary>
        /// Konstruktor klase
        /// </summary>
        public tablicaClan()
        {
            
        }

        /// <summary>
        /// Puni objekt sa podacima iz tablice Clan
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima iz tablice Clan</param>
        public tablicaClan(DbDataReader dr)
        {
            if (dr != null)
            {
                p_idClan = int.Parse(dr["idClan"].ToString());
                p_idOsoba = int.Parse(dr["idOsoba"].ToString());
                p_idMjClanarina = int.Parse(dr["idMjClanarina"].ToString());
                p_datum_uclanjenja = dr["datum_uclanjenja"].ToString();
                p_datum_isteka_clanarine = dr["datum_isteka_clanarine"].ToString();
            }

        }

        /// <summary>
        /// Jedinstveni identifikator clana
        /// </summary>
        public int idClan
        {
            get
            {
                return p_idClan;
            }
            private set
            {
                if (p_idClan != value) p_idClan = value;
            }
        }

        /// <summary>
        /// Jedinstveni identifikator osobe
        /// </summary>
        public int idOsoba
        {
            get
            {
                return p_idOsoba;
            }
            set
            {
                if (p_idOsoba != value) p_idOsoba = value;
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
            set
            {
                if (p_idMjClanarina != value) p_idMjClanarina = value;
            }
        }

        /// <summary>
        /// Datum uclanjenja
        /// </summary>
        public string datum_uclanjenja
        {
            get
            {
                return p_datum_uclanjenja;
            }
            set
            {
                if (p_datum_uclanjenja != value) p_datum_uclanjenja = value;
            }
        }

        /// <summary>
        /// Datum isteka clanarine
        /// </summary>
        public string datum_isteka_clanarine
        {
            get
            {
                return p_datum_isteka_clanarine;
            }
            set
            {
                if (p_datum_isteka_clanarine != value) p_datum_isteka_clanarine = value;
            }
        }


        /// <summary>
        /// Sprema vrijednosti objekta u bazu
        /// </summary>
        /// <returns>Broj redaka koji su izmijenjeni ili dodani</returns>
        public int Spremi()
        {
            string sqlUpit = "";
            if (idClan == 0) // Unos
            {
                sqlUpit = "INSERT INTO Clan (datum_uclanjenja, datum_isteka_clanarine, idOsoba, idMjClanarina) VALUES ('" + datum_uclanjenja + "','" + datum_isteka_clanarine + "','" + idOsoba + "','" + idMjClanarina + "')";
            }
            else // Ažuriranje
            {
                sqlUpit = "UPDATE Clan SET datum_uclanjenja = '" + datum_uclanjenja
                + "', datum_isteka_clanarine = '" + datum_isteka_clanarine
                + "', idOsoba = '" + idOsoba
                + "', idMjClanarina = '" + idMjClanarina
               + "' WHERE idClan = " + idClan;
            }

            return Baza_podataka.Instance.IzvrsiUpit(sqlUpit);
        }

        /// <summary>
        /// Briše objekt iz baze
        /// </summary>
        /// <returns>Broj obrisanih redaka</returns>
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Clan WHERE idClan = " + idClan;
            return Baza_podataka.Instance.IzvrsiUpit(sqlDelete);
        }

        /// <summary>
        /// Dohvaća sve clanove iz baze i vraća ih u obliku generičke liste
        /// </summary>
        /// <returns>Lista clanova</returns>
        public static List<tablicaClan> DohvatiClanove()
        {
            List<tablicaClan> lista = new List<tablicaClan>();
            string sqlUpit = "SELECT * FROM Clan";
            DbDataReader dr = Baza_podataka.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                tablicaClan clan = new tablicaClan(dr);
                lista.Add(clan);
            }            
            dr.Close();
            return lista;
        }

        /// <summary>
        /// Dohvaća clana prema trazenom jedinstvenom identifikatoru
        /// </summary>
        /// <param name="trazeniID">Jedinstveni identifikator clana</param>
        /// <returns>Clan</returns>
        public static tablicaClan DohvatiClanaPrekoID(int trazeniID)
        {
            string sqlUpit = "SELECT * FROM Clan WHERE idClan = " + trazeniID.ToString();
            tablicaClan clan = new tablicaClan(Baza_podataka.Instance.DohvatiDataReader(sqlUpit));
            return clan;
        }


        /// <summary>
        /// Metoda koja nadjačava ToString metodu
        /// </summary>
        /// <returns>Jedinstveni identifikator clana</returns>
        public override string ToString()
        {
            return idClan.ToString();
        }




    }
}
