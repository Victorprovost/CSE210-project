using System;

class Program
{
    static void Main(string[] args)
    {
        Displaywelcomemessage();

        string userName = PromptUserName();
        int userNumber = promptUserNumber();

        int squaredNumber = squareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
   
    }

    static void Displaywelcomemessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int promptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int squareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }


  
}