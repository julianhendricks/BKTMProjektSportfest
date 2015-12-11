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
    public partial class NewSportsFestivalGUI : MetroFramework.Forms.MetroForm
    {
        internal NewSportsFestivalGUI(NewSportsFestivalController controller)
        {
            InitializeComponent();

            this.StyleManager = metroStyleManager;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        internal void updateDisciplines(List<Discipline> availableDisciplines, List<Discipline> selectedDisciplines)
        {
            lbAvailableDisciplines.Items.Clear();
            lbActiveDisciplines.Items.Clear();

            foreach (Discipline discipline in availableDisciplines)
            {
                if (discipline == null)
                {
                    continue;
                }

                lbAvailableDisciplines.Items.Add(discipline.Name);
            }

            foreach (Discipline discipline in selectedDisciplines)
            {
                if (discipline == null)
                {
                    continue;
                }

                lbActiveDisciplines.Items.Add(discipline.Name);
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lbAvailableDisciplines.SelectedIndices.ToString());
            NewSportsFestivalController.getInstance.test123();
        }
    }
}
