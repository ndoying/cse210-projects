using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address customerAddress1 = new Address();
        customerAddress1.SetAddressProperties("13 Jonathan Avenue", "San Jose", "CA", "95118", "USA");
        Customer customerInfo1 = new Customer();
        customerInfo1.SetCustomerProperties("Akira Kurosawa", customerAddress1); 
        Order order1 = new Order();
        order1.SetOrderProperties(01, customerInfo1);
        Products product1 = new Products();
        product1.SetProductsProperties(201, "Black Beans", 1.25, 20);
        order1.AddProduct(product1);
        Products product2 = new Products();
        product2.SetProductsProperties(301, "Red Beans", 2.25, 30);
        order1.AddProduct(product2);
        Products product3 = new Products();
        product3.SetProductsProperties(401, "Gold Beans", 350.25, 1);
        order1.AddProduct(product3);

        order1.PrintPackingLabel();
        Console.WriteLine();
        order1.PrintShippingLabel();
        Console.WriteLine();
        
        
    }
}
        