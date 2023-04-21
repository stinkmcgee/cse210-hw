using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Gimme your first name? ");
        string first = Console.ReadLine();

        Console.Write("Gimme your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"You are {last}, {first} {last}.");
    }
}