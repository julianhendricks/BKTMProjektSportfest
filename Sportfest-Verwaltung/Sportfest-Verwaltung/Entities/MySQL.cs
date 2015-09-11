using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SportsfestivalManagement.Entities
{
    class MySQL
    {
        private string host;
        private string username;
        private string password;
        private string database;
        private int port;

        private MySqlConnection instance;

        public MySQL(
            string host,
            string username,
            string password,
            string database,
            int port = 3306
        ) {
            this.host = host;
            this.username = username;
            this.password = password;
            this.database = database;
            this.port = port;
        }

        public void connect() {
            string connectionString = ""
                + "SERVER=" + this.host + ";"
                + "UID=" + this.username + ";"
                + "PASSWORD=" + this.password + ";"
                + "DATABASE=" + this.database + ";"
                + "PORT=" + this.port + ";"
            ;
            this.instance = new MySqlConnection(connectionString);

            try
            {
                this.instance.Open();
            }
            catch (Exception e)
            {
                Controller.SetupConnectionController.OpenSetupConnectionGUI();
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
    }
}
