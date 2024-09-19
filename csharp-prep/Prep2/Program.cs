using System;

class Program
{
    static void Main(string[] args)
    {
        
    // Ask the user for their grade percentage, then write a series of if-elif-else statements to 
    // print out the appropriate letter grade. (At this point, you'll have a separate print statement
    // for each grade letter in the appropriate block.)

    // Assume that you must have at least a 70 to pass the class. After determining the letter grade and 
    //printing it out. Add a separate if statement to determine if the user passed the course, and if so display 
    //a message to congratulate them. If not, display a different message to encourage them for next time.

    // Change your code from the first part, so that instead of printing the letter grade in the body 
    // of each if, elif, or else block, instead create a new variable called letter and then in each block, 
    // set this variable to the appropriate value. Finally, after the whole series of if-elif-else statements, 
    //have a single print statement that prints the letter grade once.

    // A >= 90
    // B >= 80
    // C >= 70
    // D >= 60

        
        Console.Write("What is your score? ");
        string score = Console.ReadLine();
        int parsedNumber = int.Parse(score);
        Console.WriteLine(parsedNumber);

    
        if (parsedNumber >= 90)
        {
            Console.WriteLine("You got an A");
        }
        else if (parsedNumber >= 80)
        {
            Console.WriteLine("You got a B");
        }
    }
}