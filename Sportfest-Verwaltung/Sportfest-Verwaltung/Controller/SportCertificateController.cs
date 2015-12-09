using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFestivalManagement
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
