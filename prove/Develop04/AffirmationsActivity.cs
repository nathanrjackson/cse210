class AffirmationsActivity : Activity
{
    private List<string> _statements = new List<string> {
        "There are people who care for you.",
        "There are people who need you.",
        "You are loved.",
        "You are needed.",
        "You have a Heavenly Father who knows you personally.",
        "The Atonement of Jesus Christ will always apply to you.",
        "Your life is worth living."
    };
    
    public AffirmationsActivity()
    {
    }

    public AffirmationsActivity(string name, string desc, int duration)
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
        Console.WriteLine("Consider the following statements of affirmation:\n");
        Console.Clear();

        DateTime currentTime = DateTime.Now;
        DateTime finishTime = currentTime.AddSeconds(duration);

        while (currentTime < finishTime)
        {
            Console.Write($"> {GetRandomItem(_statements)} ");
            DisplayAnimation(5);
            Console.WriteLine();

            currentTime = DateTime.Now;
        }
        
        Console.WriteLine();
        DisplayConclusion(duration);
    }
}