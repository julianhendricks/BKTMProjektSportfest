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

        public List<Variant> getAllVariants()
        {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<Variant> variants = new List<Variant>();

            while(reader.Read())
            {
                variants.Add(this.getVariantById(reader.GetInt32(field_variantId)));
            }

            return variants;
        }

        public Variant getVariantById(int variantId) {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_variantId + "` = " + variantId
            );

            DisciplineProvider disciplineProvider = new DisciplineProvider();
            Discipline discipline = disciplineProvider.getDisciplineById(reader.GetInt32(field_disciplineId));

            Variant variant = new Variant(
                reader.GetInt32(field_variantId),
                reader.GetString(field_variantName),
                reader.GetInt32(field_ageFrom),
                reader.GetInt32(field_ageUntil),
                discipline
            );

            return variant;
        }

        public int createVariant(
            string variantName,
            int ageFrom,
            int ageUntil,
            Discipline discipline
        ) {
            MySqlDataReader reader = this.executeSql(""
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

            reader = this.executeSql("SELECT LAST_INSERT_ID() AS insertionId");

            return reader.GetInt32("insertionId");
        }

        public void updateVariant(Variant variant)
        {
            MySqlDataReader reader = this.executeSql(""
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

        public void deleteVariant(Variant variant)
        {
            MySqlDataReader reader = this.executeSql(""
                + "DELETE FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_variantId + " = " + variant.VariantId + " "
                + "LIMIT 1"
            );
        }
    }
}
