using SportsfestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsfestivalManagement.Provider
{
    class BenchmarkProvider : AbstractEntityProvider
    {
        const string tableName = "benchmark";
        const string field_disciplineId = "disciplineId";
        const string field_ageFrom = "ageFrom";
        const string field_ageUntil = "ageUntil";
        const string field_gender = "gender";
        const string field_rank = "rank";
        const string field_benchmark = "benchmark";

        public List<Benchmark> getAllBenchmarks()
        {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT * "
                + "FROM `" + tableName + "`"
            );

            List<Benchmark> benchmarks = new List<Benchmark>();

            while(reader.Read())
            {
                Benchmark benchmark = new Benchmark(
                    reader.GetInt32(field_disciplineId),
                    reader.GetInt32(field_ageFrom),
                    reader.GetInt32(field_ageUntil),
                    reader.GetChar(field_gender),
                    reader.GetString(field_rank),
                    reader.GetDouble(field_benchmark)
                );

                benchmarks.Add(benchmark);
            }

            return benchmarks;
        }

        public Benchmark getBenchmarkByPrimaryKey(
            int disciplineId,
            int ageFrom,
            int ageUntil,
            char gender,
            string rank
        ) {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT * "
                + "FROM `" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineId + "` = " + disciplineId
                    + "AND `" + field_ageFrom + "` = " + ageFrom
                    + "AND `" + field_ageUntil + "` = " + ageUntil
                    + "AND `" + field_gender + "` = '" + ageFrom + "'"
                    + "AND `" + field_rank + "` = '" + rank + "'"
            );

            Benchmark benchmark = new Benchmark(
                reader.GetInt32(field_disciplineId),
                reader.GetInt32(field_ageFrom),
                reader.GetInt32(field_ageUntil),
                reader.GetChar(field_gender),
                reader.GetString(field_rank),
                reader.GetDouble(field_benchmark)
            );

            return benchmark;
        }

        public void createBenchmark(
            int disciplineId,
            int ageFrom,
            int ageUntil,
            char gender,
            string rank,
            double benchmark
        ) {
            MySqlDataReader reader = this.executeSql(""
                + "INSERT INTO `" + tableName + "` "
                + "("
                    + "`" + field_disciplineId + "`, "
                    + "`" + field_ageFrom + "`, "
                    + "`" + field_ageUntil + "`, "
                    + "`" + field_gender + "`, "
                    + "`" + field_rank + "`, "
                    + "`" + field_benchmark + "`"
                + ") VALUES ("
                    + disciplineId + ", "
                    + ageFrom + ", "
                    + ageUntil + ", "
                    + "'" + gender + "', "
                    + "'" + rank + "', "
                    + benchmark
                + ")"
            );
        }

        public void updateBenchmark(Benchmark benchmark)
        {
            MySqlDataReader reader = this.executeSql(""
                + "UPDATE `" + tableName + "` "
                + "SET "
                    + "`" + field_benchmark + "` = " + benchmark.BenchmarkValue + " "
                + "WHERE "
                    + "`" + field_disciplineId + " = " + benchmark.DisciplineId + " "
                    + "AND `" + field_ageFrom + "` = " + benchmark.AgeFrom + " "
                    + "AND `" + field_ageUntil + "` = " + benchmark.AgeUntil + " "
                    + "AND `" + field_gender + "` = '" + benchmark.Gender + "' "
                    + "AND `" + field_rank + "` = '" + benchmark.Rank + "'"
            );
        }

        public void deleteBenchmark(Benchmark benchmark)
        {
            MySqlDataReader reader = this.executeSql(""
                + "DELETE FROM `" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineId + " = " + benchmark.DisciplineId + " "
                    + "AND `" + field_ageFrom + "` = " + benchmark.AgeFrom + " "
                    + "AND `" + field_ageUntil + "` = " + benchmark.AgeUntil + " "
                    + "AND `" + field_gender + "` = '" + benchmark.Gender + "' "
                    + "AND `" + field_rank + "` = '" + benchmark.Rank + "' "
                + "LIMIT 1"
            );
        }
    }
}
