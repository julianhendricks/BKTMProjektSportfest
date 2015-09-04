using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Sportfest_Verwaltung
{
    class MySQL
    {
        private MySqlConnection instance;

        public void connect(
            string host,
            string username,
            string password,
            string database,
            int port = 3306
        ) {
            /** TODO: Konfigurationsdatei anlegen */
            string connectionString = ""
                + "SERVER=" + host + ";"
                + "UID=" + username + ";"
                + "PASSWORD=" + password + ";"
                + "DATABASE=" + database + ";"
                + "PORT=" + port + ";"
            ;
            this.instance = new MySqlConnection(connectionString);

            try
            {
                this.instance.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Es trat ein Fehler beim Herstellen der Datenbankverbindung auf!\n"
                        + "Ausgabe der Datenbank:\n\n"
                        + e.Message + "\n\n"
                        + "Bitte korrigieren Sie die Verbindungsinformationen in der Konfigurationsdatei!",
                    "Datenbankfehler",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                Application.Exit();
            }
        }

        public void close()
        {
            try
            {
                this.instance.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Es trat ein Fehler beim Schließen der Datenbankverbindung auf!\n"
                        + "Ausgabe der Datenbank:\n\n"
                        + e.Message,
                    "Datenbankfehler",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                Application.Exit();
            }
            
        }

        public MySqlDataReader query(string sql)
        {
            try
            {
                MySqlCommand command = this.instance.CreateCommand();
                command.CommandText = sql;

                return command.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Es trat ein Fehler beim Ausführen einer Datenbankabfrage auf!\n"
                        + "Ausgabe der Datenbank:\n\n"
                        + e.Message,
                    "Datenbankfehler",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            return null;
        }




        static public SqlConnection GetConnection()
        {
            string ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Berufsschule;Data Source=FUP021";
            SqlConnection Conn = new SqlConnection(ConnectionString);
            return Conn;
        }

        static public SqlDataReader GetReader(string iCommandText)
        {
            SqlConnection Connection = GetConnection();
            Connection.Open();

            SqlCommand cmd = new SqlCommand(iCommandText, Connection);
            SqlDataReader rdr = cmd.ExecuteReader();
            return rdr;
        }
    }
}
