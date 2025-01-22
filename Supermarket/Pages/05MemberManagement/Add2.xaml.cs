using LiveCharts;
using MaterialDesignThemes.Wpf;
using Microsoft.Win32;
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

namespace Supermarket.Pages.MemberManagement
{
    /// <summary>
    /// Add.xaml 的交互逻辑
    /// </summary>
    public partial class Add2 : DMSkin.WPF.Small.DMSkinWindow
    {
        public Add2()
        {
            InitializeComponent();
        }


        string memberID = "";
        private void Query()
        {
            memberID = txt_memberID.Text.Trim();
            if (memberID == "")
            {
                MessageBox.Show("请输入会员卡号！");
                return;
            }

            string sql = string.Format(" select * from Member_Table where memberID='{0}' ", memberID);
            DataSet ds = Database.ExecuteQuery(sql, "Member");

            if (ds.Tables["Member"].Rows.Count == 0)
            {
                MessageBox.Show("该会员卡号不存在！");
                return;
            }

            txt_memberName.Text = ds.Tables["Member"].Rows[0]["memberName"].ToString();
            txt_telephone.Text = ds.Tables["Member"].Rows[0]["telephone"].ToString();
            txt_memberMoney.Text = ds.Tables["Member"].Rows[0]["memberMoney"].ToString();
            txt_totalMoney.Text = ds.Tables["Member"].Rows[0]["totalMoney"].ToString();
            txt_memberLevel.Text = ds.Tables["Member"].Rows[0]["memberLevel"].ToString();
            txt_statement.Text = ds.Tables["Member"].Rows[0]["statement"].ToString();
        }

        private void Btn_query_Click(object sender, RoutedEventArgs e)
        {
            Query();
            txt_recharge.Focus();
        }

        private void Txt_memberID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Query();
                txt_recharge.Focus();
            }
        }

        private void btn_Certain_Click(object sender, RoutedEventArgs e)
        {
            double money = Convert.ToDouble(txt_memberMoney.Text);
            double addMoney = Convert.ToDouble(txt_recharge.Text);
            double newMoney = money + addMoney;
            string sql = string.Format("update Member_Table set memberMoney={0} where memberID='{1}'", newMoney, memberID);
            int result = Database.ExecuteNonQuery(sql);
            if (result > 0)
            {
                MessageBox.Show("充值成功！");
                txt_recharge.Text = "";
                Query();
            }
            else
            {
                MessageBox.Show("充值失败！");
            }
        }

        private void Txt_recharge_KeyDown(object sender, KeyEventArgs e)
        {
            //调用按钮事件
            if (e.Key == Key.Enter)
            {
                this.btn_Certain.Dispatcher.Invoke(
                new Action(
                delegate
                {
                    btn_Certain.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                ));
            }
        }

        private void Win_RechargeMember_Loaded(object sender, RoutedEventArgs e)
        {
            txt_memberID.Focus();
        }
    }
}
