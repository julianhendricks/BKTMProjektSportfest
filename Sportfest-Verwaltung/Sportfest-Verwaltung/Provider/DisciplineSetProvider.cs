using SportsfestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsfestivalManagement.Provider
{
    class DisciplineSetProvider : AbstractEntityProvider
    {
        public const string tableName = "disciplineSet";
        public const string field_disciplineSetId = "disciplineSetId";

        public static List<DisciplineSet> getAllDisciplineSets()
        {
            MySqlDataReader reader = executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<DisciplineSet> disciplineSets = new List<DisciplineSet>();

            while(reader.Read())
            {
                disciplineSets.Add(getDisciplineSetById(reader.GetInt32(field_disciplineSetId)));
            }

            return disciplineSets;
        }

        public static DisciplineSet getDisciplineSetById(int disciplineSetId) {
            MySqlDataReader reader = executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineSetId + "` = " + disciplineSetId
            );

            List<Discipline> disciplines = DisciplineProvider.getDisciplinesByDisciplineSetId(reader.GetInt32(field_disciplineSetId));

            List<Competition> competitions = CompetitionProvider.getCompetitionsByDisciplineSetId(reader.GetInt32(field_disciplineSetId));

            List<DisciplineSetDisciplineMapping> disciplineSetDisciplineMappings = DisciplineSetDisciplineMappingProvider.getDisciplineSetDisciplineMappingsByDisciplineSetId(reader.GetInt32(field_disciplineSetId));

            DisciplineSet disciplineSet = new DisciplineSet(
                reader.GetInt32(field_disciplineSetId),
                disciplines,
                competitions,
                disciplineSetDisciplineMappings
            );

            return disciplineSet;
        }

        public static List<DisciplineSet> getDisciplineSetsByCompetitionId(int competitionId)
        {
            MySqlDataReader reader = executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + CompetitionProvider.relation_tableName + "` "
                + "WHERE "
                    + "`" + CompetitionProvider.relation_field_competitionId + "` = " + competitionId
            );

            List<DisciplineSet> disciplineSets = new List<DisciplineSet>();

            while (reader.Read())
            {
                disciplineSets.Add(getDisciplineSetById(reader.GetInt32(field_disciplineSetId)));
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
            MySqlDataReader reader = executeSql(""
                + "INSERT INTO `" + tableName + "` "
                + "("
                    
                + ") VALUES ("
                   
                + ")"
            );

            reader = executeSql("SELECT LAST_INSERT_ID() AS insertionId");

            return reader.GetInt32("insertionId");
        }

        public static void updateDisciplineSet(DisciplineSet disciplineSet)
        {
            // Implement if there are any updateable fields available
            
            /*MySqlDataReader reader = this.executeSql(""
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
            MySqlDataReader reader = executeSql(""
                + "DELETE FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineSetId + " = " + disciplineSet.DisciplineSetId + " "
                + "LIMIT 1"
            );
        }
    }
}
