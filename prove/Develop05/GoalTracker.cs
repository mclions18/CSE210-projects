using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;

public class GoalTracker
{
    //attributes
    private List<Goal> _goals = new List<Goal>();
    private int _totalPts = 0;
    private int _lvl = 1;
    private int _lvlUpTimesNeeded = 3;
    private int _lvlUpTimesDone = 0;
    //behaviors
    public void CreateNewGoal()
    {
        Console.WriteLine("\nGoal Types\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        Console.Write("What type of Goal do you want to Create? ");
        int goalSelection = int.Parse(Console.ReadLine());
        if (goalSelection == 1)
        {
            Goal goal = new SimpleGoal();
            goal.PromptNew();
            _goals.Add(goal);
            Console.Write("Creating Simple Goal - ");
            LoadIcon(3);
            Console.Clear();
            Console.WriteLine("Simple Goal Created!\n");
        }
        else if (goalSelection == 2)
        {
            Goal goal = new EternalGoal();
            goal.PromptNew();
            _goals.Add(goal);
            Console.Write("Creating Eternal Goal - ");
            LoadIcon(3);
            Console.Clear();
            Console.WriteLine("Eternal Goal Created!\n");
        }
        else if (goalSelection == 3)
        {
            Goal goal = new ChecklistGoal();
            goal.PromptNew();
            _goals.Add(goal);
            Console.Write("Creating Checklist Goal - ");
            LoadIcon(3);
            Console.Clear();
            Console.WriteLine("Checklist Goal Created!\n");
        }
        else
        {
            Console.WriteLine("\nInvalid selection, returning to main menu\n");
        }
    }
    public void ListGoals()
    {
        Console.WriteLine();
        int i = 1;
        foreach (Goal g in _goals)
        {
            Console.Write($"{i}. ");
            g.Display();
            i += 1;
        }
    }
    public void Save()
    {
        Console.Write("What is the file name?(.csv) ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_totalPts);
            writer.WriteLine(_lvl + "|" + _lvlUpTimesNeeded + "|" + _lvlUpTimesDone);
            foreach (Goal g in _goals)
            {
                writer.WriteLine(g.Stringify());
            }
        }
    }
    public void Load()
    {
        _goals = new List<Goal>();
        Console.Write("What is the file name?(.csv) ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _totalPts = int.Parse(lines[0]);
        string[] levelParts = lines[1].Split("|");
        _lvl = int.Parse(levelParts[0]);
        _lvlUpTimesNeeded = int.Parse(levelParts[1]);
        _lvlUpTimesDone = int.Parse(levelParts[2]);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string goalType = parts[0];
            if (goalType == "SimpleGoal")
            {
                Goal goal = new SimpleGoal();
                goal.LoadGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                Goal goal = new EternalGoal();
                goal.LoadGoal(parts[1], parts[2], int.Parse(parts[3]), false);
                _goals.Add(goal);
            }
            else if (goalType == "ChecklistGoal")
            {
                Goal goal = new ChecklistGoal();
                goal.LoadGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                goal.LoadChecklistExtra(int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]));
                _goals.Add(goal);
            }
        }
        Console.Write("Loading Goals ");
        LoadIcon(5);
    }
    public void Leveling()
    {
        _lvlUpTimesDone += 1;
        if (_lvlUpTimesDone == _lvlUpTimesNeeded)
        {
            _lvl += 1;
            _lvlUpTimesDone = 0;
            _lvlUpTimesNeeded = _lvl * 3;
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine();
        Console.WriteLine("Your goals are:");
        int i = 1;
        foreach (Goal g in _goals)
        {
            Console.Write($"{i}. ");
            g.Display();
            i += 1;
        }
        Console.Write("Which goal do you want to accomplish? ");
        int selection = int.Parse(Console.ReadLine());
        Goal selectedGoal = _goals[selection - 1];
        if (selectedGoal.IsDone())
        {
            return;
        }
        else
        {
            Leveling();
        }
        int _ptsToAdd = selectedGoal.RecordEvent();
        _totalPts += _ptsToAdd;
        Console.WriteLine($"\nYou gained {_ptsToAdd} points!\n");
    }

    public void LoadIcon(int duration)
    {
        Console.CursorVisible = false;
        int startLocation = Console.CursorLeft;
        for (int i = 0; i < duration; i++)
        {
            Console.SetCursorPosition(startLocation, Console.CursorTop);
            Console.Write(duration - i);
            Thread.Sleep(250);
            for (int p = 0; p < 3; p++)
            {
                Console.SetCursorPosition(startLocation + p + 1, Console.CursorTop);
                Console.Write('.');
                Thread.Sleep(250);
                Console.SetCursorPosition(startLocation + p + 1, Console.CursorTop);
                Console.Write(" ");
            }
        }
        Console.SetCursorPosition(startLocation, Console.CursorTop);
        Console.Write(" ");
        Console.CursorVisible = true;
    }
    public void DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine($"\nWelcome to the Goal Tracker!\n\nYou have {_totalPts} points.\n\nYou are level {_lvl} and have {_lvlUpTimesDone}/{_lvlUpTimesNeeded} completions towards the next level.\n");
            Console.WriteLine("1. Create a new Goal\n2. List your goals\n3. Save\n4. Load\n5. Record an Event\n6. Quit");
            Console.Write("What would you like to do? ");
            string selection = Console.ReadLine();
            if (selection == "1")
            {
                CreateNewGoal();
            }
            else if (selection == "2")
            {
                ListGoals();
            }
            else if (selection == "3")
            {
                Save();
            }
            else if (selection == "4")
            {
                Load();
            }
            else if (selection == "5")
            {
                RecordEvent();
            }
            else if (selection == "6")
            {
                Console.WriteLine("\nCome back soon!");
                break;
            }
            else
            {
                Console.WriteLine("\n Invalid selection, please try again...\n");
            }
        }
    }
}