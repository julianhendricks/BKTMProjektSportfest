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
    public partial class NewStudentGUI : MetroFramework.Forms.MetroForm
    {
        const string competitionGridColumn0Name = "selected";
        const string competitionGridColumn1Name = "competitionId";
        const string competitionGridColumn2Name = "competitionName";

        internal NewStudentGUI()
        {
            InitializeComponent();

            this.StyleManager = metroStyleManager;

            cbClass.DataSource = NewStudentController.getInstance.getAllClasses();
            cbClass.DisplayMember = "Shortcut";

            dpBirthday.Value = DateTime.Today.AddYears(-10);
            dpBirthday.MaxDate = DateTime.Today;

            cbGender.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            DateTime birthday = dpBirthday.Value;
            char gender = cbGender.Text == "weiblich" ? 'f' : 'm';
            string street = tbStreet.Text;
            int zip = Convert.ToInt32(tbZip.Text == "" ? "0" : tbZip.Text);
            string city = tbCity.Text;
            Class selectedClass = cbClass.SelectedItem as Class;
            bool isActive = cbActive.Checked;

            if (checkSaveAllowed(
                    firstName,
                    lastName,
                    birthday,
                    gender,
                    street,
                    zip,
                    city,
                    selectedClass
                ) == true
            ) {
                NewStudentController.getInstance.storeNewStudent(
                    firstName,
                    lastName,
                    birthday,
                    gender,
                    street,
                    zip,
                    city,
                    selectedClass,
                    isActive
                );
                Close();
            } else {
                MessageBox.Show(
                    "Bitte füllen Sie alle Felder aus.",
                    "Hinweis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private bool checkSaveAllowed(
            string firstName,
            string lastName,
            DateTime birthday,
            char gender,
            string street,
            int zip,
            string city,
            Class selectedClass
        ) {
            if (
                firstName == ""
                || lastName == ""
                || birthday.CompareTo(DateTime.Today) >= 0
                || (
                    gender != 'f'
                    && gender != 'm'
                )
                || street == ""
                || zip == 0
                || city == ""
                || selectedClass == null
            ) {
                return false;
            }

            return true;
        }

        private void NewStudentGUI_Load(object sender, EventArgs e)
        {
            
        }
    }
}
