using InventoryManagementSystem;
using System;

class Program
{
    static Inventory inventory = new Inventory();

    static void Main(string[] args)
    {
        AddProduct();
    }
    static void AddProduct()
    {
        Console.Write("Product name: ");
        string name = Console.ReadLine();
        Console.Write("Price: ");
        double price = double.Parse(Console.ReadLine());
        Console.Write("Quantity: ");
        int qty = int.Parse(Console.ReadLine());

        inventory.AddProduct(new Product(name, price, qty));
        Console.WriteLine("Product added.");
    }
}