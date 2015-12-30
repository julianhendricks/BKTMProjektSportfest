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
        private SportsFestival m_SportsFestivalRef = null;

        internal ResultsGUI(ResultsController controller, SportsFestival curSportsFestival)
        {
            m_SportsFestivalRef = curSportsFestival;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GridResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        internal void updateSubscriptions()
        {
            cbClass.DataSource = ClassProvider.getClassesBySportsFestival(m_SportsFestivalRef);
            cbClass.ValueMember = "classId";
            cbClass.DisplayMember = "classId";
            cbClass.SelectedItem = null;
            /*
            cbStudent.DataSource = StudentProvider.getStudentsBySportsFestival(curSportsFestival);
            cbStudent.ValueMember = "studentId";
            cbStudent.SelectedItem = null;
            */
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

        private void cbClass_Format(object sender, ListControlConvertEventArgs e)
        {
            string prefix = ((Class)e.ListItem).Prefix;
            string suffix = ((Class)e.ListItem).Suffix;
            e.Value = prefix + suffix;
        }

        private void cbStudent_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.renderResultsGrid();
        }

        internal void renderResultsGrid()
        {
            dgvResults.Rows.Clear();
            
            DataGridViewTextBoxColumn textBoxCompetition = new DataGridViewTextBoxColumn();
            textBoxCompetition.ReadOnly = true;
            dgvResults.Columns.Add(textBoxCompetition);
            
       
            DataGridViewTextBoxColumn textBoxDiscipline = new DataGridViewTextBoxColumn();
            textBoxCompetition.ReadOnly = true;
            dgvResults.Columns.Add(textBoxDiscipline);

            DataGridViewTextBoxColumn textBoxResult = new DataGridViewTextBoxColumn();
            dgvResults.Columns.Add(textBoxResult);         

            foreach (Competition competition in CompetitionProvider.getCompetitionsBySportsFestival(m_SportsFestivalRef))
            {
                if (competition == null)
                {
                    continue;
                }

                List<DisciplineSet> disciplineSetsList = CompetitionDisciplineSetProvider.getDisciplineSetsByCompetition(competition);
                
                foreach(DisciplineSet disciplineSet in disciplineSetsList)
                {
                    foreach(Discipline discipline in DisciplineProvider.getDisciplinesByDisciplineSetId(disciplineSet))
                    {
                        object[] rowData = new object[]
                        {
                            competition.CompetitionName,
                            discipline.Name,
                            ""
                        };
                        dgvResults.Rows.Add(rowData);
                    }
                }                                
            }
        }
    }
}
