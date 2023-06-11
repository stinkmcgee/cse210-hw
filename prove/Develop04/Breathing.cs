using System.Diagnostics;

public class Breathing : Activity{
    //static void Main(string[] args){
    //Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly.");
    //Console.WriteLine("Clear your mind and focus on your breathing.");
   // }
    public override void Perform(){
        //MAKE IT LOOP
        //probably use an if statement
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly.");
        Console.WriteLine("Clear your mind and focus on your breathing.");
        Console.WriteLine(" ");
       while(Duration > 0){
        Console.WriteLine("Breathe in");
        Countdown(3);
        //Thread.Sleep(3000);
        Console.WriteLine("Breathe out.");
        Countdown(3);
        //Thread.Sleep(3000);
        }

        Console.WriteLine($"Congrats, you just finished the Breathing Activity that lasted {Duration} seconds!");
    }
}