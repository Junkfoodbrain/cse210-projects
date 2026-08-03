using System;

using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Threading;
using System.Xml.Serialization;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        string choice = "";
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Starting listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {                
                Console.WriteLine("Invalid choice. Press Enter to continue.");
                Console.ReadLine();
                
            }

        }




        // List<string> animationStrings = new List<string>();
        // animationStrings.Add("|");
        // animationStrings.Add("/");
        // animationStrings.Add("-");
        // animationStrings.Add("\\");
        // animationStrings.Add("|");
        // animationStrings.Add("-");
        // animationStrings.Add("/");
        // animationStrings.Add("-");
        // animationStrings.Add("\\");

        // DateTime startTime = DateTime.Now;
        // DateTime endTime = startTime.AddSeconds(10);

        // int i = 0;

        // while (DateTime.Now < endTime)
        // {
        //     string s = animationStrings[i];
        //     Console.Write(s);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");

        //     i++;

        //     if (i >= animationStrings.Count)
        //     {
        //         i = 0;
        //     }
        // }


        // Console.WriteLine("Done.");
    }
}