using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsfestivalManagement.Controller
{
    class SetupConnectionController
    {
        public static void OpenSetupConnectionGUI()
        {
            View.SetupConnectionGUI SetupConnectionGUIForm;
            SetupConnectionGUIForm = new View.SetupConnectionGUI();
            SetupConnectionGUIForm.ShowDialog();
        }

        public static void TestConnection(string iHost, string iUsername, string iPassword, string iDatabase, int iPort)
        {
            string connectionString = ""
                + "SERVER=" + iHost + ";"
                + "UID=" + iUsername + ";"
                + "PASSWORD=" + iPassword + ";"
                + "DATABASE=" + iDatabase + ";"
                + "PORT=" + Convert.ToString(iPort) + ";"
            ;
            var Conn = new MySqlConnection(connectionString);

            try
            {
                Conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Verbindung fehlgeschlagen! " + e.Message);
            }

            MessageBox.Show("Verbindung erfolgreich!");
            Conn.Close();
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
            catch(Exception e)
            {
                Result = false;
                return Result;
            }
            return Result;
    }
}
