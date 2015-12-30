using SportsFestivalManagement.Entities;
using System;

namespace SportsFestivalManagement.Provider
{
    class MySQLProvider
    {
        private static MySQL mySqlInstance = null;

        public static MySQL getMySQLInstance()
        {
            if (mySqlInstance == null)
            {
                mySqlInstance = new MySQL(
                    ConfigurationProvider.loadConfigurationValue("mySql_host"),
                    ConfigurationProvider.loadConfigurationValue("mySql_username"),
                    ConfigurationProvider.loadConfigurationValue("mySql_password"),
                    ConfigurationProvider.loadConfigurationValue("mySql_database"),
                    Convert.ToInt32(ConfigurationProvider.loadConfigurationValue("mySql_port"))
                );
                mySqlInstance.connect();
            }

            return mySqlInstance;
        }

        public static Tuple<bool, string> testConnection(
            string host,
            string username,
            string password,
            string database,
            int port
        ) {
            MySQL mySqlTestInstance = new MySQL(
                host,
                username,
                password,
                database,
                port
            );

            try
            {
                mySqlTestInstance.connect();
                mySqlTestInstance.close();

                return Tuple.Create(true, "");
            }
            catch (Exception e)
            {
                return Tuple.Create(false, e.Message);
            }
        }
    }
}
