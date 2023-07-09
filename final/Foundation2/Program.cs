// write a program that has classes for Product, Customer, Address, and Order
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
// Product
    // Contains name, product id, price, and quantity of each product
    // The price of this product is computed by multiplying the price and the
        // quantity
// Customer
    // The customer contains a name and an address
    // The name is a string, but the Address is a class
    // The customer should have a method that can return whether they live in the USA or not
// Address
    // The address contains a string for the street address, the city, state, and country
    // should have a method that can return whether it is USA or not
    // should have a method to return a string all of its fields together in one string
        // with newline characters where appropriate
// make sure all member variables are private and getters, setters, and constructors are
    // created as needed
// write a program that creates at least two orders with 2-3 products each

// products

// customers
Customer link = new Customer("Link");
link.Display();
Customer obiWan = new Customer("Obi Wan Kenobi");
obiWan.Display();
Customer joshuaGraham = new Customer("Joshua Graham");
joshuaGraham.Display();