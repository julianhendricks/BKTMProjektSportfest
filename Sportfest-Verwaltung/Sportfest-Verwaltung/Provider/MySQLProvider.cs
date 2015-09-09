using SportsfestivalManagement.Entities;
using System.Configuration;
using System;

namespace SportsfestivalManagement.Provider
{
    class MySQLProvider
    {
        public static MySQL getMySQLInstance()
        {
            ConfigurationProvider provider = new ConfigurationProvider();

            return new MySQL(
                provider.loadConfigurationValue("mySql_host"),
                provider.loadConfigurationValue("mySql_username"),
                provider.loadConfigurationValue("mySql_password"),
                provider.loadConfigurationValue("mySql_database"),
                Convert.ToInt32(provider.loadConfigurationValue("mySql_port"))
            );
        }
    }
}
