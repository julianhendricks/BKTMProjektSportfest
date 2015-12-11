using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsFestivalManagement.View;

namespace SportsFestivalManagement.Controller
{
    class ResultsController
    {
        static public void OpenResultsGUI()
        {
            ResultsGUI ResultsForm;

            ResultsForm = new ResultsGUI();
            ResultsForm.ShowDialog();
        }
    }
}
