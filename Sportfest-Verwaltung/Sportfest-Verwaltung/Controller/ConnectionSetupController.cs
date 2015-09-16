using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportsfestivalManagement.Provider;
using SportsfestivalManagement.Entities;

namespace SportsfestivalManagement.Controller
{
    class ConnectionSetupController
    {
        public void OpenSetupConnectionGUI()
        {
            View.ConnectionSetupGUI SetupConnectionGUIForm;
            SetupConnectionGUIForm = new View.ConnectionSetupGUI();
            SetupConnectionGUIForm.ShowDialog();
        }

        public bool connectionSuccessfullyEstablished()
        {
            MySQLProvider mySqlProvider = new MySQLProvider();
            MySQL mySqlInstance = MySQLProvider.getMySQLInstance();

            try
            {
                mySqlInstance.connect();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool SaveConnection(string iHost, string iUsername, string iPassword, string iDatabase, int iPort)
        {
            bool Result = true;

            try
            {
                Provider.ConfigurationProvider.storeConfigurationValue("mySql_host", iHost);
                Provider.ConfigurationProvider.storeConfigurationValue("mySql_username", iUsername);
                Provider.ConfigurationProvider.storeConfigurationValue("mySql_password", iPassword);
                Provider.ConfigurationProvider.storeConfigurationValue("mySql_port", Convert.ToString(iPort));
                Provider.ConfigurationProvider.storeConfigurationValue("mySql_database", iDatabase);
            }
            catch (Exception e)
            {
                Result = false;
                return Result;
            }
            return Result;
        }

        public static implicit operator ConnectionSetupController(SportsfestivalController v)
        {
            throw new NotImplementedException();
        }
    }
}
