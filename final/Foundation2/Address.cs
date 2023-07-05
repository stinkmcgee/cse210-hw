// Address
    // The address contains a string for the street address, the city, state, and country
    // should have a method that can return whether it is USA or not
    // should have a method to return a string all of its fields together in one string
        // with newline characters where appropriate
// Address
// ******
// street() = string
// city() = string
// state() = string
// country() = string
// ******
// isUSA = true/false
//

public class Address : Customer{
    public string _street;
    public string _city;
    public string _state;
    public string _country;
    public Address(string street, string city, string state, string country){
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public void ShowAddress(){
        Console.WriteLine($"{_street}");
        Console.WriteLine($"{_city}, {_state}");
        Console.WriteLine($"{_country}");
    }
    public override void Display(){
        base.Display();
        showAddress();

    }
}