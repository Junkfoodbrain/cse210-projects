public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine();
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine();
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }

     
}

