using System;
using SportsFestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsFestivalManagement.Provider
{
    class SportsFestivalSubscriptionProvider : AbstractEntityProvider
    {
        public const string tableName = "sportsfestivalsubscription";
        public const string field_sportsFestivalSubscriptionId = "sportsFestivalSubscriptionId";
        public const string field_sportsFestivalId = "sportsFestivalId";
        public const string field_studentId = "studentId";
        public const string field_classShortcut = "classShortcut";

        public static List<Student> getStudentsBySportsFestival(SportsFestival sportsFestival)
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_sportsFestivalId + "` = " + sportsFestival.SportsFestivalId
            );

            List<Student> students = new List<Student>();

            foreach (var row in results)
            {
                students.Add(StudentProvider.getStudentById((int)row[field_studentId]));
            }

            return students;
        }

        public static List<Class> getClassesBySportsFestival(SportsFestival sportsFestival)
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_sportsFestivalId + "` = " + sportsFestival.SportsFestivalId
            );

            List<Class> classes = new List<Class>();

            foreach (var row in results)
            {
                classes.Add(ClassProvider.getClassByShortCut(row[field_classShortcut].ToString()));
            }

            return classes;
        }
    } 
}
