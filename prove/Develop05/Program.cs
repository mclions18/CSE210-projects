using System;

// To exceed expectations I added in a load icon method that displays a countdown when creating goals and loading a file. I also added a level up tracker that gives you a level after a certain amount of times of doing a goal or progressing towards completing a checklist goal. Its dependant on your level, so as you level up, you need to complete even more goals to get to the next level.
class Program
{
    static void Main(string[] args)
    {
        GoalTracker tracker = new GoalTracker();
        tracker.DisplayMenu();
    }
}