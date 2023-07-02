// displays goal with points, type, and description of goal
public class Goal{
    protected int _points = 0;
    string _goalType;
    string _description;
    bool _isFinished = false;

    public Goal(int points, string goalType, string description) {
        // happens upon initialization
        _points = points;
        _goalType = goalType;
        _description = description;
    }

    public bool IsFinished(){
        return _isFinished;
    }

    // public abstract void create();
    public List<int> getProgress(){
        
        
        List<int> values = new List<int>();
        return values;
    }
}