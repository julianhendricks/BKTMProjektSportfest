using SportsfestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsfestivalManagement.Provider
{
    class CategoryProvider : AbstractEntityProvider
    {
        public const string tableName = "category";
        public const string field_categoryId = "categoryId";
        public const string field_categoryName = "categoryName";

        public static List<Category> getAllCategories()
        {
            MySqlDataReader reader = executeSql(""
                + "SELECT "
                    + "`" + field_categoryId + "` "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<Category> categories = new List<Category>();

            while(reader.Read())
            {
                categories.Add(getCategoryById(reader.GetInt32(field_categoryId)));
            }

            return categories;
        }

        public static Category getCategoryById(int categoryId) {
            MySqlDataReader reader = executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_categoryId + "` = " + categoryId
            );

            Category category = new Category(
                reader.GetInt32(field_categoryId),
                reader.GetString(field_categoryName)
            );

            return category;
        }

        public static int createCategory(string categoryName)
        {
            MySqlDataReader reader = executeSql(""
                + "INSERT INTO "
                    + "`" + tableName + "` "
                + "("
                    + "`" + field_categoryName + "`"
                + ") VALUES ("
                    + "'" + categoryName + "'"
                + ")"
            );

            reader = executeSql("SELECT LAST_INSERT_ID() AS insertionId");

            return reader.GetInt32("insertionId");
        }

        public static void updateCategory(Category category)
        {
            MySqlDataReader reader = executeSql(""
                + "UPDATE "
                    + "`" + tableName + "` "
                + "SET "
                    + "`" + field_categoryName + "` = " + category.CategoryName + " "
                + "WHERE "
                    + "`" + field_categoryId + " = " + category.CategoryId
            );
        }

        public static void deleteCategory(Category category)
        {
            MySqlDataReader reader = executeSql(""
                + "DELETE FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_categoryId + " = " + category.CategoryId + " "
                + "LIMIT 1"
            );
        }
    }
}
