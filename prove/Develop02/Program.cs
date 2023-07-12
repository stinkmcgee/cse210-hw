//create journal program
// program must have:
    // write a new entry
        // show user a random prompt, save response, prompt, and date as an Entry
    // display journal
        // iterate through all enteries in journal and display on screen
    // save journal to file
        // prompt user for a filename
        // then load journal/complete list of entries from file
        // should replace any entries currently in the journal
    // provide menu
    //list of prompts must be five or more
    // interface should follow pattern in video demo

    // Entry
    // ******
    // _fileName() = string
    // _date() = dateTime
    // _prompt() = string
    // _response() = string
    // ******
    // NewEntry()

    // Journal
    // ******
    // DisplayJournal() - display all entries
    // SaveJournal() - get filename and save to list
    // LoadJournal() - get filename and load from list

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop02 World!");

        // test entries
        Entry entry1 = new Entry();
        entry1._fileName = "Test";
        entry1._prompt = "Test Prompt";
        entry1._response = "Test response.";
        entry1._givenDate = "July 11, 2023";

        Journal newJournal = new Journal();
        newJournal._name = "Test Journal";

        newJournal._entries.Add(entry1);
       // newJournal.Display();

       // prompts
       var random = new Random();
       var prompts = new List<string>{"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "If I had one thing I could do over today, what would it be?", "What was the most interesting conversation of my day?", "Did I do something productive today? If so, what was it. If not, what is something productive I should do in the future?"};
       int index = random.Next(prompts.Count);
       //prompts.Add("Who was the most interesting person I interacted with today?");
       //prompts.Add("What was the best part of my day?");
       //prompts.Add("How did I see the hand of the Lord in my life today?");
       //prompts.Add("If I had one thing I could do over today, what would it be?");
       //prompts.Add("What was the most interesting conversation of my day?");
       //prompts.Add("Did I do something productive today? If so, what was it. If not, what is something productive I should do in the future?");


        // create menu here
        int userChoice = -1;
        while(userChoice != 0){
            Console.Write("Enter the number of what you would like to do: ");
            Console.WriteLine(" ");
            Console.WriteLine("1. Create New Journal Entry");
            Console.WriteLine("2. Display all Entries");
            Console.WriteLine("3. Save a Journal");
            Console.WriteLine("4. Load a Journal");
            Console.WriteLine("0. Exit");
            string userResponse = Console.ReadLine();
            userChoice = int.Parse(userResponse);

            if(userChoice == 1){
                Console.WriteLine(" ");
                Console.WriteLine("Let's create a new journal entry!");
                Console.WriteLine(" ");
                // ask for current date?
                // give random prompt
                Console.WriteLine(prompts[index]);
                // start response
                Console.Write(">");
                string entryResponse = Console.ReadLine();
                // press enter to end
                Console.WriteLine(" ");
            }
            else if(userChoice == 2){
                Console.WriteLine(" ");
                Console.WriteLine("Here are all of the journal entries: ");
                // display list of entries
                newJournal.Display();
                Console.WriteLine(" ");
            }
            else if(userChoice == 3){
                Console.WriteLine(" ");
                Console.WriteLine("What is the name of the journal you would like to save?");
                // give user prompt to insert journal(file?) name
                Console.WriteLine(" ");
            }
            else if(userChoice == 4){
                Console.WriteLine(" ");
                Console.WriteLine("What is the name of the Journal you would like to see?: ");
                // give prompt to insert journal name
                // display journal and it's entries
                Console.WriteLine(" ");
            }
            else if(userChoice == 0){
                Console.WriteLine(" ");
                Console.WriteLine("Goodbye!");
            }
            else{
                Console.WriteLine(" ");
                Console.WriteLine("Seriously? Is that a choice? Please do something right in your life for once.");
                Console.WriteLine(" ");
            }
        }






    }
}