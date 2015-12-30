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
        public const string field_prefix = "prefix";
        public const string field_year = "year";
        public const string field_suffix = "suffix";

        public static List<Class> getAllClasses()
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "`" + field_classId + "` "
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
                    + "`" + field_classId + "` "
                + "FROM "
                    + "`" + tableName + "` "
                + "ORDER BY "
                    + "`" + field_prefix + "` ASC, "
                    + "`" + field_year + "` ASC, "
                    + "`" + field_suffix + "` ASC"
            );

            List<Class> classes = new List<Class>();

            foreach (var row in results)
            {
                classes.Add(getClassById(Convert.ToInt32(row[field_classId])));
            }

            return classes;
        }

        public static List<Class> getAllClassesOrderedByDescendingYear()
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "`" + field_classId + "` "
                + "FROM "
                    + "`" + tableName + "` "
                + "ORDER BY "
                    + "`" + field_year + "` DESC"
            );

            List<Class> classes = new List<Class>();

            foreach (var row in results)
            {
                classes.Add(getClassById(Convert.ToInt32(row[field_classId])));
            }

            return classes;
        }

        public static Class getClassById(int classId)
        {
            Dictionary<string, object> result = querySingleSql(""
                + "SELECT "
                    + "`" + field_classId + "`, "
                    + "`" + field_prefix + "`, "
                    + "`" + field_year + "`, "
                    + "`" + field_suffix + "` "
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
                Convert.ToString(result[field_prefix]),
                Convert.ToInt32(result[field_year]),
                Convert.ToString(result[field_suffix])
            );

            return classElement;
        }

        public static Class getClassByShortcut(
            string prefix,
            int year,
            string suffix
        ) {
            Dictionary<string, object> result = querySingleSql(""
                + "SELECT "
                    + "`" + field_classId + "` "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_prefix + "` = '" + prefix + "' "
                    + "AND `" + field_year + "` = " + year + " "
                    + "AND `" + field_suffix + "` = '" + suffix + "'"
            );

            if (result == null)
            {
                return null;
            }

            return getClassById(Convert.ToInt32(result[field_classId]));
        }

        public static int createClass(
            string prefix,
            int year,
            string suffix
        ) {
            executeSql(""
                + "INSERT INTO "
                    + "`" + tableName + "` "
                + "("
                    + "`" + field_prefix + "`, "
                    + "`" + field_year + "`, "
                    + "`" + field_suffix + "`"
                + ") VALUES ("
                    + "'" + prefix + "', "
                    + year + ", "
                    + "'" + suffix + "'"
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
                    + "`" + field_prefix + "` = '" + classElement.Prefix + "', "
                    + "`" + field_year + "` = " + classElement.Year + ", "
                    + "`" + field_suffix + "` = '" + classElement.Suffix + "' "
                + "WHERE "
                    + "`" + field_classId + "` = " + classElement.ClassId
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

        public static void rotateClasses()
        {
            List<Class> classes = getAllClassesOrderedByDescendingYear();

            foreach (Class classObject in classes)
            {
                classObject.Year++;
                updateClass(classObject);
            }
        }
    }
}
