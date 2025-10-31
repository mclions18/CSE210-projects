public class MathAssignment : Assignment
{
    //attributes
    private string _textbookSection;
    private string _problems;

    //behaviors
    public MathAssignment(string n, string t, string s, string p) : base(n, t)
    {
        _textbookSection = s;
        _problems = p;
    }
    public void GetHomeworkList()
    {
        Console.WriteLine($"Section {_textbookSection} Problems {_problems}");
    }

}