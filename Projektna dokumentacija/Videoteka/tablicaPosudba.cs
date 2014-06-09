using System;
using System.Text;
using System.Collections.Generic;
using System.Data.Common;

namespace Baza_podataka
{
    public class tablicaPosudba
    {
        private int p_idPosudba;
        private int p_Clan_idClan; // vanjski kljuc
        private int p_Film_idFilm; // vanjski kljuc
        private string p_datum_posudbe;
        private string p_posudjen_do;
        private string p_datum_vracanja;


        /// <summary>
        /// Konstruktor klase
        /// </summary>
        public tablicaPosudba()
        {
            
        }

        /// <summary>
        /// Puni objekt sa podacima iz tablice Posudba
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima iz tablice Posudba</param>
        public tablicaPosudba(DbDataReader dr)
        {
            if (dr != null)
            {
                p_idPosudba = int.Parse(dr["idPosudba"].ToString());
                p_Clan_idClan = int.Parse(dr["Clan_idClan"].ToString());
                p_Film_idFilm = int.Parse(dr["Film_idFilm"].ToString());
                p_datum_posudbe = dr["datum_posudbe"].ToString();
                p_posudjen_do = dr["posudjen_do"].ToString();
                p_datum_vracanja = dr["datum_vracanja"].ToString();
            }

        }

        /// <summary>
        /// Jedinstveni identifikator posudbe
        /// </summary>
        public int idPosudba
        {
            get
            {
                return p_idPosudba;
            }
            private set
            {
                if (p_idPosudba != value) p_idPosudba = value;
            }
        }

        /// <summary>
        /// Jedinstveni identifikator clana
        /// </summary>
        public int Clan_idClan
        {
            get
            {
                return p_Clan_idClan;
            }
            private set
            {
                if (p_Clan_idClan != value) p_Clan_idClan = value;
            }
        }

        /// <summary>
        /// Jedinstveni identifikator filma
        /// </summary>
        public int Film_idFilm
        {
            get
            {
                return p_Film_idFilm;
            }
            set
            {
                if (p_Film_idFilm != value) p_Film_idFilm = value;
            }
        }


        /// <summary>
        /// Datum posudbe filma
        /// </summary>
        public string datum_posudbe
        {
            get
            {
                return p_datum_posudbe;
            }
            set
            {
                if (p_datum_posudbe != value) p_datum_posudbe = value;
            }
        }


        /// <summary>
        /// Datum isteka posudbe filma
        /// </summary>
        public string posudjen_do
        {
            get
            {
                return p_posudjen_do;
            }
            set
            {
                if (p_posudjen_do != value) p_posudjen_do = value;
            }
        }

        /// <summary>
        /// Datum vracanja posudjenog filma
        /// </summary>
        public string datum_vracanja
        {
            get
            {
                return p_datum_vracanja;
            }
            set
            {
                if (p_datum_vracanja != value) p_datum_vracanja = value;
            }
        }

        /// <summary>
        /// Sprema vrijednosti objekta u bazu
        /// </summary>
        /// <returns>Broj redaka koji su izmijenjeni ili dodani</returns>
        public int Spremi()
        {
            string sqlUpit = "";
            if (idPosudba == 0) // Unos
            {
                sqlUpit = "INSERT INTO Posudba (Clan_idClan, Film_idFilm, datum_posudbe, posudjen_do, datum_vracanja) VALUES ('" + Clan_idClan + "','" + Film_idFilm + "','" + datum_posudbe + "','" + posudjen_do + "', '')";
            }
            else // Ažuriranje
            {
                sqlUpit = "UPDATE Posudba SET Clan_idClan = '" + Clan_idClan
                + "', Film_idFilm = '" + Film_idFilm
                + "', datum_posudbe = '" + datum_posudbe
                + "', posudjen_do = '" + posudjen_do
                + "', datum_vracanja = '" + datum_vracanja
               + "' WHERE idPosudba = " + idPosudba;
            }

            return Baza_podataka.Instance.IzvrsiUpit(sqlUpit);
        }

        /// <summary>
        /// Briše objekt iz baze
        /// </summary>
        /// <returns>Broj obrisanih redaka</returns>
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Posudba WHERE idPosudba = " + idPosudba;
            return Baza_podataka.Instance.IzvrsiUpit(sqlDelete);
        }

        /// <summary>
        /// Dohvaća sve posudjene filmove iz baze i vraća ih u obliku generičke liste
        /// </summary>
        /// <returns>Lista posudjenih filmova</returns>
        public static List<tablicaPosudba> DohvatiPosudbe()
        {
            List<tablicaPosudba> lista = new List<tablicaPosudba>();
            string sqlUpit = "SELECT * FROM Posudba";
            DbDataReader dr = Baza_podataka.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                tablicaPosudba pos = new tablicaPosudba(dr);
                lista.Add(pos);
            }            
            dr.Close();
            return lista;
        }


        /// <summary>
        /// Metoda koja nadjačava ToString metodu
        /// </summary>
        /// <returns>U slucaju da je film vracen vraca 'vracen', u suprotnom 'nije vracen'</returns>
        public override string ToString()
        {
            if (datum_vracanja == "")
            {
                return "nije vracen";
            }
            else
            {
                return "vracen";
            }
        }




    }
}
