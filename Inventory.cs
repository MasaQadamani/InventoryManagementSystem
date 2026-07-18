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
    }
}
