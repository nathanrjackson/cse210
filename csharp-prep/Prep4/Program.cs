using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string numberString = Console.ReadLine();
            number = int.Parse(numberString);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;
        int largest = 0;
        int smallestPositive = 9999;

        foreach (int num in numbers)
        {
            sum += num;

            if (num > largest)
            {
                largest = num;
            }

            if (num > 0)
            {
                if (num < smallestPositive)
                {
                    smallestPositive = num;
                }
            }
        }

        int average = sum / numbers.Count();
        numbers.Sort();

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {largest}");
        Console.WriteLine($"The smallest positive number {smallestPositive}");
        Console.WriteLine("This is the sorted list:");

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}