using SportsfestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsfestivalManagement.Provider
{
    class SubscriptionProvider : AbstractEntityProvider
    {
        const string tableName = "subscription";
        const string field_sportsFestivalSubscriptionId = "sportsFestivalSubscriptionId";
        const string field_competitionId = "competitionId";
        const string field_disciplineId = "disciplineId";
        const string field_result = "result";

        public List<Subscription> getAllSubscriptions()
        {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT * "
                + "FROM `" + tableName + "`"
            );

            List<Subscription> subscriptions = new List<Subscription>();

            while(reader.Read())
            {
                Subscription subscription = new Subscription(
                    reader.GetInt32(field_sportsFestivalSubscriptionId),
                    reader.GetInt32(field_competitionId),
                    reader.GetInt32(field_disciplineId),
                    reader.GetDouble(field_result)
                );

                subscriptions.Add(subscription);
            }

            return subscriptions;
        }

        public Subscription getSubscriptionByPrimaryKey(
            int sportsFestivalSubscriptionId,
            int competitionId,
            int disciplineId
        ) {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT * "
                + "FROM `" + tableName + "` "
                + "WHERE "
                    + "`" + field_sportsFestivalSubscriptionId + "` = " + sportsFestivalSubscriptionId
                    + "AND `" + field_competitionId + "` = " + competitionId
                    + "AND `" + field_disciplineId + "` = " + disciplineId
            );

            Subscription subscription = new Subscription(
                reader.GetInt32(field_sportsFestivalSubscriptionId),
                reader.GetInt32(field_competitionId),
                reader.GetInt32(field_disciplineId),
                reader.GetDouble(field_result)
            );

            return subscription;
        }

        public void createSubscription(
            int sportsFestivalSubscriptionId,
            int competitionId,
            int disciplineId,
            double result
        ) {
            MySqlDataReader reader = this.executeSql(""
                + "INSERT INTO `" + tableName + "` "
                + "("
                    + "`" + field_sportsFestivalSubscriptionId + "`, "
                    + "`" + field_competitionId + "`, "
                    + "`" + field_disciplineId + "`, "
                    + "`" + field_result + "`"
                + ") VALUES ("
                    + sportsFestivalSubscriptionId + ", "
                    + competitionId + ", "
                    + disciplineId + ", "
                    + result
                + ")"
            );
        }

        public void updateSubscription(Subscription subscription)
        {
            MySqlDataReader reader = this.executeSql(""
                + "UPDATE `" + tableName + "` "
                + "SET "
                    + "`" + field_result + "` = " + subscription.Result + " "
                + "WHERE "
                    + "`" + field_sportsFestivalSubscriptionId + " = " + subscription.SportsFestivalSubscriptionId + " "
                    + "AND `" + field_competitionId + "` = " + subscription.CompetitionId + " "
                    + "AND `" + field_disciplineId + "` = " + subscription.DisciplineId
            );
        }

        public void deleteSubscription(Subscription subscription)
        {
            MySqlDataReader reader = this.executeSql(""
                + "DELETE FROM `" + tableName + "` "
                + "WHERE "
                    + "`" + field_sportsFestivalSubscriptionId + " = " + subscription.SportsFestivalSubscriptionId + " "
                    + "AND `" + field_competitionId + "` = " + subscription.CompetitionId + " "
                    + "AND `" + field_disciplineId + "` = " + subscription.DisciplineId + " "
                + "LIMIT 1"
            );
        }
    }
}
