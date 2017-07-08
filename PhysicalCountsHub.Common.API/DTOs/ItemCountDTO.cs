using System;
using System.Collections.Generic;
using System.Text;

namespace PhysicalCountsHub.Common.API.DTOs
{
    public class ItemCountDTO
    {
        public uint       Id            { get; set; }
        public DateTime   TimeScanned   { get; set; }
        public int        Quantity      { get; set; }
        public ulong      Barcode       { get; set; }
        public string     Description   { get; set; }
    }
}
