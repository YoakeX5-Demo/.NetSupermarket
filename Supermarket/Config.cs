using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    static class Config
    {
        public static string MysqlServer = "127.0.0.1";
        public static string MysqlPort = "3306";
        public static string MysqlDatabase = "supermarket";
        public static string MysqlUid = "test";
        public static string MysqlPassword = "123456";
    }
}
