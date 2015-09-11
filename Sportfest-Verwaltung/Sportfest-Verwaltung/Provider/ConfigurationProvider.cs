using System.Configuration;

namespace SportsfestivalManagement.Provider
{
    class ConfigurationProvider
    {
        public string loadConfigurationValue(string configurationKey)
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
