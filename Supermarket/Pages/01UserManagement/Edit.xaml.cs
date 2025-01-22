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
    public partial class Edit : DMSkin.WPF.Small.DMSkinWindow
    {
        private string userID, userName, level;
        public Edit(string userID, string userName, string level)
        {
            InitializeComponent();
            this.userID = userID;
            this.userName = userName;
            this.level = level;
            tb_UserID.Text = userID;
            tb_UserName.Text = userName;
            cb_purview.SelectedValue = level;
        }

        private void tb_UserID_TextChanged(object sender, TextChangedEventArgs e)
        {
            userID = tb_UserID.Text.Trim();
            if (userID == "")
            {
                return;
            }
            string sql = string.Format(" select * from User_Table where userID='{0}' ", userID);
            DataSet ds = Database.ExecuteQuery(sql, "User");

            if (ds.Tables["User"].Rows.Count == 0)
            {
                return;
            }

            tb_UserName.Text = ds.Tables["User"].Rows[0]["userName"].ToString();
            cb_purview.SelectedValue = ds.Tables["User"].Rows[0]["userLevel"].ToString();
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
            string userPassword = pw_UserPassword.Password.Trim();
            if (userPassword == "")
            {
                MessageBox.Show("请输入新密码！");
                return;
            }
            string sql2 = string.Format("update User_Table set userPassword = '{0}' WHERE userID = '{1}'", userPassword, userID);
            int result2 = Database.ExecuteNonQuery(sql2);
            if (result2 > 0)
            {
                MessageBox.Show("修改密码成功！");
            }
            else
            {
                MessageBox.Show("修改密码失败！");
            }
        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
