# How to use the WPF chart rendering mechanism when printing or exporting a workbook to PDF


This example demonstrates how to use <strong>WPF</strong> charts when printing a <a href="https://documentation.devexpress.com/DocumentServer/DevExpress.Spreadsheet.Workbook.class">Workbook</a> containing embedded charts or exporting it to PDF in a <strong>WPF</strong> application.<br><br>To accomplish this task, add a reference to the <strong>DevExpress.Xpf.Spreadsheet.dll</strong> assembly and register the following services using the <a href="https://documentation.devexpress.com/DocumentServer/DevExpress.Spreadsheet.Workbook.ReplaceService~T~.method">Workbook.ReplaceService</a> method:<br> <strong>DevExpress.Xpf.Spreadsheet.Services.ChartControllerFactoryService</strong> <br><strong>DevExpress.XtraSpreadsheet.Services.Implementation.WpfChartImageService</strong> <br><br>To print the document or export it to PDF, use the <a href="https://documentation.devexpress.com/DocumentServer/DevExpress.Spreadsheet.Workbook.Print.overloads">Workbook.Print</a> or <a href="http://help.devexpress.com/#DocumentServer/DevExpressSpreadsheetWorkbook_ExportToPdftopic">Workbook.ExportToPdf</a>  method, respectively.<br><br>The<strong> Universal Subscription</strong> or an additional <strong>Office File API Subscription</strong> is required to use this example in production code. Please refer to the <a href="http://www.devexpress.com/Subscriptions/">DevExpress Subscription</a> page for pricing information.

<br/>


