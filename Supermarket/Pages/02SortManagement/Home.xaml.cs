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
    /// AddCommodity.xaml 的交互逻辑
    /// </summary>
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        string sqlGrid = "SELECT categoryID as 分类编号,categoryName as 分类名,statement as 说明 FROM Category_Table";
        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            dg_data.ItemsSource = GetDataView(sqlGrid);;
        }

        void reload()
        {
            string categoryID = TextFormat(tb_FilterID.Text);
            string querySQL = sqlGrid + string.Format(" where categoryID like '%{0}%'", categoryID);
            dg_data.ItemsSource = GetDataView(querySQL);
        }

        private void tb_Filter_TextChanged(object sender, TextChangedEventArgs e)
        {
            string categoryID = TextFormat(tb_FilterID.Text);
            string querySQL = sqlGrid + string.Format(" where categoryID like '%{0}%'", categoryID);
            dg_data.ItemsSource = GetDataView(querySQL);
        }

        private void btn_ShowAddPage_Click(object sender, RoutedEventArgs e)
        {
            Add add = new Add();
            add.Show();
            add.Closed += AddPage_Closed;
        }


        private void btn_ShowEditPage_Click(object sender, RoutedEventArgs e)
        {
            if (dg_data.SelectedItem == null)
            {
                MessageBox.Show("请选择分类！");
                return;
            }
            else
            {
                DataRowView mySelectedElement = (DataRowView)dg_data.SelectedItem;
                string categoryID = mySelectedElement.Row[0].ToString();
                string categoryName = mySelectedElement.Row[1].ToString();
                string statement = mySelectedElement.Row[2].ToString();
                Edit edit = new Edit(categoryID, categoryName, statement);
                edit.Show();
                edit.Closed += EditPage_Closed;
            }
        }

        private void btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            if (dg_data.SelectedItem == null)
            {
                MessageBox.Show("请选择用户！");
                return;
            }
            else
            {
                DataRowView mySelectedElement = (DataRowView)dg_data.SelectedItem;
                string categoryID = mySelectedElement.Row[0].ToString();
                string sql = string.Format("delete from Category_Table where categoryID='{0}'", categoryID);
                int result = Database.ExecuteNonQuery(sql);
                if (result > 0)
                {
                    MessageBox.Show("删除成功！");
                    dg_data.ItemsSource = GetDataView(sqlGrid);
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
        }

        private void AddPage_Closed(object sender, EventArgs e)
        {
            reload();
        }
        private void EditPage_Closed(object sender, EventArgs e)
        {
            reload();
        }
    }
}
