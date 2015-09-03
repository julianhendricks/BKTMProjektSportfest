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
    public partial class StudentsAndClassesGUI : MetroFramework.Forms.MetroForm
    {
        public StudentsAndClassesGUI()
        {
            InitializeComponent();

            this.StyleManager = metroStyleManager;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
