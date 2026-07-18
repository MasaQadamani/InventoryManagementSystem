using InventoryManagementSystem;
using System;

class Program
{
    static Inventory inventory = new Inventory();

    static void Main(string[] args)
    {
        Console.WriteLine("Current Inventory");
        inventory.ViewAllProducts();
        AddProduct();
        EditProduct();
        Console.WriteLine("\nInventory after edit");
        inventory.ViewAllProducts();
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
        inventory.ViewAllProducts();
    }
    static void EditProduct()
    {
        Console.Write("Product name to be edited: ");
        string name = Console.ReadLine();
        Product p = inventory.FindProduct(name);
        if (p == null)
        {
            Console.WriteLine("No such product!");
            return;
        }

        Console.Write($"New name (blank to keep '{p.Name}'): ");
        string newName = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(newName))
            p.Name = newName;

        Console.Write($"New price (blank to keep {p.Price}): ");
        string newPrice = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(newPrice))
            p.Price = double.Parse(newPrice);

        Console.Write($"New quantity (blank to keep {p.Quantity}): ");
        string newQty = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(newQty))
            p.Quantity = int.Parse(newQty);

        Console.WriteLine("Product updated.");

    }











}