using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        Menu menu = new Menu();
        Choice choiceHandler = new Choice();
        Prompt prompt = new Prompt();

        bool isRunning = true;

        while (isRunning)
        {
            menu.Display();
            string choice = choiceHandler.GetChoice();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the date (YYYY-MM-DD): ");
                    string date = Console.ReadLine();
                    prompt.Display();
                    Console.Write("Enter your response: ");
                    string text = Console.ReadLine();

                    Entry newEntry = new Entry(date, text);
                    myJournal.AddEntry(newEntry);

                    Console.WriteLine("Entry added successfully!\n");
                    break;

                case "2":
                    Console.WriteLine("\nYour Journal Entries:");
                    myJournal.DisplayEntries();
                    break;

                case "3":
                    isRunning = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.\n");
                    break;
            }
        }
    }
}

class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in the journal.");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
    }
}

class Entry
{
    public string _date;
    public string _entryText;

    public Entry(string date, string entryText)
    {
        _date = date;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"{_date} - {_entryText}");
    }
}

class Menu
{
    public void Display()
    {
        Console.WriteLine("1. Add entry");
        Console.WriteLine("2. Display entries");
        Console.WriteLine("3. Quit");
    }
}

class Choice
{
    public string GetChoice()
    {
        Console.Write("Enter your choice: ");
        return Console.ReadLine();
    }
}

class Prompt
{
    public void Display()
    {
        Console.WriteLine("What was one exciting thing you did today?");
    }
}