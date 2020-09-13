using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsIslandsDemo
{
    public partial class ThirdPartyControlForm : Form
    {
        public ThirdPartyControlForm()
        {
            InitializeComponent();

            var myHostControl = new Microsoft.Toolkit.Forms.UI.XamlHost.WindowsXamlHost();
            myHostControl.Dock = System.Windows.Forms.DockStyle.Fill;
            myHostControl.Name = "hostUwpButton";
            var customControl = new Telerik.UI.Xaml.Controls.Input.RadCalendar();
            //var customControl = Microsoft.Toolkit.Win32.UI.XamlHost.UWPTypeFactory.CreateXamlContentByType(
            //    "Telerik.UI.Xaml.Controls.Input.RadCalendar") as Telerik.UI.Xaml.Controls.Input.RadCalendar;
            customControl.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Stretch;
            customControl.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Stretch;
            myHostControl.Child = customControl;
            this.Controls.Add(myHostControl);


        }
    }
}
