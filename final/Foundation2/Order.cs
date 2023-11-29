using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

class Order
{
    private int _orderID;
    private List<Products> _products = new List<Products>();
    private Customer _customer;
    private double _shippingCost;

    public void SetOrderProperties (int id, Customer customer, double shippingCost)
    {
        _orderID = id;
        _customer = customer;
        _shippingCost = shippingCost;
    }

    public string GetShippingLabel()
    {
        Address shippingAddress = _customer.Address;
        string formattedAddress = shippingAddress.GetFormattedAddress();
        Console.WriteLine(formattedAddress);
        return formattedAddress;
        
    }
    // public string GetPackingLabel();
    // {

    // }

}