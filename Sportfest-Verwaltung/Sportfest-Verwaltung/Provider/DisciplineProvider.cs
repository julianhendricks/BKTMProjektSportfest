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


        public List<Discipline> getAllDisciplines()
        {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<Discipline> disciplines = new List<Discipline>();

            while(reader.Read())
            {
                disciplines.Add(this.getDisciplineById(reader.GetInt32(field_disciplineId)));
            }

            return disciplines;
        }

        public Discipline getDisciplineById(int disciplineId) {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineId + "` = " + disciplineId
            );

            MeasureProvider measureProvider = new MeasureProvider();
            Measure measure = measureProvider.getMeasureById(reader.GetInt32(field_measureId));

            CategoryProvider categoryProvider = new CategoryProvider();
            Category category = categoryProvider.getCategoryById(reader.GetInt32(field_categoryId));

            DisciplineSetDisciplineMappingProvider disciplineSetDisciplineMappingProvider = new DisciplineSetDisciplineMappingProvider();
            List<DisciplineSetDisciplineMapping> disciplineSetDisciplineMappings = disciplineSetDisciplineMappingProvider.getDisciplineSetDisciplineMappingsByDisciplineId(reader.GetInt32(field_disciplineId));

            Discipline discipline = new Discipline(
                reader.GetInt32(field_disciplineId),
                reader.GetString(field_name),
                measure,
                category,
                disciplineSetDisciplineMappings
            );

            return discipline;
        }

        public List<Discipline> getDisciplinesByDisciplineSetId(int disciplineSetId)
        {
            DisciplineSetDisciplineMappingProvider disciplineSetDisciplineMappingProvider = new DisciplineSetDisciplineMappingProvider();
            List<DisciplineSetDisciplineMapping> disciplineSetDisciplineMappings = disciplineSetDisciplineMappingProvider.getDisciplineSetDisciplineMappingsByDisciplineSetId(disciplineSetId);

            List<Discipline> disciplines = new List<Discipline>();

            foreach (DisciplineSetDisciplineMapping disciplineSetDisciplineMapping in disciplineSetDisciplineMappings)
            {
                disciplines.Add(this.getDisciplineById(disciplineSetDisciplineMapping.DisciplineId));
            }

            return disciplines;
        }

        public int createDiscipline(
            string name,
            Measure measure,
            Category category
        ) {
            MySqlDataReader reader = this.executeSql(""
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

            reader = this.executeSql("SELECT LAST_INSERT_ID() AS insertionId");

            return reader.GetInt32("insertionId");
        }

        public void updateDiscipline(Discipline discipline)
        {
            MySqlDataReader reader = this.executeSql(""
                + "UPDATE `" + tableName + "` "
                + "SET "
                    + "`" + field_name + "` = " + discipline.Name + ", "
                    + "`" + field_measureId + "` = " + discipline.Measure.MeasureId + ", "
                    + "`" + field_categoryId + "` = " + discipline.Category.CategoryId + " "
                + "WHERE "
                    + "`" + field_disciplineId + " = " + discipline.DisciplineId
            );
        }

        public void deleteDiscipline(Discipline discipline)
        {
            MySqlDataReader reader = this.executeSql(""
                + "DELETE FROM `" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineId + " = " + discipline.DisciplineId + " "
                + "LIMIT 1"
            );
        }
    }
}
