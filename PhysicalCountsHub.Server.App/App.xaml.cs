using PocketHub.Server.Lib.MainWindows;
using System.Windows;

namespace PhysicalCountsHub.Server.App
{
    public partial class App : Application
    {
        const string COUNT_ICO_URI = "pack://application:,,,/PhysicalCountsHub.Client.WPF;component/Assets/The_Count.ico";

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var win = new MainHubWindow1(COUNT_ICO_URI);
            win.DataContext = new ServerRegistry().CreateMainVM(this);
            win.Show();
        }
    }
}
