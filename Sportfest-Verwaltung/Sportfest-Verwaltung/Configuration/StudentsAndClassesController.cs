using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sportfest_Verwaltung;

namespace Sportfest_Verwaltung
{
    class StudentsAndClassesController
    {
        public static void OpenStudentsAndClassesGUI()
        {
            StudentsAndClassesGUI StudentsAndClassesGUIForm;
            StudentsAndClassesGUIForm = new StudentsAndClassesGUI();
            StudentsAndClassesGUIForm.ShowDialog();
        }
    }
}
