using System.ComponentModel;
public class Activity
{
    //attributes
    protected float _duration;
    protected string _activityName;
    protected string _description;
    private DateTime _startTimeStamp;
    private int _timesDone = 0;
    //behaviors
    private bool DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"\nWelcome to the {_activityName} activity!\n\n{_description}");
        try
        {
            Console.Write("\nWhat is the duration of the activity? (Please enter a duration in increments of 30 seconds): ");
            _duration = int.Parse(Console.ReadLine());
            return true;
        }
        catch (Exception)
        {
            Console.WriteLine("\nAn invalid value was inputted. Returning to main menu.");
            return false;
        } 
    }
    private void DisplayEndMessage()
    {
        Console.WriteLine($"\nThank you for doing the {_activityName} activity! You have completed this activity {_timesDone} times. Please come back often for more rest and relaxation.");
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
    public virtual void RunActivity()
    {
        Console.WriteLine("\nNormally an activity would display here, but you must've done something wrong. Sorry!!\n");
    }
    public void Start()
    {
        if (DisplayStartMessage() == false)
        {
            return;
        }
        else
        {
            RunActivity();
            DisplayEndMessage();
        }
    }
    public void StartTimer()
    {
        _startTimeStamp = DateTime.Now;
    }
    public bool IsTimerDone()
    {
        DateTime currentTime = DateTime.Now;
        if (currentTime >= _startTimeStamp + TimeSpan.FromSeconds(_duration))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void SaveTimesDone()
    {
        using (StreamWriter writer = new StreamWriter(_activityName + ".csv", false))
        {
            writer.WriteLine(_timesDone);
        }
    }
    public int LoadTimesDone()
    {
        using (StreamReader reader = new StreamReader(_activityName + ".csv"))
            return _timesDone = int.Parse(reader.ReadLine());
    }
    public void IncrementTimesDone()
    {
        LoadTimesDone();
        _timesDone += 1;
        SaveTimesDone();
    }
}