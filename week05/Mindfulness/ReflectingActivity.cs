public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    private List<string> _unusedQuestions;

    public ReflectingActivity()
        : base(
            "Reflecting Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>();
        _questions = new List<string>();

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("What did you learn from this experience?");
        _questions.Add("How did this experience make you feel?");
        _questions.Add("Would you ever do this again in the future?");
        _questions.Add("How was your life blessed from this experience?");
        _questions.Add("What aspect of your testimony was strengthened from this experience?");
        _questions.Add("Would sharing this with others be beneficial to them?");

        _unusedQuestions = new List<string>();

        foreach (string item in _questions)
        {
            _unusedQuestions.Add(item);
        }

        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you felt impressed to share the gospel.");
        _prompts.Add("Think of a time when you paid tithing, even when it was difficult.");
        _prompts.Add("Think of a time when you felt a prompting to help someone in need.");

    }

    public string GetRandomQuestion()
    {
        if (_unusedQuestions.Count == 0)
        {
            foreach (string item in _questions)
            {
                _unusedQuestions.Add(item);
            }
        }

        Random random = new Random();
        int index = random.Next(_unusedQuestions.Count);
        string promptQuestion = _unusedQuestions[index];
        _unusedQuestions.RemoveAt(index);

        return promptQuestion;
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
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now reflect upon the following questions:");
        Console.WriteLine("Get ready to reflect...");
        ShowCountDown(3);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"> {GetRandomQuestion()}");
            ShowSpinner(4);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}