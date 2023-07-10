// Lecture
// ******
// speaker() = string
// capacity() = int
// description() = string

public class Lecture : Event{
    private string _speaker;
    private int _capacity;

    public Lecture(string speaker, int capacity, string type, string description, string date, int time, string address, string title) : base(type, description, date, time, address, title){
        _speaker = speaker;
        _capacity = capacity;
    }
    public string getLecture(){
        return($"Speaker: {_speaker}. Capacity: {_capacity}");
    }
}