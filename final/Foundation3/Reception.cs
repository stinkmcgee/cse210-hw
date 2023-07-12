// Reception
// ******
// rsvpEmail() = string
// description() = string
public class Reception : Event{
    private string _rsvpEmail;

    public Reception(string rsvpEmail, string type, string description, string date, int time, string address, string title)
     : base(type, description, date, time, address, title){
        _rsvpEmail = rsvpEmail;
    }
    public string getReception(){
        return($"Email to RSVP: {_rsvpEmail}");
    }
}