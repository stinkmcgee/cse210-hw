// Scripture
// ******
// _text = string
// ******
// GetScripture()
using System;
public class Scripture{
    private readonly List<ScriptWord> words;

    public Scripture(string text){
        words = ConvertStringToWords(text);
    }

    public Reference Referene{ get; }

    private static List<ScriptWord> ConvertStringToWords(string text)
    {
        var words = text.Split(' ').Select(word => new ScriptWord(word)).ToList();
        return words;
    }

    public bool VerseFinished(){
        return words.All(word => word.IsHidden);
    }
    public void HideWord(){
        var hiddenWords = words.Where(word => word.IsHidden).ToList();
        var visibleWords = words.Where(word => !word.IsHidden).ToList();

        var randomIn = new Random().Next(visibleWords.Count);
        var wordToHide = visibleWords[randomIn];
        wordToHide.IsHidden = true;
    }

    public void GetScripture(){
       // return ($"{words}");
        Console.Clear();
        foreach(var word in words){
            if(word.IsHidden){
                Console.Write("- ");
            }
            else{
                Console.Write(word.WordGet + " ");
            }
        }
        Console.WriteLine();
    }
}