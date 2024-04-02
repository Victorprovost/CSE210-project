using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        // Adding goals
        goalManager.AddGoal(new SimpleGoal("Run a marathon", 1000));
        goalManager.AddGoal(new EternalGoal("Read scriptures", 100));
        goalManager.AddGoal(new ChecklistGoal("Attend the temple", 50, 10));

        // Menu
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nEternal Quest Program");
            Console.WriteLine("1. Record Event");
            Console.WriteLine("2. Display Goals");
            Console.WriteLine("3. Display Score");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    RecordEvent(goalManager);
                    break;
                case "2":
                    goalManager.DisplayGoals();
                    break;
                case "3":
                    goalManager.DisplayScore();
                    break;
                case "4":
                    Console.Write("Enter filename to save goals: ");
                    string saveFilename = Console.ReadLine();
                    goalManager.SaveGoals(saveFilename);
                    Console.WriteLine("Goals saved successfully.");
                    break;
                case "5":
                    Console.Write("Enter filename to load goals: ");
                    string loadFilename = Console.ReadLine();
                    goalManager.LoadGoals(loadFilename);
                    Console.WriteLine("Goals loaded successfully.");
                    break;
                case "6":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void RecordEvent(GoalManager goalManager)
    {
        Console.Write("Enter goal index to record event: ");
        if (int.TryParse(Console.ReadLine(), out int index))
        {
            goalManager.RecordEvent(index - 1); 
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}
