using System;
using SportsFestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsFestivalManagement.Provider
{
    class CategoryProvider : AbstractEntityProvider
    {
        public const string tableName = "category";
        public const string field_categoryId = "categoryId";
        public const string field_categoryName = "categoryName";

        public static List<Category> getAllCategories()
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "`" + field_categoryId + "` "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<Category> categories = new List<Category>();

            foreach (var row in results)
            {
                categories.Add(getCategoryById(Convert.ToInt32(row[field_categoryId])));
            }

            return categories;
        }

        public static Category getCategoryById(int categoryId) {
            Dictionary<string, object> result = querySingleSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_categoryId + "` = " + categoryId
            );

            if (result == null)
            {
                return null;
            }

            Category category = new Category(
                Convert.ToInt32(result[field_categoryId]),
                Convert.ToString(result[field_categoryName])
            );

            return category;
        }

        public static int createCategory(string categoryName)
        {
            executeSql(""
                + "INSERT INTO "
                    + "`" + tableName + "` "
                + "("
                    + "`" + field_categoryName + "`"
                + ") VALUES ("
                    + "'" + categoryName + "'"
                + ")"
            );

            Dictionary<string, object> result = querySingleSql("SELECT MAX(`" + field_categoryId + "`) AS `insertionId` FROM `" + tableName + "`");

            int insertionId = Convert.ToInt32(result["insertionId"]);

            return insertionId;
        }

        public static void updateCategory(Category category)
        {
            executeSql(""
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
            executeSql(""
                + "DELETE FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_categoryId + " = " + category.CategoryId + " "
                + "LIMIT 1"
            );
        }
    }
}
