class GoalManager
{
    private List<Goal> _goals;
    private int _totalPoints;

    public GoalManager() 
    { 
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Menu options:");
        Console.WriteLine("    1. Create New Goal");
        Console.WriteLine("    2. List Goals");
        Console.WriteLine("    3. Save Goals");
        Console.WriteLine("    4. Load Goals");
        Console.WriteLine("    5. Record Event");
        Console.WriteLine("    6. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void ListGoals()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{_goals.IndexOf(goal) + 1}. {goal.RenderText()}");
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_totalPoints);
            
            foreach (var goal in _goals)
            {
                writer.WriteLine($"{goal.GetType().Name}:{goal.Save()}");
            }
        }
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();
        string totalPointsString = File.ReadLines(filename).First();
        int totalPoints = int.Parse(totalPointsString);
        _totalPoints = totalPoints;
        
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split(":");

            string type = parts[0].Split('.').Last();
            string other = parts[1];

            string[] attributes = other.Split("|");

            string name = attributes[0];

            string desc = attributes[1];

            string isCompleteString = attributes[2];
            bool isComplete = bool.Parse(isCompleteString);

            string pointsString = attributes[3];
            int points = int.Parse(pointsString);

            switch (type)
            {
                case "SimpleGoal":
                    SimpleGoal simpleGoal = new SimpleGoal(name, desc, isComplete, points);
                    _goals.Add(simpleGoal);
                    break;

                case "EternalGoal":
                    EternalGoal eternalGoal = new EternalGoal(name, desc, isComplete, points);
                    _goals.Add(eternalGoal);
                    break;

                case "ChecklistGoal":
                    string requiredCompletionsString = attributes[4];
                    int requiredCompletions = int.Parse(requiredCompletionsString);

                    string actualCompletionsString = attributes[5];
                    int actualCompletions = int.Parse(actualCompletionsString);

                    string bonusPointsString = attributes[6];
                    int bonusPoints = int.Parse(bonusPointsString);

                    ChecklistGoal checklistGoal = new ChecklistGoal(name, desc, isComplete, points, requiredCompletions, actualCompletions, bonusPoints);
                    _goals.Add(checklistGoal);
                    break;
            }
        }
    }

    public void RecordEvent(int index)
    {
        _goals[index].MarkComplete();
        _totalPoints += _goals[index].GetPoints();
        Console.Clear();
        ListGoals();
    }
}