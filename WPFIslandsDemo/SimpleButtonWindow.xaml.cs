using Microsoft.Toolkit.Wpf.UI.XamlHost;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFIslandsDemo
{
    /// <summary>
    /// Interaction logic for SimpleButtonWindow.xaml
    /// </summary>
    public partial class SimpleButtonWindow : Window
    {
        public SimpleButtonWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void WindowsXamlHost_Loaded(object sender, RoutedEventArgs e)
        {
            var host = sender as WindowsXamlHost;
            var button = new Windows.UI.Xaml.Controls.Button();
            button.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Stretch;
            button.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Stretch;
            button.Content = "Say Something";
            button.Click += Button_Click;
            host.Child = button;
        }
    }
}
