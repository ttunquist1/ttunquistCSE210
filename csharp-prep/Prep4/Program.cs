using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // create a list of numbers and average and sum them
        List<int> numbers = new List<int>();
        int user_number = -1;
        int total_number = 0;
        int average_number = 0;


        while (user_number != 0){
            // get user input
            Console.WriteLine("Enter a number (or '0' to end): ");
            user_number = int.Parse(Console.ReadLine());

            if (user_number != 0){
                // Do the math stuff
                numbers.Add(user_number);
                total_number += user_number;
            }

        }

        average_number = total_number / numbers.Count;

        // print the results
        Console.WriteLine($"The sum is: {total_number}");
        Console.WriteLine($"The average is: {average_number}");
    }

}