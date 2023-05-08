// Display - iterate, show   
// consult Board.cs from the quote board code along        

public class Display{
    List<Entry> _entries = new List<Entry>(); 

    private void NicePrint(string item){
        Console.WriteLine("-----------");
    }
    public void ShowEntry(){
        foreach (EntryPointNotFoundException entry in _entries){
            NicePrint(entry.GetEntry());
        }
    }

    public void AddEntry(Entry entry){
        _entry.Add(entry);
    }
    public void FindEntryByDate(string date){
        foreach (Entry entry in _entry){
            if(entry.HasDate(date)){
                NicePrint(entry.GetEntry());
            }
        }
    }
}
