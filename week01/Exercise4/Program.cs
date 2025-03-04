using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {

        //Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.//
        List <int> numbers = new List<int>();
        int userInput = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        while (userInput != 0)
        {
            
            Console.Write("Enter number: ");
            string userResponse = Console.ReadLine();
            userInput = int.Parse(userResponse);

            if (userInput != 0)
            {
                numbers.Add(userInput);
            }

        }

        //Use sum to compute the total of the user input number//
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum} ");

        //get the number of input using "count" property//
        int count = -1;
        int average = 0;
        count = numbers.Count;
        average = sum / count;

        Console.WriteLine($"The average is: {average}");

        // Find the maximum 
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            max = number;
        }

        Console.WriteLine($"The largest number is: {max}");
    
       

        
    }
}