class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        ChoiceHandler choiceHandler = new ChoiceHandler();
        PromptManager promptManager = new PromptManager();
        Journal myJournal = new Journal();

        bool isRunning = true;
        
        Console.WriteLine("Welcome to the Journal Program!");

        while (isRunning)
        {
            menu.Display();
            string userChoice = choiceHandler.GetChoice();

            switch (userChoice)
            {
                case "1":
                    Console.Write("Enter date: ");
                    string date = Console.ReadLine();

                    string prompt = promptManager.GenerateRandomPrompt();
                    Console.Write(prompt + " ");
                    string text = Console.ReadLine();

                    Console.Write("Did you read in the Book of Mormon today? ");
                    string readBom = Console.ReadLine();

                    Entry newEntry = new Entry(date, prompt, text, readBom);
                    myJournal.AddEntry(newEntry);

                    Console.WriteLine("Entry added successfully.\n");

                    if (readBom.ToLower() == "no")
                    {
                        Console.WriteLine("\"With frightening speed, a testimony that is not nourished daily “by the good word of God”20 can crumble. Thus, the antidote to Satan’s scheme is clear: we need daily experiences worshipping the Lord and studying His gospel.\"");
                        Console.WriteLine("- Russell M. Nelson\n");
                    }

                    break;

                case "2":
                    Console.WriteLine("\nJournal Entries:");
                    myJournal.Display();
                    Console.WriteLine(" ");

                    break;

                case "3":
                    myJournal.Save();
                    Console.WriteLine("Journal saved.\n");

                    break;

                case "4":
                    myJournal.Load();
                    Console.WriteLine("\nLoaded entries:");
                    myJournal.Display();
                    Console.WriteLine(" ");

                    break;

                case "5":
                    Console.WriteLine("\nGoodbye!");
                    isRunning = false;
                    break;
            }
        }
    }
}