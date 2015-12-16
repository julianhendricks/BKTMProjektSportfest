using System;
using SportsFestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsFestivalManagement.Provider
{
    class CompetitionDisciplineSetProvider : AbstractEntityProvider
    {
        public const string tableName = "competitionDisciplineSet";
        public const string field_competitionId = "competitionId";
        public const string field_disciplineSetId = "disciplineSetId";

        public static List<Competition> getCompetitionsByDisciplineSet(DisciplineSet disciplineSet)
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineSetId + "` = " + disciplineSet.DisciplineSetId
            );

            List<Competition> competitions = new List<Competition>();

            foreach (var row in results)
            {
                competitions.Add(CompetitionProvider.getCompetitionById(Convert.ToInt32(row[field_competitionId])));
            }

            return competitions;
        }

        public static List<DisciplineSet> getDisciplineSetsByCompetition(Competition competition)
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_competitionId + "` = " + competition.CompetitionId
            );

            List<DisciplineSet> disciplineSets = new List<DisciplineSet>();

            foreach (var row in results)
            {
                disciplineSets.Add(DisciplineSetProvider.getDisciplineSetById(Convert.ToInt32(row[field_disciplineSetId])));
            }

            return disciplineSets;
        }

        public static bool relationExists(Competition competition, DisciplineSet disciplineSet)
        {
            Dictionary<string, object> result = querySingleSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_competitionId + "` = " + competition.CompetitionId + " "
                    + "AND `" + field_disciplineSetId + "` = " + disciplineSet.DisciplineSetId
            );

            if (result.Count == 1)
            {
                return true;
            }

            return false;
        }

        public static void createCompetitionDisciplineSetRelation(Competition competition, DisciplineSet disciplineSet)
        {
            executeSql(""
                + "INSERT INTO "
                    + "`" + tableName + "` "
                + "("
                    + "`" + field_competitionId + "`,"
                    + "`" + field_disciplineSetId + "`"
                + ") VALUES ("
                    + competition.CompetitionId + ","
                    + disciplineSet.DisciplineSetId
                + ")"
            );
        }

        public static void deleteCompetitionDisciplineSetRelation(Competition competition, DisciplineSet disciplineSet)
        {
            executeSql(""
                + "DELETE FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_competitionId + " = " + competition.CompetitionId + " "
                    + "AND `" + field_disciplineSetId + " = " + disciplineSet.DisciplineSetId + " "
                + "LIMIT 1"
            );
        }
    }
}
