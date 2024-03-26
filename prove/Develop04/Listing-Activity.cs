using System;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int durationInSeconds) : base(durationInSeconds) {}

    public override void PerformActivity()
    {
        DisplayStartMessage("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Random rand = new Random();
        int promptIndex = rand.Next(_prompts.Count);
        Console.WriteLine(_prompts[promptIndex]);
        Console.WriteLine("Starting to list items...");

        Thread.Sleep(5000);

        int itemCount = rand.Next(5, 15);
        Console.WriteLine($"You listed {itemCount} items.");

        DisplayEndMessage("Listing Activity");
    }
    
}