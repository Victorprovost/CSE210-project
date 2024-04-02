using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points)
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
        return $"[X] {name}";
    }
}
