using System.Windows.Forms;

namespace WinFormsIslandsDemo
{
    public partial class SimpleButtonForm : Form
    {
        public SimpleButtonForm()
        {
            InitializeComponent();

            var myHostControl = new Microsoft.Toolkit.Forms.UI.XamlHost.WindowsXamlHost();
            myHostControl.Dock = System.Windows.Forms.DockStyle.Fill;
            myHostControl.Name = "hostUwpButton";

            var uwpButton = new Windows.UI.Xaml.Controls.Button();
            uwpButton.Content = "Say Something!";
            uwpButton.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Stretch;
            uwpButton.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Stretch;
            uwpButton.Click += UwpButton_Click;

            myHostControl.Child = uwpButton;
            this.Controls.Add(myHostControl);
        }

        private void UwpButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            MessageBox.Show("Hello World!");
        }
    }
}
