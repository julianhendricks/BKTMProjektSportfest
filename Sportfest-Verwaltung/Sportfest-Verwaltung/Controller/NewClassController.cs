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
    class NewClassController
    {
        /*
         * Instance constructor
         */
        private NewClassController() { }

        private static readonly NewClassController _instance = new NewClassController();

        public static NewClassController getInstance
        {
            get { return _instance; }
        }
        /*
         * End of Instance constructor
         */


        public void OpenNewClassGUI()
        {
            NewClassGUI NewClassGUIForm;

            NewClassGUIForm = new NewClassGUI();

            NewClassGUIForm.ShowDialog();
        }

        public bool classShortcutExists(
            string prefix,
            int year,
            string suffix
        ) {
            if (
                ClassProvider.getClassByShortcut(
                    prefix,
                    year,
                    suffix
                ) == null
            ) {
                return false;
            }

            return true;
        }

        public void storeNewClass(
            string prefix,
            int year,
            string suffix
        ) {
            ClassProvider.createClass(
                prefix,
                year,
                suffix
            );
        }
    }
}
