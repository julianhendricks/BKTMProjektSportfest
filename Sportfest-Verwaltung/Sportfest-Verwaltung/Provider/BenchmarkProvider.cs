using SportsfestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace SportsfestivalManagement.Provider
{
    class BenchmarkProvider
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
            MySQL mySql = MySQLProvider.getMySQLInstance();
            mySql.connect();

            MySqlDataReader reader = mySql.query(""
                + "SELECT * "
                + "FROM `" + tableName + "`"
            );

            List<Benchmark> benchmarks = new List<Benchmark>();

            while(reader.Read())
            {
                Benchmark benchmark = new Benchmark(
                    Convert.ToInt32(reader.GetString(field_disciplineId)),
                    Convert.ToInt32(reader.GetString(field_ageFrom)),
                    Convert.ToInt32(reader.GetString(field_ageUntil)),
                    Convert.ToChar(reader.GetString(field_gender)),
                    reader.GetString(field_rank),
                    Convert.ToDouble(reader.GetString(field_benchmark))
                );

                benchmarks.Add(benchmark);
            }

            return benchmarks;
        }

        public Benchmark getBenchmarkById()
        {
            
        }
    }
}
