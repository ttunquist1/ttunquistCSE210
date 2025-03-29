using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("---------------------------------------------");
        //order 1 
        Address address1 = new Address ("538 s 2 w st", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Real Dude", address1);

        double order1ShippingCost = customer1.GetShippingCost();

        Product order1Product1 = new Product("Lightsaber", "1977", 89.00, 3);
        Product order1Product2 = new Product("Slave 1 lego set", "75060", 199.98, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(order1Product1);
        order1.AddProduct(order1Product2);
        double order1Subtotal = order1.CalculateSubtotal();
        double order1Total = order1.CalculateTotal();

        //display order 1
        order1.DisplayShippingLabel(); 
        Console.WriteLine();
        order1.DisplayPackingLabel();
        Console.WriteLine();
        order1.DisplayCosts(order1Subtotal ,order1ShippingCost, order1Total);


        Console.WriteLine("---------------------------------------------");


        //order 2
        Address address2 = new Address ("Rua Santo Irineu", "Sao Paulo", "Sao Paulo", "Brazil");
        Customer customer2 = new Customer("Juan Eduardo", address2);

        double order2ShippingCost = customer2.GetShippingCost();

        Product order2Product1 = new Product("Coca Cola", "1198", 2.50, 10);
        Product order2Product2 = new Product("Corn Dogs", "2287", 7.99, 4);
        Product order2Product3 = new Product("Rice", "1875", 0.38, 8);

        Order order2 = new Order(customer2);
        order2.AddProduct(order2Product1);
        order2.AddProduct(order2Product2);
        order2.AddProduct(order2Product3);
        double order2Subtotal = order2.CalculateSubtotal();
        double order2Total = order2.CalculateTotal();


        //display order 2
        order2.DisplayShippingLabel(); 
        Console.WriteLine();
        order2.DisplayPackingLabel();
        Console.WriteLine();
        order2.DisplayCosts(order2Subtotal, order2ShippingCost, order2Total);
        Console.WriteLine("---------------------------------------------");

    }   
}