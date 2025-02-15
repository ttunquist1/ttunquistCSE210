using System;

class Program
{
    static void Main(string[] args)
    {
        // perform full code
        Scripture scripture = new Scripture(new Reference("Almla", 18, 27, 27), "27 And he said, Yea.");
        Console.Clear();
            scripture.Display(); 
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;

                scripture.Hide(3);

                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            }
        
    }
}