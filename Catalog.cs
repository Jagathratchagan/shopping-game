using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shopping_game
{
    public class Catalog
    {
        private static readonly List<Product> products = new List<Product>
        {
            new Product("ipd", "Super iPad", 549.99m, "$"),
            new Product("mbp", "MacBook Pro", 1399.99m, "$"),
            new Product("atv", "Apple TV", 109.50m, "$"),
            new Product("vga", "VGA adapter", 30.00m, "$")
        };

        public static Product GetProduct(string product)
        {
            return products.FirstOrDefault(p => p.ProductID == product);
        }

        public static List<Product> ViewProducts()
        {
            return products;
        }

    }

}
