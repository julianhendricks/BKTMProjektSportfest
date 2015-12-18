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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            ResultsController.OpenResultsGUI();
        }

        private void Sportsfestival_Load(object sender, EventArgs e)
        {
            while (SportsFestivalController.getConnectionStateByConfigurationValues().Item1 == false)
            {
                ConnectionSetupController.OpenSetupConnectionGUI();
            }

            MySQL mySql = MySQLProvider.getMySQLInstance();
            mySql.connect();
            var result = mySql.query("SELECT * FROM sportsFestival");

            

            /*while (reader.Read())
            {
                MessageBox.Show(reader.ToString());
                reader.GetType();
            }*/

            

            /*foreach (SportsFestival sportsFestival in SportsFestivalController.getAllSportsFestivals())
            {
                string[] row = {
                    sportsFestival.SportsFestivalId.ToString(),
                    "Sportfest " + sportsFestival.Date.Year.ToString()
                };
                lvSportsfestivals.Items.Add(new ListViewItem(row));
            }*/

            //SportsfestivalController.LoadSportsFestivalListView(lvSportsfestivals);
        }

        private void sportsFestivalGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SportsFestivalController.getInstance.openSportsFestivalDetailsForm();
        }
    }
}
