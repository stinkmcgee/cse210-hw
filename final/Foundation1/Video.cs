    // Video Class
    // ******
    // title() = string 
    // author() = string
    // length() = int

using System;

public class Video{
    public string _title;
    public string _author;
    public int _length;
    public List<Video> _video = new List<Video>();
    public List<Comment> _comment = new List<Comment>();
    public void Display(){
        Console.WriteLine(" ");
        Console.WriteLine($"{_title} by {_author}.");
        Console.WriteLine($"Length {_length} seconds.");
        Console.WriteLine("Comments: ");

       // foreach(Comment comment in _comment){
       //     comment.Display();
        //};
    }
}