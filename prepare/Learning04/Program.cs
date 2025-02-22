using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a base "Assignment" object
        Assignment student1 = new Assignment("Tom Tunquist", "Algedra 3");
        Console.WriteLine(student1.GetSummary());

        // Now create the derived class assignments
        Math student2 = new Math("Eduardo Perillo", "Trigonometry", "3.3", "3-7");
        Console.WriteLine(student2.GetSummary());
        Console.WriteLine(student2.GetHomeworkList());

        Writing student3 = new Writing("Jace Gorze", "Financial Analysis", "Professional in Finance");
        Console.WriteLine(student3.GetSummary());
        Console.WriteLine(student3.GetWritingInformation());
    }
}