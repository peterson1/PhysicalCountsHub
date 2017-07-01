using NullGuard;
using System.ComponentModel;

namespace PhysicalCountsHub.Client.WPF.BarcodeScanningUI
{
    public class ItemCountRow : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };


        public int      Quantity     { get; set; }
        public ulong    Barcode      { get; set; }
        public string   Description  { get; set; }

        [AllowNull]
        public string   Remarks      { get; set; }
    }
}
