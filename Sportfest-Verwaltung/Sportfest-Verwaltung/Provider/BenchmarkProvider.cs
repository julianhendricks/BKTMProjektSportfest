﻿using SportsfestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsfestivalManagement.Provider
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
            MySqlDataReader reader = executeSql(""
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

            while(reader.Read())
            {
                Discipline discipline = DisciplineProvider.getDisciplineById(reader.GetInt32(field_disciplineId));

                benchmarks.Add(getBenchmarkByPrimaryKey(
                    discipline,
                    reader.GetInt32(field_ageFrom),
                    reader.GetInt32(field_ageUntil),
                    reader.GetChar(field_gender),
                    reader.GetString(field_rank)
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
            MySqlDataReader reader = executeSql(""
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

            Benchmark benchmark = new Benchmark(
                discipline,
                reader.GetInt32(field_ageFrom),
                reader.GetInt32(field_ageUntil),
                reader.GetChar(field_gender),
                reader.GetString(field_rank),
                reader.GetDouble(field_benchmark)
            );

            return benchmark;
        }

        public static List<Benchmark> getBenchmarksByDiscipline(Discipline discipline)
        {
            MySqlDataReader reader = executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineId + "` = " + discipline.DisciplineId
            );

            List<Benchmark> benchmarks = new List<Benchmark>();

            while (reader.Read())
            {
                Benchmark benchmark = new Benchmark(
                    discipline,
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

        public static void createBenchmark(
            Discipline discipline,
            int ageFrom,
            int ageUntil,
            char gender,
            string rank,
            double benchmark
        ) {
            MySqlDataReader reader = executeSql(""
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
            MySqlDataReader reader = executeSql(""
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
            MySqlDataReader reader = executeSql(""
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
