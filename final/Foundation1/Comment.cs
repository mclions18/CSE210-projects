public class Comment
{
    private string _commenter;
    private string _text;
    public Comment(string c, string t)
    {
        _commenter = c;
        _text = t;
    }
    public void Display()
    {
        Console.WriteLine($"{_commenter}:\n\t{_text}");
    }
}