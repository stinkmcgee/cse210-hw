// INHERITANCE
// Create an event planning tracker
    //1. Lectures
        // has a speaker and limited capacity
    //2. receptions
        // requires rsvp
    //3. outdoor gatherings
        // no limit on attendees, but need to track weather
// each event needs: Event Title, Desc., Date, Time, and Address
// give ability to generate 3 different messages:
    //1. standard detail
        // lists title, description, date, time, and address
    //2. full details
        // standard details, type of event and info
            // for lectures, include speaker name and capacity
            // for receptions, include email to rsvp
            // for outdoor, include weather statement
    //3. short description
        // lists type of event, title, and date
//write a program
    // base Event class w/ derived classes for each type of event
        // should contain necessary data and provide methods to 
        // return strings for each messages
    //any data or methods that are common among all types should be in base class
    // create at least one event of each type and set all values
    // call each of the methods to generate marketihng messages
    //program must:
        // use inheritance
        // use an address class
        // follow encapsulation

// Event
// ******
// title() = string
// date() = calender?
// description() = string
// time() = time
// address() = string

// Lecture
// ******
// speaker() = string
// capacity() = int

// Reception
// ******
// rsvpEmail() = string

// Outdoor
// ******
// weather() = string

using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation3 World!");
        Lecture e1 = new Lecture("Obi Wan Kenobi", 25, "Lecture", "Come listen to the famound Obi Wan Kenobi speak about the importance of the high ground!", "November 23", 12, "123 Some Street", "Kenobi Speaks");
        Console.WriteLine("Standard");
        Console.WriteLine(e1.GetStandardDetail());
        Console.WriteLine("Full");
        Console.WriteLine(e1.GetFullDetail());
        Console.WriteLine("Short");
        Console.WriteLine(e1.GetShortDetail());
        Console.WriteLine(e1.getLecture());
        Console.WriteLine(" ");
        Console.WriteLine(" ");

        Reception e2 = new Reception("grandmaster@jedicouncil.com", "Reception", "You are solemly invited to the wake of Jedi Master Qui Gon Jin. If you wish to attend, please RSVP through the email provided.", "August 15", 9, "456 Coursant Way", "Smell Ya Later, Old Man");
        Console.WriteLine("Standard");
        Console.WriteLine(e2.GetStandardDetail());
        Console.WriteLine(" ");
        Console.WriteLine("Full");
        Console.WriteLine(e2.GetFullDetail());
        Console.WriteLine(" ");
        Console.WriteLine("Short");
        Console.WriteLine(e2.GetShortDetail());
        Console.WriteLine(" ");
        Console.WriteLine(e2.getReception());
        Console.WriteLine(" ");
        Console.WriteLine(" ");

        Outdoor e3 = new Outdoor("Cloudy", "Outdoor", "Come join the alliance in our annual picnic! Bring a dish from your home planet or anything and have some fun!", "June 3", 10, "Yavin 4", "Rebel Alliance Annual Picnic");
        Console.WriteLine("Standard");
        Console.WriteLine(e3.GetStandardDetail());
        Console.WriteLine(" ");
        Console.WriteLine("Full");
        Console.WriteLine(e3.GetFullDetail());
        Console.WriteLine(" ");
        Console.WriteLine("Short");
        Console.WriteLine(e3.GetShortDetail());
        Console.WriteLine(" ");
        Console.WriteLine(e3.getOutdoor());
    }
}