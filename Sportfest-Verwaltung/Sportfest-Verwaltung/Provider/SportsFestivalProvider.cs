using SportsfestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace SportsfestivalManagement.Provider
{
    class SportsFestivalProvider : AbstractEntityProvider
    {
        public const string tableName = "sportsfestival";
        public const string field_sportsFestivalId = "sportsFestivalId";
        public const string field_sportsFestivalDate = "date";

        public List<SportsFestival> getAllSportsFestivals()
        {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<SportsFestival> sportsFestivals = new List<SportsFestival>();

            while (reader.Read())
            {
                sportsFestivals.Add(this.getSportsFestivalById(reader.GetInt32(field_sportsFestivalId)));
            }

            return sportsFestivals;
        }

        public SportsFestival getSportsFestivalById(int sportsFestivalId)
        {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_sportsFestivalId + "` = " + sportsFestivalId
            );

            SportsFestival sportsFestival = new SportsFestival(
                reader.GetInt32(field_sportsFestivalId),
                reader.GetDateTime(field_sportsFestivalDate)
            );

            return sportsFestival;
        }

        public int createSportsFestival(DateTime sportsFestivalDate)
        {
            MySqlDataReader reader = this.executeSql(""
                + "INSERT INTO `" + tableName + "` "
                + "("
                    + "`" + field_sportsFestivalDate + "`"
                + ") VALUES ("
                    + "'" + sportsFestivalDate.ToString("yyyy-MM-dd") + "'"
                + ")"
            );

            reader = this.executeSql("SELECT LAST_INSERT_ID() AS insertionId");

            return reader.GetInt32("insertionId");
        }

        public void updateSportsFestival(SportsFestival sportsFestival)
        {
            MySqlDataReader reader = this.executeSql(""
                + "UPDATE "
                    + "`" + tableName + "` "
                + "SET "
                    + "`" + field_sportsFestivalDate + "` = '" + sportsFestival.Date.ToString("yyyy-MM-dd") + "' "
                + "WHERE "
                    + "`" + field_sportsFestivalId + " = " + sportsFestival.SportsFestivalId
            );
        }

        public void deleteSportsFestival(SportsFestival sportsFestival)
        {
            MySqlDataReader reader = this.executeSql(""
                + "DELETE FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_sportsFestivalId + " = " + sportsFestival.SportsFestivalId + " "
                + "LIMIT 1"
            );
        }
    }
}
