// Running
// ******
// distance() = int
// ******
// CalculateDistance()

public class Running : Activity{
    private int _distance;
    public Running(string workoutType, int distance, int speed, int pace, int timeLimit) : base(workoutType, distance, speed, pace, timeLimit){
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / _timeLimit) * 60;
    }
    public override double GetPace()
    {
        return _timeLimit / _distance ;
    }
    public override double GetTime(){
        return _timeLimit;
    }
    public override string GetWorkoutType()
    {
        return _workoutType;
    }
}