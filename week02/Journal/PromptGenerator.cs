using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>()
        {
            "Write about one thing you are grateful for today.",
            "Describe a challenge and how you were able to overcome it.",
            "What is one thing that made you happy today?",
            "What is one goal you want to achieve this week?",
            "Describe something that inspired you recently."
        };
    }


    private static readonly Random _rng = new Random();

    public string GetRandomPrompt()
    {
        int index = _rng.Next(_prompts.Count);
        return _prompts[index];
    }
}
      


