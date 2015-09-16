using SportsfestivalManagement.Entities;
using System;

namespace SportsfestivalManagement.Provider
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
    }
}
