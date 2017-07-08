using LiteDB;
using Repo2.Core.ns11.FileSystems;
using Repo2.SDK.WPF45.Databases;
using System.Collections.Generic;

namespace PhysicalCountsHub.Client.WPF.LocalCaches
{
    public class ProductsLocalRepo : LocalRepoBase<ProductsCacheRow>
    {
        public ProductsLocalRepo(IFileSystemAccesor fileSystemAccessor) : base(fileSystemAccessor)
        {
        }


        public void SwapData(List<ProductsCacheRow> rows)
        {
            DeleteAll();
            BatchInsert(rows);
        }


        public override void EnsureIndeces(LiteCollection<ProductsCacheRow> col)
            => col.EnsureIndex(x => x.Barcode, true);
    }
}
