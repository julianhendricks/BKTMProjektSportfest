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
            mySql.connect();

            var reader = mySql.query(sql);

            mySql.close();

            return reader;
        }

        protected static Dictionary<string, object> querySingleSql(string sql)
        {
            MySQL mySql = MySQLProvider.getMySQLInstance();
            mySql.connect();

            var results = mySql.querySingle(sql);

            mySql.close();

            return results;
        }

        protected static void executeSql(string sql)
        {
            MySQL mySql = MySQLProvider.getMySQLInstance();
            mySql.connect();

            mySql.execute(sql);

            mySql.close();
        }
    }
}
