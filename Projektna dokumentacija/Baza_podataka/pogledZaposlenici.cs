using System;
using System.Text;
using System.Collections.Generic;
using System.Data.Common;

namespace Baza_podataka
{
    public class pogledZaposlenici
    {
        private int p_idZaposlenik;
        private string p_datum_zaposljenja;
        private int p_idOsoba;
        private string p_ime;
        private string p_prezime;
        private string p_email;
        private string p_telefon;


        /// <summary>
        /// Konstruktor klase
        /// </summary>
        public pogledZaposlenici()
        {
            
        }

        /// <summary>
        /// Puni objekt sa podacima iz tablice Zaposlenik i Osoba
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima iz tablice Zaposlenik povezanih s Osobom</param>
        public pogledZaposlenici(DbDataReader dr)
        {
            if (dr != null)
            {
                p_idOsoba = int.Parse(dr["idOsoba"].ToString());
                p_idZaposlenik = int.Parse(dr["idZaposlenik"].ToString());
                p_datum_zaposljenja = dr["datum_zaposljenja"].ToString();
                p_ime = dr["ime"].ToString();
                p_prezime = dr["prezime"].ToString();
                p_email = dr["email"].ToString();
                p_telefon = dr["telefon"].ToString();
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
        /// Datum zaposljavanja zaposenika
        /// </summary>
        public string datum_zaposljenja
        {
            get
            {
                return p_datum_zaposljenja;
            }
        }

        /// <summary>
        /// Dohvaća sve zaposlenike i osobe iz baze i vraća ih u obliku generičke liste
        /// </summary>
        /// <returns>Lista zaposlenika prosirena s atributima tablice osoba s kojom je vezana</returns>
        public static List<pogledZaposlenici> DohvatiZaposlenike()
        {
            List<pogledZaposlenici> lista = new List<pogledZaposlenici>();
            string sqlUpit = "select idZaposlenik,z.idOsoba,ime,prezime,email,telefon,datum_zaposljenja from Zaposlenik z LEFT OUTER JOIN Osoba o ON o.idOsoba = z.idOsoba Group by 1;";
            DbDataReader dr = Baza_podataka.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                pogledZaposlenici zap = new pogledZaposlenici(dr);
                lista.Add(zap);
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
