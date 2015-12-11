using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsFestivalManagement.Provider;
using SportsFestivalManagement.Entities;
using SportsFestivalManagement.View;
using System.Windows.Forms;

namespace SportsFestivalManagement.Controller
{
    class NewSportsFestivalController
    {
        private NewSportsFestivalController() { }

        private static readonly NewSportsFestivalController _instance = new NewSportsFestivalController();

        public static NewSportsFestivalController getInstance
        {
            get { return _instance; }
        } 

        public void OpenNewSportsFestivalGUI()
        {
            NewSportsFestivalGUI NewSportsFestivalGUIForm;

            NewSportsFestivalGUIForm = new NewSportsFestivalGUI(this);
            NewSportsFestivalGUIForm.Show();

            NewSportsFestivalGUIForm.updateDisciplines(
                DisciplineProvider.getAllDisciplines(), // Available disciplines
                new List<Discipline>()                  // Selected disciplines
            );
        }

        public void test123()
        {
            MessageBox.Show("hiereweffwqedfrg");
        }

    }
}
