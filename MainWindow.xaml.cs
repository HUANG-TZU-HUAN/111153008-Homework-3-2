using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace _111153008_Homework_3_2
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtMG_KeyUp(object sender, KeyEventArgs e)
        {
            if(double.TryParse(txtMG.Text,out double value)==true)
            {
                txtG.Text=string.Format("{0:0.##########}",value/1000);
                txtKG.Text = string.Format("{0:0.##########}", value / 1000000);
                txtMT.Text = string.Format("{0:0.##########}", value / 1000000000);
                txtOZ.Text = string.Format("{0:0.##########}", value / 28349);
                txtLB.Text = string.Format("{0:0.##########}", value / 453592);
            }
            else
            {
                txtinfo.Text = "錯誤";
            }
        }

        private void txtG_KeyUp(object sender, KeyEventArgs e)
        {
            if (double.TryParse(txtG.Text, out double value) == true)
            {
                txtMG.Text = string.Format("{0:0.##########}", value * 1000);
                txtKG.Text = string.Format("{0:0.######}", value / 1000);
                txtMT.Text = string.Format("{0:0.######}", value / 1000000);
                txtOZ.Text = string.Format("{0:0.######}", value / 28);
                txtLB.Text = string.Format("{0:0.######}", value / 453);
            }
            else
            {
                txtinfo.Text = "錯誤";
            }
        }

        private void txtKG_KeyUp(object sender, KeyEventArgs e)
        {
            if (double.TryParse(txtKG.Text, out double value) == true)
            {
                txtMG.Text = string.Format("{0:0.######}", value * 1000000);
                txtG.Text = string.Format("{0:0.######}", value * 1000);
                txtMT.Text = string.Format("{0:0.######}", value / 1000);
                txtOZ.Text = string.Format("{0:0.######}", value / 0.028349);
                txtLB.Text = string.Format("{0:0.######}", value / 0.453592);
            }
            else
            {
                txtinfo.Text = "錯誤";
            }
        }

        private void txtMT_KeyUp(object sender, KeyEventArgs e)
        {
            if (double.TryParse(txtMT.Text, out double value) == true)
            {
                txtMG.Text = string.Format("{0:0.######}", value * 1000000000);
                txtG.Text = string.Format("{0:0.######}", value * 1000000);
                txtKG.Text = string.Format("{0:0.######}", value * 1000);
                txtOZ.Text = string.Format("{0:0.######}", value / 0.000028349);
                txtLB.Text = string.Format("{0:0.######}", value / 0.000453592);
            }
            else
            {
                txtinfo.Text = "錯誤";
            }
        }

        private void txtOZ_KeyUp(object sender, KeyEventArgs e)
        {
            if (double.TryParse(txtOZ.Text, out double value) == true)
            {
                txtMG.Text = string.Format("{0:0.######}", value * 0.00003527396195);
                txtG.Text = string.Format("{0:0.######}", value * 0.035273962);
                txtKG.Text = string.Format("{0:0.######}", value * 35.27396195);
                txtMT.Text = string.Format("{0:0.######}", value / 35273.96195);
                txtLB.Text = string.Format("{0:0.######}", value / 16);
            }
            else
            {
                txtinfo.Text = "錯誤";
            }
        }

        
 


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtMG.Text = "";
            txtG.Text = "";
            txtKG.Text = "";
            txtMT.Text = "";
            txtOZ.Text = "";
            txtLB.Text = "";
        }

        private void txtLB_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (double.TryParse(txtLB.Text, out double value) == true)
            {
                txtMG.Text = string.Format("{0:0.################}", value / 0.00000220462262185);
                txtG.Text = string.Format("{0:0.#############}", value / 0.0022046226);
                txtKG.Text = string.Format("{0:0.############}", value / 2.2046226218);
                txtMT.Text = string.Format("{0:0.############}", value / 2204.62262185);
                txtOZ.Text = string.Format("{0:0.######}", value * 16);
            }
            else
            {
                txtinfo.Text = "錯誤";
            }
        }
    }
}
