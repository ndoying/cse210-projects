using System;

class Address
{
    private string _street;
    private string _city;
    private string _stateORprovince;
    private string _zip;
    private string _country;
    private bool _isUSA;

    public void SetAddressProperties(string street, string city, string state, string zip, string country)
    {
        _street = street;
        _city = city;
        _stateORprovince = state;
        _zip = zip;
        _country = country;
    }

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

    public string GetFormattedAddress()
    {
        string _shippingAddress = $"{_street},\n{_city}, {_stateORprovince}, {_zip},\n{_country}";
        return _shippingAddress;
    }


}