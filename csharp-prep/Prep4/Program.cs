using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //get numbers
        List<int> numbers = new List<int>();
        int number = -1;
        while (number != 0){
            Console.Write("Input a number, or 0 to quit: ");

            string answer = Console.ReadLine();
            number = int.Parse(answer);

            if (number != 0){
                numbers.Add(number);
            }
        }

        //do addition thingy for given numbers
        int sum = 0;
        foreach (int numbered in numbers){
           sum += numbered;
        }
        Console.WriteLine($"Sum: {sum}");

        //find the average
        float average = ((float)sum)/numbers.Count;
        Console.WriteLine($"Average: {average}");

        //find the max
        int max = numbers[0];
        foreach (int numbered in numbers){
            if (numbered > max){
                max = numbered;
            }
        }
        Console.WriteLine($"Max: {max}");
    }
}