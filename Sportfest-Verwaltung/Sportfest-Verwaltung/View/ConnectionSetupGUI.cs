using System;
using System.Windows.Forms;
using SportsFestivalManagement.Provider;
using SportsFestivalManagement.Controller;

namespace SportsFestivalManagement.View
{
    public partial class ConnectionSetupGUI : MetroFramework.Forms.MetroForm
    {
        private bool connectionSuccessful = false;

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
            var connectionStatus = MySQLProvider.testConnection(
                edtHost.Text,
                edtUsername.Text,
                edtPassword.Text,
                edtDatabase.Text,
                Convert.ToInt32(edtPort.Text)
            );

            if (connectionStatus.Item1 == true)
            {
                MessageBox.Show(
                    "Die Verbindung zur Datenbank wurde erfolgreich hergestellt!",
                    "Verbindung hergestellt",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.connectionSuccessful = true;
            }
            else
            {
                MessageBox.Show(
                    "Die Verbindung zur Datenbank konnte nicht hergestellt werden!\n"
                        + "\n"
                        + "Fehler:\n"
                        + connectionStatus.Item2,
                    "Verbindung fehlgeschlagen",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                this.connectionSuccessful = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.connectionSuccessful == true)
            {
                ConnectionSetupController.SaveConnection(
                    edtHost.Text,
                    edtUsername.Text,
                    edtPassword.Text,
                    edtDatabase.Text,
                    Convert.ToInt32(edtPort.Text)
                );

                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Bitte stellen Sie zuerst eine Verbindung zu einer Datenbank her, bevor Sie die Einstellungen speichern!",
                    "Speichern nicht möglich",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void SetupConnectionGUI_Load(object sender, EventArgs e)
        {
            edtHost.Text = ConfigurationProvider.loadConfigurationValue(ConfigurationProvider.mySql_host);
            edtPort.Text = ConfigurationProvider.loadConfigurationValue(ConfigurationProvider.mySql_port);
            edtDatabase.Text = ConfigurationProvider.loadConfigurationValue(ConfigurationProvider.mySql_database);
            edtUsername.Text = ConfigurationProvider.loadConfigurationValue(ConfigurationProvider.mySql_username);
            edtPassword.Text = ConfigurationProvider.loadConfigurationValue(ConfigurationProvider.mySql_password);
        }
    }
}
