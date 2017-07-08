using NullGuard;

namespace PhysicalCountsHub.Client.WPF.LocalCaches
{
    public class ProductsCacheRow
    {
        public uint    Id           { get; set; }
        public ulong   Barcode      { get; set; }

        [AllowNull]
        public string  Description  { get; set; }
    }
}
