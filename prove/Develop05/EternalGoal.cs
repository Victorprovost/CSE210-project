using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, int points)
    {
        this.name = name;
        this.points = points;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Event recorded: {name}");
    }

    public override string GetGoalStatus()
    {
        return $"[ ] {name}";
    }
}
