public class Reflecting:Activity
{
    //attributes
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<int> _randomExcptions = new List<int>();
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    //behaviors
    public Reflecting()
    {
        _activityName = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    public override void RunActivity()
    {
        IncrementTimesDone();
        Random randomPrompt = new Random();
        int promptSelect = randomPrompt.Next(0, _prompts.Count - 1);
        Console.Write($"\n{_prompts[promptSelect]}: ");
        LoadIcon(9);
        for (float i = _duration / 10; i > 0; i--)
        {
            Random randomQuestion = new Random();
            int questionSelect = randomQuestion.Next(0, _questions.Count - 1);
            Console.Write($"\n{_questions[questionSelect]}: ");
            LoadIcon(9);
        }
    }
}