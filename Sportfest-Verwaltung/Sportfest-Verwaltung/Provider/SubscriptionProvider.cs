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

        public List<Subscription> getAllSubscriptions()
        {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<Subscription> subscriptions = new List<Subscription>();

            while(reader.Read())
            {
                CompetitionProvider competitionProvider = new CompetitionProvider();
                Competition competition = competitionProvider.getCompetitionById(reader.GetInt32(field_competitionId));

                DisciplineProvider disciplineProvider = new DisciplineProvider();
                Discipline discipline = disciplineProvider.getDisciplineById(reader.GetInt32(field_disciplineId));

                subscriptions.Add(this.getSubscriptionByPrimaryKey(
                    reader.GetInt32(field_sportsFestivalSubscriptionId),
                    competition,
                    discipline
                ));
            }

            return subscriptions;
        }

        public Subscription getSubscriptionByPrimaryKey(
            int sportsFestivalSubscriptionId,
            Competition competition,
            Discipline discipline
        ) {
            MySqlDataReader reader = this.executeSql(""
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

        public void createSubscription(
            int sportsFestivalSubscriptionId,
            Competition competition,
            Discipline discipline,
            double result
        ) {
            MySqlDataReader reader = this.executeSql(""
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

        public void updateSubscription(Subscription subscription)
        {
            MySqlDataReader reader = this.executeSql(""
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

        public void deleteSubscription(Subscription subscription)
        {
            MySqlDataReader reader = this.executeSql(""
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
