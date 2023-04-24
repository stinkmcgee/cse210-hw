using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int SquaredUserNumber = SquareUserNumber(userNumber);

        DisplayResult(userName, SquaredUserNumber);

        // display message "welcome to the program!"
        static void DisplayWelcomeMessage(){
        Console.WriteLine("Welcome to the Program!");
        }

        // prompt user name (as a string)
        static string PromptUserName(){
            Console.WriteLine("What is your name: ");
            string name = Console.ReadLine();
            return name;
        }

        // prompt user number (as an integer)
        static int PromptUserNumber(){
            Console.WriteLine("What is your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        // square user number (as an integer)
       static int SquareUserNumber(int number){
            int square = number * number;
            return square;
        }

        // display the results
        static void DisplayResult(string name, int square){
            Console.WriteLine($"Hello {name}, we have squared your number and it is now {square}!");
        }
    }
}