using System;
using System.Text;
using System.Collections.Generic;
using System.Data.Common;

namespace Baza_podataka
{
    public class tablicaOsoba
    {
        private int p_idOsoba;
        private string p_ime;
        private string p_prezime;
        private string p_email;
        private string p_telefon;



        /// <summary>
        /// Konstruktor klase
        /// </summary>
        public tablicaOsoba()
        {
            
        }

        /// <summary>
        /// Puni objekt sa podacima iz tablice Osoba
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima iz tablice Osoba</param>
        public tablicaOsoba(DbDataReader dr)
        {
            if (dr != null)
            {
                p_idOsoba = int.Parse(dr["idOsoba"].ToString());
                p_ime = dr["ime"].ToString();
                p_prezime = dr["prezime"].ToString();
                p_email = dr["email"].ToString();
                p_telefon = dr["telefon"].ToString();
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
            private set
            {
                if (p_idOsoba != value) p_idOsoba = value;
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
            set
            {
                if (p_ime != value) p_ime = value;
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
            set
            {
                if (p_prezime != value) p_prezime = value;
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
            set
            {
                if (p_email != value) p_email = value;
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
            set
            {
                if (p_telefon != value) p_telefon = value;
            }
        }


        /// <summary>
        /// Sprema vrijednosti objekta u bazu
        /// </summary>
        /// <returns>Broj redaka koji su izmijenjeni ili dodani</returns>
        public int Spremi()
        {
            string sqlUpit = "";
            if (idOsoba == 0) // Unos
            {
                sqlUpit = "INSERT INTO Osoba (ime, prezime, email, telefon) VALUES ('" + ime + "','" + prezime + "','" + email + "','" + telefon + "')";
            }
            else // Ažuriranje
            {
                sqlUpit = "UPDATE Osoba SET ime = '" + ime
                + "', prezime = '" + prezime
                + "', email = '" + email
                + "', telefon = '" + telefon
               + "' WHERE idOsoba = " + idOsoba;
            }

            return Baza_podataka.Instance.IzvrsiUpit(sqlUpit);
        }

        /// <summary>
        /// Briše objekt iz baze
        /// </summary>
        /// <returns>Broj obrisanih redaka</returns>
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Osoba WHERE idOsoba = " + idOsoba;
            return Baza_podataka.Instance.IzvrsiUpit(sqlDelete);
        }

        /// <summary>
        /// Dohvaća sve osobe iz baze i vraća ih u obliku generičke liste
        /// </summary>
        /// <returns>Lista osoba</returns>
        public static List<tablicaOsoba> DohvatiOsobe()
        {
            List<tablicaOsoba> lista = new List<tablicaOsoba>();
            string sqlUpit = "SELECT * FROM Osoba";
            DbDataReader dr = Baza_podataka.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                tablicaOsoba osoba = new tablicaOsoba(dr);
                lista.Add(osoba);
            }            
            dr.Close();
            return lista;
        }

        /// <summary>
        /// Dohvaća osobu prema trazenom jedinstvenom identifikatoru
        /// </summary>
        /// <param name="trazeniID">Jedinstveni identifikator osobe</param>
        /// <returns>Osoba</returns>
        public static tablicaOsoba DohvatiOsobuPrekoID(int trazeniID)
        {
            string sqlUpit = "SELECT * FROM Osoba WHERE idOsoba = " + trazeniID.ToString();
            tablicaOsoba osoba = new tablicaOsoba(Baza_podataka.Instance.DohvatiDataReader(sqlUpit));
            return osoba;
        }

        /// <summary>
        /// Dohvaća ID osobe koja je zadnja dodana u bazu
        /// </summary>
        /// <returns>ID Osobe</returns>
        public int DohvatiZadnjiID()
        {
            string sqlUpit = "SELECT MAX(idOsoba) FROM Osoba";
            return int.Parse(Baza_podataka.Instance.DohvatiVrijednost(sqlUpit).ToString());
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
