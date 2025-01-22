using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public static class SqlServerTool
    {

        public static DataView GetDataView(string querySQL)
        {
            DataSet ds = Database.ExecuteQuery(querySQL, "temp");
            return ds.Tables["temp"].DefaultView;
        }
        public static string TextFormat(string sqlText)
        {
            return sqlText.Trim().Replace("'", ""); //从筛选框获取用户ID，去掉空格，去掉特殊符号。
        }

    }
}
