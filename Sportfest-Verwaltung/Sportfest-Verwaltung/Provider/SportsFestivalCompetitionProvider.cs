using SportsFestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace SportsFestivalManagement.Provider
{
    class SportsFestivalCompetitionProvider : AbstractEntityProvider
    {
        public const string tableName = "sportsfestivalCompetition";
        public const string field_sportsFestivalId = "sportsFestivalId";
        public const string field_competitionId = "competitionId";

        public static List<Competition> getCompetitionsBySportsFestival(SportsFestival sportsFestival)
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_sportsFestivalId + "` = " + sportsFestival.SportsFestivalId
            );

            List<Competition> competitions = new List<Competition>();

            foreach (var row in results)
            {
                competitions.Add(CompetitionProvider.getCompetitionById(Convert.ToInt32(row[field_competitionId])));
            }

            return competitions;
        }

        public static bool relationExists(SportsFestival sportsFestival, Competition competition)
        {
            Dictionary<string, object> result = querySingleSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_sportsFestivalId + "` = " + sportsFestival.SportsFestivalId + " "
                    + "AND `" + field_competitionId + "` = " + competition.CompetitionId
            );

            if (result.Count == 1)
            {
                return true;
            }

            return false;
        }

        public static void createSportsFestivalCompetitionRelation(SportsFestival sportsFestival, Competition competition)
        {
            executeSql(""
                + "INSERT INTO `" + tableName + "` "
                + "("
                    + "`" + field_sportsFestivalId + "`,"
                    + "`" + field_competitionId + "`"
                + ") VALUES ("
                    + sportsFestival.SportsFestivalId + ","
                    + competition.CompetitionId
                + ")"
            );
        }

        public static void deleteSportsFestival(SportsFestival sportsFestival, Competition competition)
        {
            executeSql(""
                + "DELETE FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_sportsFestivalId + " = " + sportsFestival.SportsFestivalId + " "
                    + "AND `" + field_competitionId + " = " + competition.CompetitionId + " "
                + "LIMIT 1"
            );
        }
    }
}
