using PhysicalCountsHub.Client.WPF.ComponentRegistry;
using PhysicalCountsHub.Client.WPF.MainWindows;
using System.Windows;

namespace PhysicalCountsHub.Client.SampleApp
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var win = new MainClientWindow1();
            win.DataContext = new ClientComponents().CreateMainVM(this);
            if (win.DataContext == null)
                win.Close();
            else
                win.Show();
        }
    }
}
