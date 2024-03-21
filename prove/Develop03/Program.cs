using System;
using System.Collections.Generic;
using System.Linq;

public class Word
{
    public string Text { get; set; }
    public bool Hidden { get; set; }

    public Word(string text)
    {
        Text = text;
        Hidden = false;
    }

    public string GetDisplayText()
    {
        return Hidden ? "______" : Text;
    }
}

public class Scripture
{
    public string Reference { get; set; }
    public List<Word> Words { get; set; }

    public Scripture(string reference, string text)
    {
        Reference = reference;
        Words = ParseTextToWords(text);
    }

    private List<Word> ParseTextToWords(string text)
    {
        List<Word> words = new List<Word>();
        string[] wordArray = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in wordArray)
        {
            words.Add(new Word(word));
        }
        return words;
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = random.Next(1, Words.Count); // Randomly select number of words to hide
        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(Words.Count); // Randomly select index of word to hide
            Words[index].Hidden = true;
        }
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine("Scripture:");
        Console.WriteLine(Reference);
        foreach (Word word in Words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine("\n\nPress Enter to continue or type 'quit' to exit:");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store scriptures
        List<Scripture> scriptures = new List<Scripture>();

        // Add the existing scriptures
        Scripture john316 = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        scriptures.Add(john316);

        Scripture nephi37 = new Scripture("1 Nephi 3:7", "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        scriptures.Add(nephi37);

        // Add the new scripture
        Scripture proverbs35to6 = new Scripture("Proverbs 3:5-6", "Trust in the Lord with all thine heart; and lean not unto thine own understanding.\n\nIn all thy ways acknowledge him, and he shall direct thy paths.");
        scriptures.Add(proverbs35to6);

        // Main loop
        while (true)
        {
            // Select a random scripture
            Scripture selectedScripture = scriptures[new Random().Next(scriptures.Count)];

            selectedScripture.Display();

            string input = Console.ReadLine().ToLower();
            if (input == "quit")
                break;

            selectedScripture.HideRandomWords();
        }
    }
}



