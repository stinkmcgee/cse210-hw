using System;
public class ScriptWord{
    public string WordGet{get;}
    private bool isHidden{get; set;}
    public bool IsHidden { get; internal set; }

    public ScriptWord(string word){
        WordGet = word;
        isHidden = false;
    }
}