using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 Elm Street", "Los Angeles", "California", "USA");
        Address address1 = new Address("22 Honey Street", "Caroline Springs", "Melbourne", "Australia");

        Customer customer = new Customer("John Smith", address);
        Customer customer1 = new Customer("Kevin Heart", address1);

        Product product = new Product("Cheese", 1234567, 2.5, 5);
        Product product1 = new Product("Ham", 891011, 65, 3);
        Product product2 = new Product("Bread", 12131415, 5, 5);
        Product product3 = new Product("Butter", 16171819, 6.75, 2);

        Order order = new Order(customer);

        order.AddProduct(product);
        order.AddProduct(product1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        //  ORDER #1
        Console.WriteLine();
        Console.WriteLine("PACKING LABEL: ");
        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine("SHIPPING LABEL: ");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine();
        Console.WriteLine("TOTAL COST: ");
        Console.WriteLine(order.GetTotalCost());

        //  ORDER #2
        Console.WriteLine();
        Console.WriteLine("PACKING LABEL: ");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("SHIPPING LABEL: ");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine();
        Console.WriteLine("TOTAL COST: ");
        Console.WriteLine(order1.GetTotalCost());
        
    }
}