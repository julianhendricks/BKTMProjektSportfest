using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportsfestivalManagement.Controller;
using SportsfestivalManagement.Provider;

namespace SportsfestivalManagement
{
    public partial class Sportsfestival : MetroFramework.Forms.MetroForm
    {
        SportsfestivalController MyController;
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
            while (SportsfestivalController.getConnectionStateByConfigurationValues().Item1 == false)
            {
                ConnectionSetupController.OpenSetupConnectionGUI();
            }

            //SportsfestivalController.LoadSportsFestivalListView(lvSportsfestivals);
        }
    }
}
