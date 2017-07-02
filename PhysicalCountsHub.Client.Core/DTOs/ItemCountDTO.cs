using System;

namespace PhysicalCountsHub.Client.Core.DTOs
{
    public class ItemCountDTO
    {
        public DateTime   TimeScanned   { get; set; }
        public int        Quantity      { get; set; }
        public ulong      Barcode       { get; set; }
        public string     Description   { get; set; }
    }
}
