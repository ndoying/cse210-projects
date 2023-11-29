using System;

class Customer
{
    private string _name;
    private Address _address;

    public void SetCustomerProperties(string name)
    {
        _name = name;
    }
    
    public string GetName()
    {
        return _name;
    }
    public Address Address 
    {
        get {return _address;}
        set {_address = value;}
    }
    
    // public Customer(string name, Address address)
    // {
    //     _name = name;
    //     _address = address;
    // }
    // string flag = GetIsUSA();

}