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

    public Product(string name, int productID, int price, int quantity){
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
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