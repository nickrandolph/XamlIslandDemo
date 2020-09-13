using Microsoft.Toolkit.Wpf.UI.XamlHost;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UwpControlLibrary;

namespace WPFIslandsDemo
{
    /// <summary>
    /// Interaction logic for ThirdPartyControlWithStyleWindow.xaml
    /// </summary>
    public partial class ThirdPartyControlWithStyleWindow : Window
    {
        public ThirdPartyControlWithStyleWindow()
        {
            InitializeComponent();

            DataContext = new DataModel();
        }

    }

    public class DataModel : INotifyPropertyChanged
    {
        private string dateAsString;
        private DateTime myDate;

        public event PropertyChangedEventHandler PropertyChanged;

        public string DateAsString
        {
            get => dateAsString; set
            {
                dateAsString = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DateAsString)));
            }
        }

        public DateTime MyDate
        {

            get => myDate;
            set
            {
                myDate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MyDate)));
                DateAsString = myDate.ToString("O");
            }
        }


    }
}
