using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List <int> numbers = new List<int>();
        int userNumber = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.WriteLine("Enter number:");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            if(userNumber != 0);
            {
                numbers.Add(userNumber);
            }
        } while(userNumber != 0);

        
        int sum = numbers.AsQueryable().Sum();
        Console.WriteLine($"The sum is: {sum}");
        
        float average = ((float)sum) / (numbers.Count-1);
        Console.WriteLine($"The average is: {average}");
        
        int maximum = numbers.AsQueryable().Max();
        Console.WriteLine($"The largest number is: {maximum}");

    }
}