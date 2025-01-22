using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class Database
    {
        private static String connectionstr = "server=127.0.0.1;uid=sa;pwd=123456;database=IntelligentSupermarket";
        public static SqlConnection connection = new SqlConnection(connectionstr);
        public static SqlCommand command = new SqlCommand();
        public static DataSet ds = new DataSet();
        public static SqlDataAdapter sda = new SqlDataAdapter();


        static Database()
        {
            command.Connection = connection;
            connection.Open();
        }

        //insert update  delete  非查询
        public static int ExecuteNonQuery(String querySQL)
        {

            command.CommandText = querySQL;
            return command.ExecuteNonQuery();
        }

        //select 单个数据
        public static Object ExecuteScalar(String querySQL)
        {
            command.CommandText = querySQL;
            return command.ExecuteScalar();
        }

        //select 多个数据，整条记录
        public static DataSet ExecuteQuery(String querySQL, String name)
        {
            command.CommandText = querySQL;
            sda.SelectCommand = command;
            if (ds.Tables.Contains(name))
                ds.Tables.Remove(name);
            sda.Fill(ds, name);
            return ds;

        }

        public static void Close()
        {
            connection.Close();
        }
    }
}
