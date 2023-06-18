interface ReportVisitor
{
    void VisitPdfReport(ReportGenerator report);
    void VisitCsvReport(ReportGenerator report);
    void VisitExcelReport(ReportGenerator report);
}