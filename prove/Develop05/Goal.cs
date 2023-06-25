
public class Goal{
    int _points = 0;
    string _goalType;
    string _description;
    bool _isFinished = false;

    public Goal(int points, string goalType, string description) {
        // happens upon initialization
        _points = points;
        _goalType = goalType;
        _description = description;
    }

    public List<int> getProgress(){
        
        
        List<int> values = new List<int>();
        return values;
    }
}