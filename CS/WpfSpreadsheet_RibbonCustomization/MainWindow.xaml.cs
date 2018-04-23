using DevExpress.Xpf.Core;
using System.Windows;

namespace WpfSpreadsheet_RibbonCustomization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DevExpress.Xpf.Ribbon.DXRibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void About_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            DXMessageBox.Show("This example demonstrates how to customize the WPF Spreadsheet's integrated ribbon UI.\n\nUse the SpreadsheetControl's RibbonActions collection to create, remove or modify ribbon elements.",
                "Spreadsheet Ribbon Customization", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
