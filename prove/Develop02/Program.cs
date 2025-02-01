using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        Journal journal = new Journal();
        Entry entry = new Entry();
        do
        {
            // create menu for navigating
            Console.WriteLine("Welcome to the Journal Program!\n\nPlease select one of the following choices:\n\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n\nWhat would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                entry.Displayprompt(); // display the prompt
                entry.CreateEntry(); // create the entry
            }
            else if (choice == 2)
            {
                // display entries
                entry.DisplayEntry();
            }
            else if (choice == 3)
            {
                // load entries from a file
                journal.LoadJournalFile();
            }
            else if (choice == 4)
            {
                // save entries to a file
                journal.CreateJournalFile();
            }
            else if (choice == 5)
            {
                // quit the program
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a number between 1 and 5.");
            }
        } while (choice != 5);
    }
}