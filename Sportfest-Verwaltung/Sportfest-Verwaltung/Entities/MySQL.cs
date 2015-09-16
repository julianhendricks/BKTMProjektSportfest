using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using SportsfestivalManagement.Provider;

namespace SportsfestivalManagement.Entities
{
    class MySQL
    {
        private const string log_tableName = "sqlLogs";
        private const string log_field_logId = "logId";
        private const string log_field_timestamp = "timestamp";
        private const string log_field_executedSql = "executedSql";

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
                throw new Exception(""
                    + "Es trat ein Fehler beim Öffnen der Datenbankverbindung auf!\n"
                    + "Ausgabe der Datenbank:\n\n"
                    + e.Message
                );
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
                MySqlCommand sqlCommand = this.instance.CreateCommand();
                sqlCommand.CommandText = sql;

                MySqlDataReader executionResult = sqlCommand.ExecuteReader();

                if (Convert.ToBoolean(ConfigurationProvider.loadConfigurationValue("enable_sql_logger")) == true)
                {
                    MySqlCommand logCommand = this.instance.CreateCommand();
                    logCommand.CommandText = ""
                        + "INSERT INTO "
                            + "`" + log_tableName + "` "
                        + "("
                            + "`" + log_field_timestamp + "`, "
                            + "`" + log_field_executedSql + "`"
                        + ") VALUES ("
                            + "`" + new DateTime().ToString("yyyy-MM-dd hh:mm:ss")
                            + "`" + MySqlHelper.EscapeString(sql) + "`"
                        + ")"
                    ;

                    logCommand.ExecuteReader();
                }

                return executionResult;
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
