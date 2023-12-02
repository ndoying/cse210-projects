using System;

class Address
{
    //Define the Address class properties
    private string _street;
    private string _city;
    private string _state;
    

    //Set the properties
    public Address(string street, string city, string state)
    {
        _street = street;
        _city = city;
        _state = state;
    }
    
    // public void SetAddressProperties(string street, string city, string state)
    // {
    //     _street = street;
    //     _city = city;
    //     _state = state;
    // }

    //Method to format the address into a string
    public string GetFormattedAddress()
    {
        string _eventAddress = $"{_street}, {_city}, {_state}";
        return _eventAddress;
    }


}
    