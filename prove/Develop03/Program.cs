using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Moroni", 10, 4, 5);
        Scripture scripture = new Scripture("And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things.", reference);
        Stopwatch stopwatch = new Stopwatch();
        
        Console.Clear();
        Console.WriteLine(scripture);

        while (true)
        {
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            string user_input = Console.ReadLine();
            
            if (user_input.ToLower() == "quit")
            {
                Environment.Exit(0);
            }
            
            scripture.HideWords();
            Console.Clear();
            Console.WriteLine(scripture);

            if (scripture.AllWordsHidden())
            {
                break;
            }
        }
    }
}