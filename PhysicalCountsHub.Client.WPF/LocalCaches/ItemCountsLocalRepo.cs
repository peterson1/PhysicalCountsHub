using PhysicalCountsHub.Common.API.DTOs;
using Repo2.Core.ns11.FileSystems;
using Repo2.SDK.WPF45.Databases;

namespace PhysicalCountsHub.Client.WPF.LocalCaches
{
    public class ItemCountsLocalRepo : LocalRepoBase<ItemCountDTO>
    {
        public ItemCountsLocalRepo(IFileSystemAccesor fileSystemAccessor) : base(fileSystemAccessor)
        {
        }
    }
}
