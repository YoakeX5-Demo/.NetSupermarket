using MaterialDesignThemes.Wpf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static Supermarket.MysqlTool;

namespace Supermarket
{
    /// <summary>
    /// UserLogin.xaml 的交互逻辑
    /// </summary>
    public partial class UserLogin : DMSkin.WPF.Small.DMSkinWindow
    {
        private static string MysqlServer;
        private static string MysqlPort;
        private static string MysqlDatabase;
        private static string MysqlUid;
        private static string MysqlPassword;

        private static string UserAccount;
        private static string UserPassword;

        public UserLogin()
        {
            InitializeComponent();
            MysqlServer = Config.MysqlServer;
            MysqlPort = Config.MysqlPort;
            MysqlDatabase = Config.MysqlDatabase;
            MysqlUid = Config.MysqlUid;
            MysqlPassword = Config.MysqlPassword;
        }

        #region 用户操作
        //用户注册
        private static string SignUp(string account, string password, string username)
        {
            MysqlTool get = new MysqlTool();
            get.Initialize(MysqlServer, MysqlPort, MysqlDatabase, MysqlUid, MysqlPassword);
            try { get.OpenConnection(); }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "无法连接到服务器";
            }
            String Com = "SELECT Account FROM users WHERE Account=\"" + account + "\";";
            MySqlDataReader read = Reader(Com);

            if (read.HasRows == false)
            {
                read.Close();
                Com = "INSERT INTO users (Account,Password,Purview) VALUES (\"" + account + "\",\"" + password + "\",\"我的好友;家人;同学;同事;\",\"我的群;常用群聊;\",\"" + username + "\");";
                try
                {
                    get.getInsert(Com);
                    get.CloseConnection();
                    return "注册成功";
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return "无法注册";
                }
            }
            else
            {
                read.Close();
                return "用户名已存在";
            }
        }

        //用户登录
        private static string LoginCheck(string Account, string Password)
        {
            MysqlTool get = new MysqlTool();
            string name;
            get.Initialize(MysqlServer, MysqlPort, MysqlDatabase, MysqlUid, MysqlPassword);
            try { get.OpenConnection(); }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return "false";
            }
            string Com = "SELECT Password,Account FROM users WHERE Account=\"" + Account + "\";";
            try
            {
                MySqlDataReader read = Reader(Com);
                if (read.HasRows == false)
                {
                    read.Close();
                    return "账号不存在";
                }
                else
                {
                    read.Read();
                    if (read[0].ToString() == Password)
                    {
                        name = read[1].ToString();
                        read.Close();
                        return "true";
                    }
                    else
                    {
                        read.Close();
                        return "密码错误";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("查询数据失败了！" + ex.Message);
                return "false";
            }
        }
        #endregion

        //数据库类
        private static MySqlDataReader Reader(String com)
        {
            MysqlTool get = new MysqlTool();
            MySqlDataReader read = null;
            get.Initialize(MysqlServer, MysqlPort, MysqlDatabase, MysqlUid, MysqlPassword);
            if (get.OpenConnection())
            {
                Console.WriteLine("链接数据库成功");
            }
            else
            {
                Console.WriteLine("链接数据库失败");
            }
            try
            {
                read = get.GetReader(com);
            }
            catch (Exception ex)
            {
                Console.WriteLine("查找数据失败了！" + ex.Message);
            }
            return read;
        }
        private static void up(string com)
        {
            MysqlTool isrt = new MysqlTool();
            isrt.Initialize(MysqlServer, MysqlPort, MysqlDatabase, MysqlUid, MysqlPassword);
            if (isrt.OpenConnection())
            {
                Console.WriteLine("链接数据库成功");
            }
            else
            {
                Console.WriteLine("链接数据库失败");
            }
            try
            {
                isrt.getInsert(com);
            }
            catch (Exception ex)
            {
                Console.WriteLine("插入数据失败了！" + ex.Message);
            }
            isrt.CloseConnection();
        }
        private static void rm(string com)
        {
            MysqlTool rmv = new MysqlTool();
            rmv.Initialize(MysqlServer, MysqlPort, MysqlDatabase, MysqlUid, MysqlPassword);
            if (rmv.OpenConnection())
            {
                Console.WriteLine("链接数据库成功");
            }
            else
            {
                Console.WriteLine("链接数据库失败");
            }
            try
            {
                rmv.getDel(com);
            }
            catch (Exception ex)
            {
                Console.WriteLine("删除数据失败了！" + ex.Message);
            }
            rmv.CloseConnection();
        }
        private static void st(string com)
        {
            MysqlTool st = new MysqlTool();
            st.Initialize(MysqlServer, MysqlPort, MysqlDatabase, MysqlUid, MysqlPassword);
            if (st.OpenConnection())
            {
                Console.WriteLine("链接数据库成功");
            }
            else
            {
                Console.WriteLine("链接数据库失败");
            }
            try
            {
                st.getUpdate(com);
            }
            catch (Exception ex)
            {
                Console.WriteLine("修改数据失败了！" + ex.Message);
            }
            st.CloseConnection();
        }

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            MysqlServer = tb_MysqlServer.Text;
            UserAccount = tb_Account.Text;
            UserPassword = pb_Password.Password;

            bar_LoggingIn.Visibility = Visibility.Visible;
            Task<string> task = Task<string>.Run(() =>
            {
                string temp = LoginCheck(UserAccount, UserPassword);
                if (temp == "true")
                {
                    return "登录成功";
                }
                else
                {
                    return "登录失败:" + temp;
                }
            });
            //会等到任务执行完之后执行
            task.GetAwaiter().OnCompleted(() =>
            {
                bar_LoggingIn.Visibility = Visibility.Hidden;
                if (task.Result != "登录成功")
                {
                }
                else
                {
                    MainWindow main = new MainWindow();
                    main.Show();
                    this.Close();
                }
            });

        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
