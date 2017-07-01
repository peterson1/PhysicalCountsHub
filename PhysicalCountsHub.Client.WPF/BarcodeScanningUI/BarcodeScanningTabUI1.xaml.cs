using System.Windows.Controls;
using System.Windows.Input;

namespace PhysicalCountsHub.Client.WPF.BarcodeScanningUI
{
    public partial class BarcodeScanningTabUI1 : UserControl
    {
        public BarcodeScanningTabUI1()
        {
            InitializeComponent();
            Loaded += (s, e) =>
            {
                qty.Value = 1;
                qty.Focus();
            };
        }


        private void qty_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.D0:
                case Key.D1:
                case Key.D2:
                case Key.D3:
                case Key.D4:
                case Key.D5:
                case Key.D6:
                case Key.D7:
                case Key.D8:
                case Key.D9:
                    bcode.Focus();
                    break;

                case Key.End:
                case Key.Home:
                case Key.Left:
                case Key.Up:
                case Key.Right:
                case Key.Down:
                case Key.Back:
                case Key.Delete:
                case Key.NumPad0:
                case Key.NumPad1:
                case Key.NumPad2:
                case Key.NumPad3:
                case Key.NumPad4:
                case Key.NumPad5:
                case Key.NumPad6:
                case Key.NumPad7:
                case Key.NumPad8:
                case Key.NumPad9:
                    break;

                default:
                    e.Handled = true;
                    break;
            }
        }


        private void bcode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter) return;

            (DataContext as BarcodeScanningTabVM)?
                .ProcessInputs(qty.Value, bcode.Text);

            bcode.Clear();
            qty.Value = 1;
            qty.Focus();
        }
    }
}
