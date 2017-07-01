namespace PhysicalCountsHub.Client.WPF.ProductsListUI
{
    public class ProductRow
    {
        public ProductRow(ulong barcode, string description)
        {
            Barcode     = barcode;
            Description = description;
        }


        public ulong   Barcode      { get; }
        public string  Description  { get; }
    }
}
