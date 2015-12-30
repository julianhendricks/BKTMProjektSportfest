using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportsFestivalManagement.Controller;
using SportsFestivalManagement.Provider;
using SportsFestivalManagement.Entities;
using MySql.Data.MySqlClient;

namespace SportsFestivalManagement.View
{
    public partial class SportsFestivalGUI : MetroFramework.Forms.MetroForm
    {
        const string sportsFestivalGridColumn0Name = "sportsFestivalId";
        const string sportsFestivalGridColumn1Name = "sportsFestivalName";

        public SportsFestivalGUI()
        {
            InitializeComponent();

            this.StyleManager = metroStyleManager;
        }

        public void renderSportsFestivalsGrid()
        {
            List<SportsFestival> sportsFestivals = SportsFestivalController.getInstance.getAllSportsFestivalsOrderedByDescendingDate();
            sportsFestivalGrid.Rows.Clear();

            foreach (SportsFestival sportsFestival in sportsFestivals)
            {
                object[] rowData = new object[] {
                    sportsFestival.SportsFestivalId,
                    "Sportfest "
                        + String.Format("{0:dd/MM/yyyy}", sportsFestival.Date)
                };

                sportsFestivalGrid.Rows.Add(rowData);
            }
        }
        
        private void btnStudentsAndClasses_Click_1(object sender, EventArgs e)
        {
            StudentsAndClassesController.getInstance.OpenStudentsAndClassesGUI();
        }

        private void btnDisciplines_Click(object sender, EventArgs e)
        {
            DisciplinesController.getInstance.OpenDisciplinesGUI();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            SportsFestivalController.getInstance.openNewSportsFestivalForm();
            renderSportsFestivalsGrid();
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            if (sportsFestivalGrid.CurrentRow != null)
            {
                int curSportsFestivalId = (int)sportsFestivalGrid.CurrentRow.Cells[0].Value;
                ResultsController.getInstance.OpenResultsGUI(SportsFestivalProvider.getSportsFestivalById(curSportsFestivalId));
            }            
        }

        private void Sportsfestival_Load(object sender, EventArgs e)
        {
            sportsFestivalGrid.Focus();

            while (SportsFestivalController.getConnectionStateByConfigurationValues().Item1 == false)
            {
                ConnectionSetupController.OpenSetupConnectionGUI();
            }

            DataGridViewTextBoxColumn sportsFestivalIdColumn = new DataGridViewTextBoxColumn();
            sportsFestivalIdColumn.HeaderText = "Sportfest-ID";
            sportsFestivalIdColumn.Name = sportsFestivalGridColumn0Name;
            sportsFestivalIdColumn.Visible = false;

            DataGridViewTextBoxColumn sportsFestivalNameColumn = new DataGridViewTextBoxColumn();
            sportsFestivalNameColumn.HeaderText = "Sportfest";
            sportsFestivalNameColumn.Name = sportsFestivalGridColumn1Name;
            sportsFestivalNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sportsFestivalNameColumn.ReadOnly = true;

            sportsFestivalGrid.Columns.Add(sportsFestivalIdColumn);
            sportsFestivalGrid.Columns.Add(sportsFestivalNameColumn);

            this.renderSportsFestivalsGrid();
        }

        private void sportsFestivalGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SportsFestivalController.getInstance.openSportsFestivalDetailsForm();
        }

        private void btSportsFestivalData_Click(object sender, EventArgs e)
        {
            SportsFestivalController.getInstance.openSportsFestivalManagementForm();
        }
    }
}
