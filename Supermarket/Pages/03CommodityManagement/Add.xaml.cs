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
using static Supermarket.SqlServerTool;

namespace Supermarket.Pages.CommodityManagement
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

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            string sql = "select categoryID,categoryName from Category_Table";
            cb_categoryID.ItemsSource = GetDataView(sql);;
            cb_categoryID.DisplayMemberPath = "categoryName";
            cb_categoryID.SelectedValuePath = "categoryID";
        }

        private void img_picture_MouseDown(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "jpg图片|*.jpg|png图片|*.png|bmp图片|*.bmp";

            if (openDialog.ShowDialog() == true)
            {
                img_picture.Source = new BitmapImage(new Uri(openDialog.FileName, UriKind.Absolute));
                pictureName = openDialog.FileName;
            }
        }

        private void btn_Certain_Click(object sender, RoutedEventArgs e)
        {
            string commodityID = txt_commodityID.Text.Trim();
            if (commodityID == "")
            {
                MessageBox.Show("请输入商品编号！");
                return;
            }

            string commodityName = txt_commodityName.Text.Trim();
            if (commodityName == "")
            {
                MessageBox.Show("请输入商品名称！");
                return;
            }

            if (txt_commodityPrice.Text.Trim() == "")
            {
                MessageBox.Show("请输入商品价格！");
                return;
            }

            double commodityPrice;
            bool result = Double.TryParse(txt_commodityPrice.Text.Trim(), out commodityPrice);
            if (result == false)
            {
                MessageBox.Show("您输入商品价格格式不正确！");
                return;
            }

            if (commodityPrice <= 0)
            {
                MessageBox.Show("商品价格必须大于0元！");
                return;
            }


            if (txt_discount.Text.Trim() == "")
            {
                MessageBox.Show("请输入商品折扣！");
                return;
            }

            int discount;
            bool result2 = Int32.TryParse(txt_discount.Text.Trim(), out discount);
            if (result2 == false)
            {
                MessageBox.Show("您输入商品折扣格式不正确！");
                return;
            }

            if (discount < 1 || discount > 100)
            {
                MessageBox.Show("商品折扣必须在1-100之间！");
                return;
            }

            string manufacturer = txt_manufacturer.Text.Trim();
            if (manufacturer == "")
            {
                MessageBox.Show("请输入生产厂商！");
                return;
            }


            if (cb_categoryID.SelectedValue == null)
            {
                MessageBox.Show("请选择商品分类！");
                return;
            }
            int categoryID = Int32.Parse(cb_categoryID.SelectedValue.ToString());

            if (pictureName == "")
            {
                MessageBox.Show("请选择商品图片！");
                return;
            }
            string picture = commodityID + ".png";

            string statement = txt_statement.Text.Trim();

            string sql = string.Format("insert into Commodity_Table values('{0}','{1}',{2},0,'{3}','{4}',{5},'{6}',{7})", commodityID, commodityName, commodityPrice, picture, manufacturer, discount, statement, categoryID);
            int result3 = Database.ExecuteNonQuery(sql);
            if (result3 > 0)
            {
                MessageBox.Show("添加商品成功！");
                string savePath = AppDomain.CurrentDomain.BaseDirectory + "\\images\\" + picture;
                BitmapSource bmpSource = (BitmapSource)img_picture.Source;
                PngBitmapEncoder pngBitmap = new PngBitmapEncoder();
                pngBitmap.Frames.Add(BitmapFrame.Create(bmpSource));
                using (Stream st = File.Create(savePath))
                {
                    pngBitmap.Save(st);
                }

            }
            else
            {
                MessageBox.Show("添加商品失败！");
            }
        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
