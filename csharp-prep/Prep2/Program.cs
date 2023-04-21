using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);
        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
            Console.WriteLine("You got an A! Congrats!");
        }
        else if (percent >= 80)
        {
            letter = "B";
            Console.WriteLine("You got an B! Good Job!");
        }
        else if (percent >= 70) 
        {
            letter = "C";
            Console.WriteLine("You got a C! I see potential!");
        }
        else if (percent >= 60)
        {
            letter = "D";
            Console.WriteLine("You got a D! I know you can do it!");
        }
        else 
        {
            letter = "F";
            Console.WriteLine("You got an F.");
        }

        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine("Congrats, you passed the class!");
        }
        else{
            Console.WriteLine("Oof, try again!");
        }
    }
}