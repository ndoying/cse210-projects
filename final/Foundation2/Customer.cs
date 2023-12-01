using System;

class Customer
{
    //Define the Customer class properties
    private string _name;
    private Address _address;

    //Set the properties
    public void SetCustomerProperties(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    
    //Getters
    public string GetName()
    {
        return _name;
    }
    public Address GetAddress()
    {
        return _address; 
    }
    
    public bool GetInUSA()
    {
        return _address.GetIsUSA();
    }

}