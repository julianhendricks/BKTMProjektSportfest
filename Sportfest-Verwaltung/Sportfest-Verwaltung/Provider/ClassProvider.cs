using System;
using SportsFestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsFestivalManagement.Provider
{
    class ClassProvider : AbstractEntityProvider
    {
        public const string tableName = "class";
        public const string field_classId = "classId";
        public const string field_shortcut = "shortcut";

        public static List<Class> getAllClasses()
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<Class> classes = new List<Class>();

            foreach (var row in results)
            {
                classes.Add(getClassById(Convert.ToInt32(row[field_classId])));
            }

            return classes;
        }

        public static List<Class> getAllClassesOrderedByAscendingShortcut()
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "ORDER BY "
                    + "`" + field_shortcut + "` ASC"
            );

            List<Class> classes = new List<Class>();

            foreach (var row in results)
            {
                classes.Add(getClassById(Convert.ToInt32(row[field_classId])));
            }

            return classes;
        }

        public static Class getClassById(int classId) {
            Dictionary<string, object> result = querySingleSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_classId + "` = " + classId
            );

            if (result == null)
            {
                return null;
            }

            Class classElement = new Class(
                Convert.ToInt32(result[field_classId]),
                Convert.ToString(result[field_shortcut])
            );

            return classElement;
        }

        public static int createClass(string shortcut)
        {
            executeSql(""
                + "INSERT INTO "
                    + "`" + tableName + "` "
                + "("
                    + "`" + field_shortcut + "`"
                + ") VALUES ("
                    + "'" + shortcut + "'"
                + ")"
            );

            Dictionary<string, object> result = querySingleSql("SELECT MAX(`" + field_classId + "`) AS `insertionId` FROM `" + tableName + "`");

            int insertionId = Convert.ToInt32(result["insertionId"]);

            return insertionId;
        }

        public static void updateClass(Class classElement)
        {
            executeSql(""
                + "UPDATE "
                    + "`" + tableName + "` "
                + "SET "
                    + "`" + field_shortcut + "` = " + classElement.Shortcut + " "
                + "WHERE "
                    + "`" + field_classId + " = " + classElement.ClassId
            );
        }

        public static void deleteClass(Class classElement)
        {
            executeSql(""
                + "DELETE FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_classId + " = " + classElement.ClassId + " "
                + "LIMIT 1"
            );
        }
    }
}
