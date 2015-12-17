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
    class NewStudentController
    {
        /*
         * Instance constructor
         */
        private NewStudentController() { }

        private static readonly NewStudentController _instance = new NewStudentController();

        public static NewStudentController getInstance
        {
            get { return _instance; }
        }
        /*
         * End of Instance constructor
         */


        public void OpenNewStudentGUI()
        {
            List<Competition> competitions = CompetitionProvider.getAllCompetitions();

            NewStudentGUI NewStudentGUIForm;

            NewStudentGUIForm = new NewStudentGUI();

            NewStudentGUIForm.ShowDialog();
        }

        public List<Class> getAllClasses()
        {
            return ClassProvider.getAllClasses();
        }

        public void storeNewStudent(
            string firstName,
            string lastName,
            DateTime birthday,
            char gender,
            string street,
            int zip,
            string city,
            Class selectedClass,
            bool isActive
        ) {
            StudentProvider.createStudent(
                firstName,
                lastName,
                birthday,
                gender,
                street,
                zip,
                city,
                selectedClass,
                isActive
            );
        }
    }
}
