using System;
using System.Numerics;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost() // total + shipping cost
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total = total + product.GetTotalCost();
        }

        if (_customer.UsaOrNot())
        {
            total = total + 5;
        }

        else
        {
            total = total + 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = " ";

        foreach (Product product in _products)
        {
            label = label + product.GetPackingLabel() + "\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return _customer.GetShippingLabel();
    }
}