using SportsfestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace SportsfestivalManagement.Provider
{
    class CategoryProvider : AbstractEntityProvider
    {
        const string tableName = "category";
        const string field_categoryId = "categoryId";
        const string field_categoryName = "categoryName";

        public List<Category> getAllCategories()
        {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT * "
                + "FROM `" + tableName + "`"
            );

            List<Category> categories = new List<Category>();

            while(reader.Read())
            {
                Category category = new Category(
                    reader.GetInt32(field_categoryId),
                    reader.GetString(field_categoryName)
                );

                categories.Add(category);
            }

            return categories;
        }

        public Category getCategoryById(int categoryId) {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT * "
                + "FROM `" + tableName + "` "
                + "WHERE "
                    + "`" + field_categoryId + "` = " + categoryId
            );

            Category category = new Category(
                reader.GetInt32(field_categoryId),
                reader.GetString(field_categoryName)
            );

            return category;
        }

        public int createCategory(string categoryName)
        {
            MySqlDataReader reader = this.executeSql(""
                + "INSERT INTO `" + tableName + "` "
                + "("
                    + "`" + field_categoryName + "`"
                + ") VALUES ("
                    + "'" + categoryName + "'"
                + ")"
            );

            reader = this.executeSql("SELECT LAST_INSERT_ID() AS insertionId");

            return reader.GetInt32("insertionId");
        }

        public void updateCategory(Category category)
        {
            MySqlDataReader reader = this.executeSql(""
                + "UPDATE `" + tableName + "` "
                + "SET "
                    + "`" + field_categoryName + "` = " + category.CategoryName + " "
                + "WHERE "
                    + "`" + field_categoryId + " = " + category.CategoryId
            );
        }

        public void deleteCategory(Category category)
        {
            MySqlDataReader reader = this.executeSql(""
                + "DELETE FROM `" + tableName + "` "
                + "WHERE "
                    + "`" + field_categoryId + " = " + category.CategoryId + " "
                + "LIMIT 1"
            );
        }
    }
}
