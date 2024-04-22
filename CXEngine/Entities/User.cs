namespace CXEngine;

public class User
{
    public int Id { get; set; }
    public string RealName { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
    public DateTime DateRegistered { get; set; } = DateTime.UtcNow;
    public List<Feedback> FeedbackReceived { get; set; }
    public List<WorkItem> WorkItems { get; set; }

    public int GroupID { get; set; }
    public Group Group { get; set; }

}
