using System.Collections.Generic;

public class User
{
    private string username;
    private List<Message> receivedMessages;

    public User(string username)
    {
        this.username = username;

        if (this.receivedMessages == null)
        {
            this.receivedMessages = new List<Message>();
        }
    }

    public string Username
    {
        get { return this.username; }
    }

    public List<Message> ReceivedMessages
    {
        get { return this.receivedMessages; }
    }

    public void AddMsg(User sender, string msg)
    {
        this.receivedMessages.Add(new Message(msg, sender));
    }
}