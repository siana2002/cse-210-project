using System;

public class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string name, int productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        double total = _price * _quantity;
        return total;
    }

    public string GetPackingLabel()
    {
        string packingLabel = $"Product Name: {_name}, Product ID: {_productId} ";
        return packingLabel;
    }
}