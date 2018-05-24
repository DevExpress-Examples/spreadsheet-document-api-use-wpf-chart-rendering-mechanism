Imports DevExpress.Spreadsheet
Imports DevExpress.Xpf.Spreadsheet.Services
Imports DevExpress.XtraSpreadsheet.Services
Imports DevExpress.XtraSpreadsheet.Services.Implementation
Imports System

Namespace WpfWorksheetChartExportPDF
    Friend Class Program
        <STAThread> _
        Shared Sub Main(ByVal args() As String)
            Dim workbook As New Workbook()

            ' Replace the default chart rendering mechanism with the WPF one.
            workbook.ReplaceService(Of IChartControllerFactoryService)(New ChartControllerFactoryService())
            workbook.ReplaceService(Of IChartImageService)(New WpfChartImageService())

            workbook.LoadDocument("Document.xlsx")
            workbook.ExportToPdf("ExportedDocument.pdf")

            System.Diagnostics.Process.Start("ExportedDocument.pdf")
        End Sub
    End Class
End Namespace
