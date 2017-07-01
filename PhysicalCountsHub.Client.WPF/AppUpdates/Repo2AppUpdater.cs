using PhysicalCountsHub.Client.WPF.Configuration;
using Repo2.Core.ns11.Authentication;
using Repo2.Core.ns11.FileSystems;
using Repo2.Core.ns11.PackageDownloaders;
using Repo2.SDK.WPF45.AppUpdates;
using System.ComponentModel;

namespace PhysicalCountsHub.Client.WPF.AppUpdates
{
    public class Repo2AppUpdater : R2AppUpdaterBase, INotifyPropertyChanged
    {
        private ClientSettingsWPF _cfg;


        public Repo2AppUpdater(ClientSettingsWPF clientSettingsWPF, ILocalPackageFileUpdater localPackageFileUpdater, IFileSystemAccesor fileSystemAccesor) : base(localPackageFileUpdater, fileSystemAccesor)
        {
            _cfg = clientSettingsWPF;
        }


        protected override IR2Credentials GetCredentials()
            => new R2Credentials
            {
                BaseURL              = _cfg.R2BaseURL,
                Username             = _cfg.R2Username,
                Password             = _cfg.R2Password,
                CertificateThumb     = _cfg.R2CertificateThumb,
                CheckIntervalSeconds = _cfg.R2CheckIntervalSeconds,
            };
    }
}
