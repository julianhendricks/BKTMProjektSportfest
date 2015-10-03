using SportsfestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsfestivalManagement.Provider
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
            MySqlDataReader reader = executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<Discipline> disciplines = new List<Discipline>();

            while(reader.Read())
            {
                disciplines.Add(getDisciplineById(reader.GetInt32(field_disciplineId)));
            }

            return disciplines;
        }

        public static Discipline getDisciplineById(int disciplineId) {
            MySqlDataReader reader = executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineId + "` = " + disciplineId
            );

            Measure measure = MeasureProvider.getMeasureById(reader.GetInt32(field_measureId));

            Category category = CategoryProvider.getCategoryById(reader.GetInt32(field_categoryId));

            List<DisciplineSetDisciplineMapping> disciplineSetDisciplineMappings = DisciplineSetDisciplineMappingProvider.getDisciplineSetDisciplineMappingsByDisciplineId(reader.GetInt32(field_disciplineId));

            Discipline discipline = new Discipline(
                reader.GetInt32(field_disciplineId),
                reader.GetString(field_name),
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
            MySqlDataReader reader = executeSql(""
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

            reader = executeSql("SELECT LAST_INSERT_ID() AS insertionId");

            return reader.GetInt32("insertionId");
        }

        public static void updateDiscipline(Discipline discipline)
        {
            MySqlDataReader reader = executeSql(""
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
            MySqlDataReader reader = executeSql(""
                + "DELETE FROM `" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineId + " = " + discipline.DisciplineId + " "
                + "LIMIT 1"
            );
        }
    }
}
