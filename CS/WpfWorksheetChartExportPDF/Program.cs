using DevExpress.Spreadsheet;
using DevExpress.Xpf.Spreadsheet.Services;
using DevExpress.XtraSpreadsheet.Services;
using DevExpress.XtraSpreadsheet.Services.Implementation;
using System;

namespace WpfWorksheetChartExportPDF
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Workbook workbook = new Workbook();

            // Replace the default chart rendering mechanism with the WPF one.
            workbook.ReplaceService<IChartControllerFactoryService>(new ChartControllerFactoryService());
            workbook.ReplaceService<IChartImageService>(new WpfChartImageService());

            workbook.LoadDocument("Document.xlsx");
            workbook.ExportToPdf("ExportedDocument.pdf");

            System.Diagnostics.Process.Start("ExportedDocument.pdf");
        }
    }
}
