using System;

class Program
{
    static void Main(string[] args)
    {
         List<int> numbers = new List<int>();

         int usernumber = -1;
         while (usernumber != 0)
         {
             Console.WriteLine("Enter a number (0 to quit): ");

            string userresponse = Console.ReadLine();
            usernumber = int.Parse(userresponse);

            if (userresponse != "0")
            {
                numbers.Add(usernumber);
            }
         }

         int sum = 0;
         foreach (int number in numbers)
         {
             sum += number;
         }

         Console.WriteLine($"the sum is: {sum}");

         float average = ((float)sum) / numbers.Count;
         Console.WriteLine($"the average is: {average}");

         int largest = numbers[0];

         foreach (int number in numbers)
         {
             if (number > largest)
             {
                 largest = number;
             }
         }

         Console.WriteLine($"the largest number is: {largest}");

    }
}