﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsfestivalManagement
{
    class NewSportsFestivalController
    {
        public static void OpenNewSportsFestivalGUI()
        {
            NewSportsFestivalGUI NewSportsFestivalGUIForm;

            NewSportsFestivalGUIForm = new NewSportsFestivalGUI();
            NewSportsFestivalGUIForm.ShowDialog();
        }
    }
}