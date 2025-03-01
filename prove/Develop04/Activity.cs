class Activity
{
    private string _name;
    private string _desc;
    private int _duration;

    public Activity()
    {
        _name = "";
        _desc = "";
        _duration = 0;
    }

    public Activity(string name, string desc, int duration)
    {
        _name = name;
        _desc = desc;
        _duration = duration;
    }

    public void DisplayIntro()
    {
        Console.WriteLine($"Welcome to the {_name}!\n");
        Console.WriteLine($"{_desc}\n");
    }

    public void PromptDuration()
    {
        Console.Write("Input activity duration (seconds): ");
        string durationString = Console.ReadLine();
        int duration = int.Parse(durationString);
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayGetReady()
    {
        Console.WriteLine("Get ready...");
    }

    public void DisplayAnimation(int seconds)
    {
        DateTime currentTime = DateTime.Now;
        DateTime finishTime = currentTime.AddSeconds(seconds);
        
        while (currentTime < finishTime)
        {
            Console.Write("|");
            Thread.Sleep(100);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(100);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(100);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(100);
            Console.Write("\b \b");

            Console.Write("|");
            Thread.Sleep(100);
            Console.Write("\b \b");

            currentTime = DateTime.Now;
        }
    }

    public void DisplayCountdown(string text, int start)
    {
        Console.Write(text);
        for (int i = start; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void DisplayConclusion(int duration)
    {
        Console.WriteLine("Well done!");
        DisplayAnimation(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed {duration} seconds of the {_name}.");
        DisplayAnimation(3);
    }

    public string GetRandomItem(List<string> items)
    {
        Random random = new Random();
        int randomIndex = random.Next(items.Count);
        string randomItem = items[randomIndex];
        return randomItem;
    }

}