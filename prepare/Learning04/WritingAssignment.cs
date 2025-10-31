using System.Runtime.CompilerServices;

public class WritingAssignment : Assignment
{
    //attributes
    private string _title;

    //behaviors
    public WritingAssignment(string n, string t, string title) : base(n, t)
    {
        _title = title;
    }
    public void GetWritingInformation()
    {
        Console.WriteLine($"{_title} by {GetStudentName()}");
    }
}