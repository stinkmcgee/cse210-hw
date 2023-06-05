/**********************************
*            Reference            *
*---------------------------------*
* _book : string                  *
* _startVerse : int               *
* _endVerse : int                 *
* _chapter : int                  *
*---------------------------------*
* Reference()                       *
* Reference(book : string, startVerse : int, endVerse : int, chapter : int)   *
**
* Display()*
**********************************/

public class Reference{
    public string _book;
    public int _startVerse;
    public int _endVerse;
    public int _chapter;

    public Reference(string book, int startVerse, int endVerse, int chapter){
        _book = book;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _chapter = chapter;
    }
    public string Display(){
    return $"{_book} {_chapter}: {_startVerse} {_endVerse}";
    }
}