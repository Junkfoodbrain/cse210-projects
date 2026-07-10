using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        theJournal._entries = new List<Entry>();
        PromptGenerator promptGenerator = new PromptGenerator();
        Entry entry = new Entry();
        entry._date = DateTime.Now.ToString("yyyy-MM-dd");
        entry._promptText = promptGenerator.GetRandomPrompt();
        entry._entryText = "This is a sample journal entry.";
        theJournal.AddEntry(entry);
        theJournal.DisplayAll();
        theJournal.SaveToFile("journal.txt");
        theJournal.LoadFromFile("journal.txt");

        
        Console.WriteLine("Hello World! This is the Journal Project.");
    }
}