Imports DevExpress.Xpf.Core
Imports System.Windows

Namespace WpfSpreadsheet_RibbonCustomization
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits DevExpress.Xpf.Ribbon.DXRibbonWindow

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub About_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            DXMessageBox.Show("This example demonstrates how to customize the WPF Spreadsheet's integrated ribbon UI." & ControlChars.Lf & ControlChars.Lf & "Use the SpreadsheetControl's RibbonActions collection to create, remove or modify ribbon elements.", "Spreadsheet Ribbon Customization", MessageBoxButton.OK, MessageBoxImage.Information)
        End Sub
    End Class
End Namespace
