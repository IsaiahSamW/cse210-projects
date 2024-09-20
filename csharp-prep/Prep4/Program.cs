using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        // starting with the title, made the list
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numberLis = new List<int>();

        // while loop for adding numbers to list
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

        // foreach loop to math the list
        int numberAdded =0;

        int numberOfThings= 0;
        
        int maximumNumber = -10;
        foreach (int number in numberLis)
        {
            // adding all the numbers together
            // Console.Write($"{number}, ");
            numberAdded = numberAdded +number;

            // counting the number of times looped
            numberOfThings= numberOfThings +1;

            // if there's a number larget than the maximun, that number becomes the maximun
            if (number > maximumNumber)
            {
                maximumNumber = number;
            }
        }
        Console.WriteLine("");
        // typing out the sum, the average, and the largest number
        Console.WriteLine($"The sum is: {numberAdded}");
        // Console.WriteLine(numberOfThings);
        float average = numberAdded/numberOfThings;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maximumNumber}");
        Console.WriteLine("");

    }
}