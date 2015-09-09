using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsfestivalManagement;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SportsfestivalManagement
{
    class StudentsAndClassesController
    {
        SqlConnection StudentsAndClassesConnection;

        public static void OpenStudentsAndClassesGUI()
        {
            StudentsAndClassesGUI StudentsAndClassesGUIForm;
            StudentsAndClassesGUIForm = new StudentsAndClassesGUI();
            StudentsAndClassesGUIForm.ShowDialog();
        }

        public StudentsAndClassesController()
        {
            /*int currentClassId;
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
            ClassDS.Close();*/
        }

        public void LoadClassesListView(ListView iListView)
        {
            /*foreach (Classes CurrentClass in ClassesCollection)
            {
                string[] row = { CurrentClass.ClassId.ToString(), CurrentClass.getShortcut().ToString() };
                iListView.Items.Add(new ListViewItem(row));
            }*/
        }

        public void AddNewClass(ListView iListView)
        {
            /*Classes newClass;            

            newClass = new Classes(iListView.Items.Count + 1, "Kürzel");
            newClass.newFlag = true;
            ClassesCollection.Add(newClass);

            string[] row = { Convert.ToString(iListView.Items.Count + 1), "Kürzel" };
            iListView.Items.Add(new ListViewItem(row));*/
        }

        public void UpdateClassShortcut(string iNewShortCut, int iClassID, ListView iListView)
        {
            /*Classes ChangedClass = ClassesCollection.First(ClassCol => ClassCol.ClassId == iClassID);
            ChangedClass.setShortcut(iNewShortCut);
            ChangedClass.changedFlag = true;

            int Index = iListView.FindItemWithText(Convert.ToString(iClassID)).Index;
            iListView.Items[Index].SubItems[1].Text = iNewShortCut;*/
        }

        public void DeleteClass(int iClassId, ListView iListView)
        {
            /*Classes DeletedClass = ClassesCollection.First(ClassCol => ClassCol.ClassId == iClassId);
            DeletedClass.deletedFlag = true;

            int Index = iListView.FindItemWithText(Convert.ToString(iClassId)).Index;
            iListView.Items[Index].Remove();*/
        }

        public void UpdateClassTable()
        {
            /*string SQLStatement;
            foreach (Classes Class in ClassesCollection)
            {
                SQLStatement = "";
                if (Class.newFlag == true)
                {
                    SQLStatement = "INSERT INTO class (classId, shortcut) VALUES (" + Convert.ToString(Class.ClassId)
                        + ", '" + Class.getShortcut() + "')";
                }
                else if (Class.changedFlag == true)
                {
                    SQLStatement = "UPDATE class SET shortcut = '" + Class.getShortcut() + "' WHERE classId = "
                        + Convert.ToString(Class.ClassId);
                }
                if (Class.deletedFlag == true)
                {
                    SQLStatement = "DELETE FROM class WHERE classId = " + Convert.ToString(Class.ClassId);
                }

                if (SQLStatement != "")
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = SQLStatement;
                    cmd.Connection = StudentsAndClassesConnection;
                    cmd.ExecuteNonQuery();
                }
            }*/
        }
    }
}
