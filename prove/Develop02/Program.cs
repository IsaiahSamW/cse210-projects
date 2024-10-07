using System;

class Program
{
    static void Main(string[] args)
    {
        // starting
        Console.WriteLine("Welcome to the Journal Program!");
        int userActionParsed;
        // do/while loop, while user doesn't input a 5, asking user for input
        do
        {
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("1, Write.");
            Console.WriteLine("2, Display.");
            Console.WriteLine("3, Load.");
            Console.WriteLine("4, Save.");
            Console.WriteLine("5, Quit.");
            
            Console.Write("What would you like to do: ");
            string userAction = Console.ReadLine();
            userActionParsed = int.Parse(userAction);
            // Console.WriteLine(userActionParsed);
             
            // calling the write command
            if (userActionParsed == 1)
            {
                
            } 
            else if (userActionParsed == 2)
            {

            }
            else if (userActionParsed == 3)
            {

            }

            else if (userActionParsed == 5)
            {

            }
            else
            {
                Console.WriteLine("I do not understand what you're asking");
            }
        }
        while (userActionParsed !=5);
        
            

        
    }
}