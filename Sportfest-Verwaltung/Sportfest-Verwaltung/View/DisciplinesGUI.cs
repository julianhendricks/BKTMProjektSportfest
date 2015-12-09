using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsFestivalManagement
{
    public partial class DisciplinesGUI : MetroFramework.Forms.MetroForm
    {
        public DisciplinesGUI()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSportCertificate_Click(object sender, EventArgs e)
        {
            SportCertificateController.OpenSportCertificateGUI();
        }
    }
}
