using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(int durationInSeconds) : base(durationInSeconds)
    {
    }

    // public class BreathingActivity(int durationInSeconds) : Base(durationInSeconds) { }

    public override void PerformActivity()
    {
        DisplayStartMessage("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

        for (int i = 0; i < durationInSeconds; i++)
        {
            Console.WriteLine("Breathe in...");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Now breathe out...");
            System.Threading.Thread.Sleep(5000);
        }

        DisplayEndMessage("Breathing Activity");
    }
}