using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool InUsOrNot()
    {
        if (_country == "USA")
        {
            return true;
        }

        if (_country == "US")
        {
            return true;
        }

        if (_country == "America")
        {
            return true;
        }

        return false;
    }

    public string Display()
    {
        string address = $"{_streetAddress}, {_city}, {_state}, {_country}";
        return address;
    }
}