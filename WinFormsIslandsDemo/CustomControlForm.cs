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
            var uwpButton = Microsoft.Toolkit.Win32.UI.XamlHost.UWPTypeFactory.CreateXamlContentByType(
                "UwpControlLibrary.MyCustomControl") as MyCustomControl;
            uwpButton.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Stretch;
            uwpButton.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Stretch;
            myHostControl.Child = uwpButton;
            this.Controls.Add(myHostControl);
        }
    }
}
