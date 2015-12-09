using System.Configuration;

namespace SportsFestivalManagement.Provider
{
    class ConfigurationProvider
    {
        public const string mySql_host = "mySql_host";
        public const string mySql_username = "mySql_username";
        public const string mySql_password = "mySql_password";
        public const string mySql_port = "mySql_port";
        public const string mySql_database = "mySql_database";
        public const string enable_sql_logger = "enable_sql_logger";

        public static string loadConfigurationValue(string configurationKey)
        {
            return ConfigurationManager.AppSettings.Get(configurationKey);
        }

        public static void storeConfigurationValue(string configurationKey, string configurationValue)
        {
            KeyValueConfigurationElement configurationElement = new KeyValueConfigurationElement(configurationKey, configurationValue);

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove(configurationKey);
            config.AppSettings.Settings.Add(configurationElement); 
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
