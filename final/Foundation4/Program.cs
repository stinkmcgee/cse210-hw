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
    }
}