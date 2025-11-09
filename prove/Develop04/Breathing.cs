public class Breathing:Activity
{
    //behaviors
    public Breathing()
    {
        _activityName = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public override void RunActivity()
    {
        IncrementTimesDone();
        Console.Write("Focus your breathing: ");
        LoadIcon(5);
        for (float i = _duration / 10; i > 0; i--)
        {
            Console.Write("\nBreathe in - ");
            LoadIcon(6);
            Console.Write("\nBreathe out - ");
            LoadIcon(4);
        }
        Console.Write("\nFinishing activity: ");
        LoadIcon(5);
    }
}