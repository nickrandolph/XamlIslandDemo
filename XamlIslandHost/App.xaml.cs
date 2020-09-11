using Telerik.UI.Xaml.Controls.Input;

namespace XamlIslandHost
{
    public sealed partial class App : Microsoft.Toolkit.Win32.UI.XamlHost.XamlApplication
    {
        public App()
        {
            this.Initialize();

            var x = new RadCalendar();
        }
    }

}
