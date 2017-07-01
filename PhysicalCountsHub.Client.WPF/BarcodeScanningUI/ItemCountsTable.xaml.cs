using Repo2.SDK.WPF45.Extensions.DataGridExtensions;
using System.Windows.Controls;

namespace PhysicalCountsHub.Client.WPF.BarcodeScanningUI
{
    public partial class ItemCountsTable : UserControl
    {
        public ItemCountsTable()
        {
            InitializeComponent();
            Loaded += (s, e) => dg.EnableToggledColumns(DataGridLengthUnitType.Auto);
        }
    }
}
