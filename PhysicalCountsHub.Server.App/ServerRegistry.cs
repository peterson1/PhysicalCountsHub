using PocketHub.Server.Lib.ComponentRegistry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;
using Autofac;
using System.Windows;
using PhysicalCountsHub.Server.App.SignalRHubs;
using Repo2.SDK.WPF45.Extensions.IOCExtensions;

namespace PhysicalCountsHub.Server.App
{
    class ServerRegistry : ServerRegistryBase2
    {
        protected override string MainWindowTitle => "Physical Counts Hub Server";

        protected override void RegisterServerComponents(ContainerBuilder b, Application app)
        {
            b.Hub<InventoryCountsHub>();

            b.Solo<IWebAppStarter, ServerRegistry>();
        }


        public override IDisposable StartWebApp(string hubServerUrl)
            => WebApp.Start<ServerRegistry>(hubServerUrl);
    }
}
