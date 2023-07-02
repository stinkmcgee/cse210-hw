// display the list of Eternal goals
// child of Goal class
    // that shows points, type, and description
// _type = string
public class Eternal : Goal{



    public List<string> displayGoals(){
    List<string> eternalGoals = new List<string>();
    return eternalGoals;
    }
    public Eternal (int points, string goalType, string description){
        eternalGoals.Add(100, "Eternal", "Go to the Temple");
        eternalGoals.Add(100, "Eternal", "Finish a book.");
        eternalGoals.Add(100, "Eternal", "Finish a show.");
        eternalGoals.Add(100, "Eternal", "Cook something new.");
        eternalGoals.Add(100, "Eternal", "Make a friend.");
    }
}