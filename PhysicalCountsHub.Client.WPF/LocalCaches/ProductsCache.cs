using LiteDB;
using NullGuard;
using PhysicalCountsHub.Common.API.ServiceContracts;
using Repo2.Core.ns11.Exceptions;
using Repo2.Core.ns11.FileSystems;
using Repo2.SDK.WPF45.ChangeNotification;
using Repo2.SDK.WPF45.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhysicalCountsHub.Client.WPF.LocalCaches
{
    public class ProductsCache : StatusChangerN45
    {
        private IProductDataSource _remoteSrc;
        private ProductsLocalRepo  _localRepo;

        public ProductsCache(IProductDataSource productDataSource,
                             ProductsLocalRepo productsLocalRepo)
        {
            _remoteSrc = productDataSource;
            _localRepo = productsLocalRepo;
        }


        public async Task<uint> UpdateFromRemote()
        {
            try
            {
                var freshList = await QueryRemoteSource();
                _localRepo.SwapData(freshList);
            }
            catch (Exception ex)
            {
                SetStatus(ex.Info());
            }

            var count = _localRepo.CountAll();
            SetStatus($"Local cache now contains {count} items.");
            return count;
        }


        [return: AllowNull]
        public string FindDescription(ulong barcode)
        {
            var matches = _localRepo.Find(x => x.Barcode == barcode);
            if (!matches.Any()) return null;

            if (matches.Count > 1)
                throw Fault.NonSolo($"Matches for barcode [{barcode}]", matches.Count);

            return matches.Single().Description;
        }


        private async Task<List<ProductsCacheRow>> QueryRemoteSource()
        {
            SetStatus("Getting list of Products ...");
            var dict = await _remoteSrc.GetMasterList();
            return CastToRows(dict);
        }


        private List<ProductsCacheRow> CastToRows(Dictionary<ulong, string> dict)
            => dict.Select(x => new ProductsCacheRow
            {
                Barcode     = x.Key,
                Description = x.Value,
            }
            ).ToList();


    }
}
