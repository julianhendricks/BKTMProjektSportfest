using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportsFestivalManagement.Entities;
using SportsFestivalManagement.Controller;

namespace SportsFestivalManagement.View
{
    public partial class StudentsAndClassesGUI : MetroFramework.Forms.MetroForm
    {
        const string studentsGridColumnStudentId = "studentId";
        const string studentsGridColumnStudentFirstName = "studentFirstName";
        const string studentsGridColumnStudentLastName = "studentLastName";
        const string studentsGridColumnStudentClass = "studentClass";

        const string classesGridColumnClassId = "classId";
        const string classesGridColumnClassShortcut = "classShortcut";

        public StudentsAndClassesGUI()
        {
            InitializeComponent();

            this.StyleManager = metroStyleManager;
        }

        private void StudentsAndClassesGUI_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn studentIdColumn = new DataGridViewTextBoxColumn();
            studentIdColumn.HeaderText = "Schüler-ID";
            studentIdColumn.Name = studentsGridColumnStudentId;
            studentIdColumn.Visible = false;

            DataGridViewTextBoxColumn studentFirstNameColumn = new DataGridViewTextBoxColumn();
            studentFirstNameColumn.HeaderText = "Vorname";
            studentFirstNameColumn.Name = studentsGridColumnStudentFirstName;
            studentFirstNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewTextBoxColumn studentLastNameColumn = new DataGridViewTextBoxColumn();
            studentLastNameColumn.HeaderText = "Nachname";
            studentLastNameColumn.Name = studentsGridColumnStudentLastName;
            studentLastNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewTextBoxColumn studentClassColumn = new DataGridViewTextBoxColumn();
            studentClassColumn.HeaderText = "Klasse";
            studentClassColumn.Name = studentsGridColumnStudentClass;
            studentClassColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            studentsGrid.Columns.Add(studentIdColumn);
            studentsGrid.Columns.Add(studentFirstNameColumn);
            studentsGrid.Columns.Add(studentLastNameColumn);
            studentsGrid.Columns.Add(studentClassColumn);



            DataGridViewTextBoxColumn classesIdColumn = new DataGridViewTextBoxColumn();
            classesIdColumn.HeaderText = "Klassen-ID";
            classesIdColumn.Name = classesGridColumnClassId;
            classesIdColumn.Visible = false;

            DataGridViewTextBoxColumn classesShortcutColumn = new DataGridViewTextBoxColumn();
            classesShortcutColumn.HeaderText = "Kürzel";
            classesShortcutColumn.Name = classesGridColumnClassShortcut;
            classesShortcutColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            classesGrid.Columns.Add(classesIdColumn);
            classesGrid.Columns.Add(classesShortcutColumn);

            this.renderStudentsGrid();
            this.renderClassesGrid();
        }

        public void renderStudentsGrid()
        {
            studentsGrid.Rows.Clear();

            foreach (Student student in StudentsAndClassesController.getInstance.getAllStudentsOrderedByAscendingLastName())
            {
                object[] rowData = new object[] {
                    student.StudentId,
                    student.FirstName,
                    student.LastName,
                    student.ClassObject.Shortcut
                };

                studentsGrid.Rows.Add(rowData);
            }
        }

        public void renderClassesGrid()
        {
            classesGrid.Rows.Clear();

            foreach (Class classObject in StudentsAndClassesController.getInstance.getAllClassesOrderedByAscendingShortcut())
            {
                object[] rowData = new object[] {
                    classObject.ClassId,
                    classObject.Shortcut
                };

                classesGrid.Rows.Add(rowData);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            TabPage selectedTab = tcStudentsAndClasses.SelectedTab;
            if (selectedTab == pagStudents)
            {
                StudentsAndClassesController.getInstance.openNewStudentForm();
            } else if (selectedTab == pagClasses) {
                StudentsAndClassesController.getInstance.openNewClassForm();
            }
        }

        private void tcStudentsAndClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage selectedTab = tcStudentsAndClasses.SelectedTab;
            if (selectedTab == pagStudents)
            {
                btnUpgrade.Visible = false;
            }
            else if (selectedTab == pagClasses)
            {
                btnUpgrade.Visible = true;
            }
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            StudentsAndClassesController.getInstance.rotateClasses();
            MessageBox.Show("Alle Klassen wurden hochgestuft.");
            this.renderClassesGrid();
            this.renderStudentsGrid();
        }
    }
}
