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
    public partial class Edit : DMSkin.WPF.Small.DMSkinWindow
    {
        public Edit()
        {
            InitializeComponent();
        }
        string memberID = "";
        private void btn_Certain_Click(object sender, RoutedEventArgs e)
        {
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

            statement = txt_statement.Text;

            string sql = string.Format("update Member_Table set memberName='{0}',memberPassword='{1}',telephone='{2}',memberLevel='{3}',statement='{4}' where memberID='{5}'",
                 memberName, memberPassword, telephone, memberLevel, statement, memberID);
            int result = Database.ExecuteNonQuery(sql);
            if (result > 0)
            {
                MessageBox.Show("修改成功！");
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Win_ChangeMember_Loaded(object sender, RoutedEventArgs e)
        {
            txt_memberID.Focus();
        }


        private void Btn_query_Click(object sender, RoutedEventArgs e)
        {
            Query();
        }

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
            psw_memberPassword.Password = ds.Tables["Member"].Rows[0]["memberPassword"].ToString();
            psw_confirmPassword.Password = psw_memberPassword.Password;
            txt_telephone.Text = ds.Tables["Member"].Rows[0]["telephone"].ToString();
            txt_statement.Text = ds.Tables["Member"].Rows[0]["statement"].ToString();
            btn_Certain.IsEnabled = true;
        }

        private void Txt_memberID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Query();
            }
        }
    }
}
