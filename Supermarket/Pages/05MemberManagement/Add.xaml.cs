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
    public partial class Add : DMSkin.WPF.Small.DMSkinWindow
    {
        public string pictureName = "";

        public Add()
        {
            InitializeComponent();
        }


        private void btn_Certain_Click(object sender, RoutedEventArgs e)
        {
            string memberID = txt_memberID.Text.Trim();
            if (memberID == "")
            {
                MessageBox.Show("请输入会员卡号！");
                return;
            }

            string memberName = txt_memberName.Text.Trim();
            if (memberName == "")
            {
                MessageBox.Show("请输入会员姓名！");
                return;
            }

            string memberPassword = psw_memberPassword.Password.Trim();
            if (memberPassword == "")
            {
                MessageBox.Show("请输入会员密码！");
                return;
            }

            string confirmPassword = psw_confirmPassword.Password.Trim();
            if (confirmPassword == "")
            {
                MessageBox.Show("请输入确认密码！");
                return;
            }

            if (memberPassword != confirmPassword)
            {
                MessageBox.Show("两次密码不一致！");
                return;
            }

            string telephone = txt_telephone.Text.Trim();
            if (telephone == "")
            {
                MessageBox.Show("请输入手机号码！");
                return;
            }

            string memberLevel = "", statement = "";
            double memberMoney = 0, totalMoney = 0;
            int memberDiscount = 0;

            statement = txt_statement.Text;
            Int32.TryParse(txt_memberDiscount.Text, out memberDiscount);
            Double.TryParse(txt_memberMoney.Text, out memberMoney);

            string sql = string.Format("insert into Member_Table values('{0}','{1}','{2}',{3},'{4}','{5}',{6},{7},'{8}')",
                memberID, memberName, memberPassword, memberMoney, telephone, memberLevel, memberDiscount, totalMoney, statement);
            int result = Database.ExecuteNonQuery(sql);
            if (result > 0)
            {
                MessageBox.Show("注册成功！");
            }
            else
            {
                MessageBox.Show("注册失败！");
            }
        }


        private void Win_RegisterMember_Loaded(object sender, RoutedEventArgs e)
        {
            txt_memberID.Focus();
        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
