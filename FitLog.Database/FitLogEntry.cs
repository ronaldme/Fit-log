using FitLog.Core;

namespace FitLog.Database;

public class FitLogEntry
{
    public int Id { get; set; }
    public DateTimeOffset Date { get; set; }
    public required string Workout { get; set; }
    public WorkoutType WorkoutType { get; set; }

    public int? Distance { get; set; }
    public string? Remark { get; set; }
}