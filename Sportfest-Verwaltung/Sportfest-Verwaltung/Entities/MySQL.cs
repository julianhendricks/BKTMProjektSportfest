using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using SportsFestivalManagement.Provider;
using System.Linq;

namespace SportsFestivalManagement.Entities
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
                throw new Exception(""
                    + "Es trat ein Fehler beim Schließen der Datenbankverbindung auf!\n"
                    + "Ausgabe der Datenbank:\n\n"
                    + e.Message
                );
            }
            
        }

        public List<Dictionary<string, object>> query(string sql)
        {
            return this.queryStatement(sql);
        }

        public Dictionary<string, object> querySingle(string sql)
        {
            return this.queryStatement(sql).FirstOrDefault();
        }

        public void execute(string sql)
        {
            this.queryStatement(sql);
        }

        private List<Dictionary<string, object>> queryStatement(string sql)
        {
            try
            {
                MySqlCommand sqlCommand = this.instance.CreateCommand();
                sqlCommand.CommandText = sql;

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
                            + "'" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "', "
                            + "'" + MySqlHelper.EscapeString(sql) + "'"
                        + ")"
                    ;

                    MySqlDataReader logReader = logCommand.ExecuteReader();
                    logReader.Close();
                }

                MySqlDataReader reader = sqlCommand.ExecuteReader();
                var executionResult = this.getArrayFromDataReader(reader);
                reader.Close();

                return executionResult;
            }
            catch (Exception e)
            {
                throw new Exception(""
                    + "Es trat ein Fehler beim Ausführen einer Datenbankabfrage auf!\n"
                    + "Ausgabe der Datenbank:\n\n"
                    + e.Message
                );
            }
        }

        private List<Dictionary<string, object>> getArrayFromDataReader(MySqlDataReader reader)
        {
            var dataSets = new List<Dictionary<string, object>>();

            var columns = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToList();

            while (reader.Read())
            {
                var dataSet = new Dictionary<string, object>();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    if (reader.IsDBNull(i))
                    {
                        dataSet[reader.GetName(i)] = null;
                        continue;
                    }

                    dataSet[reader.GetName(i)] = reader.GetValue(i);
                }

                dataSets.Add(dataSet);
            }

            return dataSets;
        }
    }
}
