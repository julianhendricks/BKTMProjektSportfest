using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsFestivalManagement.View;
using SportsFestivalManagement.Provider;
using SportsFestivalManagement.Entities;
using SportsFestivalManagement.Controller;

namespace SportsFestivalManagement.Controller
{
    class ResultsController
    {
        private ResultsController() { }

        private ResultsGUI ResultsGUIForm;

        private static readonly ResultsController _instance = new ResultsController();

        public static ResultsController getInstance
        {
            get { return _instance; }
        } 

        public void OpenResultsGUI(SportsFestival curSportsFestival)
        {
            ResultsGUIForm = new ResultsGUI(this);

            ResultsGUIForm.updateSubscriptions(curSportsFestival);

            ResultsGUIForm.ShowDialog();
        }
    }
}
