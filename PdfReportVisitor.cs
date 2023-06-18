class PdfReportVisitor : ReportVisitor
{
    public void VisitPdfReport(ReportGenerator report)
    {
        Console.WriteLine("Generating PDF report...");
        // Generate a PDF report based on the report settings
    }

    public void VisitCsvReport(ReportGenerator report)
    {
        // Do nothing, this visitor does not support CSV reports
    }

    public void VisitExcelReport(ReportGenerator report)
    {
        // Do nothing, this visitor does not support Excel reports
    }
}