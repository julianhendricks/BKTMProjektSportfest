using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportsFestivalManagement.Provider;
using SportsFestivalManagement.Entities;
using SportsFestivalManagement.Controller;

namespace SportsFestivalManagement.View
{
    public partial class ResultsGUI : MetroFramework.Forms.MetroForm
    {
        internal ResultsGUI(ResultsController controller)
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GridResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        internal void updateSubscriptions(SportsFestival curSportsFestival)
        {
            cbClass.DataSource = SportsFestivalSubscriptionProvider.getClassesBySportsFestival(curSportsFestival);
            cbClass.ValueMember = "classId";
            cbClass.DisplayMember = "Shortcut";
            cbClass.SelectedItem = null;

            cbStudent.DataSource = SportsFestivalSubscriptionProvider.getStudentsBySportsFestival(curSportsFestival);
            cbStudent.ValueMember = "studentId";
            cbStudent.SelectedItem = null;
        }

        private void cbStudent_Format(object sender, ListControlConvertEventArgs e)
        {
            string firstname = ((Student)e.ListItem).FirstName;
            string lastname= ((Student)e.ListItem).LastName;
            e.Value = lastname + ", " + firstname;
        }

        private void cbClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbStudent.DataSource = StudentProvider.getAllStudentsByClassId((int)cbClass.SelectedValue);
            cbStudent.SelectedItem = null;
        }
    }
}
