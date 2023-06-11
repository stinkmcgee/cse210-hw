using System;
using System.Diagnostics;

public class MindApp
{
   public static void Main()
    {
        // Console.WriteLine("Hello Develop04 World!");
        while(true){
            DisplayMenu();
            int choice;
            if(int.TryParse(Console.ReadLine(), out choice)){
                if (choice == 0){
                    Console.WriteLine("Goodbye for now!");
                    break;
                }
                else if(choice >=1 && choice <= 3){
                    Activity activity;
                    if(choice == 1)
                        activity = new Breathing();
                    else if(choice == 2)
                        activity = new Reflection();
                    else
                        activity = new Listing();

                    Console.Write("How long, in seconds, do you want to do this?: ");
                     if(int.TryParse(Console.ReadLine(), out int duration)){
                        activity.Duration = duration;
                        activity.startActivity();
                     }
                        else{
                            Console.WriteLine("Invalid.");
                        }
                }
                else{
                    Console.WriteLine("Invalid.");
                }
            }
                else{
                Console.WriteLine("Invalid.");
            }
            Console.WriteLine();
                }
            }
            public static void DisplayMenu(){
                Console.WriteLine("Welcome to the Mindfulness App");
                Console.WriteLine("Activities available:");
                Console.WriteLine("1. Breathing");
                Console.WriteLine("2. Reflection");
                Console.WriteLine("3. Listing");
                Console.WriteLine("0. Exit");
                Console.Write("Which activity do you want to do?: ");

            }
        }