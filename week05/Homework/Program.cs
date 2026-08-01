using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("James Kirk", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Stuart Little", "Fractions", "1.3", "7-9");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Ron Weasley", "Accidental Magic", "A Journey into Sweet Surprises");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());

        
    }
}