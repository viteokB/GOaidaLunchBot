namespace GOaidaLunchBot.Core.Models;

public class User
{
    /// <summary>
    /// User Telegram id
    /// </summary>
    public long Id { get; set; }
    
    /// <summary>
    /// Telegram Username
    /// </summary>
    public required string Username { get; set; }

    public string FirstName { get; set; } = null!;
    
    public string LastName { get; set; } = null!;
    
    public IReadOnlyList<Group>? Groups { get; set; }

    public bool IsPublic { get; set; }
    
    public bool Consent { get; set; }
    
    public DateTimeOffset Created { get; set; }
    
    public DateTimeOffset? UpdatedAt { get; set; }
}