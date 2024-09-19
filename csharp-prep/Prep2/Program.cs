using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your score? ");
        string score = Console.ReadLine();
        int number = int.Parse(score);
        Console.Write(number);
    }
}