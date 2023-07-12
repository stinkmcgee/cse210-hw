// Journal
// ******
// DisplayJournal() - display all entries
// SaveJournal() - get filename and save to list
// LoadJournal() - get filename and load from list

using System;
using System.Collections.Generic;
public class Journal{
    public string _name;

    public List<Entry> _entries = new List<Entry>();

    public void Display(){
        Console.WriteLine($"Journal Name: {_name}");

        foreach(Entry entry in _entries){
            entry.Display();
        }
    }
}