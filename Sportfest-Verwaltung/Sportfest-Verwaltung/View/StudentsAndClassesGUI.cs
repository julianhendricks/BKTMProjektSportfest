using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsfestivalManagement
{
    public partial class StudentsAndClassesGUI : MetroFramework.Forms.MetroForm
    {
        StudentsAndClassesController MyController;

        public StudentsAndClassesGUI()
        {
            InitializeComponent();

            this.StyleManager = metroStyleManager;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StudentsAndClassesGUI_Load(object sender, EventArgs e)
        {
            MyController = new StudentsAndClassesController();
            MyController.LoadClassesListView(lvClasses);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (tcStudentsAndClasses.SelectedTab == pagClasses)
            {
                MyController.AddNewClass(lvClasses);
            }
        }

        private void lvClasses_Click(object sender, EventArgs e)
        {
            edtShortcut.Text = lvClasses.SelectedItems[0].SubItems[1].Text;
        }

        private void edtShortcut_TextChanged(object sender, EventArgs e)
        {
            int ClassId = Convert.ToInt32(lvClasses.SelectedItems[0].Text);
            MyController.UpdateClassShortcut(edtShortcut.Text, ClassId, lvClasses);
        }

        private void StudentsAndClassesGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyController.UpdateClassTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tcStudentsAndClasses.SelectedTab == pagClasses)
            {
                int ClassId = Convert.ToInt32(lvClasses.SelectedItems[0].Text);
                MyController.DeleteClass(ClassId, lvClasses);
            }
        }
    }
}
