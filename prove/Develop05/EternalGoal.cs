using System;
using System.Reflection.Metadata;

public class EternalGoal : Goal
{
    //behaviors
    public override void PromptNew()
    {
        base.PromptNew();
    }
    public override string Stringify()
    {
        string stringified = typeof(EternalGoal) + "|" + base.Stringify();
        return stringified;
    }
    public override int RecordEvent()
    {
        return _pts;
    }
    public override void Display()
    {
        Console.WriteLine($"[ ] {_name} - {_description}");
    }
}