using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness App!");

        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Enter duration (in seconds): ");
                int duration = int.Parse(Console.ReadLine());
                new BreathingActivity(duration).PerformActivity();
            }
            else if (choice == "2")
            {
                Console.WriteLine("Enter duration (in seconds): ");
                int duration = int.Parse(Console.ReadLine());
                new ReflectionActivity(duration).PerformActivity();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Enter duration (in seconds): ");
                int duration = int.Parse(Console.ReadLine());
                new ListingActivity(duration).PerformActivity();
            }
            else if (choice == "4")
            {
                break;
            }
                
                
            }
        }   
    }

// internal class BreathingActivity
// {
//     private int duration;

//     public BreathingActivity(int durationInSeconds) : base(durationInSeconds)
//     {
//         this.duration = duration;
//     }
// }