using System;

public class Reference{
    private string _book;
    private int _startVerse;
    private int _endVerse;
    private int _chapter;

    public Reference(string book, int startVerse, int endVerse, int chapter){
        _book = book;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _chapter = chapter;
    }
    public string GetReference(){
    return $"{_book} {_chapter}: {_startVerse}-{_endVerse}";
    }
}