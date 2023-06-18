class ExcelReportVisitor : ReportVisitor
{
    public void VisitPdfReport(ReportGenerator report)
    {
        // Do nothing, this visitor does not support PDF reports
    }

    public void VisitCsvReport(ReportGenerator report)
    {
        // Do nothing, this visitor does not support CSV reports
    }

    public void VisitExcelReport(ReportGenerator report)
    {
        Console.WriteLine("Generating Excel report...");
        // Generate an Excel report based on the report settings
    }
}