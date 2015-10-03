using SportsfestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsfestivalManagement.Provider
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
            MySqlDataReader reader = executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<Subscription> subscriptions = new List<Subscription>();

            while(reader.Read())
            {
                Competition competition = CompetitionProvider.getCompetitionById(reader.GetInt32(field_competitionId));

                Discipline discipline = DisciplineProvider.getDisciplineById(reader.GetInt32(field_disciplineId));

                subscriptions.Add(getSubscriptionByPrimaryKey(
                    reader.GetInt32(field_sportsFestivalSubscriptionId),
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
            MySqlDataReader reader = executeSql(""
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
                reader.GetInt32(field_sportsFestivalSubscriptionId),
                competition,
                discipline,
                reader.GetDouble(field_result)
            );

            return subscription;
        }

        public static void createSubscription(
            int sportsFestivalSubscriptionId,
            Competition competition,
            Discipline discipline,
            double result
        ) {
            MySqlDataReader reader = executeSql(""
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
            MySqlDataReader reader = executeSql(""
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
            MySqlDataReader reader = executeSql(""
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
