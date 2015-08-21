using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sportfest_Verwaltung
{
    public partial class Sportsfestival : MetroFramework.Forms.MetroForm
    {
        public Sportsfestival()
        {
            InitializeComponent();

            this.StyleManager = metroStyleManager;
        }
        
        private void btnStudentsAndClasses_Click_1(object sender, EventArgs e)
        {
            StudentsAndClassesController.OpenStudentsAndClassesGUI();
        }

        private void btnDisciplines_Click(object sender, EventArgs e)
        {
            DisciplinesController.OpenDisciplinesGUI();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewSportsFestivalController.OpenNewSportsFestivalGUI();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
