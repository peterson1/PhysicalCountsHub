using Repo2.Core.ns11.AppUpdates;
using Repo2.Core.ns11.FileSystems;
using Repo2.SDK.WPF45.ViewModelTools;

namespace PhysicalCountsHub.Client.WPF.MainWindows
{
    public class MainClientWindowVM : TabbedMainWindowBase
    {
        protected override string CaptionPrefix => "Physical Count";


        public MainClientWindowVM(IAppUpdater appUpdater,
                                  IFileSystemAccesor fs) : base(fs)
        {
            Updater = appUpdater;
        }


        public IAppUpdater   Updater   { get; }
    }
}
