class ReportGenerator
{
    private List<string> _dataSet;
    public string Format { get; private set; }

    public ReportGenerator(List<string> dataSet)
    {
        Console.WriteLine("ReportGenerator initialized.");
        _dataSet = dataSet;
    }

    public ReportMemento SaveState()
    {
        Console.WriteLine("Saving report state...");
        return new ReportMemento { Format = Format, Filters = new List<string>(), SortBy = "", Ascending = true };
    }

    public void RestoreState(ReportMemento memento)
    {
        Console.WriteLine("Restoring report state...");
        // Restore the state from the memento object
    }

    public void SetFormat(string format)
    {
        Console.WriteLine($"Setting report format to: {format}");
        // Set the format for the report
        Format = format;
    }

    public void AddFilter(string filter)
    {
        Console.WriteLine($"Adding filter to report: {filter}");
        // Add a filter to the report
    }

    public void SetSortBy(string sortBy, bool ascending)
    {
        Console.WriteLine($"Setting sort criteria to: {sortBy}, ascending: {ascending}");
        // Set the sorting criteria for the report
    }

    public void GenerateReport(ReportVisitor visitor)
    {
        Console.WriteLine("Generating report...");
        // Visit the visitor object based on the format of the report
    }
}