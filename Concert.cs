public class Concert
{
    public int Id { get; set; }
    public bool ReducedVenue { get; set; }
    public DateTime Date { get; set; }
    public string Performer { get; set; } = string.Empty;
    public int BeginsAt { get; set; }
    public int FullCapacitySales { get; set; }
}
