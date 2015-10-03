using SportsfestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsfestivalManagement.Provider
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
            MySqlDataReader reader = executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<Competition> competitions = new List<Competition>();

            while (reader.Read())
            {
                competitions.Add(getCompetitionById(reader.GetInt32(field_competitionId)));
            }

            return competitions;
        }

        public static Competition getCompetitionById(int competitionId)
        {
            MySqlDataReader reader = executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_competitionId + "` = " + competitionId
            );

            List<DisciplineSet> disciplineSetsList = DisciplineSetProvider.getDisciplineSetsByCompetitionId(reader.GetInt32(field_competitionId));

            Competition competition = new Competition(
                reader.GetInt32(field_competitionId),
                reader.GetString(field_competitionName),
                disciplineSetsList
            );

            return competition;
        }

        public static List<Competition> getCompetitionsByDisciplineSetId(int disciplineSetId)
        {
            MySqlDataReader reader = executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + relation_tableName + "` "
                + "WHERE "
                    + "`" + relation_field_disciplineSetId + "` = " + disciplineSetId
            );

            List<Competition> competitions = new List<Competition>();

            while (reader.Read())
            {
                competitions.Add(getCompetitionById(reader.GetInt32(relation_field_competitionId)));
            }

            return competitions;
        }

        public static int createCompetition(string competitionName)
        {
            MySqlDataReader reader = executeSql(""
                + "INSERT INTO "
                    + "`" + tableName + "` "
                + "("
                    + "`" + field_competitionName + "`"
                + ") VALUES ("
                    + "'" + competitionName + "'"
                + ")"
            );

            reader = executeSql("SELECT LAST_INSERT_ID() AS insertionId");

            return reader.GetInt32("insertionId");
        }

        public static void updateCompetition(Competition competition)
        {
            MySqlDataReader reader = executeSql(""
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
            MySqlDataReader reader = executeSql(""
                + "DELETE FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_competitionId + " = " + competition.CompetitionId + " "
                + "LIMIT 1"
            );
        }
    }
}
