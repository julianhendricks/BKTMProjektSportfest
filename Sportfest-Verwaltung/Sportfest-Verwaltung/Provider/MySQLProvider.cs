using SportsFestivalManagement.Entities;
using System;

namespace SportsFestivalManagement.Provider
{
    class MySQLProvider
    {
        public static MySQL getMySQLInstance()
        {
            return new MySQL(
                ConfigurationProvider.loadConfigurationValue("mySql_host"),
                ConfigurationProvider.loadConfigurationValue("mySql_username"),
                ConfigurationProvider.loadConfigurationValue("mySql_password"),
                ConfigurationProvider.loadConfigurationValue("mySql_database"),
                Convert.ToInt32(ConfigurationProvider.loadConfigurationValue("mySql_port"))
            );
        }

        public static Tuple<bool, string> testConnection(
            string host,
            string username,
            string password,
            string database,
            int port
        ) {
            MySQL mySqlInstance = new MySQL(
                host,
                username,
                password,
                database,
                port
            );

            try
            {
                mySqlInstance.connect();
                mySqlInstance.close();

                return Tuple.Create(true, "");
            }
            catch (Exception e)
            {
                return Tuple.Create(false, e.Message);
            }
        }
    }
}
