using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int guess = -1;

        while (guess != number){
            Console.WriteLine("Pick a number, any number! Between 1 and 100.");
            guess = int.Parse(Console.ReadLine());

            if (guess > number){
                Console.WriteLine("Not quite. Lower.");
            }
            else if (guess < number){
                Console.WriteLine("Not there yet. Go Higher!");
            }
            else{
                Console.WriteLine("Congrats! You guessed correctly!");
            }
        }
    }
}