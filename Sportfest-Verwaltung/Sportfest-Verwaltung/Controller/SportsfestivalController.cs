using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using SportsFestivalManagement.Entities;
using SportsFestivalManagement.Provider;
using SportsFestivalManagement.View;

namespace SportsFestivalManagement.Controller
{
    class SportsFestivalController
    {
        /*
         * Instance constructor
         */
        private SportsFestivalController() { }

        private static readonly SportsFestivalController _instance = new SportsFestivalController();

        public static SportsFestivalController getInstance
        {
            get { return _instance; }
        } 
        /*
         * End of Instance constructor
         */


        private SportsFestivalGUI view;

        public Form getMainWindow()
        {
            this.view = new SportsFestivalGUI();
            return this.view;
        }

        public void openNewSportsFestivalForm()
        {
            NewSportsFestivalController.getInstance.OpenNewSportsFestivalGUI();
            this.view.renderSportsFestivalsGrid();
        }

        public void openSportsFestivalDetailsForm()
        {

        }

        public List<SportsFestival> getAllSportsFestivalsOrderedByDescendingDate()
        {
            return SportsFestivalProvider.getAllSportsFestivalsByDescendingDate();
        }

        public static Tuple<bool, string> getConnectionStateByConfigurationValues()
        {
            return MySQLProvider.testConnection(
                ConfigurationProvider.loadConfigurationValue(ConfigurationProvider.mySql_host),
                ConfigurationProvider.loadConfigurationValue(ConfigurationProvider.mySql_username),
                ConfigurationProvider.loadConfigurationValue(ConfigurationProvider.mySql_password),
                ConfigurationProvider.loadConfigurationValue(ConfigurationProvider.mySql_database),
                Convert.ToInt32(ConfigurationProvider.loadConfigurationValue(ConfigurationProvider.mySql_port))
            );
        }


    }
}
