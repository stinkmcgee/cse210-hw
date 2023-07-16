// Activity
// ******
// distance() = virtual
// speed() = virtual
// pace() = virtual
// date() = DateTime.Today
// timeLimit() = string
// ******
// GetSummary()
using System;
public abstract class Activity{
    private int _distance;
    private int _speed;
    private int _pace;
    //private string _date;
    public int _timeLimit;
    public string _workoutType;

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();
    public abstract double GetTime();
    public abstract string GetWorkoutType();
    public Activity(string workoutType, int distance, int speed, int pace, int timeLimit){
        _workoutType = workoutType;
        _distance = distance;
        _speed = speed;
        _pace = pace;
        //_date = date;
        _timeLimit = timeLimit;
    }
    //public string GetSummary(int timeLimit, int distance, int speed, int pace){
      //  return _timeLimit + " min -" + "Distance: " + _distance +" miles, Speed: "+ _speed + 
        //    " mph, Pace: " + _pace + " min per mile";
   // }
}
