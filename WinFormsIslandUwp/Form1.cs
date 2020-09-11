using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsIslandUwp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            var myHostControl = new Microsoft.Toolkit.Forms.UI.XamlHost.WindowsXamlHost();
            
            var entryForm = Microsoft.Toolkit.Win32.UI.XamlHost.UWPTypeFactory.CreateXamlContentByType(
                "XamlIslandUwpHost.CalendarHost") as XamlIslandUwpHost.CalendarHost;

            //var entryForm = Microsoft.Toolkit.Win32.UI.XamlHost.UWPTypeFactory.CreateXamlContentByType(
            //    "Telerik.UI.Xaml.Controls.Input.RadCalendar") as Telerik.UI.Xaml.Controls.Input.RadCalendar;
            myHostControl.Name = "myUwpAppHostControl";
            myHostControl.Child = entryForm;
            myHostControl.Location = new System.Drawing.Point(0, 0);
            myHostControl.Size = Size;
            Controls.Add(myHostControl);
        }

    }
}
