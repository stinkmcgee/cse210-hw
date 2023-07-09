// Product
    // Contains name, product id, price, and quantity of each product
    // The price of this product is computed by multiplying the price and the
        // quantity
// Product
// ******
// name() = string
// productID() = int
// price() = int
// quantity() = int
// ******
// productPrice = price * quantity

public class Product{
    public string _name;
    public int _productID;
    public int _price;
    public int _quantity;
    public int actualPrice;

    public List<Product> _product = new List<Product>();
    //public List<string> _product = new List<string>();

    public Product(string name, int productID, int price, int quantity){
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
        // products... move maybe?
        Product heartyLizard = new Product("Hearty Lizard", 1, 100, 3);
        heartyLizard.Display();
        Product arrow = new Product("Arrow", 2, 25, 5);
        arrow.Display();
        Product restlessCricket = new Product("Restless Cricket", 3, 25, 5);
        restlessCricket.Display();
        Product sunsetFirefly = new Product("Sunset Firefly", 4, 50, 10);
        sunsetFirefly.Display();
        Product summerWing = new Product("Summerwing Butterfly", 5, 30, 5);
        summerWing.Display();
        Product octoBalloon = new Product("Octo Balloon", 6, 25, 3);
        octoBalloon.Display();
        Product tirelessFrog = new Product("Tireless Frog", 7, 20, 5);
        tirelessFrog.Display();
    }
    public void productPrice(){
        actualPrice = _price * _quantity;
    }
    public void Display(){

        foreach(Product product in _product){
            Console.WriteLine($"Product: {_name}");
            Console.WriteLine($"{_productID}");
            Console.WriteLine($"Product Price: {actualPrice}");
        }

    }
}