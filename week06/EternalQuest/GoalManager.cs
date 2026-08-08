using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine($"You currently have {_score} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice == "6")
            {
                isRunning = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select from the menu options.");
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("Give a short description of your goal: ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (goalType == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (goalType == "3")
        {
            Console.Write("How many times should you accomplish this goal to earn a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Invalid goal type selected. Goal cannot be created.");
            return;
        }
        Console.WriteLine("Goal created successfully.");
    }

    private void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }

        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }       
    }

    private void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        List<string> lines = new List<string>();
        lines.Add(_score.ToString());

        foreach (Goal goal in _goals)
        {
            lines.Add(goal.GetStringRepresentation());
        }

        File.WriteAllLines(fileName, lines);
        Console.WriteLine("Goals saved successfully.");
    }

    private void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(fileName);

        if (lines.Length == 0)
        {
            Console.WriteLine("File is empty.");
            return;
        }

        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];

            if (line.StartsWith("SimpleGoal:"))
            {
                string data = line.Substring("SimpleGoal:".Length);
                string[] parts = data.Split(',');

                string name = parts[0];
                string description = parts[1];
                int points = int.Parse(parts[2]);
                bool isComplete = bool.Parse(parts[3]);

                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);

                if (isComplete)
                {
                    simpleGoal.RecordEvent();
                }

                _goals.Add(simpleGoal);
                
            }
            else if (line.StartsWith("EternalGoal:"))
            {
                string data = line.Substring("EternalGoal:".Length);
                string[] parts = data.Split(',');

                string name = parts[0];
                string description = parts[1];
                int points = int.Parse(parts[2]);

                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);

            }
            else if (line.StartsWith("ChecklistGoal:"))
            {
                string data = line.Substring("ChecklistGoal:".Length);
                string[] parts = data.Split(',');

                string name = parts[0];
                string description = parts[1];
                int points = int.Parse(parts[2]);
                int bonus = int.Parse(parts[3]);
                int target = int.Parse(parts[4]);
                int amountCompleted = int.Parse(parts[5]);

                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);

                for (int j = 0; j < amountCompleted; j++)
                {
                    checklistGoal.RecordEvent();
                }

                _goals.Add(checklistGoal);
            }
        }
        
    }
    
    private void RecordEvent()

    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available to record.");
            return;
        }

        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }

        Console.Write("Which goal did you accomplish?");
        int goalNumber = int.Parse(Console.ReadLine());

        if (goalNumber < 1 || goalNumber > _goals.Count)
        {
            Console.WriteLine("Invalid Goal number.");
            return;
        }

        int pointsEarned = _goals[goalNumber - 1].RecordEvent();
        _score += pointsEarned;

        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
    }
}
