using System;
using System.Net;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        //Use random to generate random numbers//
        Random randomGenerator= new Random() ;
        int magicNumber = randomGenerator.Next(1, 101);

        // use bool to return a value//
        bool playAgain = true;
        int guess;
        int tries;
        string response;
        

        // Create a while loop to keep prompting the user if he wants to play more//
        while (playAgain)
        {
            guess = 0;
            tries = 0;
            magicNumber = randomGenerator.Next(1, 101);
            response = "";

            //Create a while loop until the user guessed the magic number //
            while (guess != magicNumber)
            {
                //Prompt the user to guess between 1-100//
                Console.Write("Guess the magic number between 1 - 100.  ");
                string userGuess = Console.ReadLine();
                guess = int.Parse(userGuess);

                // Create if statements to prompt the user if the guess is higher or lower until he guessed it right//
                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                tries++;
                
                
            }
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"Number of tries {tries}");

            //Prompt the user if he wants to play again//
            Console.WriteLine("Would you like to play again? (Y/N) ");
            response = Console.ReadLine();
            response = response.ToUpper();

            //Use if statements to determine if the user will continue to play again or not//
            if (response == "Y")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }
            

        }
        
        Console.WriteLine("Thanks for playing! ");
    }
}