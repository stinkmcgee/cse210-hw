
using System;
public class Event{
    // event type
    private string _type;
    private string _description;
    private string _date;
    private int _time;
    private string _address;
    private string _title;
    public Event(string type, string description, string date, int time, string address, string title){
        _type = type;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _title = title;
    }

    // lists title, description, date, time, and address
    public string GetStandardDetail(){
        return "Title: " + _title + " Description: " + _description + " Date: " + _date + " Time: " + _time + " Where: " + _address;
    }
    // standard details, type of event and info
            // for lectures, include speaker name and capacity
            // for receptions, include email to rsvp
            // for outdoor, include weather statement
    public string GetFullDetail(){
        return "Title: " + _title + " Description: " + _description + " Date: " + _date + " Time: " + _time + " Where: " + _address + " Type: " + _type;
    }
    // lists type of event, title, and date
    public string GetShortDetail(){
        return "Type: " + _type + " Title: " + _title  + " Date: " +  _date;
    }
}