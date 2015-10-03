using MySql.Data.MySqlClient;
using SportsfestivalManagement.Entities;

namespace SportsfestivalManagement.Provider
{
    abstract class AbstractEntityProvider
    {
        protected static MySqlDataReader executeSql(string sql)
        {
            MySQL mySql = MySQLProvider.getMySQLInstance();
            mySql.connect();

            MySqlDataReader reader = mySql.query(sql);

            mySql.close();

            return reader;
        }
    }
}
