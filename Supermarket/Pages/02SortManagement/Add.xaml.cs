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

namespace Supermarket.Pages.SortManagement
{
    /// <summary>
    /// Add.xaml 的交互逻辑
    /// </summary>
    public partial class Add : DMSkin.WPF.Small.DMSkinWindow
    {

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
        }

        private void btn_Certain_Click(object sender, RoutedEventArgs e)
        {
            string CategoryName = tb_CategoryName.Text.Trim();
            if (CategoryName == "")
            {
                MessageBox.Show("请输入分类名称！");
                return;
            }

            string CategoryStatement = tb_CategoryStatement.Text.Trim();
            if (CategoryStatement == "")
            {
                MessageBox.Show("请输入分类说明！");
                return;
            }
            string sql = string.Format("insert into Category_Table values('{0}','{1}')", CategoryName, CategoryStatement);
            int result = Database.ExecuteNonQuery(sql);
            if (result > 0)
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
