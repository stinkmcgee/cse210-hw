// Simple Goals:
// - set amount of events
// - example: reading a book
   // - each chapter = 10 points
  //  - finish book = 500 points
// Simple : Goals
// ------
// DisplayGoals(): list
// IsFinished() : bool
// AddScore() : override

public class Simple : Goal{
    public List<string> displayGoals(){
        List<string> simpleGoals = new List<string>();
        return simpleGoals;
    }
    public override void addScore(){

    }

}