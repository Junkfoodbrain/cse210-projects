

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
        Console.WriteLine();

    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Congratulations! You have completed {_duration} seconds of the {_name}.");
    }
    public void ShowSpinner(int seconds)
    {

    }
    public void ShowCountDown(int seconds)
    {

    }

}