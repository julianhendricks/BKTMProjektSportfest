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
    public partial class SportsFestivalManagementGUI : MetroFramework.Forms.MetroForm
    {
        private bool changesMade = false;
        private object initialData = null;

        public SportsFestivalManagementGUI()
        {
            InitializeComponent();
        }

        private void SportsFestivalManagementGUI_Shown(object sender, EventArgs e)
        {
            this.loadTabData(mainTabControl.SelectedTab);
        }

        private void metroTabControl1_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            if (this.authorizeTabChange() == false)
            {
                e.Cancel = true;
            }
        }

        private void metroTabControl1_Selected(object sender, TabControlEventArgs e)
        {
            this.loadTabData(e.TabPage);
            this.changesMade = false;
        }

        private void loadTabData(TabPage tab)
        {
            switch (tab.Name)
            {
                case "tabBenchmarks":
                    this.prepareBenchmarksTab();
                    break;
            }
        }

        private void prepareBenchmarksTab()
        {
            benchmarksGrid.Rows.Clear();
            benchmarksGrid.Columns.Clear();

            List<Benchmark> benchmarks = SportsFestivalManagementController.getInstance.getAllBenchmarks();

            DataGridViewComboBoxColumn disciplineColumn = new DataGridViewComboBoxColumn();
            disciplineColumn.DataSource = SportsFestivalManagementController.getInstance.getAllDisciplines();
            disciplineColumn.DisplayMember = "Name";
            disciplineColumn.ValueMember = "DisciplineId";
            disciplineColumn.Name = "Disziplin";
            disciplineColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewTextBoxColumn ageFromColumn = new DataGridViewTextBoxColumn();
            ageFromColumn.Name = "Alter: Von";
            ageFromColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewTextBoxColumn ageUntilColumn = new DataGridViewTextBoxColumn();
            ageUntilColumn.Name = "Alter: Bis";
            ageUntilColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewTextBoxColumn genderColumn = new DataGridViewTextBoxColumn();
            genderColumn.Name = "Geschlecht";
            genderColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewTextBoxColumn rankColumn = new DataGridViewTextBoxColumn();
            rankColumn.Name = "Rang";
            rankColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewTextBoxColumn valueColumn = new DataGridViewTextBoxColumn();
            valueColumn.Name = "Richtwert";
            valueColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewTextBoxColumn measureColumn = new DataGridViewTextBoxColumn();
            measureColumn.Name = "Einheit";
            measureColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            benchmarksGrid.Columns.Add(disciplineColumn);
            benchmarksGrid.Columns.Add(ageFromColumn);
            benchmarksGrid.Columns.Add(ageUntilColumn);
            benchmarksGrid.Columns.Add(genderColumn);
            benchmarksGrid.Columns.Add(rankColumn);
            benchmarksGrid.Columns.Add(valueColumn);
            benchmarksGrid.Columns.Add(measureColumn);

            foreach (Benchmark benchmark in benchmarks)
            {
                object[] dataRow = new object[] {
                    benchmark.Discipline.DisciplineId,
                    benchmark.AgeFrom,
                    benchmark.AgeUntil,
                    benchmark.Gender == 'm' ? "männlich" : "weiblich",
                    benchmark.Rank == "bronze" ? "Bronze" : benchmark.Rank == "silver" ? "Silber" : "Gold",
                    benchmark.BenchmarkValue,
                    benchmark.Discipline.Measure.Name
                };
                benchmarksGrid.Rows.Add(dataRow);
            }
        }

        private bool authorizeTabChange()
        {
            if (this.changesMade == false)
            {
                return true;
            }

            DialogResult decision = MessageBox.Show(
                "Es befinden sich nicht gespeicherte Änderungen in diesem Tab. Wenn Sie den Tab wechseln gehen diese Informationen verloren.\n\nSind Sie sicher, dass Sie den Tab wechseln möchten?",
                "Warnung",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (decision == DialogResult.Yes)
            {
                return true;
            }

            return false;
        }
    }
}
