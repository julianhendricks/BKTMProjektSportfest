using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sportfest_Verwaltung
{
    class SportsfestivalController
    {
        List<SportsFestival> SportsFestivalCollection;
        SqlConnection SportsFestivalConnection;

        public SportsfestivalController()
        {
            int currentSportsFestivalId;
            DateTime currentSportsFestivalDate;
            SqlDataReader SportsFestivalsDS;

            SportsFestivalCollection = new List<SportsFestival>();
            SportsFestivalConnection = SQL.GetConnection();

            //Reader erstellen und durchlaufen
            String SQLStatement = "SELECT * FROM SportsFestival";
            SportsFestivalsDS = SQL.GetReader(SQLStatement, SportsFestivalConnection);
            while (SportsFestivalsDS.Read())
            {
                currentSportsFestivalId = Convert.ToInt32(SportsFestivalsDS["sportsFestivalId"]);
                currentSportsFestivalDate = Convert.ToDateTime(SportsFestivalsDS["date"]);

                SportsFestival CurrentItem = new SportsFestival(currentSportsFestivalId, currentSportsFestivalDate);
                SportsFestivalCollection.Add(CurrentItem);
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
