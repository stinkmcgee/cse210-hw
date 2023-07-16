// write a program with a base Activity class
    // then a derived class for each of the three activities
// base class should contain any attributes that are shared among the activities
// base class should contain virtual methods for getting distance, speed, pace
    // methods should be overridden in the derived classes
// finally, provide a GetSummary method to produce a string with all the summary info
    // summary method can make use of the other methods to produce its result
    // should be available for all classes and be defined in base class
// write a program that creates at least one activity of each type
    // put these activities in the same list
    // then iterate through this list and call the GetSummary method on each item and display result
// program must:
    // use inheritance to avoid duplicating shared attribute/methods
    // use method overriding for the calculation methods
    // follow the principles of encapsulation, making sure each member variable is private

// Activity
// ******
// distance() = virtual
// speed() = virtual
// pace() = virtual
// date() = DateTime.Today
// timeLimit() = string
// ******
// GetSummary()

// Running
// ******
// distance() = int
// ******
// CalculateDistance()

// Cycling
// ******
// speed() = int
// ******
// CalculateSpeed()

// Swimming
// ******
// laps() = int
// ******
// CalculatePace()

using System;


class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation4 World!");
        List<Activity> activities = new List<Activity>();
        DateTime currentDate = DateTime.Now;
        string formattedDate = currentDate.ToString("dd MMMM yyyy");
        // ignore the errors on Swimming.
        //Swimming s = new Swimming(2, 15, 5, 2, 15);
        //activities.Add(s);
        Swimming s2 = new Swimming("Swimming", 25, 0, 0, 0, 60);
        activities.Add(s2);
        //Running r = new Running(3, 50, 1, 1);
       // activities.Add(r);
       Running r2 = new Running("Running", 3, 0, 0, 30);
       activities.Add(r2);
       Cycling c = new Cycling("Cycling", 15, 15, 0, 60);
       activities.Add(c);

        foreach(Activity a in activities){
            double distance = a.GetDistance();
            
            double speed = a.GetSpeed();

            double pace = a.GetPace();

            double timeLimit = a.GetTime();

            string workoutType = a.GetWorkoutType();

            Console.WriteLine($"{formattedDate} {workoutType} ({timeLimit} min) - Distance: {distance} miles, Speed: {speed} mph, Pace: {pace} min per mile");
        }
    }
}
