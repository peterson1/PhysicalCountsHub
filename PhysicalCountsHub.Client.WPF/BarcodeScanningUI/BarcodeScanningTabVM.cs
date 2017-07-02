using PhysicalCountsHub.Client.WPF.ProductsListUI;
using Repo2.Core.ns11.DataStructures;
using Repo2.Core.ns11.Extensions.StringExtensions;
using Repo2.SDK.WPF45.Exceptions;
using Repo2.SDK.WPF45.InputCommands;
using Repo2.SDK.WPF45.ViewModelTools;
using System;

namespace PhysicalCountsHub.Client.WPF.BarcodeScanningUI
{
    public class BarcodeScanningTabVM : R2ViewModelBase
    {
        private ProductsListTabVM _skuTab;


        public BarcodeScanningTabVM(ProductsListTabVM productsListTabVM)
        {
            UpdateTitle("Barcode Scanning");
            _skuTab = productsListTabVM;
        }


        public Observables<ItemCountRow>  ItemCounts  { get; } = new Observables<ItemCountRow>();

        //[AllowNull]
        //public string  LastScannedSKU  { get; private set; }


        internal void ProcessInputs(int? qty, string barcodeText)
        {
            if (!qty.HasValue) return;
            if (!TryParseBarcode(barcodeText, out ulong bCode)) return;

            var skuDesc = _skuTab.FindDescription(bCode);
            if (skuDesc.IsBlank())
            {
                Alerter.ShowError("Unregistered Barcode",
                    $"Barcode is not in Products Master List:{L.f}“{bCode}”");
                return;
            }

            var row = new ItemCountRow
            {
                TimeScanned = DateTime.Now,
                Quantity    = qty.Value,
                Barcode     = bCode,
                Description = skuDesc,
            };

            row.DeleteCmd = R2Command.Relay(() 
                => ItemCounts.Remove(row));

            ItemCounts.Insert(0, row);
        }


        private bool TryParseBarcode(string barcodeText, out ulong bCode)
        {
            var ok = ulong.TryParse(barcodeText, out bCode);

            if (!ok) Alerter.ShowError("Invalid barcode value",
                        $"Not a valid number:{L.f}“{barcodeText}”");
            return ok;
        }
    }
}
