using SportsfestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsfestivalManagement.Provider
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
            MySqlDataReader reader = executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<Variant> variants = new List<Variant>();

            while(reader.Read())
            {
                variants.Add(getVariantById(reader.GetInt32(field_variantId)));
            }

            return variants;
        }

        public static Variant getVariantById(int variantId) {
            MySqlDataReader reader = executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_variantId + "` = " + variantId
            );

            Discipline discipline = DisciplineProvider.getDisciplineById(reader.GetInt32(field_disciplineId));

            Variant variant = new Variant(
                reader.GetInt32(field_variantId),
                reader.GetString(field_variantName),
                reader.GetInt32(field_ageFrom),
                reader.GetInt32(field_ageUntil),
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
            MySqlDataReader reader = executeSql(""
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

            reader = executeSql("SELECT LAST_INSERT_ID() AS insertionId");

            return reader.GetInt32("insertionId");
        }

        public static void updateVariant(Variant variant)
        {
            MySqlDataReader reader = executeSql(""
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
            MySqlDataReader reader = executeSql(""
                + "DELETE FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_variantId + " = " + variant.VariantId + " "
                + "LIMIT 1"
            );
        }
    }
}
