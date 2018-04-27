using System.Collections.Generic;

public class Website
{
    private string host;
    private string domain;
    private string[] queries;

    public Website(string host, string domain, params string[] queries)
    {
        this.host = host;
        this.domain = domain;
        this.queries = queries;     
    }

    public string Host
    {
        get { return this.host; }
    }
    public string Domain
    {
        get { return this.domain; }
    }
    public string[] Queries
    {
        get { return this.queries; }
    }
}

