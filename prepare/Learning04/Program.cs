using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning04 World!");
        Assignment a1 = new Assignment("Anakin Skywalker", "Multiplication");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine(" ");

        MathAssignment a2 = new MathAssignment("Obi Wan Kenobi", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeWorkList());
        Console.WriteLine(" ");

        WritingAssignment a3 = new WritingAssignment("Ashoka Tano", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}