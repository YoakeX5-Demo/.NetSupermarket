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
using static Supermarket.SqlServerTool;

namespace Supermarket.Pages.SortManagement
{
    /// <summary>
    /// Add.xaml 的交互逻辑
    /// </summary>
    public partial class Edit : DMSkin.WPF.Small.DMSkinWindow
    {
        private string categoryID, categoryName, statement;
        public Edit(string userID, string userName, string level)
        {
            InitializeComponent();
            this.categoryID = userID;
            this.categoryName = userName;
            this.statement = level;
        }

        public string CategoryID = "";
        public string CategoryName = "";
        private void txt_CategoryID_TextChanged(object sender, TextChangedEventArgs e)
        {
            CategoryID = txt_CategoryID.Text.Trim();
            if (CategoryID == "")
            {
                return;
            }
            string sql = string.Format("select * from Category_Table where CategoryID='{0}' ", CategoryID);
            DataSet ds = Database.ExecuteQuery(sql, "Category");

            if (ds.Tables["Category"].Rows.Count == 0)
            {
                return;
            }
            txt_CategoryName.Text = ds.Tables["Category"].Rows[0]["CategoryName"].ToString();
            txt_CategoryID.Text = ds.Tables["Category"].Rows[0]["CategoryID"].ToString();
            txt_CategorySt.Text = ds.Tables["Category"].Rows[0]["statement"].ToString();
        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_Certain_Click(object sender, RoutedEventArgs e)
        {
            string CategoryName = txt_CategoryName.Text.Trim();
            if (CategoryName == "")
            {
                MessageBox.Show("请输入分类名称！");
                return;
            }

            string CategorySt = txt_CategorySt.Text.Trim();
            if (CategorySt == "")
            {
                MessageBox.Show("请输入分类说明！");
                return;
            }

            string sql = string.Format("update Category_Table set CategoryName='{0}',statement='{1}' where categoryID='{2}' ", CategoryName, CategorySt,CategoryID);
            int result = Database.ExecuteNonQuery(sql);
            if (result > 0)
            {
                MessageBox.Show("修改分类成功！");
            }
            else
            {
                MessageBox.Show("修改分类失败！");
            }

        }
    }
}
