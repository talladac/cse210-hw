using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade //
        Console.Write("What is your grade? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        string letter = "";
        

        if (number >= 90)
        {
            letter = "A" ;
        }
        else if (number >= 80)
        {
            letter = "B" ;
        
        }
        else if (number >= 70)
        {
            letter = "C" ;
        }
        else if (number >= 60)
        {
            letter = "D" ;
        }
        else 
        {
            letter = "F" ;
        }

        Console.WriteLine($"Your grade letter is {letter}.");

        if (number > 70)
        {
            Console.Write("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Sorry you failed. You can do better!");
        }
    }
}