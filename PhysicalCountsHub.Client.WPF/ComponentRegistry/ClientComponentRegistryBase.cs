using Autofac;
using PhysicalCountsHub.Client.Core.ServiceContracts;
using PhysicalCountsHub.Client.WPF.AppUpdates;
using PhysicalCountsHub.Client.WPF.BarcodeScanningUI;
using PhysicalCountsHub.Client.WPF.Configuration;
using PhysicalCountsHub.Client.WPF.CountConsolidationUI;
using PhysicalCountsHub.Client.WPF.MainWindows;
using PhysicalCountsHub.Client.WPF.ProductsListUI;
using Repo2.Core.ns11.AppUpdates;
using Repo2.Core.ns11.Authentication;
using Repo2.Core.ns11.FileSystems;
using Repo2.SDK.WPF45.ComponentRegistry;
using Repo2.SDK.WPF45.Configuration;
using Repo2.SDK.WPF45.Extensions.IOCExtensions;
using Repo2.SDK.WPF45.Extensions.ViewModelExtensions;
using System;
using System.Windows;

namespace PhysicalCountsHub.Client.WPF.ComponentRegistry
{
    public abstract class ClientComponentRegistryBase : ComponentRegistryBase<ClientSettingsWPF>
    {

        protected override void RegisterComponents(ContainerBuilder b)
        {
            b.Solo<IAppUpdater, Repo2AppUpdater>();

            b.Solo<MainClientWindowVM>();

            b.Solo<BarcodeScanningTabVM>();
            b.Solo<CountConsolidationTabVM>();
            b.Solo<ProductsListTabVM>();

            b.RegisterType(SKUDataSourceType).As<IProductDataSource>();

            b.RegisterInstance<IR2Credentials>(UpdaterCredentials);
        }


        protected abstract Type            SKUDataSourceType  { get; }
        protected abstract IR2Credentials  UpdaterCredentials { get; }


        protected override void SetDataTemplates(Application app)
        {
            app.SetTemplate<CountConsolidationTabVM, CountConsolidationTabUI1>();
            app.SetTemplate<BarcodeScanningTabVM, BarcodeScanningTabUI1>();
            app.SetTemplate<ProductsListTabVM, ProductsListTabUI1>();
        }


        protected override ClientSettingsWPF LoadSettingsFile(IFileSystemAccesor fs)
        {
            var loadr = new BesideExeCfgLoader<ClientSettingsWPF>(fs);
            return loadr.Load(ClientSettingsWPF.CreateDraft());
        }


        protected override object ResolveMainWindowVM(ILifetimeScope scope)
            => scope.Resolve<MainClientWindowVM>();
    }
}
