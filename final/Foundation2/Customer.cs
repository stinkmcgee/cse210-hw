// Customer
    // The customer contains a name and an address
    // The name is a string, but the Address is a class
    // The customer should have a method that can return whether they live in the USA or not
// Customer : Address
// *******
// name() = string
//*******
// getAddress?
// isUSA = true/false

public class Customer {
    private string _customerName;
    protected bool _isUSA = true;

    public void isUSA(){
    _isUSA = true;
    }
    public void notUSA(){
        _isUSA = false;
    }
    public Customer(string customerName){
        _customerName = customerName;
    }
    public void ShowCustomerDetails(){
        Console.WriteLine($"{_customerName}");
    }
    public virtual void Display(){
        Console.WriteLine($"USA Resident? {_isUSA}");
}

}

