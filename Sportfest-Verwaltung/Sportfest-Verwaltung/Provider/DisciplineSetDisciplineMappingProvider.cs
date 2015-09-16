using SportsfestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsfestivalManagement.Provider
{
    class DisciplineSetDisciplineMappingProvider : AbstractEntityProvider
    {
        public const string tableName = "disciplineSetDisciplineMapping";
        public const string field_disciplineSetId = "disciplineSetId";
        public const string field_ageFrom = "ageFrom";
        public const string field_ageUntil = "ageUntil";
        public const string field_disciplineId = "disciplineId";

        public List<DisciplineSetDisciplineMapping> getAllDisciplineSetDisciplineMappings()
        {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<DisciplineSetDisciplineMapping> disciplineSetDisciplineMappings = new List<DisciplineSetDisciplineMapping>();

            while(reader.Read())
            {
                disciplineSetDisciplineMappings.Add(this.getDisciplineSetDisciplineMappingByPrimaryKey(
                    reader.GetInt32(field_disciplineSetId),
                    reader.GetInt32(field_ageFrom),
                    reader.GetInt32(field_ageUntil),
                    reader.GetInt32(field_disciplineId)
                ));
            }

            return disciplineSetDisciplineMappings;
        }

        public DisciplineSetDisciplineMapping getDisciplineSetDisciplineMappingByPrimaryKey(
            int disciplineSetId,
            int ageFrom,
            int ageUntil,
            int disciplineId
        ) {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineSetId + "` = " + disciplineSetId + " "
                    + "AND `" + field_ageFrom + "` = " + ageFrom + " "
                    + "AND `" + field_ageUntil + "` = " + ageUntil + " "
                    + "AND `" + field_disciplineId + "` = " + disciplineId
            );

            DisciplineSetDisciplineMapping disciplineSetDisciplineMapping = new DisciplineSetDisciplineMapping(
                reader.GetInt32(field_disciplineSetId),
                reader.GetInt32(field_ageFrom),
                reader.GetInt32(field_ageUntil),
                reader.GetInt32(field_disciplineId)
            );

            return disciplineSetDisciplineMapping;
        }

        public List<DisciplineSetDisciplineMapping> getDisciplineSetDisciplineMappingsByDisciplineSetId(int disciplineSetId)
        {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineSetId + "` = " + disciplineSetId
            );

            List<DisciplineSetDisciplineMapping> disciplineSetDisciplineMappings = new List<DisciplineSetDisciplineMapping>();

            while (reader.Read())
            {
                disciplineSetDisciplineMappings.Add(this.getDisciplineSetDisciplineMappingByPrimaryKey(
                    reader.GetInt32(field_disciplineSetId),
                    reader.GetInt32(field_ageFrom),
                    reader.GetInt32(field_ageUntil),
                    reader.GetInt32(field_disciplineId)
                ));
            }

            return disciplineSetDisciplineMappings;
        }

        public List<DisciplineSetDisciplineMapping> getDisciplineSetDisciplineMappingsByDisciplineId(int disciplineId)
        {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineId + "` = " + disciplineId
            );

            List<DisciplineSetDisciplineMapping> disciplineSetDisciplineMappings = new List<DisciplineSetDisciplineMapping>();

            while (reader.Read())
            {
                disciplineSetDisciplineMappings.Add(this.getDisciplineSetDisciplineMappingByPrimaryKey(
                    reader.GetInt32(field_disciplineSetId),
                    reader.GetInt32(field_ageFrom),
                    reader.GetInt32(field_ageUntil),
                    reader.GetInt32(field_disciplineId)
                ));
            }

            return disciplineSetDisciplineMappings;
        }

        public void createDisciplineSetDisciplineMapping(
            int disciplineSetId,
            int ageFrom,
            int ageUntil,
            int disciplineId
        ) {
            MySqlDataReader reader = this.executeSql(""
                + "INSERT INTO "
                    + "`" + tableName + "` "
                + "("
                    + "`" + field_disciplineSetId + "`, "
                    + "`" + field_ageFrom + "`, "
                    + "`" + field_ageUntil + "`, "
                    + "`" + field_disciplineId + "`"
                + ") VALUES ("
                    + disciplineSetId + ", "
                    + ageFrom + ", "
                    + ageUntil + ", "
                    + disciplineId
                + ")"
            );
        }

        public void updateDisciplineSetDisciplineMapping(DisciplineSetDisciplineMapping disciplineSetDisciplineMapping)
        {
            MySqlDataReader reader = this.executeSql(""
                + "UPDATE "
                    + "`" + tableName + "` "
                + "SET "
                    + "`" + field_ageFrom + "` = " + disciplineSetDisciplineMapping.AgeFrom + ", "
                    + "`" + field_ageUntil + "` = " + disciplineSetDisciplineMapping.AgeUntil + " "
                + "WHERE "
                    + "`" + field_disciplineSetId + " = " + disciplineSetDisciplineMapping.DisciplineSetId + " "
                    + "AND `" + field_ageFrom + "` = " + disciplineSetDisciplineMapping.AgeFrom + " "
                    + "AND `" + field_ageUntil + "` = " + disciplineSetDisciplineMapping.AgeUntil + " "
                    + "AND `" + field_disciplineId + "` = " + disciplineSetDisciplineMapping.DisciplineId
            );
        }

        public void deleteDisciplineSetDisciplineMapping(DisciplineSetDisciplineMapping disciplineSetDisciplineMapping)
        {
            MySqlDataReader reader = this.executeSql(""
                + "DELETE FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineSetId + " = " + disciplineSetDisciplineMapping.DisciplineSetId + " "
                    + "AND `" + field_ageFrom + "` = " + disciplineSetDisciplineMapping.AgeFrom + " "
                    + "AND `" + field_ageUntil + "` = " + disciplineSetDisciplineMapping.AgeUntil + " "
                    + "AND `" + field_disciplineId + "` = " + disciplineSetDisciplineMapping.DisciplineId + " "
                + "LIMIT 1"
            );
        }
    }
}
