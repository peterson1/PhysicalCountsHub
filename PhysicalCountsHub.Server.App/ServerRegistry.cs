using Autofac;
using Microsoft.Owin.Hosting;
using PhysicalCountsHub.Server.App.SignalRHubs;
using PocketHub.Server.Lib.ComponentRegistry;
using Repo2.SDK.WPF45.Extensions.IOCExtensions;
using System;
using System.Windows;

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
