using System;

class Program
{
    static void Main(string[] args)
    {
   
    
    // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    // DisplayResult - Accepts the user's name and the squared number and displays them.
        DisplayWelcome();

        string userName = PromptUserName();

        int userNumber = PromptUserNumber();

        int squared = SquareNumber(userNumber);

        // string results = DisplayResult();
        
        // displays message
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        // asks for, recieves, and returns string name
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name= Console.ReadLine();

            return name;
        }

        // asks for, recieves, and returns int number
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number: ");
            string number = Console.ReadLine();
            int numberParsed = int.Parse(number);

            return numberParsed;
        }

        // gets a number, squares it, and returns it
        static int SquareNumber(int number)
        {
            int numberSquared = number * number;

            return numberSquared;
        }

    }
}