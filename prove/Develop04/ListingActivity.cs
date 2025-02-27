class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _responses = new List<string>();
    
    public ListingActivity()
    {
    }

    public ListingActivity(string name, string desc, int duration)
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

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"-- {GetRandomItem(_prompts)} --");
        DisplayCountdown("You may begin in: ", 5);
        Console.WriteLine();

        DateTime currentTime = DateTime.Now;
        DateTime finishTime = currentTime.AddSeconds(duration);

        while (currentTime < finishTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            _responses.Add(response);
            currentTime = DateTime.Now;
        }

        Console.WriteLine($"You listed {_responses.Count} items!\n");

        DisplayConclusion(duration);
    }
}