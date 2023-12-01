using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

class Order
{
    private int _orderID;
    private List<Products> _products = new List<Products>();
    private Customer _customer;
    private double _shippingCost;

    public void SetOrderProperties (int id, Customer customer)
    {
        _orderID = id;
        _customer = customer;
        _shippingCost = 0;
    }

    public void AddProduct(Products product)
    {
        _products.Add(product);
    }
    public double GetTotal()
    {
        double total = 0;

        foreach (var product in _products)
        {
            total += product.CalculatePrice();
        }

        bool flag = _customer.GetAddress().GetIsUSA();
        if ( flag == true)
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }
        return total + _shippingCost;
    }
    
    public void PrintShippingLabel()
    {
        Console.WriteLine($"Customer Name: \n{_customer.GetName()}");
        Console.WriteLine($"Shipping Address: \n{_customer.GetAddress().GetFormattedAddress()}");

    }
    public void PrintPackingLabel()
    {
        Console.WriteLine($"Order ID: {_orderID}");
        foreach (var product in _products)
        {
            Console.WriteLine($"Product Name/ID: {product.GetProductName()}/{product.GetProductID()}");
            
        }
        Console.WriteLine($"\nThe Order Total is: {GetTotal()}");

    }

}