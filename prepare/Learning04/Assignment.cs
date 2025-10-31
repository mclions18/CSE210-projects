public class Assignment
{
    //attributes
    private string _name;
    private string _topic;

    //behaviors
    public Assignment(string n, string t)
    {
        _name = n;
        _topic = t;
    }
    public void GetSummary()
    {
        Console.WriteLine(_name + " - " + _topic);
    }
    public string GetStudentName()
    {
        return _name;
    }
    public string GetTopic()
    {
        return _topic;
    }
}