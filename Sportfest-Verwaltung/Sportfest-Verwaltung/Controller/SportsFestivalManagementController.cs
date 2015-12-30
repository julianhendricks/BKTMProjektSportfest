using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using SportsFestivalManagement.Entities;
using SportsFestivalManagement.Provider;
using SportsFestivalManagement.View;

namespace SportsFestivalManagement.Controller
{
    class SportsFestivalManagementController
    {
        /*
         * Instance constructor
         */
        private SportsFestivalManagementController() { }

        private static readonly SportsFestivalManagementController _instance = new SportsFestivalManagementController();

        public static SportsFestivalManagementController getInstance
        {
            get { return _instance; }
        }
        /*
         * End of Instance constructor
         */


        private SportsFestivalManagementGUI view = null;

        public void openSportsFestivalManagementForm()
        {
            MessageBox.Show(
                "Bitte beachten Sie, dass Änderungen an den folgenden Daten alle existierenden Datensätze beeinflussen!\nNehmen Sie Änderungen mit Bedacht vor.",
                "Warnung",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            this.getView().ShowDialog();
        }

        public List<Benchmark> getAllBenchmarks()
        {
            return BenchmarkProvider.getAllBenchmarks();
        }

        public List<Discipline> getAllDisciplines()
        {
            return DisciplineProvider.getAllDisciplines();
        }

        public List<Variant> getAllVariants()
        {
            return VariantProvider.getAllVariants();
        }



        private SportsFestivalManagementGUI getView()
        {
            if (this.view == null)
            {
                this.view = new SportsFestivalManagementGUI();

                FormClosedEventHandler handler = (sender, e) =>
                {
                    this.view = null;
                };

                this.view.FormClosed += handler;
            }

            return this.view;
        }
    }
}
