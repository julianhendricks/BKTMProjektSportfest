using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsFestivalManagement;
using System.Data.SqlClient;
using System.Windows.Forms;
using SportsFestivalManagement.View;
using SportsFestivalManagement.Entities;
using SportsFestivalManagement.Provider;

namespace SportsFestivalManagement.Controller
{
    class StudentsAndClassesController
    {
        /*
         * Instance constructor
         */
        private StudentsAndClassesController() { }

        private static readonly StudentsAndClassesController _instance = new StudentsAndClassesController();

        public static StudentsAndClassesController getInstance
        {
            get { return _instance; }
        }
        /*
         * End of Instance constructor
         */

        private StudentsAndClassesGUI view = null;

        public void OpenStudentsAndClassesGUI()
        {
            this.getView().ShowDialog();
        }

        public List<Student> getAllStudentsOrderedByAscendingLastName()
        {
            return StudentProvider.getAllStudentsOrderedByAscendingLastName();
        }

        public List<Class> getAllClassesOrderedByAscendingShortcut()
        {
            return ClassProvider.getAllClassesOrderedByAscendingShortcut();
        }

        public void openNewStudentForm()
        {
            NewStudentController.getInstance.OpenNewStudentGUI();
            this.getView().renderStudentsGrid();
        }

        public void openNewClassForm()
        {
            NewClassController.getInstance.OpenNewClassGUI();
            this.getView().renderClassesGrid();
        }

        public void rotateClasses()
        {
            ClassProvider.rotateClasses();
        }

        private StudentsAndClassesGUI getView()
        {
            if (this.view == null) {
                this.view = new StudentsAndClassesGUI();

                FormClosedEventHandler handler = (sender, e) =>
                {
                    this.view = null;
                };

                this.view.FormClosed += handler;
            }

            return this.view;
        }
    }
}
