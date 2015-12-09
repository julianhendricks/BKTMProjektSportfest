using System;
using SportsFestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsFestivalManagement.Provider
{
    class CompetitionProvider : AbstractEntityProvider
    {
        public const string tableName = "competition";
        public const string field_competitionId = "competitionId";
        public const string field_competitionName = "competitionName";

        public const string relation_tableName = "competitionDisciplineSet";
        public const string relation_field_competitionId = "competitionId";
        public const string relation_field_disciplineSetId = "disciplineSetId";

        public static List<Competition> getAllCompetitions()
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<Competition> competitions = new List<Competition>();

            foreach (var row in results)
            {
                competitions.Add(getCompetitionById(Convert.ToInt32(row[field_competitionId])));
            }

            return competitions;
        }

        public static Competition getCompetitionById(int competitionId)
        {
            Dictionary<string, object> result = querySingleSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_competitionId + "` = " + competitionId
            );

            List<DisciplineSet> disciplineSetsList = DisciplineSetProvider.getDisciplineSetsByCompetitionId(Convert.ToInt32(result[field_competitionId]));

            Competition competition = new Competition(
                Convert.ToInt32(result[field_competitionId]),
                Convert.ToString(result[field_competitionName]),
                disciplineSetsList
            );

            return competition;
        }

        public static List<Competition> getCompetitionsByDisciplineSetId(int disciplineSetId)
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + relation_tableName + "` "
                + "WHERE "
                    + "`" + relation_field_disciplineSetId + "` = " + disciplineSetId
            );

            List<Competition> competitions = new List<Competition>();

            foreach (var row in results)
            {
                competitions.Add(getCompetitionById(Convert.ToInt32(row[relation_field_competitionId])));
            }

            return competitions;
        }

        public static int createCompetition(string competitionName)
        {
            executeSql(""
                + "INSERT INTO "
                    + "`" + tableName + "` "
                + "("
                    + "`" + field_competitionName + "`"
                + ") VALUES ("
                    + "'" + competitionName + "'"
                + ")"
            );

            Dictionary<string, object> result = querySingleSql("SELECT LAST_INSERT_ID() AS `insertionId`");

            return Convert.ToInt32(result["insertionId"]);
        }

        public static void updateCompetition(Competition competition)
        {
            executeSql(""
                + "UPDATE "
                    + "`" + tableName + "` "
                + "SET "
                    + "`" + field_competitionName + "` = " + competition.CompetitionName + " "
                + "WHERE "
                    + "`" + field_competitionId + " = " + competition.CompetitionId
            );
        }

        public static void deleteCompetition(Competition competition)
        {
            executeSql(""
                + "DELETE FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_competitionId + " = " + competition.CompetitionId + " "
                + "LIMIT 1"
            );
        }
    }
}
