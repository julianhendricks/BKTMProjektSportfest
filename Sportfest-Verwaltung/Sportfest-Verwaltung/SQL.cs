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
    class SQL
    {
        private MySqlConnection instance;

        public void connect()
        {
            /** TODO: Konfigurationsdatei */
            String connectionString = "SERVER=localhost;DATABASE=sportsfsestival;UID=root;PASSWORD=;";
            this.instance = new MySqlConnection(connectionString);

            try
            {
                this.instance.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Es trat ein Fehler beim Herstellen einer Datenbankverbindung auf!\n"
                        + "Ausgabe der Datenbank:\n\n"
                        + ex.Message + "\n\n"
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
            catch
            {

            }
            
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
