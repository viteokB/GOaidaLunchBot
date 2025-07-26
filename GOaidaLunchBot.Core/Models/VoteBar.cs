namespace GOaidaLunchBot.Core.Models;

public class VoteBar
{
    public long Id { get; set; }
    
    public long GroupId { get; set; }

    public IReadOnlyCollection<long>? Votes { get; set; }

    public IReadOnlyCollection<Period>? Periods { get; set; }
    
    public DateTimeOffset CreatedTime { get; set; }
    
    public DateTimeOffset? UpdatedAt { get; set; }
}