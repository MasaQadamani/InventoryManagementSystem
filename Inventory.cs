using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagementSystem
{
    internal class Inventory
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void ViewAllProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("Inventory is Empty!");
            }
            else
            {
                foreach (Product product in products)
                {
                    Console.WriteLine(product.ToString());
                }
            }

        }
        public Product FindProduct(string name)
        {
            foreach (Product p in products)
            {
                if (p.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return p;
                }
            }
            return null;
        }


        public bool DeleteProduct(string name)
        {
            Product p = FindProduct(name);
            if (p == null)
                return false;
            products.Remove(p);
            return true;

        }
    }
}
