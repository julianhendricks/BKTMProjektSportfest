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
        /*
         * Instance constructor
         */
        private NewSportsFestivalController() { }

        private static readonly NewSportsFestivalController _instance = new NewSportsFestivalController();

        public static NewSportsFestivalController getInstance
        {
            get { return _instance; }
        }
        /*
         * End of Instance constructor
         */


        public void OpenNewSportsFestivalGUI()
        {
            List<Competition> competitions = CompetitionProvider.getAllCompetitions();

            NewSportsFestivalGUI NewSportsFestivalGUIForm;

            NewSportsFestivalGUIForm = new NewSportsFestivalGUI(this);
            NewSportsFestivalGUIForm.renderCompetitionsGrid(competitions);

            NewSportsFestivalGUIForm.ShowDialog();
        }

        public void createNewSportsFestival(DateTime sportsFestivalDate, List<Int32> competitionIds)
        {
            List<Competition> competitions = new List<Competition>();

            foreach (int competitionId in competitionIds)
            {
                Competition competition = CompetitionProvider.getCompetitionById(competitionId);
                competitions.Add(competition);
            }

            int sportsFestivalId = SportsFestivalProvider.createSportsFestival(sportsFestivalDate, competitions);

            SportsFestival sportsFestival = SportsFestivalProvider.getSportsFestivalById(sportsFestivalId);
            List<Student> students = StudentProvider.getAllActiveStudents();

            foreach (Student student in students)
            {
                SportsFestivalSubscriptionProvider.createSportsFestivalSubscription(
                    sportsFestival,
                    student
                );
            }
        }

    }
}
