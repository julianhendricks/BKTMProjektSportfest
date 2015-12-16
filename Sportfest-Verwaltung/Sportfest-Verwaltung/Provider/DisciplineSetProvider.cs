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

            DisciplineSet disciplineSet = new DisciplineSet(
                Convert.ToInt32(result[field_disciplineSetId])
            );

            foreach (Discipline discipline in DisciplineSetDisciplineMappingProvider.getDisciplinesByDisciplineSet(disciplineSet))
            {
                disciplineSet.addDiscipline(discipline);
            }

            foreach (Competition competition in CompetitionProvider.getCompetitionsByDisciplineSet(disciplineSet))
            {
                disciplineSet.addCompetition(competition);
            }

            foreach (DisciplineSetDisciplineMapping disciplineSetDisciplineMapping in DisciplineSetDisciplineMappingProvider.getDisciplineSetDisciplineMappingsByDisciplineSet(disciplineSet))
            {
                disciplineSet.addDisciplineSetDisciplineMapping(disciplineSetDisciplineMapping);
            }

            return disciplineSet;
        }

        public static List<DisciplineSet> getDisciplineSetsByCompetition(Competition competition)
        {
            return CompetitionDisciplineSetProvider.getDisciplineSetsByCompetition(competition);
        }

        public static List<DisciplineSet> getDisciplineSetsByDisciplineId(Discipline discipline)
        {
            return DisciplineSetDisciplineMappingProvider.getDisciplineSetsByDiscipline(discipline);
        }

        public static int createDisciplineSet(

        ) {
            executeSql(""
                + "INSERT INTO `" + tableName + "` "
                + "("
                    
                + ") VALUES ("
                   
                + ")"
            );

            Dictionary<string, object> result = querySingleSql("SELECT MAX(`" + field_disciplineSetId + "`) AS `insertionId` FROM `" + tableName + "`");

            int insertionId = Convert.ToInt32(result["insertionId"]);

            return insertionId;
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
