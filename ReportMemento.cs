class ReportMemento
{
    public string Format { get; set; }
    public List<string> Filters { get; set; }
    public string SortBy { get; set; }
    public bool Ascending { get; set; }
}