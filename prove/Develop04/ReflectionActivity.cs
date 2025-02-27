class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string> {
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

    public ReflectionActivity()
    {
    }

    public ReflectionActivity(string name, string desc, int duration)
        : base(name, desc, duration)
    {
    }

    public void DoActivity()
    {
        DisplayIntro();
        PromptDuration();
        int duration = GetDuration();
        Console.Clear();
        
        DisplayGetReady();
        DisplayAnimation(5);
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"-- {GetRandomItem(_prompts)} --\n");
        Console.Write("When you have something in mind, press enter to continue.\n");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        DisplayCountdown("You may begin in: ", 5);
        Console.Clear();

        DateTime currentTime = DateTime.Now;
        DateTime finishTime = currentTime.AddSeconds(duration);

        while (currentTime < finishTime)
        {
            Console.Write($"> {GetRandomItem(_questions)} ");
            DisplayAnimation(5);
            Console.WriteLine();

            currentTime = DateTime.Now;
        }
        
        Console.WriteLine();
        DisplayConclusion(duration);
    }
}