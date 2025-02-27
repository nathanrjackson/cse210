class BreathingActivity : Activity
{
    public BreathingActivity()
    {
    }

    public BreathingActivity(string name, string desc, int duration)
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

        for (int i = duration / 10; i > 0; i--)
        {
            DisplayCountdown("Breath in...", 5);
            Console.WriteLine();
            DisplayCountdown("Now breath out...", 5);
            Console.WriteLine("\n");
        }

        DisplayConclusion(duration);
    }
}