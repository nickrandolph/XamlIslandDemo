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
    public partial class CustomControlForm : Form
    {
        public CustomControlForm()
        {
            InitializeComponent();

            var myHostControl = new Microsoft.Toolkit.Forms.UI.XamlHost.WindowsXamlHost();
            myHostControl.Dock = System.Windows.Forms.DockStyle.Fill;
            myHostControl.Name = "hostUwpButton";
            var customControl = new MyCustomControl();
            //var customControl = Microsoft.Toolkit.Win32.UI.XamlHost.UWPTypeFactory.CreateXamlContentByType(
            //    "UwpControlLibrary.MyCustomControl") as MyCustomControl;
            customControl.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Stretch;
            customControl.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Stretch;
            myHostControl.Child = customControl;
            this.Controls.Add(myHostControl);
        }
    }
}
