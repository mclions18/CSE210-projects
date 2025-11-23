using System;

public class SimpleGoal : Goal
{
    //behaviors
    public override void PromptNew()
    {
        base.PromptNew();
    }
    public override string Stringify()
    {
        string stringified = typeof(SimpleGoal) + "|" + base.Stringify() + "|" + _done;
        return stringified;
    }
    public override int RecordEvent()
    {
        if (_done == false)
        {
            _done = true;
            return _pts;
        }
        else
        {
            Console.WriteLine("\nYou've already completed this goal!");
            return 0;
        }
    }
    public override void Display()
    {
        Console.WriteLine($"[{(_done ? "X" : " ")}] {_name} - {_description}");
    }
}