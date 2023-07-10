// Outdoor
// ******
// weather() = string
// description() = string
public class Outdoor : Event{
    private string _weather;

    public Outdoor(string weather, string type, string description, string date, int time, string address, string title) : base(type, description, date, time, address, title){
        _weather = weather;
    }
    public string getOutdoor(){
        return($"Predicted weather: {_weather}");
    }
}