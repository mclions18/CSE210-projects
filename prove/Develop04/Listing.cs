public class Listing:Activity
{
    //attributes
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    //behaviors
    public Listing()
    {
        _activityName = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    public override void RunActivity()
    {
        IncrementTimesDone();
        Random randomPrompt = new Random();
        int promptSelect = randomPrompt.Next(0, _prompts.Count - 1);
        Console.WriteLine($"\n{_prompts[promptSelect]}");
        Console.Write("Please take 10 seconds to think about the prompt and then begin listing your responses\n");
        LoadIcon(9);
        StartTimer();
        while (!IsTimerDone())
        {
            Console.Write("- ");
            Console.ReadLine();
        }
    }
}