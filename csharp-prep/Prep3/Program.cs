using System;

class Program
{
    static void Main(string[] args)
    {
        // asking for the number, turn it into an integer
        Console.Write("What is the magic number: ");
        string magicNumber = Console.ReadLine();
        int parsedMagicNumber = int.Parse(magicNumber);

        // asking for the guess, turning it into a integer
        Console.Write("What is your guess: ");
        string guess = Console.ReadLine();
        int parsedGuess = int.Parse(guess);

        Console.WriteLine(parsedGuess);
    }
}