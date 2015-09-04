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

        public SportsfestivalController()
        {
            int currentSportsFestivalId;
            string currentSportsFestivalDate;

            SportsFestivalCollection = new List<SportsFestival>();

            //Reader erstellen und durchlaufen
            //String SQLStatement = "SELECT * FROM SportsFestival";
            //SportsFestivalsDS = SQL.GetReader(SQLStatement);
            /*while (SportsFestivalsDS.Read())
            {
                currentSportsFestivalId = Convert.ToInt32(SportsFestivalsDS["SportsFestivalId"]);
                currentSportsFestivalDate = Convert.ToDateTime(SportsFestivalsDS["date"]);

                SportsFestival CurrentItem = new SportsFestival(currentSportsFestivalId, currentSportsFestivalDate);
                SportsFestivalCollection.Add(CurrentItem);
            }*/

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

        public void LoadSportsFestivalListView(ListView iListView)
        {
            foreach (SportsFestival Sportsfest in SportsFestivalCollection){
                string[] row = { Sportsfest.GetSportsFestivalId().ToString(), "Sportfest " + Sportsfest.GetSportsFestivalDate().Year.ToString() };
                iListView.Items.Add(new ListViewItem(row));
            }
        }
    }
}
