// Entry
// ******
// _fileName() = string
// _date() = dateTime
// _prompt() = string
// _response() = string
// ******
// Display()

using System;
public class Entry{
    public string _fileName;
    public string _givenDate;
    public string _prompt;
    public string _response;

    public void Display(){
        Console.WriteLine($"File Name: {_fileName}");
        Console.WriteLine($"Created: {_givenDate}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"{_response}");
    }
}