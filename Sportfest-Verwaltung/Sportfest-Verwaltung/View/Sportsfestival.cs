using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportsFestivalManagement.Controller;
using SportsFestivalManagement.Provider;
using SportsFestivalManagement.Entities;
using MySql.Data.MySqlClient;

namespace SportsFestivalManagement
{
    public partial class Sportsfestival : MetroFramework.Forms.MetroForm
    {
        SportsFestivalController MyController;
        public Sportsfestival()
        {
            InitializeComponent();

            this.StyleManager = metroStyleManager;
        }
        
        private void btnStudentsAndClasses_Click_1(object sender, EventArgs e)
        {
            StudentsAndClassesController.OpenStudentsAndClassesGUI();
        }

        private void btnDisciplines_Click(object sender, EventArgs e)
        {
            DisciplinesController.OpenDisciplinesGUI();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //NewSportsFestivalController.OpenNewSportsFestivalGUI();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            ResultsController.OpenResultsGUI();
        }

        private void Sportsfestival_Load(object sender, EventArgs e)
        {
            while (SportsFestivalController.getConnectionStateByConfigurationValues().Item1 == false)
            {
                ConnectionSetupController.OpenSetupConnectionGUI();
            }

            MySQL mySql = MySQLProvider.getMySQLInstance();
            mySql.connect();
            var result = mySql.query("SELECT * FROM sportsFestival");

            

            /*while (reader.Read())
            {
                MessageBox.Show(reader.ToString());
                reader.GetType();
            }*/

            

            /*foreach (SportsFestival sportsFestival in SportsFestivalController.getAllSportsFestivals())
            {
                string[] row = {
                    sportsFestival.SportsFestivalId.ToString(),
                    "Sportfest " + sportsFestival.Date.Year.ToString()
                };
                lvSportsfestivals.Items.Add(new ListViewItem(row));
            }*/

            //SportsfestivalController.LoadSportsFestivalListView(lvSportsfestivals);
        }
    }
}
