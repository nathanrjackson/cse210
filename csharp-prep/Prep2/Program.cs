using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter grade percentage: ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);
        int secondDigit = gradePercentage % 10;

        string gradeModifier = "";

        if (secondDigit >= 7)
        {
            gradeModifier = "+";
        }
        else if (secondDigit < 3)
        {
            gradeModifier = "-";
        }

        string letterGrade = "";

        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else if (gradePercentage < 60)
        {
            letterGrade = "F";
        }

        if (!(gradeModifier == "") && letterGrade != "A" && letterGrade != "F")
        {
            Console.WriteLine($"Letter grade: {letterGrade}{gradeModifier}");
        }
        else if (letterGrade == "A")
        {
            if (gradeModifier == "+") {
                Console.WriteLine($"Letter grade: {letterGrade}");
            }
            else
            {
                Console.WriteLine($"Letter grade: {letterGrade}{gradeModifier}");
            }
        }
        
        else
        {
            Console.WriteLine($"Letter grade: {letterGrade}");
        }
    }
}