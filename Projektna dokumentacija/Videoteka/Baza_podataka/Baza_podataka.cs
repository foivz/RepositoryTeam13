using System;
using System.Data.Common;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;


namespace Videoteka.Baza_podataka
{
    class Baza_podataka
    {
        private static Baza_podataka instance; // Singleton objekt
        private string connectionString; // Putanja i podaci za spajanje na bazu podataka
        private SQLiteConnection connection; // Konekcija prema bazi podataka

        /// <summary>
        /// Konstruktor klase
        /// </summary>
        private Baza_podataka()
        {
            connectionString = @"Data Source=VideotekaBaza.db3";
            Connection = new SQLiteConnection(ConnectionString);

            Connection.Open();
        }

        /// <summary>
        /// Destruktor klase
        /// </summary>
        ~Baza_podataka()
        {
            Connection.Close();
            Connection = null;
        }

        /// <summary>
        /// Singleton instanca klase za rad s bazom podataka
        /// </summary>
        public static Baza_podataka Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Baza_podataka();
                }
                return instance;
            }
        }

        /// <summary>
        /// Tekstualna reprezentacija konekcije na bazu podataka
        /// </summary>
        public string ConnectionString
        {
            get
            {
                return connectionString;
            }
            private set
            {
                if (connectionString != value)
                {
                    connectionString = value;
                }
            }
        }

        /// <summary>
        /// Konekcija na bazu podataka
        /// </summary>
        public SQLiteConnection Connection
        {
            get
            {
                return connection;
            }
            private set
            {
                if (connection != value)
                {
                    connection = value;
                }
            }
        }

        /// <summary>
        /// Dohvaća podatke u obliku DataReader objekta na temelju proslijeđenog upita
        /// </summary>
        /// <param name="sqlUpit">SQL upit</param>
        /// <returns>Rezultati upita</returns>
        public DbDataReader DohvatiDataReader(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            return command.ExecuteReader();
        }

        /// <summary>
        /// Dohvaća skalarnu vrijednost kao rezultat proslijeđenog upita
        /// </summary>
        /// <param name="sqlUpit">SQL upit</param>
        /// <returns>Skalarna vrijednost kao rezultat upita</returns>
        public object DohvatiVrijednost(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            return command.ExecuteScalar();
        }

        /// <summary>
        /// Izvršava INSERT, UPDATE, DELETE SQL izraz
        /// </summary>
        /// <param name="sqlUpit">INSERT, UPDATE, DELETE SQL izraz</param>
        /// <returns>Broj redaka u tablici koji su dodani, promijenjeni ili obrisani</returns>
        public int IzvrsiUpit(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            return command.ExecuteNonQuery();
        }

    }
}
