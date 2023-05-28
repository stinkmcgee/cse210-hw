public class Reference{
    public string _book;
    public int _startVerse;
    public int _endVerse;
    public int _chapter;

    public string Display(){
    return $"{_book} {_chapter}: {_startVerse} {_endVerse}";
    }
}