// Swimming
// ******
// laps() = int
// ******
// CalculatePace()
using System;
public class Swimming : Activity{
    private int _laps;
    private int _timeLimit;
    public Swimming(string workoutType, int laps, int distance, int speed, int pace, int timeLimit) : base(workoutType, distance, speed, pace, timeLimit){
        _laps = laps;
        _timeLimit = timeLimit;
    }
    // public string CalculatePace(){
    //   return($"");
    // }
    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
       return ((_laps * 50 / 1000 * 0.62) / _timeLimit) * 60;
    }
    public override double GetPace()
    {
        return _timeLimit / (_laps * 50 / 1000 * 0.62);
    }
    public override double GetTime(){
        return _timeLimit;
    }
    public override string GetWorkoutType()
    {
        return _workoutType;
    }
}