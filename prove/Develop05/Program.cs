class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        Console.Clear();
        
        while (true)
        {
            Console.WriteLine($"\nYou have {goalManager.GetTotalPoints()} points");

            if (goalManager.GetTotalPoints() >= 1000)
            {
                Console.WriteLine("Level 1");
            }
            else if (goalManager.GetTotalPoints() >= 2500)
            {
                Console.WriteLine("Level 2");
            }
            else if (goalManager.GetTotalPoints() >= 5000)
            {
                Console.WriteLine("Level 3");
            }
            else if (goalManager.GetTotalPoints() >= 10000)
            {
                Console.WriteLine("Level 4");
                Console.WriteLine("You made it!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Level 0");
            }

            Console.WriteLine();
            goalManager.DisplayMenu();
            string choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("The types of goals are:");
                    Console.WriteLine("    1. Simple Goal");
                    Console.WriteLine("    2. Eternal Goal");
                    Console.WriteLine("    3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    string input = Console.ReadLine();
                    Console.Clear();

                    switch (input)
                    {
                        case "1":
                            Console.Write("Goal name: ");
                            string name = Console.ReadLine();
                            
                            Console.Write("Goal description: ");
                            string desc = Console.ReadLine();
                            
                            Console.Write("Point value: ");
                            string pointsString = Console.ReadLine();
                            int points = int.Parse(pointsString);
                            
                            SimpleGoal simpleGoal = new SimpleGoal(name, desc, false, points);
                            goalManager.AddGoal(simpleGoal);

                            Console.WriteLine("Goal added!");
                            break;

                        case "2":
                            Console.Write("Goal name: ");
                            name = Console.ReadLine();

                            Console.Write("Goal description: ");
                            desc = Console.ReadLine();

                            Console.Write("Point value: ");
                            pointsString = Console.ReadLine();
                            points = int.Parse(pointsString);

                            EternalGoal eternalGoal = new EternalGoal(name, desc, false, points);
                            goalManager.AddGoal(eternalGoal);

                            Console.WriteLine("Goal added!");
                            break;

                        case "3":
                            Console.Write("Goal name: ");
                            name = Console.ReadLine();

                            Console.Write("Goal description: ");
                            desc = Console.ReadLine();

                            Console.Write("Point value: ");
                            pointsString = Console.ReadLine();
                            points = int.Parse(pointsString);

                            Console.Write("Required completions: ");
                            string requiredCompletionsString = Console.ReadLine();
                            int requiredCompletions = int.Parse(requiredCompletionsString);

                            Console.Write("Bonus point value: ");
                            string bonusPointsString = Console.ReadLine();
                            int bonusPoints = int.Parse(bonusPointsString);

                            ChecklistGoal checklistGoal = new ChecklistGoal(name, desc, false, points, requiredCompletions, 0, bonusPoints);
                            goalManager.AddGoal(checklistGoal);

                            Console.WriteLine("Goal added!");
                            break;
                    }
                    break;

                case "2":
                    goalManager.ListGoals();
                    break;

                case "3":
                    Console.Write("Enter filename: ");
                    string filename = Console.ReadLine();
                    goalManager.SaveGoals(filename);

                    Console.WriteLine("Goals saved!");
                    break;

                case "4":
                    Console.Write("Enter filename: ");
                    filename = Console.ReadLine();
                    goalManager.LoadGoals(filename);

                    Console.WriteLine("Goals loaded!");
                    break;

                case "5":
                    goalManager.ListGoals();
                    Console.Write("Which goal did you complete? ");
                    string indexString = Console.ReadLine();
                    int index = int.Parse(indexString);
                    goalManager.RecordEvent(index - 1);
                    break;

                case "6":
                    Environment.Exit(0);
                    break;
            }        
        }
    }
}