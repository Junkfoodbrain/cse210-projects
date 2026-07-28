using System;

class Program
{

    static void Main(string[] args)
    {
        Address address1 = new Address("123 Your Street", "Roseville", " CA", "USA");
        Customer customer1 = new Customer("Leah Sorensen", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Hammer", 12, 12, 2);
        Product product2 = new Product("Screwdriver", 34, 8, 3);
        Product product3 = new Product("Wrench", 56, 15, 1);

        order1.addProduct(product1);
        order1.addProduct(product2);
        order1.addProduct(product3);

        Console.WriteLine("Start New Order Here--------------");
        Console.WriteLine(order1.getPackingLabel());
        Console.WriteLine(order1.getShippingLabel());
        Console.WriteLine("Total: $" + order1.getTotalPrice());
        Console.WriteLine();


        Address address2 = new Address("356 Diagon Alley", "London", " England", "UK");
        Customer customer2 = new Customer("Harry Potter", address2);
        Order order2 = new Order(customer2);

        Product product4 = new Product("Invisibility Cloak", 78, 50, 1);
        Product product5 = new Product("Wand", 45, 30, 1);

        order2.addProduct(product4);
        order2.addProduct(product5);

        Console.WriteLine("Start New Order Here--------------");
        Console.WriteLine(order2.getPackingLabel());
        Console.WriteLine(order2.getShippingLabel());
        Console.WriteLine("Total: $" + order2.getTotalPrice());
        Console.WriteLine();

    }
}