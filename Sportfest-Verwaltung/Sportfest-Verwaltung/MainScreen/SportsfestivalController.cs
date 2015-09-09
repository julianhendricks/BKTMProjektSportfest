using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Sportfest_Verwaltung
{
    class SportsfestivalController
    {
        List<SportsFestival> SportsFestivalCollection;
        SqlConnection SportsFestivalConnection;

        public SportsfestivalController()
        {
            int currentSportsFestivalId;
            string currentSportsFestivalDate;

            SportsFestivalCollection = new List<SportsFestival>();
            SportsFestivalConnection = SQL.GetConnection();

            MySQL sqlInstance = new MySQL();
            sqlInstance.connect("localhost", "root", "", "sportsfestival");
            MySqlDataReader reader = sqlInstance.query("SELECT * FROM `variant`");
            while(reader.Read())
            {
                currentSportsFestivalId = Convert.ToInt32(reader["variantId"]);
                currentSportsFestivalDate = Convert.ToString(reader["variantName"]);

                MessageBox.Show(currentSportsFestivalId + " " + currentSportsFestivalDate);

                //SportsFestival CurrentItem = new SportsFestival(currentSportsFestivalId, currentSportsFestivalDate);
                //SportsFestivalCollection.Add(CurrentItem);
            }


        }

       /* ~SportsfestivalController()
        {
            if (SportsFestivalConnection.State == System.Data.ConnectionState.Open)
            {
                SportsFestivalConnection.Close();
            }
        }*/

        public void LoadSportsFestivalListView(ListView iListView)
        {
            foreach (SportsFestival Sportsfest in SportsFestivalCollection){
                string[] row = { Sportsfest.GetSportsFestivalId().ToString(), "Sportfest " + Sportsfest.GetSportsFestivalDate().Year.ToString() };
                iListView.Items.Add(new ListViewItem(row));
            }
        }
    }
}
