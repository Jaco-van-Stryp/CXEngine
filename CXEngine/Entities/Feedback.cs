namespace CXEngine;

public class Feedback
{
    public int Id { get; set; }
    public string ReceivedBy { get; set; }
    public string FeedbackType { get; set; }
    public string FeedbackJSON { get; set; }

    public int UserId { get; set; }
    public User user { get; set; }
}
