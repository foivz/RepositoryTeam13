using System;
using System.Text;
using System.Collections.Generic;
using System.Data.Common;

namespace Baza_podataka
{
    public class tablicaZaposlenik
    {
        private int p_idZaposlenik;
        private string p_korisnicko_ime;
        private string p_lozinka;
        private string p_datum_zaposljenja;
        private int p_idOsoba; // vanjski kljuc



        /// <summary>
        /// Konstruktor klase
        /// </summary>
        public tablicaZaposlenik()
        {
            
        }

        /// <summary>
        /// Puni objekt sa podacima iz tablice Zaposlenik
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima iz tablice Zaposlenik</param>
        public tablicaZaposlenik(DbDataReader dr)
        {
            if (dr != null)
            {
                p_idZaposlenik = int.Parse(dr["idZaposlenik"].ToString());
                p_korisnicko_ime = dr["korisnicko_ime"].ToString();
                p_lozinka = dr["lozinka"].ToString();
                p_datum_zaposljenja = dr["datum_zaposljenja"].ToString();
                p_idOsoba = int.Parse(dr["idOsoba"].ToString());
            }

        }

        /// <summary>
        /// Jedinstveni identifikator zaposlenika
        /// </summary>
        public int idZaposlenik
        {
            get
            {
                return p_idZaposlenik;
            }
            private set
            {
                if (p_idZaposlenik != value) p_idZaposlenik = value;
            }
        }

        /// <summary>
        /// Korisnicko ime zaposenika
        /// </summary>
        public string korisnicko_ime
        {
            get
            {
                return p_korisnicko_ime;
            }
            set
            {
                if (p_korisnicko_ime != value) p_korisnicko_ime = value;
            }
        }

        /// <summary>
        /// Lozinka zaposenika
        /// </summary>
        public string lozinka
        {
            get
            {
                return p_lozinka;
            }
            set
            {
                if (p_lozinka != value) p_lozinka = value;
            }
        }

        /// <summary>
        /// Datum zaposljavanja zaposenika
        /// </summary>
        public string datum_zaposljenja
        {
            get
            {
                return p_datum_zaposljenja;
            }
            set
            {
                if (p_datum_zaposljenja != value) p_datum_zaposljenja = value;
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
        /// Sprema vrijednosti objekta u bazu
        /// </summary>
        /// <returns>Broj redaka koji su izmijenjeni ili dodani</returns>
        public int Spremi()
        {
            string sqlUpit = "";
            if (idZaposlenik == 0) // Unos
            {
                sqlUpit = "INSERT INTO Zaposlenik (korisnicko_ime, lozinka, datum_zaposljenja, idOsoba) VALUES ('" + korisnicko_ime + "','" + lozinka + "','" + datum_zaposljenja + "','" + idOsoba + "')";
            }
            else // Ažuriranje
            {
                sqlUpit = "UPDATE Zaposlenik SET korisnicko_ime = '" + korisnicko_ime
                + "', lozinka = '" + lozinka
                + "', datum_zaposljenja = '" + datum_zaposljenja
                + "', idOsoba = '" + idOsoba
               + "' WHERE idZaposlenik = " + idZaposlenik;
            }

            return Baza_podataka.Instance.IzvrsiUpit(sqlUpit);
        }

        /// <summary>
        /// Briše objekt iz baze
        /// </summary>
        /// <returns>Broj obrisanih redaka</returns>
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Zaposlenik WHERE idZaposlenik = " + idZaposlenik;
            return Baza_podataka.Instance.IzvrsiUpit(sqlDelete);
        }

        /// <summary>
        /// Dohvaća sve zaposlenike iz baze i vraća ih u obliku generičke liste
        /// </summary>
        /// <returns>Lista zaposlenika</returns>
        public static List<tablicaZaposlenik> DohvatiZaposlenike()
        {
            List<tablicaZaposlenik> lista = new List<tablicaZaposlenik>();
            string sqlUpit = "SELECT * FROM Zaposlenik";
            DbDataReader dr = Baza_podataka.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                tablicaZaposlenik zap = new tablicaZaposlenik(dr);
                lista.Add(zap);
            }            
            dr.Close();
            return lista;
        }

        /// <summary>
        /// Dohvaća zaposlenika prema trazenom jedinstvenom identifikatoru
        /// </summary>
        /// <param name="trazeniID">Jedinstveni identifikator zaposlenika kao string</param>
        /// <returns>Zaposlenik</returns>
        public static tablicaZaposlenik DohvatiZaposlenikaPrekoID(string trazeniID)
        {
            string sqlUpit = "SELECT * FROM Zaposlenik WHERE idZaposlenik = " + trazeniID;
            tablicaZaposlenik zap = new tablicaZaposlenik(Baza_podataka.Instance.DohvatiDataReader(sqlUpit));
            return zap;
        }


        /// <summary>
        /// Metoda koja nadjačava ToString metodu
        /// </summary>
        /// <returns>ID zaposlenika</returns>
        public override string ToString()
        {
            return idZaposlenik.ToString();
        }




    }
}
