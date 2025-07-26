namespace GOaidaLunchBot.Core.Models;

public class Group
{
    public long Id { get; set; }

    public IReadOnlyCollection<User>? GroupAdmins { get; set; } = null!;

    public IReadOnlyCollection<User>? GroupUsers { get; set; } = null!;
    
    public required string GroupName { get; set; }
    
    public bool IsPublic { get; set; }
    
    public DateTime CreationDate { get; set; }
    
    public DateTime? UpdatedAt { get; set; }
}