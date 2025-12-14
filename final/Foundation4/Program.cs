using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activityList = new List<Activity>();
        Activity running = new Running("13 Oct 2025",60,5);
        _activityList.Add(running);
        Activity cycling = new Cycling("14 October 2025",90,6);
        _activityList.Add(cycling);
        Activity swimming = new Swimming("15 October 2025",30,40);
        _activityList.Add(swimming);
        foreach (Activity a in _activityList)
        {
            a.GetSummary();
        }

    }
}