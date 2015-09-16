using SportsfestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsfestivalManagement.Provider
{
    class CompetitionProvider : AbstractEntityProvider
    {
        public const string tableName = "competition";
        public const string field_competitionId = "competitionId";
        public const string field_competitionName = "competitionName";

        public const string relation_tableName = "competitionDisciplineSet";
        public const string relation_field_competitionId = "competitionId";
        public const string relation_field_disciplineSetId = "disciplineSetId";

        public List<Competition> getAllCompetitions()
        {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<Competition> competitions = new List<Competition>();

            while (reader.Read())
            {
                competitions.Add(this.getCompetitionById(reader.GetInt32(field_competitionId)));
            }

            return competitions;
        }

        public Competition getCompetitionById(int competitionId)
        {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_competitionId + "` = " + competitionId
            );

            DisciplineSetProvider disciplineSetProvider = new DisciplineSetProvider();
            List<DisciplineSet> disciplineSetsList = disciplineSetProvider.getDisciplineSetsByCompetitionId(reader.GetInt32(field_competitionId));

            Competition competition = new Competition(
                reader.GetInt32(field_competitionId),
                reader.GetString(field_competitionName),
                disciplineSetsList
            );

            return competition;
        }

        public List<Competition> getCompetitionsByDisciplineSetId(int disciplineSetId)
        {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + relation_tableName + "` "
                + "WHERE "
                    + "`" + relation_field_disciplineSetId + "` = " + disciplineSetId
            );

            List<Competition> competitions = new List<Competition>();

            while (reader.Read())
            {
                competitions.Add(this.getCompetitionById(reader.GetInt32(relation_field_competitionId)));
            }

            return competitions;
        }

        public int createCompetition(string competitionName)
        {
            MySqlDataReader reader = this.executeSql(""
                + "INSERT INTO "
                    + "`" + tableName + "` "
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
                + "UPDATE "
                    + "`" + tableName + "` "
                + "SET "
                    + "`" + field_competitionName + "` = " + competition.CompetitionName + " "
                + "WHERE "
                    + "`" + field_competitionId + " = " + competition.CompetitionId
            );
        }

        public void deleteCompetition(Competition competition)
        {
            MySqlDataReader reader = this.executeSql(""
                + "DELETE FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_competitionId + " = " + competition.CompetitionId + " "
                + "LIMIT 1"
            );
        }
    }
}
