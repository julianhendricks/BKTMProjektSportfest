using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsFestivalManagement.View;

namespace SportsFestivalManagement.Controller
{
    class SportCertificateController
    {
        static public void OpenSportCertificateGUI()
        {
            SportCertificateGUI SportCertificateForm;

            SportCertificateForm = new SportCertificateGUI();
            SportCertificateForm.ShowDialog();
        }
    }
}
