using System;
using System.Collections.Generic;
using System.IO;

public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }
}

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    
    public void AddEntry(string prompt, string response)
    {
        Entry newEntry = new Entry
        {
            Prompt = prompt,
            Response = response,
            Date = DateTime.Now
        };
        entries.Add(newEntry);
    }

    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}\nPrompt: {entry.Prompt}\nResponse: {entry.Response}\n");
        }
    }

    
    public void SaveJournalToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"Date: {entry.Date}\nPrompt: {entry.Prompt}\nResponse: {entry.Response}\n");
            }
        }
    }

    
    public void LoadJournalFromFile(string filename)
    {
        entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                Entry newEntry = new Entry
                {
                    Date = DateTime.Parse(parts[0]),
                    Prompt = parts[1],
                    Response = parts[2]
                };
            }
            }
        }
    }


partial class Program
{
     static string ProgramMain(string[] args)
    {
        Journal myJournal = new Journal();

        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice:");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
                case 2:
                    myJournal.DisplayJournal();
                    break;
                case 3:
                    Console.WriteLine("Enter the filename to save:");
                    string saveFilename = Console.ReadLine();
                    myJournal.SaveJournalToFile(saveFilename);
                    break;
                case 4:
                    Console.WriteLine("Enter the filename to load:");
                    string loadFilename = Console.ReadLine();
                    myJournal.LoadJournalFromFile(loadFilename);
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
