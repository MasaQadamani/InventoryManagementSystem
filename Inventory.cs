using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagementSystem
{
    internal class Inventory
    {
        private List<Product> products  = new List<Product>();

        public void AddProduct(Product product)
        {
            { products.Add(product); }
        }
    }
}
