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

        public static List<SportsFestival> getAllSportsFestivals()
        {
            MySqlDataReader reader = executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<SportsFestival> sportsFestivals = new List<SportsFestival>();

            while (reader.Read())
            {
                sportsFestivals.Add(getSportsFestivalById(reader.GetInt32(field_sportsFestivalId)));
            }

            return sportsFestivals;
        }

        public static SportsFestival getSportsFestivalById(int sportsFestivalId)
        {
            MySqlDataReader reader = executeSql(""
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

        public static int createSportsFestival(DateTime sportsFestivalDate)
        {
            MySqlDataReader reader = executeSql(""
                + "INSERT INTO `" + tableName + "` "
                + "("
                    + "`" + field_sportsFestivalDate + "`"
                + ") VALUES ("
                    + "'" + sportsFestivalDate.ToString("yyyy-MM-dd") + "'"
                + ")"
            );

            reader = executeSql("SELECT LAST_INSERT_ID() AS insertionId");

            return reader.GetInt32("insertionId");
        }

        public static void updateSportsFestival(SportsFestival sportsFestival)
        {
            MySqlDataReader reader = executeSql(""
                + "UPDATE "
                    + "`" + tableName + "` "
                + "SET "
                    + "`" + field_sportsFestivalDate + "` = '" + sportsFestival.Date.ToString("yyyy-MM-dd") + "' "
                + "WHERE "
                    + "`" + field_sportsFestivalId + " = " + sportsFestival.SportsFestivalId
            );
        }

        public static void deleteSportsFestival(SportsFestival sportsFestival)
        {
            MySqlDataReader reader = executeSql(""
                + "DELETE FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_sportsFestivalId + " = " + sportsFestival.SportsFestivalId + " "
                + "LIMIT 1"
            );
        }
    }
}
