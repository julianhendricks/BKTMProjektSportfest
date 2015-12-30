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

    public partial class DisciplinesGUI : MetroFramework.Forms.MetroForm
    {
        List<int> addedRows = new List<int> { };

        internal DisciplinesGUI(DisciplinesController controller)
        {
            InitializeComponent();

            this.StyleManager = metroStyleManager;
        }

        internal void updateDisciplines(List<Discipline> availableDisciplines)
        {
            dgvDisciplines.Rows.Clear();

            DataGridViewTextBoxColumn textBoxName = new DataGridViewTextBoxColumn();
            dgvDisciplines.Columns.Add(textBoxName);

            DataGridViewComboBoxColumn comboBoxCategory = new DataGridViewComboBoxColumn();
            comboBoxCategory.DataSource = CategoryProvider.getAllCategories();
            comboBoxCategory.DataPropertyName = "categoryName";
            comboBoxCategory.ValueMember = "categoryId";
            comboBoxCategory.DisplayMember = "categoryName";
            dgvDisciplines.Columns.Add(comboBoxCategory);

            List<Measure> allMeasures = MeasureProvider.getAllMeasures();
            allMeasures.Insert(0, new Measure(0, "", ""));

            DataGridViewComboBoxColumn comboBoxMeasure = new DataGridViewComboBoxColumn();
            comboBoxMeasure.DataSource = allMeasures;
            comboBoxMeasure.DataPropertyName = "name";
            comboBoxMeasure.ValueMember = "measureId";
            comboBoxMeasure.DisplayMember = "name";
            dgvDisciplines.Columns.Add(comboBoxMeasure);

            int i = 0;
            
            foreach (Discipline discipline in availableDisciplines)
            {
                if (discipline == null)
                {
                    continue;
                }

                object[] rowData = new object[]
                {
                    discipline.Name,
                    discipline.Category == null ? 0 : discipline.Category.CategoryId,
                    discipline.Measure == null ? 0 : discipline.Measure.MeasureId
                };

                dgvDisciplines.Rows.Add(rowData);
                dgvDisciplines.Rows[i].ReadOnly = true;
                i += 1;
                 
            }       
        }

        internal void renderDisciplinesGrid(List<Discipline> disciplines)
        {
            dgvDisciplines.Rows.Clear();
            int i = 0;
            foreach (Discipline discipline in disciplines)
            {
                object[] rowData = new object[] {
                    discipline.Name,
                    discipline.Category == null ? 0 : discipline.Category.CategoryId,
                    discipline.Measure == null ? 0 : discipline.Measure.MeasureId
                };

                dgvDisciplines.Rows.Add(rowData);
                dgvDisciplines.Rows[i].ReadOnly = true;
                i += 1;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSportCertificate_Click(object sender, EventArgs e)
        {
            SportCertificateController.OpenSportCertificateGUI();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvDisciplines.Rows.Add();
            addedRows.Add(dgvDisciplines.RowCount-1);            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<object> saveList = new List<object> { };

            foreach (int row in addedRows)
            {
                object[] rowData = new object[]
                {
                    dgvDisciplines.Rows[row].Cells[0].Value,
                    dgvDisciplines.Rows[row].Cells[1].Value,
                    dgvDisciplines.Rows[row].Cells[2].Value,
                };
                saveList.Add(rowData);
            }

            DisciplinesController.getInstance.Save(saveList);
        }
    }
}
