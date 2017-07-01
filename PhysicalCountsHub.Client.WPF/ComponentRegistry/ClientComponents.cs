using Autofac;
using PhysicalCountsHub.Client.WPF.AppUpdates;
using PhysicalCountsHub.Client.WPF.Configuration;
using PhysicalCountsHub.Client.WPF.MainWindows;
using PocketHub.Client.Lib.Configuration;
using Repo2.Core.ns11.AppUpdates;
using Repo2.Core.ns11.FileSystems;
using Repo2.SDK.WPF45.ComponentRegistry;
using Repo2.SDK.WPF45.Configuration;
using Repo2.SDK.WPF45.Extensions.IOCExtensions;
using System.Windows;

namespace PhysicalCountsHub.Client.WPF.ComponentRegistry
{
    public class ClientComponents : ComponentRegistryBase<ClientSettingsWPF>
    {

        protected override void RegisterComponents(ContainerBuilder b)
        {
            b.Solo<IAppUpdater, Repo2AppUpdater>();

            b.Solo<MainClientWindowVM>();
        }


        protected override void SetDataTemplates(Application app)
        {
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
