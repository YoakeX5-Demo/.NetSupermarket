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

namespace Supermarket.Pages.MemberManagement
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

        string sqlGrid = "SELECT memberID as 账号,memberName as 姓名,memberPassword as 密码,memberMoney as 余额,telephone as 电话,memberLevel as 等级,memberDiscount as 折扣,totalMoney as 价格,statement as 说明 FROM Member_Table";
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
                string memberID = mySelectedElement.Row[0].ToString();
                string querySQL = sqlGrid;
                string sql = string.Format("delete from Member_Table where memberID='{0}'", memberID);
                int result = Database.ExecuteNonQuery(sql);
                if (result > 0)
                {
                    MessageBox.Show("删除成功！");
                    dg_data.ItemsSource = GetDataView(querySQL);
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
        }

        private void tb_FilterID_TextChanged(object sender, TextChangedEventArgs e)
        {
            reload();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            reload();
        }

        void reload()
        {
            string userID = TextFormat(tb_FilterID.Text);

            string querySQL = sqlGrid + string.Format(" where memberID like '%{0}%'", userID);
            dg_data.ItemsSource = GetDataView(querySQL);
        }

        private void cb_purview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            reload();
        }

        private void ClearOutlinedComboBox_Click(object sender, RoutedEventArgs e)
        {

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

        private void btn_Add2_Click(object sender, RoutedEventArgs e)
        {
            Add2 add2 = new Add2();
            add2.Show();
        }
    }
}
