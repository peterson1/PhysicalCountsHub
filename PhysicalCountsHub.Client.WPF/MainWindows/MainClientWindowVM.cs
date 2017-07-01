using PhysicalCountsHub.Client.WPF.BarcodeScanningUI;
using PhysicalCountsHub.Client.WPF.ProductsListUI;
using Repo2.Core.ns11.AppUpdates;
using Repo2.Core.ns11.FileSystems;
using Repo2.SDK.WPF45.ViewModelTools;

namespace PhysicalCountsHub.Client.WPF.MainWindows
{
    public class MainClientWindowVM : TabbedMainWindowBase
    {
        protected override string CaptionPrefix => "Physical Count";


        public MainClientWindowVM(BarcodeScanningTabVM barcodeScanningTabVM,
                                  ProductsListTabVM productsListTabVM,
                                  IAppUpdater appUpdater,
                                  IFileSystemAccesor fs) : base(fs)
        {
            AddAsTab(barcodeScanningTabVM);
            AddAsTab(productsListTabVM);

            Updater = appUpdater;
            Updater.StartCheckingForUpdates();
        }


        public IAppUpdater   Updater   { get; }
    }
}
