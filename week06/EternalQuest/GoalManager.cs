using System;

public class GoalManager
{
    private List<Goals> _goals;
    private int _score;
    
    public GoalManager()
    {
        _goals = new List<Goals>();
        _score = 0;
    }

    public void Start()
    {
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine();
            DisplayPlayerInfo();

            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                CreateGoal();
            }

            if (choice == 2)
            {
                ListGoalDetails();
            }

            if (choice == 3)
            {
                SaveGoals();
            }

            if (choice == 4)
            {
                LoadGoals();
            }

            if (choice == 5)
            {
                RecordEvent();
            }

            if (choice == 6)
            {
                Console.WriteLine("Goodbye");
                break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points. ");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].Name()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Goals: ");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetGoalRepresentation()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine();
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());
                
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goals goal = null;
        
        if (choice == 1)
        {
            goal = new Simple(name, description, points);
            Console.WriteLine(goal.GetGoalRepresentation());
        }

        else if (choice == 2)
        {
            goal = new Eternal(name, description, points);
            Console.WriteLine(goal.GetGoalRepresentation());
        }

        else if (choice == 3)
        {
            Console.Write("How many times does this goal need to be accomplished? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            goal = new Checklist(name, description, points, target, bonus);
            Console.WriteLine(goal.GetGoalRepresentation());
        }

        else
        {
            Console.WriteLine("Invalid goal type. ");
            return;
        }

        _goals.Add(goal);
        Console.WriteLine("Goal created successfully. ");
    }

    public void SaveGoals()
    {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(_score);

            foreach (Goals goals in _goals)
            {
                output.WriteLine(goals.GetGoalDetails());
            }
        }

        Console.WriteLine("Goals saved. ");
    }

    public void LoadGoals()
    {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            _goals.Clear();

            string[] lines = System.IO.File.ReadAllLines(filename);

            _score = int.Parse(lines[0]);
        
            for (int i = 1; i < lines.Length; i++)
            {
                string [] parts = lines[i].Split("|");
                string typeInfo = parts[0].Trim();

                if (typeInfo.StartsWith("Simple Goal"))
                {
                    string name = parts[1].Trim();
                    string description = parts[2].Trim();
                    int points = int.Parse(parts[3].Trim());

                    Simple goal = new Simple(name, description, points);

                    _goals.Add(goal);
                }

                else if (typeInfo.StartsWith("Eternal Goal"))
                {
                    string name = parts[1].Trim();
                    string description = parts[2].Trim();
                    int points = int.Parse(parts[3].Trim());

                    Eternal goal = new Eternal(name, description, points);

                    _goals.Add(goal);
                }

                else if (typeInfo.StartsWith("Checklist"))
                {
                    string name = parts[1].Trim();
                    string description = parts[2].Trim();
                    int points = int.Parse(parts[3].Trim());
                    int amountCompleted = int.Parse(parts[4].Trim());
                    int target = int.Parse(parts[5].Trim());
                    int bonus = int.Parse(parts[6].Trim());

                    Checklist goal = new Checklist(name, description, points, target, bonus);

                    for (int j = 0; j < amountCompleted; j++)
                    {
                        goal.RecordEvent();
                    }

                    _goals.Add(goal);
                }
            }   

            Console.WriteLine("Goals loaded. ");
        }

        else
        {
            Console.WriteLine("File not found. ");
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine();
        Console.WriteLine("The goals are: ");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int answer = int.Parse(Console.ReadLine()) -1;

        if (answer >= 0 && answer < _goals.Count)
        {
            Goals goals = _goals[answer];
            goals.RecordEvent();
            
            _score = _score + goals.GetPoints();

            if (goals is Checklist)
            {
                Checklist checklist = (Checklist)goals;

                if (checklist.JustCompleted())
                {
                    _score = _score + checklist.GetBonus();
                }
            }

            Console.WriteLine($"Congrats, you earned a total of {_score} points! ");
        }

    
    }
}