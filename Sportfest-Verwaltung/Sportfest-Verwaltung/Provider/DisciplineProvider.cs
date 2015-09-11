using SportsfestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsfestivalManagement.Provider
{
    class DisciplineProvider : AbstractEntityProvider
    {
        const string tableName = "discipline";
        const string field_disciplineId = "disciplineId";
        const string field_name = "name";
        const string field_measureId = "measureId";
        const string field_categoryId = "categoryId";


        public List<Discipline> getAllDisciplines()
        {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT * "
                + "FROM `" + tableName + "`"
            );

            List<Discipline> disciplines = new List<Discipline>();

            while(reader.Read())
            {
                Discipline discipline = new Discipline(
                    reader.GetInt32(field_disciplineId),
                    reader.GetString(field_name),
                    reader.GetInt32(field_measureId),
                    reader.GetInt32(field_categoryId)
                );

                disciplines.Add(discipline);
            }

            return disciplines;
        }

        public Discipline getDisciplineById(int disciplineId) {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT * "
                + "FROM `" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineId + "` = " + disciplineId
            );

            Discipline discipline = new Discipline(
                reader.GetInt32(field_disciplineId),
                reader.GetString(field_name),
                reader.GetInt32(field_measureId),
                reader.GetInt32(field_categoryId)
            );

            return discipline;
        }

        public int createDiscipline(string name)
        {
            MySqlDataReader reader = this.executeSql(""
                + "INSERT INTO `" + tableName + "` "
                + "("
                    + "`" + field_name + "`"
                + ") VALUES ("
                    + "'" + name + "'"
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
                    + "`" + field_name + "` = " + discipline.Name + " "
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
