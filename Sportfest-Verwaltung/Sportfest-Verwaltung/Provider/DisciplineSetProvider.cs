using System;
using SportsFestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsFestivalManagement.Provider
{
    class DisciplineSetProvider : AbstractEntityProvider
    {
        public const string tableName = "disciplineSet";
        public const string field_disciplineSetId = "disciplineSetId";

        public static List<DisciplineSet> getAllDisciplineSets()
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<DisciplineSet> disciplineSets = new List<DisciplineSet>();

            foreach (var row in results)
            {
                disciplineSets.Add(getDisciplineSetById(Convert.ToInt32(row[field_disciplineSetId])));
            }

            return disciplineSets;
        }

        public static DisciplineSet getDisciplineSetById(int disciplineSetId) {
            Dictionary<string, object> result = querySingleSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineSetId + "` = " + disciplineSetId
            );

            if (result == null)
            {
                return null;
            }

            List<Discipline> disciplines = DisciplineProvider.getDisciplinesByDisciplineSetId(Convert.ToInt32(result[field_disciplineSetId]));

            List<Competition> competitions = CompetitionProvider.getCompetitionsByDisciplineSetId(Convert.ToInt32(result[field_disciplineSetId]));

            List<DisciplineSetDisciplineMapping> disciplineSetDisciplineMappings = DisciplineSetDisciplineMappingProvider.getDisciplineSetDisciplineMappingsByDisciplineSetId(Convert.ToInt32(result[field_disciplineSetId]));

            DisciplineSet disciplineSet = new DisciplineSet(
                Convert.ToInt32(result[field_disciplineSetId]),
                disciplines,
                competitions,
                disciplineSetDisciplineMappings
            );

            return disciplineSet;
        }

        public static List<DisciplineSet> getDisciplineSetsByCompetitionId(int competitionId)
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + CompetitionProvider.relation_tableName + "` "
                + "WHERE "
                    + "`" + CompetitionProvider.relation_field_competitionId + "` = " + competitionId
            );

            List<DisciplineSet> disciplineSets = new List<DisciplineSet>();

            foreach (var row in results)
            {
                disciplineSets.Add(getDisciplineSetById(Convert.ToInt32(row[field_disciplineSetId])));
            }

            return disciplineSets;
        }

        public static List<DisciplineSet> getDisciplineSetsByDisciplineId(int disciplineId)
        {
            List<DisciplineSetDisciplineMapping> disciplineSetDisciplineMappings = DisciplineSetDisciplineMappingProvider.getDisciplineSetDisciplineMappingsByDisciplineId(disciplineId);

            List<DisciplineSet> disciplineSets = new List<DisciplineSet>();

            foreach (DisciplineSetDisciplineMapping disciplineSetDisciplineMapping in disciplineSetDisciplineMappings)
            {
                disciplineSets.Add(getDisciplineSetById(disciplineSetDisciplineMapping.DisciplineSetId));
            }

            return disciplineSets;
        }

        public static int createDisciplineSet(

        ) {
            executeSql(""
                + "INSERT INTO `" + tableName + "` "
                + "("
                    
                + ") VALUES ("
                   
                + ")"
            );

            Dictionary<string, object> result = querySingleSql("SELECT LAST_INSERT_ID() AS `insertionId`");

            return Convert.ToInt32(result["insertionId"]);
        }

        public static void updateDisciplineSet(DisciplineSet disciplineSet)
        {
            // Implement if there are any updateable fields available
            
            /*this.executeSql(""
                + "UPDATE "
                    + "`" + tableName + "` "
                + "SET "
                    + "`" + field_name + "` = " + discipline.Name + ", "
                    + "`" + field_measureId + "` = " + discipline.Measure.MeasureId + ", "
                    + "`" + field_categoryId + "` = " + discipline.Category.CategoryId + " "
                + "WHERE "
                    + "`" + field_disciplineId + " = " + discipline.DisciplineId
            );*/
        }

        public static void deleteDisciplineSet(DisciplineSet disciplineSet)
        {
            executeSql(""
                + "DELETE FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineSetId + " = " + disciplineSet.DisciplineSetId + " "
                + "LIMIT 1"
            );
        }
    }
}
