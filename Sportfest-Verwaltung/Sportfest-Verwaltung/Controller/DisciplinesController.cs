using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsFestivalManagement.View;

namespace SportsFestivalManagement.Controller
{
    class DisciplinesController
    {
        public static void OpenDisciplinesGUI()
        {
            DisciplinesGUI DisciplinesGUIForm;

            DisciplinesGUIForm = new DisciplinesGUI();
            DisciplinesGUIForm.ShowDialog();
        }
    }
}
