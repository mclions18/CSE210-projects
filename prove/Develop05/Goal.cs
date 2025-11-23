using System;

public class Goal
{
    //attributes
    protected string _name;
    protected string _description;
    protected bool _done;
    protected int _pts;
    //behaviors
    public virtual void PromptNew()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("Please provide a brief description of your goal: ");
        _description = Console.ReadLine();
        Console.Write("What is the point value associated with completing this goal? ");
        _pts = int.Parse(Console.ReadLine());
    }
    public virtual string Stringify()
    {
        string stringified = _name + "|" + _description + "|" + _pts;
        return stringified;
    }
    public virtual int RecordEvent()
    {
        Console.WriteLine("\nThis code has to be broken, or you wouldn't be able to see this.\n");
        return 0;
    }
    public virtual void Display()
    {
        Console.WriteLine("\nYou shouldn't see this.\n");
    }
    public void LoadGoal(string n, string d, int p, bool b)
    {
        _name = n;
        _description = d;
        _pts = p;
        _done = b;
    }
    public virtual void LoadChecklistExtra(int tn, int td, int bp)
    {
        Console.WriteLine("\nWhy u see dis?\n");
    }
    public bool IsDone()
    {
        return _done;
    }
}