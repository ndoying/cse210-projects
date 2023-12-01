using System;
using System.Data.Common;
using System.Diagnostics.Contracts;

class Products
{
    private int _productID;
    private string _productName;
    private double _productPrice;
    private int _productQuantity;

    public void SetProductsProperties(int id, string name, double price, int quantity)
    {
        _productID = id;
        _productName = name;
        _productPrice = price;
        _productQuantity = quantity;

    }

    public string GetProductName()
    {
        return _productName;
    }

    public int GetProductID()
    {
        return _productID;
    }
    public double CalculatePrice()
    {
        double orderedValue = _productPrice * _productQuantity;
        return orderedValue;
    }

    
    
    

}