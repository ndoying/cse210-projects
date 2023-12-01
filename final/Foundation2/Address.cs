using System;

class Address
{
    //Define the Address class properties
    private string _street;
    private string _city;
    private string _stateORprovince;
    private string _country;
    private bool _isUSA;

    //Set the properties
    public void SetAddressProperties(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _stateORprovince = state;
        _country = country;
    }

    //Method to determine if the address is in the USA
    public bool GetIsUSA()
    {
        if (_country is "USA")
        {
            _isUSA = true;
            return _isUSA;
        }
        else
        {
            _isUSA = false;
            return _isUSA;
        }
    }

    //Method to format the address into a string
    public string GetFormattedAddress()
    {
        string _shippingAddress = $"{_street},\n{_city}, {_stateORprovince}, \n{_country}";
        return _shippingAddress;
    }


}