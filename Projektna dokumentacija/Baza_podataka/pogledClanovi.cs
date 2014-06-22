using System;
using System.Text;
using System.Collections.Generic;
using System.Data.Common;

namespace Baza_podataka
{
    public class pogledClanovi
    {
        private int p_idClan;
        private float p_MjClanarina;
        private string p_datum_uclanjenja;
        private string p_datum_isteka_clanarine;
        private int p_idOsoba;
        private string p_ime;
        private string p_prezime;
        private string p_email;
        private string p_telefon;


        /// <summary>
        /// Konstruktor klase
        /// </summary>
        public pogledClanovi()
        {
            
        }

        /// <summary>
        /// Puni objekt sa podacima iz tablice Clan i Osoba
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima iz tablice Clan povezanih s Osobom</param>
        public pogledClanovi(DbDataReader dr)
        {
            if (dr != null)
            {
                p_idClan = int.Parse(dr["idClan"].ToString());
                p_idOsoba = int.Parse(dr["idOsoba"].ToString());
                p_MjClanarina = float.Parse(dr["MjClanarina"].ToString());
                p_datum_uclanjenja = dr["datum_uclanjenja"].ToString();
                p_datum_isteka_clanarine = dr["datum_isteka_clanarine"].ToString();
                p_ime = dr["ime"].ToString();
                p_prezime = dr["prezime"].ToString();
                p_email = dr["email"].ToString();
                p_telefon = dr["telefon"].ToString();
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
        /// Datum uclanjenja
        /// </summary>
        public string datum_uclanjenja
        {
            get
            {
                return p_datum_uclanjenja;
            }
        }

        /// <summary>
        /// Iznos mjesecne clanarine
        /// </summary>
        public float MjClanarina
        {
            get
            {
                return p_MjClanarina;
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
        }

        /// <summary>
        /// Dohvaća sve clanove i osobe iz baze i vraća ih u obliku generičke liste
        /// </summary>
        /// <returns>Lista clanova prosirena s atributima tablice osoba s kojom je vezana</returns>
        public static List<pogledClanovi> DohvatiClanove()
        {
            List<pogledClanovi> lista = new List<pogledClanovi>();
            string sqlUpit = "select Clan.idOsoba,idClan,ime,prezime,email,telefon,datum_uclanjenja,MjClanarina,datum_isteka_clanarine from Clan LEFT OUTER JOIN Osoba ON Osoba.idOsoba = Clan.idOsoba Group by 1;";
            DbDataReader dr = Baza_podataka.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                pogledClanovi clan = new pogledClanovi(dr);
                lista.Add(clan);
            }
            dr.Close();
            return lista;
        }

        /// <summary>
        /// Metoda koja nadjačava ToString metodu
        /// </summary>
        /// <returns>Ime i prezime osobe</returns>
        public override string ToString()
        {
            return ime + " " + prezime;
        }


    }
}
