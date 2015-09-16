﻿using SportsfestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SportsfestivalManagement.Provider
{
    class CategoryProvider : AbstractEntityProvider
    {
        public const string tableName = "category";
        public const string field_categoryId = "categoryId";
        public const string field_categoryName = "categoryName";

        public List<Category> getAllCategories()
        {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT "
                    + "`" + field_categoryId + "` "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<Category> categories = new List<Category>();

            while(reader.Read())
            {
                categories.Add(this.getCategoryById(reader.GetInt32(field_categoryId)));
            }

            return categories;
        }

        public Category getCategoryById(int categoryId) {
            MySqlDataReader reader = this.executeSql(""
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

        public int createCategory(string categoryName)
        {
            MySqlDataReader reader = this.executeSql(""
                + "INSERT INTO "
                    + "`" + tableName + "` "
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
                + "UPDATE "
                    + "`" + tableName + "` "
                + "SET "
                    + "`" + field_categoryName + "` = " + category.CategoryName + " "
                + "WHERE "
                    + "`" + field_categoryId + " = " + category.CategoryId
            );
        }

        public void deleteCategory(Category category)
        {
            MySqlDataReader reader = this.executeSql(""
                + "DELETE FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_categoryId + " = " + category.CategoryId + " "
                + "LIMIT 1"
            );
        }
    }
}
