using System;
using System.Buffers.Binary;

public class ChecklistGoal : Goal
{
    //attributes
    private int _bonusPoints;
    private int _timesNeeded;
    private int _timesDone = 0;
    //behaviors
    public override void PromptNew()
    {
        base.PromptNew();
        Console.Write("How many times do you want to complete this goal? ");
        _timesNeeded = int.Parse(Console.ReadLine());
        Console.Write("How many bonus points should be awarded when all instances of this goal are completed? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }
    public override string Stringify()
    {
        string stringified = typeof(ChecklistGoal) + "|" + base.Stringify() + "|" + _done + "|" + _timesNeeded + "|" + _timesDone + "|" + _bonusPoints;
        return stringified;
    }
    public override int RecordEvent()
    {
        if (_done == false)
        {
            _timesDone += 1;
            if (_timesDone == _timesNeeded)
            {
                _done = true;
                Console.WriteLine($"\nYou've earned {_bonusPoints} bonus points!");
                return _pts + _bonusPoints;
            }
            else
            {
                return _pts;
            }
        }
        else
        {
            Console.WriteLine("\nYou've fully completed this goal already!");
            return 0;
        }
    }
    public override void Display()
    {
        Console.WriteLine($"[{(_done ? "X" : " ")}] {_name} - {_description} {_timesDone}/{_timesNeeded}");
    }
    public override void LoadChecklistExtra(int tn, int td, int bp)
    {
        _timesNeeded = tn;
        _timesDone = td;
        _bonusPoints = bp;
    }
}