using System;
using SportsFestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsFestivalManagement.Provider
{
    class DisciplineProvider : AbstractEntityProvider
    {
        public const string tableName = "discipline";
        public const string field_disciplineId = "disciplineId";
        public const string field_name = "name";
        public const string field_measureId = "measureId";
        public const string field_categoryId = "categoryId";


        public static List<Discipline> getAllDisciplines()
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<Discipline> disciplines = new List<Discipline>();

            foreach (var row in results)
            {
                disciplines.Add(getDisciplineById(Convert.ToInt32(row[field_disciplineId])));
            }

            return disciplines;
        }

        public static Discipline getDisciplineById(int disciplineId) {
            Dictionary<string, object> result = querySingleSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineId + "` = " + disciplineId
            );

            Measure measure = MeasureProvider.getMeasureById(Convert.ToInt32(result[field_measureId]));

            Category category = CategoryProvider.getCategoryById(Convert.ToInt32(result[field_categoryId]));

            List<DisciplineSetDisciplineMapping> disciplineSetDisciplineMappings = DisciplineSetDisciplineMappingProvider.getDisciplineSetDisciplineMappingsByDisciplineId(Convert.ToInt32(result[field_disciplineId]));

            Discipline discipline = new Discipline(
                Convert.ToInt32(result[field_disciplineId]),
                Convert.ToString(result[field_name]),
                measure,
                category,
                disciplineSetDisciplineMappings
            );

            return discipline;
        }

        public static List<Discipline> getDisciplinesByDisciplineSetId(int disciplineSetId)
        {
            List<DisciplineSetDisciplineMapping> disciplineSetDisciplineMappings = DisciplineSetDisciplineMappingProvider.getDisciplineSetDisciplineMappingsByDisciplineSetId(disciplineSetId);

            List<Discipline> disciplines = new List<Discipline>();

            foreach (DisciplineSetDisciplineMapping disciplineSetDisciplineMapping in disciplineSetDisciplineMappings)
            {
                disciplines.Add(getDisciplineById(disciplineSetDisciplineMapping.DisciplineId));
            }

            return disciplines;
        }

        public static int createDiscipline(
            string name,
            Measure measure,
            Category category
        ) {
            executeSql(""
                + "INSERT INTO `" + tableName + "` "
                + "("
                    + "`" + field_name + "`, "
                    + "`" + field_measureId + "`, "
                    + "`" + field_categoryId + "`"
                + ") VALUES ("
                    + "'" + name + "', "
                    + measure.MeasureId + ", "
                    + category.CategoryId
                + ")"
            );

            Dictionary<string, object> result = querySingleSql("SELECT LAST_INSERT_ID() AS `insertionId`");

            return Convert.ToInt32(result["insertionId"]);
        }

        public static void updateDiscipline(Discipline discipline)
        {
            executeSql(""
                + "UPDATE `" + tableName + "` "
                + "SET "
                    + "`" + field_name + "` = " + discipline.Name + ", "
                    + "`" + field_measureId + "` = " + discipline.Measure.MeasureId + ", "
                    + "`" + field_categoryId + "` = " + discipline.Category.CategoryId + " "
                + "WHERE "
                    + "`" + field_disciplineId + " = " + discipline.DisciplineId
            );
        }

        public static void deleteDiscipline(Discipline discipline)
        {
            executeSql(""
                + "DELETE FROM `" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineId + " = " + discipline.DisciplineId + " "
                + "LIMIT 1"
            );
        }
    }
}
