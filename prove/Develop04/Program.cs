using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            // Menu for user interaction
            Console.WriteLine("Hello, Welcome to the Mindfulness Activity Program!");
            Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");
            Console.Write("Enter the number of the activity: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (choice == 1)
            {
                Breathing breathing = new Breathing("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 30);
                breathing.InteractBreathing();
            }
            else if (choice == 2)
            {
                Reflection reflection = new Reflection("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 30);
                reflection.InteractReflection();
            }
            else if (choice == 3)
            {
                Listing listing = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 15);
                listing.InteractListing();
            }
            else if (choice == 4)
            {
                Console.WriteLine("Goodbye!");
                running = false;
            }
        }
        
        



    }
}