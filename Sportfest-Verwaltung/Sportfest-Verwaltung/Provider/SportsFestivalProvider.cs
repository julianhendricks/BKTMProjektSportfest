using SportsFestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace SportsFestivalManagement.Provider
{
    class SportsFestivalProvider : AbstractEntityProvider
    {
        public const string tableName = "sportsfestival";
        public const string field_sportsFestivalId = "sportsFestivalId";
        public const string field_sportsFestivalDate = "date";

        public static List<SportsFestival> getAllSportsFestivals()
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<SportsFestival> sportsFestivals = new List<SportsFestival>();

            foreach (var row in results)
            {
                sportsFestivals.Add(getSportsFestivalById(Convert.ToInt32(row[field_sportsFestivalId])));
            }

            return sportsFestivals;
        }

        public static List<SportsFestival> getAllSportsFestivalsByDescendingDate()
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "ORDER BY "
                    + "`" + field_sportsFestivalDate + "` DESC"
            );

            List<SportsFestival> sportsFestivals = new List<SportsFestival>();

            foreach (var row in results)
            {
                sportsFestivals.Add(getSportsFestivalById(Convert.ToInt32(row[field_sportsFestivalId])));
            }

            return sportsFestivals;
        }

        public static SportsFestival getSportsFestivalById(int sportsFestivalId)
        {
            Dictionary<string, object> result = querySingleSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_sportsFestivalId + "` = " + sportsFestivalId
            );

            if (result == null)
            {
                return null;
            }

            SportsFestival sportsFestival = new SportsFestival(
                Convert.ToInt32(result[field_sportsFestivalId]),
                Convert.ToDateTime(result[field_sportsFestivalDate])
            );

            foreach (Competition competition in CompetitionProvider.getCompetitionsBySportsFestival(sportsFestival))
            {
                sportsFestival.addCompetition(competition);
            }

            return sportsFestival;
        }

        public static int createSportsFestival(DateTime sportsFestivalDate, List<Competition> competitions)
        {
            executeSql(""
                + "INSERT INTO `" + tableName + "` "
                + "("
                    + "`" + field_sportsFestivalDate + "`"
                + ") VALUES ("
                    + "'" + sportsFestivalDate.ToString("yyyy-MM-dd") + "'"
                + ")"
            );

            Dictionary<string, object> result = querySingleSql("SELECT MAX(`" + field_sportsFestivalId + "`) AS `insertionId` FROM `" + tableName + "`");

            int insertionId = Convert.ToInt32(result["insertionId"]);

            foreach (Competition competition in competitions)
            {
                SportsFestivalCompetitionProvider.createSportsFestivalCompetitionRelation(
                    getSportsFestivalById(insertionId),
                    competition
                );
            }

            return insertionId;
        }

        public static void updateSportsFestival(SportsFestival sportsFestival)
        {
            executeSql(""
                + "UPDATE "
                    + "`" + tableName + "` "
                + "SET "
                    + "`" + field_sportsFestivalDate + "` = '" + sportsFestival.Date.ToString("yyyy-MM-dd") + "' "
                + "WHERE "
                    + "`" + field_sportsFestivalId + "` = " + sportsFestival.SportsFestivalId
            );

            foreach (Competition competition in sportsFestival.getCompetitions())
            {
                if (SportsFestivalCompetitionProvider.relationExists(sportsFestival, competition) == false)
                {
                    SportsFestivalCompetitionProvider.createSportsFestivalCompetitionRelation(sportsFestival, competition);
                }
            }
        }

        public static void deleteSportsFestival(SportsFestival sportsFestival)
        {
            executeSql(""
                + "DELETE FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_sportsFestivalId + " = " + sportsFestival.SportsFestivalId + " "
                + "LIMIT 1"
            );
        }
    }
}
