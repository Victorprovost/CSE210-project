
public class WriteAssignment : Assignment
{
    private string _title;
    public WriteAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        string _studentName = GetStudentName();

        return $"{_title} by {_studentName}"; 
    }

    private string GetStudentName()
    {
        throw new NotImplementedException();
    }
}