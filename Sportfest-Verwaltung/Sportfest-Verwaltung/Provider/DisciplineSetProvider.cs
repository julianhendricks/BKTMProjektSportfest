using SportsfestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsfestivalManagement.Provider
{
    class DisciplineSetProvider : AbstractEntityProvider
    {
        public const string tableName = "disciplineSet";
        public const string field_disciplineSetId = "disciplineSetId";

        public List<DisciplineSet> getAllDisciplineSets()
        {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<DisciplineSet> disciplineSets = new List<DisciplineSet>();

            while(reader.Read())
            {
                disciplineSets.Add(this.getDisciplineSetById(reader.GetInt32(field_disciplineSetId)));
            }

            return disciplineSets;
        }

        public DisciplineSet getDisciplineSetById(int disciplineSetId) {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineSetId + "` = " + disciplineSetId
            );

            DisciplineProvider disciplineProvider = new DisciplineProvider();
            List<Discipline> disciplines = disciplineProvider.getDisciplinesByDisciplineSetId(reader.GetInt32(field_disciplineSetId));

            CompetitionProvider competitionProvider = new CompetitionProvider();
            List<Competition> competitions = competitionProvider.getCompetitionsByDisciplineSetId(reader.GetInt32(field_disciplineSetId));

            DisciplineSetDisciplineMappingProvider disciplineSetDisciplineMappingProvider = new DisciplineSetDisciplineMappingProvider();
            List<DisciplineSetDisciplineMapping> disciplineSetDisciplineMappings = disciplineSetDisciplineMappingProvider.getDisciplineSetDisciplineMappingsByDisciplineSetId(reader.GetInt32(field_disciplineSetId));

            DisciplineSet disciplineSet = new DisciplineSet(
                reader.GetInt32(field_disciplineSetId),
                disciplines,
                competitions,
                disciplineSetDisciplineMappings
            );

            return disciplineSet;
        }

        public List<DisciplineSet> getDisciplineSetsByCompetitionId(int competitionId)
        {
            MySqlDataReader reader = this.executeSql(""
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
                disciplineSets.Add(this.getDisciplineSetById(reader.GetInt32(field_disciplineSetId)));
            }

            return disciplineSets;
        }

        public List<DisciplineSet> getDisciplineSetsByDisciplineId(int disciplineId)
        {
            DisciplineSetDisciplineMappingProvider disciplineSetDisciplineMappingProvider = new DisciplineSetDisciplineMappingProvider();
            List<DisciplineSetDisciplineMapping> disciplineSetDisciplineMappings = disciplineSetDisciplineMappingProvider.getDisciplineSetDisciplineMappingsByDisciplineId(disciplineId);

            List<DisciplineSet> disciplineSets = new List<DisciplineSet>();

            foreach (DisciplineSetDisciplineMapping disciplineSetDisciplineMapping in disciplineSetDisciplineMappings)
            {
                disciplineSets.Add(this.getDisciplineSetById(disciplineSetDisciplineMapping.DisciplineSetId));
            }

            return disciplineSets;
        }

        public int createDisciplineSet(

        ) {
            MySqlDataReader reader = this.executeSql(""
                + "INSERT INTO `" + tableName + "` "
                + "("
                    
                + ") VALUES ("
                   
                + ")"
            );

            reader = this.executeSql("SELECT LAST_INSERT_ID() AS insertionId");

            return reader.GetInt32("insertionId");
        }

        public void updateDisciplineSet(DisciplineSet disciplineSet)
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

        public void deleteDisciplineSet(DisciplineSet disciplineSet)
        {
            MySqlDataReader reader = this.executeSql(""
                + "DELETE FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineSetId + " = " + disciplineSet.DisciplineSetId + " "
                + "LIMIT 1"
            );
        }
    }
}
