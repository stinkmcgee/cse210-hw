// write a program to keep track of YouTube videos and comments left on them
//should have a Video class
    // has responsibility to track the title, author, and length of video
    // each video also has responsibility to store a list of comments
    // and should have a method to return number of comments
    // Video Class
    // ******
    // title() = string 
    // author() = string
    // length() = int
    // comments() = list

// comments should be defined in Comment class
    // has responsibility for tracking both the name of the person who wrote it
    // and the text of the comment
    // Comment Class
    // ******
    // comment() = string
    // writer() = string

// write a program that creates 3-4 videos, sets the appropriate values
    // and for each one add a list of 3-4 comments
// put each video in a list
// have program iterate through the list of videos and for each one
    // display the title, author, length, number of comments and then list
    // out all of the comments for that video
using System;

class Program
{
    static void Main(string[] args)
    {
        // create video 1
            Video video1 = new Video();
            video1._title = "Recreating Saw Traps in Real Life!";
            video1._author = "Mr.Beast";
            video1._length = 1200;
            // add comments to it and add comments to comments list
            Comment comment1v1 = new Comment();
            comment1v1._comment = "Crazy how deadly these traps are!";
            comment1v1._writer = "Jane Doe";
            Comment comment1v2 = new Comment();
            comment1v2._comment = "Squid Games, now this?? Dude needs to be locked up!";
            comment1v2._writer = "Fergus Ferguson";
            Comment comment1v3 = new Comment();
            comment1v3._comment = "This guy is the new jugsaw without the cancer";
            comment1v3._writer = "John Kramer";
            video1.Display();
            comment1v1.Display();
            comment1v2.Display();
            comment1v3.Display();
        // create video 2
            Video video2 = new Video();
            video2._title = "A Marxist's Review of Shrek the Third";
            video2._author = "AnonymousCommunist";
            video2._length = 3600;
            Comment comment2v1 = new Comment();
            comment2v1._comment = "Really makes you think...";
            comment2v1._writer = "xXpreppygirlXx";
            Comment comment2v2 = new Comment();
            comment2v2._comment = "Mcarthyism in Shrek? I know what I'm not showing my kids now.";
            comment2v2._writer = "NotAKaren";
            Comment comment2v3 = new Comment();
            comment2v3._comment = "Great video!";
            comment2v3._writer = "ajdfhsdafkhdla19bda76";
            video2.Display();
            comment2v1.Display();
            comment2v2.Display();
            comment2v3.Display();
        // create video 3
            Video video3 = new Video();
            video3._title = "History of the Abandoned Garfield Ride";
            video3._author = "ThemeParkCreep";
            video3._length = 1234;
            Comment comment3v1 = new Comment();
            comment3v1._comment = "How did I just find out about this ride!";
            comment3v1._writer = "KorokFinder";
            Comment comment3v2 = new Comment();
            comment3v2._comment = "Love listening to these videos while crocheting";
            comment3v2._writer = "SweetTulip";
            Comment comment3v3 = new Comment();
            comment3v3._comment = "Why are you guys still following this creep?";
            comment3v3._writer = "Dimitri Adidas";
            video3.Display();
            comment3v1.Display();
            comment3v2.Display();
            comment3v3.Display();
        // create video 4
            Video video4 = new Video();
            video4._title = "Three Tips to Surviving";
            video4._author = "TheRealSurvivalist";
            video4._length = 123;
            Comment comment4v1 = new Comment();
            comment4v1._comment = "Wow, now I know what it takes to survive!";
            comment4v1._writer = "CapybaraGroomer";
            Comment comment4v2 = new Comment();
            comment4v2._comment = "Followed instructions to a T. I am no longer surviving. Help.";
            comment4v2._writer = "Azeli Fox";
            Comment comment4v3 = new Comment();
            comment4v3._comment = "Surviving what?";
            comment4v3._writer = "OppenheimerBarbieEnthusiast";
            video4.Display();
            comment4v1.Display();
            comment4v2.Display();
            comment4v3.Display();
    }
}