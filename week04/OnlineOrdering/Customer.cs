using System;

public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public bool UsaOrNot()
    {
        return _address.InUsOrNot();
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"Customer Name: {_customerName}, Address: {_address.Display()}";
        return shippingLabel;
    }
}