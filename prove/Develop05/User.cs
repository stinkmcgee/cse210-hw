// shows current level
// and shows possible levels?

public class User
{
    int Points = 0;
    string CurrentLevel = "Youngling";
    IDictionary<string, int> Levels = new Dictionary<string, int>();
    
    public User(){
        Levels.Add("Youngling", 0);
        Levels.Add("Padawan", 100);
        Levels.Add("Jedi Knight", 500);
        Levels.Add("Jedi Master", 1000);
    }

}