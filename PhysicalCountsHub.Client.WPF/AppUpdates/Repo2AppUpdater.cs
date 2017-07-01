using Repo2.Core.ns11.Authentication;
using Repo2.Core.ns11.FileSystems;
using Repo2.Core.ns11.PackageDownloaders;
using Repo2.SDK.WPF45.AppUpdates;
using System.ComponentModel;

namespace PhysicalCountsHub.Client.WPF.AppUpdates
{
    public class Repo2AppUpdater : R2AppUpdaterBase, INotifyPropertyChanged
    {
        private IR2Credentials    _r2Creds;


        public Repo2AppUpdater(IR2Credentials r2Credentials, ILocalPackageFileUpdater localPackageFileUpdater, IFileSystemAccesor fileSystemAccesor) : base(localPackageFileUpdater, fileSystemAccesor)
        {
            _r2Creds = r2Credentials;
        }

        protected override IR2Credentials GetCredentials() => _r2Creds;
    }
}
