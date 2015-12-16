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

            if (result == null)
            {
                return null;
            }

            Competition competition = new Competition(
                Convert.ToInt32(result[field_competitionId]),
                Convert.ToString(result[field_competitionName])
            );

            foreach (DisciplineSet disciplineSet in DisciplineSetProvider.getDisciplineSetsByCompetition(competition))
            {
                competition.addDisciplineSet(disciplineSet);
            }

            return competition;
        }

        public static List<Competition> getCompetitionsByDisciplineSet(DisciplineSet disciplineSet)
        {
            return CompetitionDisciplineSetProvider.getCompetitionsByDisciplineSet(disciplineSet);
        }

        public static List<Competition> getCompetitionsBySportsFestival(SportsFestival sportsFestival)
        {
            return SportsFestivalCompetitionProvider.getCompetitionsBySportsFestival(sportsFestival);
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

            Dictionary<string, object> result = querySingleSql("SELECT MAX(`" + field_competitionId + "`) AS `insertionId` FROM `" + tableName + "`");

            int insertionId = Convert.ToInt32(result["insertionId"]);

            return insertionId;
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

            foreach (DisciplineSet disciplineSet in competition.getDisciplineSets())
            {
                if (CompetitionDisciplineSetProvider.relationExists(competition, disciplineSet) == false)
                {
                    CompetitionDisciplineSetProvider.createCompetitionDisciplineSetRelation(competition, disciplineSet);
                }
            }
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
