using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sportfest_Verwaltung;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sportfest_Verwaltung
{
    class StudentsAndClassesController
    {
        List<Classes> ClassesCollection;
        SqlConnection StudentsAndClassesConnection;

        public static void OpenStudentsAndClassesGUI()
        {
            StudentsAndClassesGUI StudentsAndClassesGUIForm;
            StudentsAndClassesGUIForm = new StudentsAndClassesGUI();
            StudentsAndClassesGUIForm.ShowDialog();
        }

        public StudentsAndClassesController()
        {
            int currentClassId;
            string currentClassName;
            SqlDataReader ClassDS;

            ClassesCollection = new List<Classes>();
            StudentsAndClassesConnection = SQL.GetConnection();

            //Reader erstellen und durchlaufen
            String SQLStatement = "SELECT * FROM class";
            ClassDS = SQL.GetReader(SQLStatement, StudentsAndClassesConnection);
            while (ClassDS.Read())
            {
                currentClassId = Convert.ToInt32(ClassDS["classId"]);
                currentClassName = Convert.ToString(ClassDS["shortcut"]);

                Classes CurrentItem = new Classes(currentClassId, currentClassName);
                ClassesCollection.Add(CurrentItem);
            }
            ClassDS.Close();
        }

        public void LoadClassesListView(ListView iListView)
        {
            foreach (Classes CurrentClass in ClassesCollection)
            {
                string[] row = { CurrentClass.ClassId.ToString(), CurrentClass.getShortcut().ToString() };
                iListView.Items.Add(new ListViewItem(row));
            }
        }

        public void AddNewClass(ListView iListView)
        {
            Classes newClass;            

            newClass = new Classes(iListView.Items.Count + 1, "Kürzel");
            newClass.newFlag = true;
            ClassesCollection.Add(newClass);

            string[] row = { Convert.ToString(iListView.Items.Count + 1), "Kürzel" };
            iListView.Items.Add(new ListViewItem(row));
        }

        public void UpdateClassShortcut(string iNewShortCut, int iClassID, ListView iListView)
        {
            Classes ChangedClass = ClassesCollection.First(ClassCol => ClassCol.ClassId == iClassID);
            ChangedClass.setShortcut(iNewShortCut);
            ChangedClass.changedFlag = true;

            int Index = iListView.FindItemWithText(Convert.ToString(iClassID)).Index;
            iListView.Items[Index].SubItems[1].Text = iNewShortCut;
        }
    }
}
