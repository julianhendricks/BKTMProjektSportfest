using System;
using SportsFestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsFestivalManagement.Provider
{
    class BenchmarkProvider : AbstractEntityProvider
    {
        public const string tableName = "benchmark";
        public const string field_disciplineId = "disciplineId";
        public const string field_ageFrom = "ageFrom";
        public const string field_ageUntil = "ageUntil";
        public const string field_gender = "gender";
        public const string field_rank = "rank";
        public const string field_benchmark = "benchmark";

        public static List<Benchmark> getAllBenchmarks()
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "`" + field_disciplineId + "`, "
                    + "`" + field_ageFrom + "`, "
                    + "`" + field_ageUntil + "`, "
                    + "`" + field_gender + "`, "
                    + "`" + field_rank + "` "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<Benchmark> benchmarks = new List<Benchmark>();

            foreach(var row in results)
            {
                Discipline discipline = DisciplineProvider.getDisciplineById(Convert.ToInt32(row[field_disciplineId]));

                benchmarks.Add(getBenchmarkByPrimaryKey(
                    discipline,
                    Convert.ToInt32(row[field_ageFrom]),
                    Convert.ToInt32(row[field_ageUntil]),
                    Convert.ToChar(row[field_gender]),
                    Convert.ToString(row[field_rank])
                ));
            }

            return benchmarks;
        }

        public static Benchmark getBenchmarkByPrimaryKey(
            Discipline discipline,
            int ageFrom,
            int ageUntil,
            char gender,
            string rank
        ) {
            Dictionary<string, object> result = querySingleSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineId + "` = " + discipline.DisciplineId + " "
                    + "AND `" + field_ageFrom + "` = " + ageFrom + " "
                    + "AND `" + field_ageUntil + "` = " + ageUntil + " "
                    + "AND `" + field_gender + "` = '" + ageFrom + "' "
                    + "AND `" + field_rank + "` = '" + rank + "'"
            );

            if (result == null)
            {
                return null;
            }

            Benchmark benchmark = new Benchmark(
                discipline,
                Convert.ToInt32(result[field_ageFrom]),
                Convert.ToInt32(result[field_ageUntil]),
                Convert.ToChar(result[field_gender]),
                Convert.ToString(result[field_rank]),
                Convert.ToDouble(result[field_benchmark])
            );

            return benchmark;
        }

        public static List<Benchmark> getBenchmarksByDiscipline(Discipline discipline)
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineId + "` = " + discipline.DisciplineId
            );

            List<Benchmark> benchmarks = new List<Benchmark>();

            foreach (var row in results)
            {
                Benchmark benchmark = new Benchmark(
                    discipline,
                    Convert.ToInt32(row[field_ageFrom]),
                    Convert.ToInt32(row[field_ageUntil]),
                    Convert.ToChar(row[field_gender]),
                    Convert.ToString(row[field_rank]),
                    Convert.ToDouble(row[field_benchmark])
                );

                benchmarks.Add(benchmark);
            }

            return benchmarks;
        }

        public static void createBenchmark(
            Discipline discipline,
            int ageFrom,
            int ageUntil,
            char gender,
            string rank,
            double benchmark
        ) {
            executeSql(""
                + "INSERT INTO "
                    + "`" + tableName + "` "
                + "("
                    + "`" + field_disciplineId + "`, "
                    + "`" + field_ageFrom + "`, "
                    + "`" + field_ageUntil + "`, "
                    + "`" + field_gender + "`, "
                    + "`" + field_rank + "`, "
                    + "`" + field_benchmark + "`"
                + ") VALUES ("
                    + discipline.DisciplineId + ", "
                    + ageFrom + ", "
                    + ageUntil + ", "
                    + "'" + gender + "', "
                    + "'" + rank + "', "
                    + benchmark
                + ")"
            );
        }

        public static void updateBenchmark(Benchmark benchmark)
        {
            executeSql(""
                + "UPDATE "
                    + "`" + tableName + "` "
                + "SET "
                    + "`" + field_benchmark + "` = " + benchmark.BenchmarkValue + " "
                + "WHERE "
                    + "`" + field_disciplineId + " = " + benchmark.Discipline.DisciplineId + " "
                    + "AND `" + field_ageFrom + "` = " + benchmark.AgeFrom + " "
                    + "AND `" + field_ageUntil + "` = " + benchmark.AgeUntil + " "
                    + "AND `" + field_gender + "` = '" + benchmark.Gender + "' "
                    + "AND `" + field_rank + "` = '" + benchmark.Rank + "'"
            );
        }

        public static void deleteBenchmark(Benchmark benchmark)
        {
            executeSql(""
                + "DELETE FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineId + " = " + benchmark.Discipline.DisciplineId + " "
                    + "AND `" + field_ageFrom + "` = " + benchmark.AgeFrom + " "
                    + "AND `" + field_ageUntil + "` = " + benchmark.AgeUntil + " "
                    + "AND `" + field_gender + "` = '" + benchmark.Gender + "' "
                    + "AND `" + field_rank + "` = '" + benchmark.Rank + "' "
                + "LIMIT 1"
            );
        }
    }
}
