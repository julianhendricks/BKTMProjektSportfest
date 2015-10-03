using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using SportsfestivalManagement.Entities;
using SportsfestivalManagement.Provider;

namespace SportsfestivalManagement
{
    class SportsFestivalController
    {
        public SportsFestivalController()
        {

        }

       /* ~SportsfestivalController()
        {
            if (SportsFestivalConnection.State == System.Data.ConnectionState.Open)
            {
                SportsFestivalConnection.Close();
            }
        }*/

        public static List<SportsFestival> getAllSportsFestivals()
        {
           return SportsFestivalProvider.getAllSportsFestivals();

            /*foreach (SportsFestival Sportsfest in SportsFestivalCollection){
                string[] row = { Sportsfest.GetSportsFestivalId().ToString(), "Sportfest " + Sportsfest.GetSportsFestivalDate().Year.ToString() };
                iListView.Items.Add(new ListViewItem(row));
            }*/
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
