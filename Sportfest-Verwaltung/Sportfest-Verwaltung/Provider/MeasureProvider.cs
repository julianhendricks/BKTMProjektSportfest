using System;
using SportsFestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsFestivalManagement.Provider
{
    class MeasureProvider : AbstractEntityProvider
    {
        public const string tableName = "measure";
        public const string field_measureId = "measureId";
        public const string field_name = "name";
        public const string field_shortcut = "shortcut";

        public static List<Measure> getAllMeasures()
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<Measure> measures = new List<Measure>();

            foreach (var row in results)
            {
                measures.Add(getMeasureById(Convert.ToInt32(row[field_measureId])));
            }

            return measures;
        }

        public static Measure getMeasureById(int measureId)
        {
            Dictionary<string, object> result = querySingleSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_measureId + "` = " + measureId
            );

            if (result == null)
            {
                return null;
            }

            Measure measure = new Measure(
                Convert.ToInt32(result[field_measureId]),
                Convert.ToString(result[field_name]),
                Convert.ToString(result[field_shortcut])
            );

            return measure;
        }

        public static int createMeasure(string name)
        {
            executeSql(""
                + "INSERT INTO "
                    + "`" + tableName + "` "
                + "("
                    + "`" + field_name + "`"
                + ") VALUES ("
                    + "'" + name + "'"
                + ")"
            );

            Dictionary<string, object> result = querySingleSql("SELECT LAST_INSERT_ID() AS `insertionId`");

            return Convert.ToInt32(result["insertionId"]);
        }

        public static void updateMeasure(Measure measure)
        {
            executeSql(""
                + "UPDATE "
                    + "`" + tableName + "` "
                + "SET "
                    + "`" + field_name + "` = " + measure.Name + ". "
                    + "`" + field_shortcut + "` = " + measure.Shortcut + " "
                + "WHERE "
                    + "`" + field_measureId + " = " + measure.MeasureId
            );
        }

        public static void deleteMeasure(Measure measure)
        {
            executeSql(""
                + "DELETE FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_measureId + " = " + measure.MeasureId + " "
                + "LIMIT 1"
            );
        }
    }
}
