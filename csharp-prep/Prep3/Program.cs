using System;

class Program
{
    static void Main()
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guessCount = 0;
        int guess = -1;
        while (guess != magicNumber) 
        {    
            Console.Write("What is your guess? ");
            string guessString = Console.ReadLine();
            guess = int.Parse(guessString);

            if (guess > magicNumber)
            {
                Console.WriteLine("Too high!");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Too low!");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
            guessCount++;
        }    
       
        Console.WriteLine($"Guess count: {guessCount}");

        Console.Write("Would you like to play again? ");
        string playAgain = Console.ReadLine();

        if (playAgain.ToLower() == "yes")
        {
            Main();
        }
    }
}