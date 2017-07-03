using PhysicalCountsHub.Client.WPF.LocalCaches;
using Repo2.Core.ns11.DataStructures;
using Repo2.Core.ns11.InputCommands;
using Repo2.SDK.WPF45.InputCommands;
using Repo2.SDK.WPF45.ViewModelTools;
using System.Threading.Tasks;

namespace PhysicalCountsHub.Client.WPF.ProductsListUI
{
    public class ProductsListTabVM : R2ViewModelBase
    {
        private ProductsCache _cache;


        public ProductsListTabVM(ProductsCache productsCache)
        {
            UpdateTitle("Products List");

            _cache        = productsCache;
            UpdateListCmd = R2Command.Async(UpdateList, _ => !IsBusy, "Update List");

            _cache.StatusChanged += (s, e) => SetStatus(e);
            this.StatusChanged   += (s, e) => AsUI(_ => Logs.Add(e));

            UpdateListCmd.ExecuteIfItCan();
        }


        public IR2Command  UpdateListCmd  { get; }
        public uint        Count          { get; private set; }

        public Observables<string> Logs { get; } = new Observables<string>();


        private async Task UpdateList()
        {
            StartBeingBusy("Updating products list ...");

            Count = await _cache.UpdateFromRemote();

            StopBeingBusy();
        }
    }
}
