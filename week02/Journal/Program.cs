using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Journal theJournal = new Journal();
        theJournal._entries = new List<Entry>();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;
        while (running)
        {
            Console.WriteLine("Hello and welcome to the Journal program.");
            Console.WriteLine("Please choose one of the following options: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {

            }
            else if (choice == "2")
            {

            }
            else if (choice == "3")
            {

            }
            else if (choice == "4")
            {

            }
            else if (choice == "5")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Please try again, using an option from the list.");
            }

        }

        Console.WriteLine();
    }
}