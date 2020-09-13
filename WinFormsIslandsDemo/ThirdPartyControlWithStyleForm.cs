using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UwpControlLibrary;

namespace WinFormsIslandsDemo
{
    public partial class ThirdPartyControlWithStyleForm : Form
    {
        public ThirdPartyControlWithStyleForm()
        {
            InitializeComponent();

            var myHostControl = new Microsoft.Toolkit.Forms.UI.XamlHost.WindowsXamlHost();
            myHostControl.Dock = DockStyle.Fill;
            myHostControl.Name = "uwpHost";

            var customControl = new CustomCalendar();
            customControl.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Stretch;
            customControl.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Stretch;
            myHostControl.Child = customControl;

            pnlXamlIsland.Controls.Add(myHostControl);

            var data = new DataModel();
            customControl.DataContext = data;
            dtpPickDate.DataBindings.Add(new Binding(nameof(DateTimePicker.Value), data, nameof(DataModel.MyDate), true, DataSourceUpdateMode.OnPropertyChanged));
            lblDate.DataBindings.Add(new Binding(nameof(Label.Text), data, nameof(DataModel.DateAsString), true, DataSourceUpdateMode.OnPropertyChanged));
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
