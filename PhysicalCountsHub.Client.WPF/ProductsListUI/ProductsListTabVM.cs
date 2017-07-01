using PhysicalCountsHub.Client.Core.ServiceContracts;
using Repo2.Core.ns11.DataStructures;
using Repo2.Core.ns11.InputCommands;
using Repo2.SDK.WPF45.InputCommands;
using Repo2.SDK.WPF45.ViewModelTools;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Repo2.Core.ns11.Extensions;
using NullGuard;

namespace PhysicalCountsHub.Client.WPF.ProductsListUI
{
    public class ProductsListTabVM : R2ViewModelBase
    {
        private IProductDataSource        _skuSrc;
        private Dictionary<ulong, string> _skuDict;


        public ProductsListTabVM(IProductDataSource productDataSource)
        {
            UpdateTitle("Products List");

            _skuSrc       = productDataSource;
            UpdateListCmd = R2Command.Async(UpdateList, _ => !IsBusy, "Update List");
            UpdateListCmd.ExecuteIfItCan();
        }


        public IR2Command  UpdateListCmd  { get; }

        public Observables<ProductRow> Products { get; } = new Observables<ProductRow>();


        private async Task UpdateList()
        {
            StartBeingBusy("Updating products list ...");
            AsUI(_ => Products.Clear());

            _skuDict = await _skuSrc.GetMasterList();

            var rows = new List<ProductRow>();
            foreach (var kvp in _skuDict)
                rows.Add(new ProductRow(kvp.Key, kvp.Value));

            AsUI(_ => Products.Swap(rows));
            StopBeingBusy();
        }

        
        [return: AllowNull]
        public string FindDescription(ulong barcode)
            => _skuDict?.GetOrDefault(barcode);
    }
}
