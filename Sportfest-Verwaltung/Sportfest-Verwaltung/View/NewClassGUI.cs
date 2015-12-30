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
    public partial class NewClassGUI : MetroFramework.Forms.MetroForm
    {
        const string competitionGridColumn0Name = "selected";
        const string competitionGridColumn1Name = "competitionId";
        const string competitionGridColumn2Name = "competitionName";

        internal NewClassGUI()
        {
            InitializeComponent();

            this.StyleManager = metroStyleManager;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string prefix = tbPrefix.Text;
            int year = Convert.ToInt32(numYear.Value);
            string suffix = tbSuffix.Text;

            if (year != 0) {
                if (NewClassController.getInstance.classShortcutExists(prefix, year, suffix) == false)
                {
                    NewClassController.getInstance.storeNewClass(prefix, year, suffix);
                    Close();
                }
                else
                {
                    MessageBox.Show(
                        "Es existiert bereits eine Klasse mit dem gewählten Kürzel!",
                        "Fehler",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            } else {
                MessageBox.Show(
                    "Bitte füllen Sie mindestens das Feld \"Jahrgangsnummer\" aus.",
                    "Hinweis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}
