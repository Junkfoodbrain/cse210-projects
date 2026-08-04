using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _count;

    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity will help you reflect on good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>();

        _prompts.Add("Name some people in your life that you are grateful for.");
        _prompts.Add("What are some of your personal strengths?");
        _prompts.Add("Name some people that you have helped this week.");
        _prompts.Add("List some things that you would like to learn to do.");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();

        Console.WriteLine("When you are ready, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Get ready to begin... ");
        ShowCountDown(3);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        _count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                _count++;
            }
            
        }

        if (_count == 1)
        {
            Console.WriteLine("You listed 1 item.");
        }
        else
        {
            Console.WriteLine($"You listed {_count} items.");
        }
        
        DisplayEndingMessage();
    }
}