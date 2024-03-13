using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerateor promptGenerator = new PromptGenerateor();

        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. save the journal to Json");
            Console.WriteLine("6. load the journal from Json");
            Console.WriteLine("7. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    string promt = promptGenerator.GetRandomprompt();
                    Console.WriteLine($"prompt: {promt}");
                    Console.Write("Enter your response: ");
                    string response = Console.ReadLine();
                    Entry newEntry = new Entry(DateTime.Now.ToString(), promt, response);
                    journal.AddEntry(newEntry);
                    break;

                case 2:
                    journal.DisplayAll();
                    break;

                case 3:
                    Console.Write("Enter the file name to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case 4:
                    Console.Write("Enter the file name to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case 5:
                    Console.Write("Enter the JSON file name to save: ");
                    string saveJsonFile = Console.ReadLine();
                    journal.SaveToJson(saveJsonFile);
                    break;

                case 6:
                    Console.Write("Enter the JSON file name to load: ");
                    string loadJsonFile = Console.ReadLine();
                    journal.LoadFromJson(loadJsonFile);
                    break;

                case 7:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;

            }

        }
    }
}

internal class PromptGenerateor
{
    internal string GetRandomprompt() => throw new NotImplementedException();
}