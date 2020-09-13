using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.UI.Xaml.Controls.Input;

namespace WinFormsIslandsUwpApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //// 
            //// button1
            //// 
            //this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.button1.Location = new System.Drawing.Point(10, 10);
            //this.button1.Name = "button1";
            //this.button1.Size = new System.Drawing.Size(716, 330);
            //this.button1.TabIndex = 0;
            //this.button1.Text = "button1";
            //this.button1.UseVisualStyleBackColor = true;


            var myHostControl = new Microsoft.Toolkit.Forms.UI.XamlHost.WindowsXamlHost();

            //var entryForm = Microsoft.Toolkit.Win32.UI.XamlHost.UWPTypeFactory.CreateXamlContentByType(
            //    "XamlIslandUwpHost.CalendarHost") as XamlIslandUwpHost.CalendarHost;

            var test = new Test();
            var entryForm = Microsoft.Toolkit.Win32.UI.XamlHost.UWPTypeFactory.CreateXamlContentByType(
                "XamlIslandUwpAppHost.CalendarHost") as XamlIslandUwpAppHost.CalendarHost;

            //var entryForm = Microsoft.Toolkit.Win32.UI.XamlHost.UWPTypeFactory.CreateXamlContentByType(
            //    "Telerik.UI.Xaml.Controls.Input.RadCalendar") as Telerik.UI.Xaml.Controls.Input.RadCalendar;
            //entryForm.DataContext = test;
            myHostControl.Name = "myUwpAppHostControl";
            myHostControl.Child = entryForm;

            myHostControl.Dock = System.Windows.Forms.DockStyle.Fill;
            myHostControl.Name = "button1";
            myHostControl.TabIndex = 0;

            label2.DataBindings.Add(new Binding("Text", test, "Name", true, DataSourceUpdateMode.OnPropertyChanged));


            //var b = new Windows.UI.Xaml.Data.Binding();
            //b.Mode = Windows.UI.Xaml.Data.BindingMode.TwoWay;
            //b.Source = test;
            //b.Path =new Windows.UI.Xaml.PropertyPath("DateRange");

            //entryForm.SetBinding(RadCalendar.SelectedDateRangeProperty, b);

            entryForm.DataContext = test;

            panel1.Controls.Add(myHostControl);
        }

    }

    public class Test : INotifyPropertyChanged
    {
        private string name;
        private DateTime myDate;
        private CalendarDateRange? dateRange;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get => name; set
            {
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }

        public DateTime MyDate
        {
           
            get => myDate; 
            set
            {
                myDate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MyDate)));
                Name = myDate.ToString("O");
            }
        }

        public CalendarDateRange? DateRange
        {
            get => dateRange; set
            {
                dateRange = value;
                if (value != null)
                {
                    MyDate = value.Value.StartDate;
                }
            }
        }

    }
}
