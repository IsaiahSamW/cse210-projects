using System;

class Program
{
    static void Main(string[] args)
    {
        // asking for the number, turn it into an integer
        Console.Write("What is the magic number: ");
        string magicNumber = Console.ReadLine();
        int parsedMagicNumber = int.Parse(magicNumber);

        // Console.WriteLine(parsedMagicNumber);

        // asking for the guess, turning it into a integer
        Console.Write("What is your guess: ");
        string guess = Console.ReadLine();
        int parsedGuess = int.Parse(guess);

        // Console.WriteLine(parsedGuess);

        //if statments for higher or lower
        if (parsedGuess > parsedMagicNumber)
        {
            Console.WriteLine("Lower");
        }
        else if (parsedGuess < parsedMagicNumber)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine($"You got it! {parsedMagicNumber} is the Magic Number!");
        }
    }
}