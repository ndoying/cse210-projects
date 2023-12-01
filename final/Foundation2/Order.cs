using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

class Order
{
    //Define the Order class properties and create a product list
    private int _orderID;
    private List<Products> _products = new List<Products>();
    private Customer _customer;
    private double _shippingCost;

    //Set the properties
    public void SetOrderProperties (Customer customer)
    {
        _customer = customer;
        _shippingCost = 0;
    }

    //Method to add products to the product list
    public void AddProduct(Products product)
    {
        _products.Add(product);
    }

    //Method to calculate the total for the order including shipping cost
    public double GetTotal()
    {
        double total = 0;

        foreach (var product in _products)
        {
            total += product.CalculatePrice();
        }

        bool flag = _customer.GetInUSA();
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
    
    //Method to create a shipping label string
    public string GetShippingLabel()
    {
        string _shippingLabel = $"Customer Name: \n{_customer.GetName()}\nShipping Address:\n{_customer.GetAddress().GetFormattedAddress()}";
        return _shippingLabel;
    }

    //Method to create a packing label string
    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();
        packingLabel.AppendLine("Products Ordered: ");

        foreach (var product in _products)
        {
            packingLabel.AppendLine($"Product Name/ID: {product.GetProductName()}/{product.GetProductID()}");
        }
        return packingLabel.ToString();
    }
        
}