using SportsfestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsfestivalManagement.Provider
{
    class ClassProvider : AbstractEntityProvider
    {
        const string tableName = "class";
        const string field_classId = "classId";
        const string field_shortcut = "shortcut";

        public List<Class> getAllClasses()
        {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT * "
                + "FROM `" + tableName + "`"
            );

            List<Class> classes = new List<Class>();

            while(reader.Read())
            {
                Class classElement = new Class(
                    reader.GetInt32(field_classId),
                    reader.GetString(field_shortcut)
                );

                classes.Add(classElement);
            }

            return classes;
        }

        public Class getClassById(int classId) {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT * "
                + "FROM `" + tableName + "` "
                + "WHERE "
                    + "`" + field_classId + "` = " + classId
            );

            Class classElement = new Class(
                reader.GetInt32(field_classId),
                reader.GetString(field_shortcut)
            );

            return classElement;
        }

        public int createClass(string shortcut)
        {
            MySqlDataReader reader = this.executeSql(""
                + "INSERT INTO `" + tableName + "` "
                + "("
                    + "`" + field_shortcut + "`"
                + ") VALUES ("
                    + "'" + shortcut + "'"
                + ")"
            );

            reader = this.executeSql("SELECT LAST_INSERT_ID() AS insertionId");

            return reader.GetInt32("insertionId");
        }

        public void updateClass(Class classElement)
        {
            MySqlDataReader reader = this.executeSql(""
                + "UPDATE `" + tableName + "` "
                + "SET "
                    + "`" + field_shortcut + "` = " + classElement.Shortcut + " "
                + "WHERE "
                    + "`" + field_classId + " = " + classElement.ClassId
            );
        }

        public void deleteClass(Class classElement)
        {
            MySqlDataReader reader = this.executeSql(""
                + "DELETE FROM `" + tableName + "` "
                + "WHERE "
                    + "`" + field_classId + " = " + classElement.ClassId + " "
                + "LIMIT 1"
            );
        }
    }
}
