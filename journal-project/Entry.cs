public class Entry{
    private string _author = "";
    private string _entry = "";
    private string _date = "";

    public Entry(string person, string entry, string date){
        _author = person;
        _entry = entry;
        _date = date;
    }
    public string GetEntry(){
        return $"\"{_entry}\"\n{_author} - {_date}";
    }
}