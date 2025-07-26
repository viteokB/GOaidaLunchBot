namespace GOaidaLunchBot.Core.Models;

public class GroupVoteSettings
{
    public long Id { get; set; }
    
    public required string ScheduleString { get; set; }
    
    public required IReadOnlyCollection<Period>? LunchPeriods { get; set; }
}