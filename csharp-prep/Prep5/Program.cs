using System;

class Program
{
    static void Main(string[] args)
    {
        greetUser();

        // take user input
        string name = promptName();
        int number = promptNumber();

        int square = squareNumber(number);

        // display result
        displayResult(name, square);
    }

    // Create functions

    static void greetUser()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string promptName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int promptNumber()
    {
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int squareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void displayResult(string name, int square)
    {
        Console.WriteLine($"Hello {name}, your favorite number squared is {square}!");
    }

}