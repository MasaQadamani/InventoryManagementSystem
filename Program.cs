using InventoryManagementSystem;
using System;

class Program
{
    static Inventory inventory = new Inventory();

    static void Main(string[] args)
    {

        bool exit = false;
        while (!exit)
        {
            PrintMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": AddProduct(); break;
                case "2": inventory.ViewAllProducts(); break;
                case "3": EditProduct(); break;
                case "4": DeleteProduct(); break;
                case "5": SearchProduct(); break;
                case "6": exit = true;
                    Console.WriteLine("GOODBYE!");
                    break;
                default: Console.WriteLine("Try Again!"); break;

            }
        }
        

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
    static void DeleteProduct()
    {
        Console.Write("Product name to be deleted: ");
        string name = Console.ReadLine() ;
        
        bool deleted = inventory.DeleteProduct(name);
        if (deleted)
            Console.WriteLine("DELETED!");
        else
            Console.WriteLine("No such Product!");

    }
    static void SearchProduct()
    {
        Console.Write("Product name to search for: ");
        string name = Console.ReadLine();
        Product p = inventory.FindProduct(name);
        if (p == null)
        {
            Console.WriteLine("No such product!");
            return;
        }
        Console.WriteLine(p.ToString());
    }
    static void PrintMenu()
    {
        Console.WriteLine("\n--- Inventory Menu ---");
        Console.WriteLine("1. Add product");
        Console.WriteLine("2. View all products");
        Console.WriteLine("3. Edit product");
        Console.WriteLine("4. Delete product");
        Console.WriteLine("5. Search product");
        Console.WriteLine("6. Exit");
        Console.Write("Choose an option: ");
    }

        










}