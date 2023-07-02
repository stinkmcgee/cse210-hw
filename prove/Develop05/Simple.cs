// Simple Goals:
// - set amount of events
// - example: reading a book
   // - each chapter = 10 points
  //  - finish book = 500 points
// Simple : Goals
// _goalType = string
// ------
// DisplayGoals(): list
// IsFinished() : bool
// AddScore() : override

public class Simple : Goal{
    public List<string> displayGoals(){
        List<string> simpleGoals = new List<string>();
        return simpleGoals;
    }
    public override void CreateGoal(){
        // ask for name
        Console.WriteLine("What is the name of the goal?: ");
        Console.ReadLine();
        // ask for description
        Console.WriteLine("What is the description?: ");
        // ask for amount of points
        Console.WriteLine("How many points is this worth?: ");
    }

    public override int completegoal(){
        if (Goal != true){
            
        }
        // if statement
            //ex if goal is != true
            // add points
            // else "already completed"
        // points += _points ? maybe
        // return points
    }
}