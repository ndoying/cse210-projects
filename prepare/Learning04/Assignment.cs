using System;

public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    protected string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        string _summary = $"{_studentName} - {_topic}";
        return _summary;
    }

}