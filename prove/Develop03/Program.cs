// create scripture study thingy
// program must:
    // 1. store a scripture, include reference and text
    // 2. accommodate scriptures with multiple verses
    // 3. clear screen and display complete scripture, including reference and text
    // 4. prompt user to press enter or type quit
    // 5. if user types quit, program should end
    // 6. if user presses the enter key, program should hide words in scripture, clear console screen, and display scripture again
    // 7. should continue prompting user and hiding more words until all words are hidden
    // 8. when all words in scripture are hidden, program ends
    // 9. when selecting random words to hide, select any word at random, even if word is already hidden
// program also must:
    // 1. use encapsulation
    // 2. contain at least 3 classes
        // one for scripture, reference, and wordRepresent
    // 3. provide multiple constructors for scripture reference to handle case of a single verse and verse range

// Scripture
// ******
// _text = string
// ******
// GetScripture()

// Reference
// ******
// _bookName = string
// _chapter = int
// _startVerse = int
// _endVerse = int
// ******
// GetReference()

// Word
// ******
// _word = string
// ******
// ShowWord() - shows the word
// HideWord() - figure out how to hide words then reveal them in ShowWord

using System;

class Program
{
    static void Main(string[] args)
    {
        //Scripture s1 = new Scripture("Now Jericho was straitly shut up because of the children of Israel: none went out, and none came in.");
        //Reference r1 = new Reference("Joshua", 1, 1, 6);
       // Console.WriteLine(r1.GetReference());
       // Console.WriteLine(s1.GetScripture());

      //  Console.WriteLine(" ");

        var scripture = new Scripture("Behold, blessed are you for this thing, and for speaking my words which I have given you according to my commandments. And now, behold, I say unto you, that the thing which will be of the most worth unto you will be to declare repentance unto this people, that you may bring souls unto me, that you may rest with them in the kingdom of my Father, Amen.");
        Reference r = new Reference("D&C", 5, 6, 15);
        //Console.WriteLine(r2.GetReference());
        //Console.WriteLine(s2.GetScripture());

        while(!scripture.VerseFinished()){
            Console.WriteLine(r.GetReference());
            scripture.GetScripture();
                Console.WriteLine("Enter to continue. Type 'Exit' to exit");
            var input = Console.ReadLine();

            if(input == "Exit")
                break;
            scripture.HideWord();
        }
    }
}