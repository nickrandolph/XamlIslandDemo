using System;
using Windows.UI.Xaml.Controls;


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace UwpControlLibrary
{
    public sealed partial class MyCustomControl : UserControl
    {
        public MyCustomControl()
        {
            this.InitializeComponent();
        }

        private void RandomNumber_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var rnd = new Random();
            RandomNumberOutputTextBlock.Text = rnd.Next(0, 10000).ToString();
        }
    }
}
