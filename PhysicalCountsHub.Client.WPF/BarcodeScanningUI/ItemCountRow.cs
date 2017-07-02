using NullGuard;
using Repo2.Core.ns11.InputCommands;
using System;
using System.ComponentModel;

namespace PhysicalCountsHub.Client.WPF.BarcodeScanningUI
{
    public class ItemCountRow : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public DateTime     TimeScanned   { get; set; }
        public int          Quantity      { get; set; }
        public ulong        Barcode       { get; set; }
        public string       Description   { get; set; }

        [AllowNull]
        public IR2Command   DeleteCmd     { get; set; }
    }
}
