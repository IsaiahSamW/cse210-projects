using System;

class Program
{
    static void Main(string[] args)
    {        

        
        Console.Write("What is your score? ");
        string score = Console.ReadLine();
        int parsedNumber = int.Parse(score);
        string letter ="A";
        Console.WriteLine(parsedNumber);

    
        if (parsedNumber >= 90)
        {
            letter = "A";
        }
        else if (parsedNumber >= 80)
        {
            letter = "B";
        }
        else if (parsedNumber >= 70)
        {
            letter = "C";
        }
        else if (parsedNumber >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"You got a: {letter}");

        if (parsedNumber >=70)
        {
            Console.WriteLine("Congradulations! You passed.");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass. Just know that we are never");
            Console.WriteLine("stuck in one spot. You can try again!");
        }
    }
}