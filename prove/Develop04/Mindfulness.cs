using System;

public abstract class Activity
{
    protected int durationInSeconds;

    public Activity(int durationInSeconds)
    {
        this.durationInSeconds = durationInSeconds;
    }

    protected void DisplayStartMessage(string activityName, string description)
    {
        Console.WriteLine($"Starting {activityName}...");
        Console.WriteLine(description);
        Console.WriteLine($"Duraation: {durationInSeconds} seconds\n");
        System.Threading.Thread.Sleep(3000);
    }

    protected void DisplayEndMessage(string activityName)
    {
        Console.WriteLine($"\nCongratulations! You have completed the {activityName}.");
        Console.WriteLine($"Time elapsed: {durationInSeconds} seconds\n");
        System.Threading.Thread.Sleep(3000);
    }

    public abstract void PerformActivity();
}