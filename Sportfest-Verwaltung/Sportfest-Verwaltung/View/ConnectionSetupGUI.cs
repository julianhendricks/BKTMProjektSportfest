using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportsfestivalManagement.Provider;

namespace SportsfestivalManagement.View
{
    public partial class ConnectionSetupGUI : MetroFramework.Forms.MetroForm
    {
        public ConnectionSetupGUI()
        {
            InitializeComponent();
        }

        private void btnTerminate_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            //Controller.SetupConnectionController.TestConnection(edtHost.Text, edtUsername.Text, edtPassword.Text,
            //    edtDatabase.Text, Convert.ToInt32(edtPort.Value));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Controller.ConnectionSetupController.SaveConnection(edtHost.Text, edtUsername.Text, edtPassword.Text,
                edtDatabase.Text, Convert.ToInt32(edtPort.Value))){
                Close();
            }
            else
            {
                MessageBox.Show("Es ist ein Fehler beim Speichern der Verbindung aufgetreten!");
            }
        }

        private void SetupConnectionGUI_Load(object sender, EventArgs e)
        {
            edtHost.Text = ConfigurationProvider.loadConfigurationValue("mySql_host");
            edtPort.Text = ConfigurationProvider.loadConfigurationValue("mySql_port");
            edtDatabase.Text = ConfigurationProvider.loadConfigurationValue("mySql_database");
            edtUsername.Text = ConfigurationProvider.loadConfigurationValue("mySql_username");
            edtPassword.Text = ConfigurationProvider.loadConfigurationValue("mySql_password");
        }
    }
}
