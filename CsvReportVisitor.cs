class CsvReportVisitor : ReportVisitor
{
    public void VisitPdfReport(ReportGenerator report)
    {
        // Do nothing, this visitor does not support PDF reports
    }

    public void VisitCsvReport(ReportGenerator report)
    {
        Console.WriteLine("Generating CSV report...");
        // Generate a CSV report based on the report settings
    }

    public void VisitExcelReport(ReportGenerator report)
    {
        // Do nothing, this visitor does not support Excel reports
    }
}