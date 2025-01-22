using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using NLE.Devices.ZigBee;
using System.Windows.Threading;

namespace Supermarket.Pages.ConfigManagement
{
    /// <summary>
    /// DashBoard.xaml 的交互逻辑
    /// </summary>
    public partial class Home : UserControl, INotifyPropertyChanged
    {
        public static IZigBee zigbee;
        #region UI更新接口
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        string _cpuUsage;
        public string CpuUsage
        {
            get
            {
                return _cpuUsage;
            }
            set
            {
                _cpuUsage = value;
                OnPropertyChanged("CpuUsage");
            }
        }

        public ChartValues<double> Values { get; set; }
        public string wd { get; set; }

        public Home()
        {
            InitializeComponent();

            Values = new ChartValues<double> { 150, 375, 420, 500, 160, 140 };

            zigbee = new ZigBeeSeries();
            zigbee.DataReceived += Zigbee_DataReceived;
            zigbee.Connect("COM202", 38400);
            DataContext = this;
        }

        private void Zigbee_DataReceived(object sender, ZigBeeDataEventArgs e)
        {
            this.Dispatcher.Invoke(() =>
            {
                //CpuUsage = FourChannelConvert.Temperature(e.Data.Value2).ToString();
                //txt_lx.Text = FourChannelConvert.Light(e.Data.Value1).ToString();
                //txt_humi.Text = FourChannelConvert.Humidity(e.Data.Value3).ToString();
                //txt_co.Text = FourChannelConvert.CO2(e.Data.Value4).ToString();
            });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CpuUsage = "88";
            Values = new ChartValues<double> { 375, 375, 375, 375, 375, 140 };
            Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal, action);
        }
        Action action = delegate
        {
        };
    }
}
