using System.Collections.Generic;

public class Exercise
{
    private string topic;
    private string courseName;
    private string judgeContestLink;
    private string[] problems;

    public Exercise(string topic, string courseName, string judgeContestLink, string[] problems)
    {
        this.topic = topic;
        this.courseName = courseName;
        this.judgeContestLink = judgeContestLink;
        this.problems = problems;
    }

    public string Topic
    {
        get { return this.topic; }
    }
    public string CourseName
    {
        get { return this.courseName; }
    }
    public string JudgeContestLink
    {
        get { return this.judgeContestLink; }
    }
    public string[] Problems
    {
        get { return this.problems; }
    }

}

