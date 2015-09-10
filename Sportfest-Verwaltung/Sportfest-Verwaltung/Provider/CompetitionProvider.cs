using SportsfestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsfestivalManagement.Provider
{
    class CompetitionProvider : AbstractEntityProvider
    {
        const string tableName = "competition";
        const string field_competitionId = "competitionId";
        const string field_competitionName = "competitionName";

        public List<Competition> getAllCompetitions()
        {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT * "
                + "FROM `" + tableName + "`"
            );

            List<Competition> competitions = new List<Competition>();

            while (reader.Read())
            {
                Competition competition = new Competition(
                    reader.GetInt32(field_competitionId),
                    reader.GetString(field_competitionName)
                );

                competitions.Add(competition);
            }

            return competitions;
        }

        public Competition getCompetitionById(int competitionId)
        {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT * "
                + "FROM `" + tableName + "` "
                + "WHERE "
                    + "`" + field_competitionId + "` = " + competitionId
            );

            Competition competition = new Competition(
                reader.GetInt32(field_competitionId),
                reader.GetString(field_competitionName)
            );

            return competition;
        }

        public int createCompetition(string competitionName)
        {
            MySqlDataReader reader = this.executeSql(""
                + "INSERT INTO `" + tableName + "` "
                + "("
                    + "`" + field_competitionName + "`"
                + ") VALUES ("
                    + "'" + competitionName + "'"
                + ")"
            );

            reader = this.executeSql("SELECT LAST_INSERT_ID() AS insertionId");

            return reader.GetInt32("insertionId");
        }

        public void updateCompetition(Competition competition)
        {
            MySqlDataReader reader = this.executeSql(""
                + "UPDATE `" + tableName + "` "
                + "SET "
                    + "`" + field_competitionName + "` = " + competition.CompetitionName + " "
                + "WHERE "
                    + "`" + field_competitionId + " = " + competition.CompetitionId
            );
        }

        public void deleteCompetition(Competition competition)
        {
            MySqlDataReader reader = this.executeSql(""
                + "DELETE FROM `" + tableName + "` "
                + "WHERE "
                    + "`" + field_competitionId + " = " + competition.CompetitionId + " "
                + "LIMIT 1"
            );
        }
    }
}
