using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int score = 0;

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            goals[goalIndex].RecordEvent();
            score += goals[goalIndex].Points;
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetGoalStatus()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Your current score: {score}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Points}");
            }
        }
    }

    public void LoadGoals(string filename)
    {
        goals.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string type = parts[0];
                string name = parts[1];
                int points = int.Parse(parts[2]);

                Goal goal;
                if (type == "SimpleGoal")
                {
                    goal = new SimpleGoal(name, points);
                }
                else if (type == "EternalGoal")
                {
                    goal = new EternalGoal(name, points);
                }
                else // ChecklistGoal
                {
                    goal = new ChecklistGoal(name, points, 5); // Assuming default target count of 5 for checklist goal
                }

                goals.Add(goal);
            }
        }
    }
}
