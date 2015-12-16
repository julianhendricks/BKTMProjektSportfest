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
            List<Competition> competitions = CompetitionProvider.getAllCompetitions();

            NewSportsFestivalGUI NewSportsFestivalGUIForm;

            NewSportsFestivalGUIForm = new NewSportsFestivalGUI(this);
            NewSportsFestivalGUIForm.Show();

            NewSportsFestivalGUIForm.renderCompetitionsGrid(competitions);
        }

        public void createNewSportsFestival(DateTime sportsFestivalDate, List<Int32> competitionIds)
        {
            List<Competition> competitions = new List<Competition>();

            foreach (int competitionId in competitionIds)
            {
                Competition competition = CompetitionProvider.getCompetitionById(competitionId);
                competitions.Add(competition);
            }

            SportsFestivalProvider.createSportsFestival(sportsFestivalDate, competitions);
        }

    }
}
