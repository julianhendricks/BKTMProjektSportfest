using System;
using SportsFestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsFestivalManagement.Provider
{
    class SubscriptionProvider : AbstractEntityProvider
    {
        public const string tableName = "subscription";
        public const string field_sportsFestivalSubscriptionId = "sportsFestivalSubscriptionId";
        public const string field_competitionId = "competitionId";
        public const string field_disciplineId = "disciplineId";
        public const string field_result = "result";

        public static List<Subscription> getAllSubscriptions()
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<Subscription> subscriptions = new List<Subscription>();

            foreach (var row in results)
            {
                Competition competition = CompetitionProvider.getCompetitionById(Convert.ToInt32(row[field_competitionId]));

                Discipline discipline = DisciplineProvider.getDisciplineById(Convert.ToInt32(row[field_disciplineId]));

                subscriptions.Add(getSubscriptionByPrimaryKey(
                    Convert.ToInt32(row[field_sportsFestivalSubscriptionId]),
                    competition,
                    discipline
                ));
            }

            return subscriptions;
        }

        public static Subscription getSubscriptionByPrimaryKey(
            int sportsFestivalSubscriptionId,
            Competition competition,
            Discipline discipline
        ) {
            Dictionary<string, object> result = querySingleSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_sportsFestivalSubscriptionId + "` = " + sportsFestivalSubscriptionId + " "
                    + "AND `" + field_competitionId + "` = " + competition.CompetitionId + " "
                    + "AND `" + field_disciplineId + "` = " + discipline.DisciplineId
            );

            Subscription subscription = new Subscription(
                Convert.ToInt32(result[field_sportsFestivalSubscriptionId]),
                competition,
                discipline,
                Convert.ToDouble(result[field_result])
            );

            return subscription;
        }

        public static void createSubscription(
            int sportsFestivalSubscriptionId,
            Competition competition,
            Discipline discipline,
            double result
        ) {
            executeSql(""
                + "INSERT INTO "
                    + "`" + tableName + "` "
                + "("
                    + "`" + field_sportsFestivalSubscriptionId + "`, "
                    + "`" + field_competitionId + "`, "
                    + "`" + field_disciplineId + "`, "
                    + "`" + field_result + "`"
                + ") VALUES ("
                    + sportsFestivalSubscriptionId + ", "
                    + competition.CompetitionId + ", "
                    + discipline.DisciplineId + ", "
                    + result
                + ")"
            );
        }

        public static void updateSubscription(Subscription subscription)
        {
            executeSql(""
                + "UPDATE "
                    + "`" + tableName + "` "
                + "SET "
                    + "`" + field_result + "` = " + subscription.Result + " "
                + "WHERE "
                    + "`" + field_sportsFestivalSubscriptionId + " = " + subscription.SportsFestivalSubscriptionId + " "
                    + "AND `" + field_competitionId + "` = " + subscription.Competition.CompetitionId + " "
                    + "AND `" + field_disciplineId + "` = " + subscription.Discipline.DisciplineId
            );
        }

        public static void deleteSubscription(Subscription subscription)
        {
            executeSql(""
                + "DELETE FROM `" + tableName + "` "
                + "WHERE "
                    + "`" + field_sportsFestivalSubscriptionId + " = " + subscription.SportsFestivalSubscriptionId + " "
                    + "AND `" + field_competitionId + "` = " + subscription.Competition.CompetitionId + " "
                    + "AND `" + field_disciplineId + "` = " + subscription.Discipline.DisciplineId + " "
                + "LIMIT 1"
            );
        }
    }
}
