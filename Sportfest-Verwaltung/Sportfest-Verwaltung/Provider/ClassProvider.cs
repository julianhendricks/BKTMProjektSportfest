using SportsfestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsfestivalManagement.Provider
{
    class ClassProvider : AbstractEntityProvider
    {
        public const string tableName = "class";
        public const string field_classId = "classId";
        public const string field_shortcut = "shortcut";

        public static List<Class> getAllClasses()
        {
            MySqlDataReader reader = executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<Class> classes = new List<Class>();

            while(reader.Read())
            {
                classes.Add(getClassById(reader.GetInt32(field_classId)));
            }

            return classes;
        }

        public static Class getClassById(int classId) {
            MySqlDataReader reader = executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_classId + "` = " + classId
            );

            Class classElement = new Class(
                reader.GetInt32(field_classId),
                reader.GetString(field_shortcut)
            );

            return classElement;
        }

        public static int createClass(string shortcut)
        {
            MySqlDataReader reader = executeSql(""
                + "INSERT INTO "
                    + "`" + tableName + "` "
                + "("
                    + "`" + field_shortcut + "`"
                + ") VALUES ("
                    + "'" + shortcut + "'"
                + ")"
            );

            reader = executeSql("SELECT LAST_INSERT_ID() AS insertionId");

            return reader.GetInt32("insertionId");
        }

        public static void updateClass(Class classElement)
        {
            MySqlDataReader reader = executeSql(""
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
            MySqlDataReader reader = executeSql(""
                + "DELETE FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_classId + " = " + classElement.ClassId + " "
                + "LIMIT 1"
            );
        }
    }
}
