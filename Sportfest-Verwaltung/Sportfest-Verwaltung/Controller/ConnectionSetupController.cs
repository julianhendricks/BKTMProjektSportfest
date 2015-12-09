using System;
using SportsFestivalManagement.Provider;

namespace SportsFestivalManagement.Controller
{
    class ConnectionSetupController
    {
        public static void OpenSetupConnectionGUI()
        {
            View.ConnectionSetupGUI SetupConnectionGUIForm;
            SetupConnectionGUIForm = new View.ConnectionSetupGUI();
            SetupConnectionGUIForm.ShowDialog();
        }

        public static void SaveConnection(
            string host,
            string username,
            string password,
            string database,
            int port
        ) {
            ConfigurationProvider.storeConfigurationValue(ConfigurationProvider.mySql_host, host);
            ConfigurationProvider.storeConfigurationValue(ConfigurationProvider.mySql_username, username);
            ConfigurationProvider.storeConfigurationValue(ConfigurationProvider.mySql_password, password);
            ConfigurationProvider.storeConfigurationValue(ConfigurationProvider.mySql_port, Convert.ToString(port));
            ConfigurationProvider.storeConfigurationValue(ConfigurationProvider.mySql_database, database);
        }

        public static implicit operator ConnectionSetupController(SportsFestivalController v)
        {
            throw new NotImplementedException();
        }
    }
}
