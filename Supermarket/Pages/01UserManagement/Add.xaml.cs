using LiveCharts;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Supermarket.Pages.UserManagement
{
    /// <summary>
    /// Add.xaml 的交互逻辑
    /// </summary>
    public partial class Add : DMSkin.WPF.Small.DMSkinWindow
    {
        public string pictureName = "";

        public Add()
        {
            InitializeComponent();
        }

        public class CategoryInfo
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            List<CategoryInfo> categoryList = new List<CategoryInfo>();
            categoryList.Add(new CategoryInfo { Name = "用户", Value = "用户" });
            categoryList.Add(new CategoryInfo { Name = "管理员", Value = "管理员" });
            cb_purview.ItemsSource = categoryList;
            cb_purview.DisplayMemberPath = "Name";
            cb_purview.SelectedValuePath = "Value";
        }

        private void btn_Certain_Click(object sender, RoutedEventArgs e)
        {
            string userID = tb_UserID.Text.Trim();
            if (userID == "")
            {
                MessageBox.Show("请输入账号！");
                return;
            }

            string userName = tb_UserName.Text.Trim();
            if (userName == "")
            {
                MessageBox.Show("请输入姓名！");
                return;
            }

            string userPassword = pw_UserPassword.Password.Trim();
            if (userPassword == "")
            {
                MessageBox.Show("请输入密码！");
                return;
            }

            string userLevel = cb_purview.Text.Trim();
            if (userLevel == "")
            {
                MessageBox.Show("请输入权限！");
                return;
            }
            string sql = string.Format("insert into User_Table values('{0}','{1}','{2}','{3}')", userID, userName, userPassword, userLevel);
            int result3 = Database.ExecuteNonQuery(sql);
            if (result3 > 0)
            {
                MessageBox.Show("添加成功！");
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
