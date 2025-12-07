using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1234 Street dr","Pocatello","Idaho","USA");
        Product product1_1 = new Product("Black Beans","BEAN13475",0.99,8);
        Product product2_1 = new Product("Rice","RICE71311",4.99,2);
        Product product3_1 = new Product("Tortilla","TORT79813",5.50,1);
        Customer customer1 = new Customer("John Doe",address1);
        Order order1 = new Order(customer1, product1_1, product2_1, product3_1);
        order1.PackingLabel();
        order1.ShippingLabel();
        order1.TotalCost();

        Console.WriteLine("\n~~~\n");

        Address address2 = new Address("5678 Avenue pl","Somewhere","British Columbia","Canada");
        Product product1_2 = new Product("Rice","RICE71311",4.99,4);
        Product product2_2 = new Product("Tortilla","TORT798123",5.50,3);
        Customer customer2 = new Customer("Tanner Minecraft",address2);
        Order order2 = new Order(customer2, product1_2, product2_2);
        order2.PackingLabel();
        order2.ShippingLabel();
        order2.TotalCost();
    }
}