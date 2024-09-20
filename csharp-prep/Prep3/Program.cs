using System;

class Program
{
    static void Main(string[] args)
    {

        // asking for the number, turn it into an integer
        // Console.Write("What is the magic number: ");
        // string magicNumber = Console.ReadLine();
        // int parsedMagicNumber = int.Parse(magicNumber);

        // Random number generator
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        // Console.WriteLine(magicNumber);

        // hopefully this works...
       
        int parsedGuess= 0;
    
        while (parsedGuess != magicNumber)
        {
            // asking for the guess, turning it into a integer
            Console.Write("What is your guess: ");
            string guess = Console.ReadLine();
            parsedGuess= int.Parse(guess);
            

            //if statments for lower
            if (parsedGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            // if statment for higher
            else if (parsedGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            // only other thing can be correct.
            else
            {
                Console.WriteLine($"You got it! {magicNumber} is the Magic Number!");
            }
        }
    }
}