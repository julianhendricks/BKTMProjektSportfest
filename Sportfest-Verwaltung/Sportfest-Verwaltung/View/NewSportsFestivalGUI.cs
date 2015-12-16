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
using System.Dynamic;

namespace SportsFestivalManagement.View
{
    public partial class NewSportsFestivalGUI : MetroFramework.Forms.MetroForm
    {
        const string competitionGridColumn0Name = "selected";
        const string competitionGridColumn1Name = "competitionId";
        const string competitionGridColumn2Name = "competitionName";

        internal NewSportsFestivalGUI(NewSportsFestivalController controller)
        {
            InitializeComponent();

            this.StyleManager = metroStyleManager;

            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
            checkboxColumn.HeaderText = "";
            checkboxColumn.Name = competitionGridColumn0Name;
            checkboxColumn.Width = 50;

            DataGridViewTextBoxColumn competitionIdColumn = new DataGridViewTextBoxColumn();
            competitionIdColumn.HeaderText = "Wettkampf-ID";
            competitionIdColumn.Name = competitionGridColumn1Name;
            competitionIdColumn.Visible = false;

            DataGridViewTextBoxColumn competitionNameColumn = new DataGridViewTextBoxColumn();
            competitionNameColumn.HeaderText = "Wettkampf";
            competitionNameColumn.Name = competitionGridColumn2Name;
            competitionNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            competitionNameColumn.ReadOnly = true;

            competitionGrid.Columns.Add(checkboxColumn);
            competitionGrid.Columns.Add(competitionIdColumn);
            competitionGrid.Columns.Add(competitionNameColumn);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        internal void renderCompetitionsGrid(List<Competition> competitions)
        {
            foreach (Competition competition in competitions)
            {
                object[] rowData = new object[] {
                    false,
                    competition.CompetitionId,
                    competition.CompetitionName
                };

                competitionGrid.Rows.Add(rowData);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (checkAllowSave() == false)
            {
                MessageBox.Show("Bitte stellen Sie sicher, dass Sie ein Datum ausgewählt haben, welches in der Zukunft liegt und mindestens einen Wettbewerb ausgewählt haben.");
                return;
            }

            List<Int32> selectedCompetitionIds = new List<Int32>();

            for (int i = 0; i < competitionGrid.Rows.Count; i++)
            {
                if (Convert.ToBoolean(competitionGrid.Rows[i].Cells[competitionGridColumn0Name].Value) == true)
                {
                    selectedCompetitionIds.Add(Convert.ToInt32(competitionGrid.Rows[i].Cells[competitionGridColumn1Name].Value));
                }
            }

            NewSportsFestivalController.getInstance.createNewSportsFestival(dateTimePickerSportsFestival.Value, selectedCompetitionIds);

            MessageBox.Show("Das Sportfest wurde erfolgreich angelegt.");
            Close();
        }

        private bool checkAllowSave()
        {
            if (dateTimePickerSportsFestival.Value.CompareTo(new DateTime()) <= 0) {
                return false;
            }

            Boolean rowIsChecked = false;
            for (int i = 0; i < competitionGrid.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell checkboxCell = competitionGrid.Rows[i].Cells[competitionGridColumn0Name] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(checkboxCell.Value) == true)
                {
                    rowIsChecked = true;
                    break;
                }
            }

            return rowIsChecked;
        }
    }
}
