using System;
using SportsFestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsFestivalManagement.Provider
{
    class VariantProvider : AbstractEntityProvider
    {
        public const string tableName = "variant";
        public const string field_variantId = "variantId";
        public const string field_variantName = "variantName";
        public const string field_ageFrom = "ageFrom";
        public const string field_ageUntil = "ageUntil";
        public const string field_disciplineId = "disciplineId";

        public static List<Variant> getAllVariants()
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<Variant> variants = new List<Variant>();

            foreach (var row in results)
            {
                variants.Add(getVariantById(Convert.ToInt32(row[field_variantId])));
            }

            return variants;
        }

        public static Variant getVariantById(int variantId) {
            Dictionary<string, object> result = querySingleSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_variantId + "` = " + variantId
            );

            if (result == null)
            {
                return null;
            }

            Discipline discipline = DisciplineProvider.getDisciplineById(Convert.ToInt32(result[field_disciplineId]));

            Variant variant = new Variant(
                Convert.ToInt32(result[field_variantId]),
                Convert.ToString(result[field_variantName]),
                Convert.ToInt32(result[field_ageFrom]),
                Convert.ToInt32(result[field_ageUntil]),
                discipline
            );

            return variant;
        }

        public static int createVariant(
            string variantName,
            int ageFrom,
            int ageUntil,
            Discipline discipline
        ) {
            executeSql(""
                + "INSERT INTO "
                    + "`" + tableName + "` "
                + "("
                    + "`" + field_variantName + "`"
                + ") VALUES ("
                    + "'" + variantName + "', "
                    + ageFrom + ", "
                    + ageUntil + ", "
                    + discipline.DisciplineId
                + ")"
            );

            Dictionary<string, object> result = querySingleSql("SELECT LAST_INSERT_ID() AS `insertionId`");

            return Convert.ToInt32(result["insertionId"]);
        }

        public static void updateVariant(Variant variant)
        {
            executeSql(""
                + "UPDATE "
                    + "`" + tableName + "` "
                + "SET "
                    + "`" + field_variantName + "` = '" + variant.VariantName + "', "
                    + "`" + field_ageFrom + "` = " + variant.AgeFrom + ", "
                    + "`" + field_ageUntil + "` = " + variant.AgeUntil + ", "
                    + "`" + field_disciplineId + "` = " + variant.Discipline.DisciplineId + " "
                + "WHERE "
                    + "`" + field_variantId + " = " + variant.VariantId
            );
        }

        public static void deleteVariant(Variant variant)
        {
            executeSql(""
                + "DELETE FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_variantId + " = " + variant.VariantId + " "
                + "LIMIT 1"
            );
        }
    }
}
