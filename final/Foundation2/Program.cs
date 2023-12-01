using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        //First Order
        Address customerAddress1 = new Address();
        customerAddress1.SetAddressProperties("13 Jonathan Avenue", "San Jose", "CA", "USA");
        Customer customerInfo1 = new Customer();
        customerInfo1.SetCustomerProperties("John Ford", customerAddress1); 
        Order order1 = new Order();
        order1.SetOrderProperties(customerInfo1);
        Products product1 = new Products();
        product1.SetProductsProperties(101, "Black Beans", 1.25, 20);
        order1.AddProduct(product1);
        Products product2 = new Products();
        product2.SetProductsProperties(201, "Red Beans", 2.25, 30);
        order1.AddProduct(product2);
        Products product3 = new Products();
        product3.SetProductsProperties(301, "Gold Beans", 350.25, 1);
        order1.AddProduct(product3);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nThe Order Total is: ${order1.GetTotal()}");
        Console.WriteLine();

        //Second Order
        Address customerAddress2 = new Address();
        customerAddress2.SetAddressProperties("14 Bradley Avenue", "Medford", "MA", "USA");
        Customer customerInfo2 = new Customer();
        customerInfo2.SetCustomerProperties("Alfred Hitchcock", customerAddress2); 
        Order order2 = new Order();
        order2.SetOrderProperties(customerInfo2);
        Products product4 = new Products();
        product4.SetProductsProperties(401, "Silver Beans", 150.85, 2);
        order2.AddProduct(product4);
        Products product5 = new Products();
        product5.SetProductsProperties(501, "Boston Baked Beans", 3.75, 15);
        order2.AddProduct(product5);
        Products product6 = new Products();
        product6.SetProductsProperties(601, "String Beans", 1.25, 50);
        order2.AddProduct(product6);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nThe Order Total is: ${order2.GetTotal()}");
        Console.WriteLine();

        //Third Order
        Address customerAddress3 = new Address();
        customerAddress3.SetAddressProperties("10-15-23 Tobe-cho", "Yokohama", "Kanagawa", "Japan");
        Customer customerInfo3 = new Customer();
        customerInfo3.SetCustomerProperties("Akira Kurosawa", customerAddress3); 
        Order order3 = new Order();
        order3.SetOrderProperties(customerInfo3);
        Products product7 = new Products();
        product7.SetProductsProperties(701, "Daimond Beans", 750.85, 3);
        order3.AddProduct(product7);
        Products product8 = new Products();
        product8.SetProductsProperties(801, "Azuki Beans", 5.75, 10);
        order3.AddProduct(product8);
        Products product9 = new Products();
        product9.SetProductsProperties(901, "Lima Beans", 0.75, 60);
        order3.AddProduct(product9);

        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"\nThe Order Total is: ${order3.GetTotal()}");
        Console.WriteLine();
        
        
    }
}
        