using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a guess the number game
        bool running = true;
        List<int> guesses = new List<int>();
        int magicNumber = new Random().Next(1, 101);

        while (running)
        {
            Console.WriteLine("\nWhat is your guess? "); 
            int guess = int.Parse(Console.ReadLine());

            // Add guess to a list for tracking
            
            guesses.Add(guess);

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                running = false;
            }
        }

        // Tell User how many guesses they took
        Console.WriteLine($"\nYou took {guesses.Count} guesses.");

        // Do they want to play again?
        Console.WriteLine("\nWould you like to play again? (y/n)");
        string playAgain = Console.ReadLine();
        if (playAgain == "y")
        {
            // Play again
            Main(args);
        }
        
    }
}