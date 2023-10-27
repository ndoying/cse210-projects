using System;

class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string title, string name, string topic) : base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}