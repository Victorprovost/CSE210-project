using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.WriteLine("what is your first name?");
        string firstName = Console.ReadLine();
        Console.WriteLine("what is your last name?");
        string lastName = Console.ReadLine();

        Console.WriteLine($"your name is {lastName}, {firstName} {lastName}.");
    }
}