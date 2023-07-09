//Order
    // Contains a list of products and a customer
    // Can calculate the total cost of the order
        // and can return a string for the packing label
        // and can return a string for the shipping label.
    // The total price is calculated as the sum of the prices
        // of each product plus a one-time shipping cost
    // Company is based in the USA
        // If customer lives in USA, shipping is $5
            // if not, then shipping is $35
    // Packing label should list the name and product id of each
        // product in the order
    // A shipping label should list the name and address of the customer

// Order
// ******
// orderNumber() = int - gives order number
// packingLabel() = string - lists name and product if for each product being bought
// shippingLabel() = string - lists customer name and address
// ******
// calculateOrder()
// showOrder() = shows order with customer name and products being purchased
// totalPrice() = sum of prices of products + one time shipping cost 
using System;
using System.Collections;
public class Order{
   // public Address a{get; set;}
   // public Customer c{get; set;}
    
    // try to figure out interfaces to call Address, Customer, and Products
   // public Order(Address a, Customer c){
   //     this.a = a;
   //     this.c = c;
   // }
   interface Customer{
        string GetName();
   }
   interface Address{
        string getAddress();
   }
   interface Product{
        string getProduct();
   }
    class GetOrder : Customer{
        public void GetName(){
            ArrayList Name_list = new ArrayList();
            Name_list.Add("Link");
            Name_list.Add("Obi Wan Kenobi");
            Name_list.Add("Jar Jar Binks");
            foreach(var elements in Name_list){
                Console.WriteLine(elements);
            }
        }
    }
    class getOrder : Address{
        List<string> Adr_list = new List<string>();
        public void getAddress(){
            for(int i = 0; i < Adr_list.Count; i++)
                Debug.Log(Adr_list);
            Adr_list.AddRange("1986 Nintendo Lane", "Hyrule", "California", "USA" );
            Adr_list.AddRange("1977 20th Century Street", "Mos Eisley", "Tattoine", "USA");
            Adr_list.AddRange("1999 Lucasfilm Way", "Otoh Gunga", "Naboo", "Mid Rim");
            
        }
    }
    private int _orderNumber;
    public Order(int orderNumber){
        _orderNumber = orderNumber;
    }

    // displays order number, customer name, products being bought
    public void packingLabel(){
        Console.WriteLine($"Order Number: {_orderNumber}");
        Console.WriteLine($"Name: {_customerName}");
    }

    // display customer name and customer address
    public void shippingLabel(){

    }

    public void showOrder(){
        Console.WriteLine($"Order Number: {_orderNumber}");
    }

    public override void Display(){
        base.Display();
        showOrder();
    }
}