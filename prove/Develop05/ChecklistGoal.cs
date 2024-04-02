using System;

public class ChecklistGoal : Goal
{
    private int targetCount;
    private int completedCount;

    public ChecklistGoal(string name, int points, int targetCount)
    {
        this.name = name;
        this.points = points;
        this.targetCount = targetCount;
    }

    public override void RecordEvent()
    {
        completedCount++;
        Console.WriteLine($"Event recorded: {name}");

        if (completedCount == targetCount)
        {
            Console.WriteLine($"Congratulations! You've completed the checklist goal: {name}");
            points += 500; // Bonus points for completing the checklist
        }
    }

    public override string GetGoalStatus()
    {
        return $"Completed {completedCount}/{targetCount} times - {name}";
    }
}
