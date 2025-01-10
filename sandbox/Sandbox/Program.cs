using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        
        for (int i = 1; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        string name = "";
        Console.Write("Enter first name: ");
        name = Console.ReadLine();

        Console.WriteLine(name);
    }
}