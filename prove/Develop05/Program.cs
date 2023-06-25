// eternal goals
// set up menu thingy here
// display awarded points/title along with menu
    // menu options
    // Create New Goal
    // List Goals
    // Save Goals
    // Load Goals
    // Record Event
    // Levels (shows what level/title they are at and the list of levels/titles)
using System;
using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        // Goals goals = new Goals();
        DisplayGoals();
        int choice;
    if(int.TryParse(Console.ReadLine(), out choice)){
        if(choice == 7){
            Console.WriteLine("Goodbye!");
        }
        else if(choice == 1){
            Console.WriteLine("...");
        }
        else if(choice == 2){
            Console.WriteLine("These are the list of goals available: ");
        }
        else if(choice == 3){
            Console.WriteLine("...");
        }
         else if(choice == 4){
            Console.Write("What goal would you like to load up?: ");
        }
         else if(choice == 5){
            Console.Write("Was the event for a Simple or Eternal goal?: ");
            string answer = Console.ReadLine();
            if (answer == "Simple"){
                Console.Write("...");
            }
            else if (answer == "Eternal"){
                Console.Write("...");
            }
            else{
                Console.WriteLine("Do something right for once in your life.");
            }
        }
         else if(choice == 6){
            Console.WriteLine("These are the levels: ");
            Console.WriteLine("Level 1: Youngling");
            Console.WriteLine("Level 2, Gained at 100 points: Padawan");
            Console.WriteLine("Level 3, Gained at 500 points: Jedi Knight");
            Console.WriteLine("Level 4, Gained at 1000 points: Jedi Master");
            Console.WriteLine("Level 5, Gained at 2000 points: Council Member");
            Console.WriteLine("Level 6, Gained at 5000 points: Master of the Order");
            Console.WriteLine("Level 7, Gained at 10000 points: Grand Master");
        }
        else{
            Console.WriteLine("Is that a choice? I don't think so...");
        }
    }
    }
        public static void DisplayGoals(){
        Console.WriteLine("Welcome to Eternal Quest!");
        Console.WriteLine("1. Create new goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goal");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Levels");
        Console.WriteLine("7. Exit");
        Console.Write("What would you like to do?: ");
    }
    
}