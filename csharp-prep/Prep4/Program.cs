using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numberLis = new List<int>();

        int parseNumbers =-1;

        while (parseNumbers !=0 )
        {
            Console.Write("Enter number: ");
            string userNumber = Console.ReadLine();
            parseNumbers= int.Parse(userNumber);

            if (parseNumbers != 0)
            {
                numberLis.Add(parseNumbers);
            }
        }
        int numberAdded =0;
        foreach (int number in numberLis)
        {
            // Console.Write($"{number}, ");
            numberAdded = numberAdded +number;
        }
        Console.WriteLine(numberAdded);
    }
}