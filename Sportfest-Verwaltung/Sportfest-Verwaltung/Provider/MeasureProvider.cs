using SportsfestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsfestivalManagement.Provider
{
    class MeasureProvider : AbstractEntityProvider
    {
        public const string tableName = "measure";
        public const string field_measureId = "measureId";
        public const string field_name = "name";
        public const string field_shortcut = "shortcut";

        public List<Measure> getAllMeasures()
        {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<Measure> measures = new List<Measure>();

            while (reader.Read())
            {
                measures.Add(this.getMeasureById(reader.GetInt32(field_measureId)));
            }

            return measures;
        }

        public Measure getMeasureById(int measureId)
        {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_measureId + "` = " + measureId
            );

            Measure measure = new Measure(
                reader.GetInt32(field_measureId),
                reader.GetString(field_name),
                reader.GetString(field_shortcut)
            );

            return measure;
        }

        public int createMeasure(string name)
        {
            MySqlDataReader reader = this.executeSql(""
                + "INSERT INTO "
                    + "`" + tableName + "` "
                + "("
                    + "`" + field_name + "`"
                + ") VALUES ("
                    + "'" + name + "'"
                + ")"
            );

            reader = this.executeSql("SELECT LAST_INSERT_ID() AS insertionId");

            return reader.GetInt32("insertionId");
        }

        public void updateMeasure(Measure measure)
        {
            MySqlDataReader reader = this.executeSql(""
                + "UPDATE "
                    + "`" + tableName + "` "
                + "SET "
                    + "`" + field_name + "` = " + measure.Name + ". "
                    + "`" + field_shortcut + "` = " + measure.Shortcut + " "
                + "WHERE "
                    + "`" + field_measureId + " = " + measure.MeasureId
            );
        }

        public void deleteMeasure(Measure measure)
        {
            MySqlDataReader reader = this.executeSql(""
                + "DELETE FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_measureId + " = " + measure.MeasureId + " "
                + "LIMIT 1"
            );
        }
    }
}
