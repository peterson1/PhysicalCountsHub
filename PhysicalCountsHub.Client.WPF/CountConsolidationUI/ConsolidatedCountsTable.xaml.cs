using Repo2.SDK.WPF45.Extensions.DataGridExtensions;
using System.Windows.Controls;

namespace PhysicalCountsHub.Client.WPF.CountConsolidationUI
{
    public partial class ConsolidatedCountsTable : UserControl
    {
        public ConsolidatedCountsTable()
        {
            InitializeComponent();
            Loaded += (s, e) => dg.EnableToggledColumns(DataGridLengthUnitType.Auto);
        }
    }
}
