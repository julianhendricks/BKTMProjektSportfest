using System;
using SportsFestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsFestivalManagement.Provider
{
    class DisciplineSetDisciplineMappingProvider : AbstractEntityProvider
    {
        public const string tableName = "disciplineSetDisciplineMapping";
        public const string field_disciplineSetId = "disciplineSetId";
        public const string field_ageFrom = "ageFrom";
        public const string field_ageUntil = "ageUntil";
        public const string field_disciplineId = "disciplineId";

        public static List<DisciplineSetDisciplineMapping> getAllDisciplineSetDisciplineMappings()
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<DisciplineSetDisciplineMapping> disciplineSetDisciplineMappings = new List<DisciplineSetDisciplineMapping>();

            foreach (var row in results)
            {
                disciplineSetDisciplineMappings.Add(getDisciplineSetDisciplineMappingByPrimaryKey(
                    Convert.ToInt32(row[field_disciplineSetId]),
                    Convert.ToInt32(row[field_ageFrom]),
                    Convert.ToInt32(row[field_ageUntil]),
                    Convert.ToInt32(row[field_disciplineId])
                ));
            }

            return disciplineSetDisciplineMappings;
        }

        public static DisciplineSetDisciplineMapping getDisciplineSetDisciplineMappingByPrimaryKey(
            int disciplineSetId,
            int ageFrom,
            int ageUntil,
            int disciplineId
        ) {
            Dictionary<string, object> result = querySingleSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineSetId + "` = " + disciplineSetId + " "
                    + "AND `" + field_ageFrom + "` = " + ageFrom + " "
                    + "AND `" + field_ageUntil + "` = " + ageUntil + " "
                    + "AND `" + field_disciplineId + "` = " + disciplineId
            );

            if (result == null)
            {
                return null;
            }

            DisciplineSetDisciplineMapping disciplineSetDisciplineMapping = new DisciplineSetDisciplineMapping(
                Convert.ToInt32(result[field_disciplineSetId]),
                Convert.ToInt32(result[field_ageFrom]),
                Convert.ToInt32(result[field_ageUntil]),
                Convert.ToInt32(result[field_disciplineId])
            );

            return disciplineSetDisciplineMapping;
        }

        public static List<DisciplineSetDisciplineMapping> getDisciplineSetDisciplineMappingsByDisciplineSet(DisciplineSet disciplineSet)
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineSetId + "` = " + disciplineSet.DisciplineSetId
            );

            List<DisciplineSetDisciplineMapping> disciplineSetDisciplineMappings = new List<DisciplineSetDisciplineMapping>();

            foreach (var row in results)
            {
                disciplineSetDisciplineMappings.Add(getDisciplineSetDisciplineMappingByPrimaryKey(
                    Convert.ToInt32(row[field_disciplineSetId]),
                    Convert.ToInt32(row[field_ageFrom]),
                    Convert.ToInt32(row[field_ageUntil]),
                    Convert.ToInt32(row[field_disciplineId])
                ));
            }

            return disciplineSetDisciplineMappings;
        }

        public static List<Discipline> getDisciplinesByDisciplineSet(DisciplineSet disciplineSet)
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineSetId + "` = " + disciplineSet.DisciplineSetId
            );

            List<Discipline> disciplines = new List<Discipline>();

            foreach (var row in results)
            {
                disciplines.Add(DisciplineProvider.getDisciplineById(Convert.ToInt32(row[field_disciplineId])));
            }

            return disciplines;
        }

        public static List<DisciplineSet> getDisciplineSetsByDiscipline(Discipline discipline)
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineId + "` = " + discipline.DisciplineId
            );

            List<DisciplineSet> disciplineSets = new List<DisciplineSet>();

            foreach (var row in results)
            {
                disciplineSets.Add(DisciplineSetProvider.getDisciplineSetById(Convert.ToInt32(row[field_disciplineSetId])));
            }

            return disciplineSets;
        }

        public static List<DisciplineSetDisciplineMapping> getDisciplineSetDisciplineMappingsByDisciplineSetAndDiscipline(DisciplineSet disciplineSet, Discipline discipline)
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineSetId + "` = " + disciplineSet.DisciplineSetId + " "
                    + "AND `" + field_disciplineId + "` = " + discipline.DisciplineId
            );

            List<DisciplineSetDisciplineMapping> disciplineSetDisciplineMappings = new List<DisciplineSetDisciplineMapping>();

            foreach (var row in results)
            {
                disciplineSetDisciplineMappings.Add(getDisciplineSetDisciplineMappingByPrimaryKey(
                    Convert.ToInt32(row[field_disciplineSetId]),
                    Convert.ToInt32(row[field_ageFrom]),
                    Convert.ToInt32(row[field_ageUntil]),
                    Convert.ToInt32(row[field_disciplineId])
                ));
            }

            return disciplineSetDisciplineMappings;
        }

        public static List<DisciplineSetDisciplineMapping> getDisciplineSetDisciplineMappingsByDiscipline(Discipline discipline)
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineId + "` = " + discipline.DisciplineId
            );

            List<DisciplineSetDisciplineMapping> disciplineSetDisciplineMappings = new List<DisciplineSetDisciplineMapping>();

            foreach (var row in results)
            {
                disciplineSetDisciplineMappings.Add(getDisciplineSetDisciplineMappingByPrimaryKey(
                    Convert.ToInt32(row[field_disciplineSetId]),
                    Convert.ToInt32(row[field_ageFrom]),
                    Convert.ToInt32(row[field_ageUntil]),
                    Convert.ToInt32(row[field_disciplineId])
                ));
            }

            return disciplineSetDisciplineMappings;
        }

        public static bool relationExists(DisciplineSet disciplineSet, Discipline discipline)
        {
            Dictionary<string, object> result = querySingleSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineSetId + "` = " + disciplineSet.DisciplineSetId + " "
                    + "AND `" + field_disciplineId + "` = " + discipline.DisciplineId
            );

            if (result.Count == 1)
            {
                return true;
            }

            return false;
        }

        public static void createDisciplineSetDisciplineMapping(
            int disciplineSetId,
            int ageFrom,
            int ageUntil,
            int disciplineId
        ) {
            executeSql(""
                + "INSERT INTO "
                    + "`" + tableName + "` "
                + "("
                    + "`" + field_disciplineSetId + "`, "
                    + "`" + field_ageFrom + "`, "
                    + "`" + field_ageUntil + "`, "
                    + "`" + field_disciplineId + "`"
                + ") VALUES ("
                    + disciplineSetId + ", "
                    + ageFrom + ", "
                    + ageUntil + ", "
                    + disciplineId
                + ")"
            );
        }

        public static void updateDisciplineSetDisciplineMapping(DisciplineSetDisciplineMapping disciplineSetDisciplineMapping)
        {
            executeSql(""
                + "UPDATE "
                    + "`" + tableName + "` "
                + "SET "
                    + "`" + field_ageFrom + "` = " + disciplineSetDisciplineMapping.AgeFrom + ", "
                    + "`" + field_ageUntil + "` = " + disciplineSetDisciplineMapping.AgeUntil + " "
                + "WHERE "
                    + "`" + field_disciplineSetId + " = " + disciplineSetDisciplineMapping.DisciplineSetId + " "
                    + "AND `" + field_ageFrom + "` = " + disciplineSetDisciplineMapping.AgeFrom + " "
                    + "AND `" + field_ageUntil + "` = " + disciplineSetDisciplineMapping.AgeUntil + " "
                    + "AND `" + field_disciplineId + "` = " + disciplineSetDisciplineMapping.DisciplineId
            );
        }

        public static void deleteDisciplineSetDisciplineMapping(DisciplineSetDisciplineMapping disciplineSetDisciplineMapping)
        {
            executeSql(""
                + "DELETE FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_disciplineSetId + " = " + disciplineSetDisciplineMapping.DisciplineSetId + " "
                    + "AND `" + field_ageFrom + "` = " + disciplineSetDisciplineMapping.AgeFrom + " "
                    + "AND `" + field_ageUntil + "` = " + disciplineSetDisciplineMapping.AgeUntil + " "
                    + "AND `" + field_disciplineId + "` = " + disciplineSetDisciplineMapping.DisciplineId + " "
                + "LIMIT 1"
            );
        }
    }
}
