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

namespace WPFIslandsDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSimpleButton_Click(object sender, RoutedEventArgs e)
        {
            new SimpleButtonWindow().ShowDialog();
        }
        private void btnCustomControl_Click(object sender, RoutedEventArgs e)
        {
            new CustomControlWindow().ShowDialog();
        }
        private void btnThirdPartyControl_Click(object sender, RoutedEventArgs e)
        {
            new ThirdPartyControlWindow().ShowDialog();
        }
        private void btnThirdPartyControlWithStyle_Click(object sender, RoutedEventArgs e)
        {
            new ThirdPartyControlWithStyleWindow().ShowDialog();
        }
    }
}
