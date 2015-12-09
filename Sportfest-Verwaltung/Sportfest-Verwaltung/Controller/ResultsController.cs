using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFestivalManagement
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
