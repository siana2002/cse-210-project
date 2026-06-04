using System;

public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment()
    {
        _studentName = "Samuel Bennett";
        _topic = "Multiplication";
    }

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetSummary()
    {
        string summary = $"Student Name: {_studentName} - Topic: {_topic}";
        return summary;
    }
}