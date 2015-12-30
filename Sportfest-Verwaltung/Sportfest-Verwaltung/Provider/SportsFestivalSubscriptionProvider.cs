using SportsFestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace SportsFestivalManagement.Provider
{
    class SportsFestivalSubscriptionProvider : AbstractEntityProvider
    {
        public const string tableName = "sportsfestivalSubscription";
        public const string field_sportsFestivalSubscriptionId = "sportsFestivalSubscriptionId";
        public const string field_sportsFestivalId = "sportsFestivalId";
        public const string field_studentId = "studentId";
        public const string field_classShortcut = "classShortcut";

        public static List<SportsFestivalSubscription> getSportsFestivalSubscriptionsBySportsFestival(SportsFestival sportsFestival)
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_sportsFestivalId + "` = " + sportsFestival.SportsFestivalId
            );

            List<SportsFestivalSubscription> sportsFestivalSubscriptions = new List<SportsFestivalSubscription>();

            foreach (var row in results)
            {
                sportsFestivalSubscriptions.Add(getSportsFestivalSubscriptionById(Convert.ToInt32(row[field_sportsFestivalSubscriptionId])));
            }

            return sportsFestivalSubscriptions;
        }

        public static SportsFestivalSubscription getSportsFestivalSubscriptionById(int sportsFestivalSubscriptionId)
        {
            Dictionary<string, object> result = querySingleSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_sportsFestivalSubscriptionId + "` = " + sportsFestivalSubscriptionId
            );

            if (result == null)
            {
                return null;
            }

            SportsFestivalSubscription sportsFestivalSubscription = new SportsFestivalSubscription(
                Convert.ToInt32(result[field_sportsFestivalSubscriptionId]),
                SportsFestivalProvider.getSportsFestivalById(Convert.ToInt32(result[field_sportsFestivalId])),
                StudentProvider.getStudentById(Convert.ToInt32(result[field_studentId])),
                Convert.ToString(result[field_classShortcut])
            );

            return sportsFestivalSubscription;
        }

        public static int createSportsFestivalSubscription(
            SportsFestival sportsFestival,
            Student student
        ) {
            executeSql(""
                + "INSERT INTO `" + tableName + "` "
                + "("
                    + "`" + field_sportsFestivalId + "`, "
                    + "`" + field_studentId + "`, "
                    + "`" + field_classShortcut + "`"
                + ") VALUES ("
                    + sportsFestival.SportsFestivalId + ", "
                    + student.StudentId + ", "
                    + "'" + student.ClassObject.Shortcut + "'"
                + ")"
            );

            Dictionary<string, object> result = querySingleSql("SELECT MAX(`" + field_sportsFestivalSubscriptionId + "`) AS `insertionId` FROM `" + tableName + "`");

            int insertionId = Convert.ToInt32(result["insertionId"]);

            return insertionId;
        }

        public static void deleteSportsFestivalSubscription(SportsFestivalSubscription sportsFestivalSubscription)
        {
            executeSql(""
                + "DELETE FROM `" + tableName + "` "
                + "WHERE "
                    + "`" + field_sportsFestivalSubscriptionId + " = " + sportsFestivalSubscription.SportsFestivalSubscriptionId + " "
                + "LIMIT 1"
            );
        }
    }
}
