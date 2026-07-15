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

            //write
            if (choice == "1")
            {
                Entry entry = new Entry();
                entry._date = DateTime.Now.ToString("yyyy-MM-dd");
                entry._promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {entry._promptText}");
                Console.Write("Your response: ");
                entry._entryText = Console.ReadLine();
                theJournal.AddEntry(entry);
                Console.WriteLine("Entry added.");
            }
            //display
            else if (choice == "2")
            {
                theJournal.DisplayAll();
            }
            //load
            else if (choice == "3")
            {
                Console.Write("Filename to load: ");
                string loadFile = Console.ReadLine();
                theJournal.LoadFromFile(loadFile);
                Console.WriteLine("Journal loaded. ");
            }
            //save
            else if (choice == "4")
            {
                Console.Write("Filename to save: ");
                string saveFile = Console.ReadLine();
                theJournal.SaveToFile(saveFile);
                Console.WriteLine("Journal saved.");
            }
            //end loop/quit
            else if (choice == "5")
            {
                running = false;
            }
            //if anything other than the given options is entered. Prompts user to try again.
            else
            {
                Console.WriteLine("Please try again, using an option from the list.");
            }

            //write a blank line before the menu repeats. Gives the user a visual break.
            Console.WriteLine();
        }        
    }
}