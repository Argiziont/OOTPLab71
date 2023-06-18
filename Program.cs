using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting the program...");
        List<string> dataSet = new List<string>(); // Populate the dataset with data
        ReportGenerator report = new ReportGenerator(dataSet);
        report.SetFormat("PDF");
        report.AddFilter("Some Filter");
        report.SetSortBy("Some Column", true);

        PdfReportVisitor pdfVisitor = new PdfReportVisitor();
        CsvReportVisitor csvVisitor = new CsvReportVisitor();
        ExcelReportVisitor excelVisitor = new ExcelReportVisitor();

        if (report.Format == "PDF")
        {
            report.GenerateReport(pdfVisitor);
        }
        if (report.Format == "CSV")
        {
            report.GenerateReport(csvVisitor);
        }
        if (report.Format == "Excel")
        {
            report.GenerateReport(excelVisitor);
        }

        Console.WriteLine("End of program.");
    }
}
