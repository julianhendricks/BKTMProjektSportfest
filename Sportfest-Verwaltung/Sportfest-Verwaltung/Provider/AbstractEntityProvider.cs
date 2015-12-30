using MySql.Data.MySqlClient;
using SportsFestivalManagement.Entities;
using System.Collections.Generic;

namespace SportsFestivalManagement.Provider
{
    abstract class AbstractEntityProvider
    {
        protected static List<Dictionary<string, object>> querySql(string sql)
        {
            MySQL mySql = MySQLProvider.getMySQLInstance();

            var reader = mySql.query(sql);

            return reader;
        }

        protected static Dictionary<string, object> querySingleSql(string sql)
        {
            MySQL mySql = MySQLProvider.getMySQLInstance();

            var results = mySql.querySingle(sql);

            return results;
        }

        protected static void executeSql(string sql)
        {
            MySQL mySql = MySQLProvider.getMySQLInstance();

            mySql.execute(sql);
        }
    }
}
