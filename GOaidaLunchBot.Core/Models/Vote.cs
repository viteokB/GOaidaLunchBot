namespace GOaidaLunchBot.Core.Models;

public class Vote
{
    public long Id { get; set; }
    
    public required User User { get; set; }
    
    public required VoteBar VoteBar { get; set; }
    
    public required Period Period { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    
    public DateTimeOffset? UpdatedAt { get; set; }
}