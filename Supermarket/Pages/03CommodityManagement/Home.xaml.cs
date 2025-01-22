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

namespace Supermarket.Pages.CommodityManagement
{
    /// <summary>
    /// AddCommodity.xaml 的交互逻辑
    /// </summary>
    public partial class Home : UserControl
    {
        public string pictureName = "";

        public Home()
        {
            InitializeComponent();
        }

        private void btn_ShowAddPage_Click(object sender, RoutedEventArgs e)
        {
            Add add = new Add();
            add.Show();
        }

        private void btn_ShowEditPage_Click(object sender, RoutedEventArgs e)
        {
            Edit edit = new Edit();
            edit.Show();
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
                string commodityID = mySelectedElement.Row[0].ToString();
                string sql = string.Format("delete from Commodity_Table where commodityID='{0}'", commodityID);
                int result = Database.ExecuteNonQuery(sql);
                if (result > 0)
                {
                    MessageBox.Show("删除商品成功！");
                    //刷新查询的数据
                    reload();
                }
                else
                {
                    MessageBox.Show("删除商品失败！");
                }
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            string sql = "select categoryID,categoryName from Category_Table";
            cb_purview.ItemsSource = GetDataView(sql);;
            cb_purview.DisplayMemberPath = "categoryName";//显示的列
            cb_purview.SelectedValuePath = "categoryID";//选中值的列
            reload();
        }

        void reload()
        {
            string commodityID = TextFormat(tb_FilterID.Text);
            string commodityName = TextFormat(tb_FilterName.Text);
            string querySQL = "SELECT commodityID as 商品编号,commodityName as 商品名称,commodityPrice as 商品价格 ,amount as 商品库存 ,manufacturer as 生产厂商 ,discount as 商品折扣 ,com.statement as 商品说明 ,categoryName as 商品分类  FROM Commodity_Table com,Category_Table cat where com.categoryID=cat.categoryID";
            if (commodityID != "")
                querySQL += string.Format(" and com.commodityID='{0}' ", commodityID);
            if (commodityName != "")
                querySQL += string.Format(" and com.commodityName like  '%{0}%' ", commodityName);
            if (cb_purview.SelectedValue != null)
            {
                int categoryID = Int32.Parse(cb_purview.SelectedValue.ToString());
                querySQL += string.Format(" and com.categoryID={0} ", categoryID);
            }
            dg_data.ItemsSource = GetDataView(querySQL);
        }

        private void cb_purview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            reload();
        }

        private void tb_FilterID_TextChanged(object sender, TextChangedEventArgs e)
        {
            reload();
        }

        private void tb_FilterName_TextChanged(object sender, TextChangedEventArgs e)
        {
            reload();
        }
    }
}
