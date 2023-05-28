using System;
using System.Collections.Generic;

public class Scripture{
    private List<Word> _words = new List<Word>();

    Reference reference = new Reference(); //place refrence in parentheses

    private string _Scripture = " "; //place scripture in quotes. figure out how to let person manually place scripture and save it??
    public Scripture(string wholeText){
        string[] texts = wholeText.Split(" ");
        for (int i = 0; i < texts.Length; i++){
            string text = texts[i];
            Word word = new Word(text);
            _words.Add(word);
        }
    }
// !! use void if method does not return a value !!
    public void RandomlyHiddenWord(){
        List<Word> visibleWords = GetVisibleWords(); //put GetVisibleWords in word. figure it out
        Random random = new Random();
        int index = random.Next(0, visibleWords.Count);
        Word word = visibleWords[index];
        word.Hide(); //figure out Hide. Put in word
    }
}