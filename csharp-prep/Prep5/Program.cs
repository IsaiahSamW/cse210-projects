using System;

class Program
{
    static void Main(string[] args)
    {
    // DisplayWelcome - Displays the message, "Welcome to the Program!"
    // PromptUserName - Asks for and returns the user's name (as a string)
    // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    // DisplayResult - Accepts the user's name and the squared number and displays them.
        DisplayWelcome();

        string userName = PromptUserName();

        
        
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        
        static string PromptUserName();
        {
            Console.Write("Please enter your name: ");
            string name= Console.ReadLine();

            return name
        }

        static int PromptUserNumber();
        {

        }

    }
}