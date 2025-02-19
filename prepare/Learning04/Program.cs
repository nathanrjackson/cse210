using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        
        Assignment a1 = new Assignment("Nathan Jackson", "Programming");
        Console.WriteLine(a1.GetSummary());

        Console.WriteLine();

        MathAssignment a2 = new MathAssignment("Brother Comeau", "Addition Class", "10.0", "1-100");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment a3 = new WritingAssignment("Russell Russell", "Christian History", "Why the Restoration?");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());

        Console.WriteLine();
    }
}