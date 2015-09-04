using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Sportfest_Verwaltung
{
    class SQL
    {
        static public SqlConnection GetConnection()
        {
            string ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=sportsfestival;Data Source=FUP021";
            SqlConnection Conn = new SqlConnection(ConnectionString);
            return Conn;
        }

        static public SqlDataReader GetReader(string iCommandText, SqlConnection iConnection)
        {
            if (iConnection.State == ConnectionState.Closed)
            {
                iConnection.Open();
            }

            SqlCommand cmd = new SqlCommand(iCommandText, iConnection);
            SqlDataReader rdr = cmd.ExecuteReader();
            return rdr;
        }
    }
}
