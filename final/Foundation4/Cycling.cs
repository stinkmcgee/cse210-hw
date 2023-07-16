// Cycling
// ******
// speed() = int
// ******
// CalculateSpeed()

public class Cycling : Activity{
private int _speed;
private int _distance;
public Cycling(string workoutType, int distance, int speed, int pace, int timeLimit) : base(workoutType, distance, speed, pace, timeLimit){
    _speed = speed;
    _distance = distance;
}

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
    public override double GetTime(){
        return _timeLimit;
    }
    public override string GetWorkoutType()
    {
        return _workoutType;
    }
}