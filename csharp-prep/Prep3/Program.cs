using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess the Magic Number:");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int guess = -1;
        int guessCount = 0;
        do
        {
            Console.WriteLine("Guess a number:");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
            guessCount++;
        } while (guess != magicNumber);
        Console.WriteLine($"It took you {guessCount} guesses to find the Magic Number!");
    }
}