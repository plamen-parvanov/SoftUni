public class Message
{
    private string content;
    private User sender;

    public Message(string content, User sender)
    {
        this.content = content;
        this.sender = sender;
    }

    public string Content
    {
        get { return this.content; }
    }

    public User Sender
    {
        get { return this.sender; }
    }
}