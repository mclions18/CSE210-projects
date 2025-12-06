using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();
    public Video(string t, string a, int l)
    {
        _title = t;
        _author = a;
        _length = l;
    }
    public void Display()
    {
        Console.WriteLine($"Video Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Video Length (s): {_length}\n");
        foreach (Comment c in _comments)
        {
            c.Display();
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    public void AddComment(Comment c)
    {
        _comments.Add(c);
    }
}