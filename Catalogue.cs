using System;
using System.Collections.Generic;
using System.Text;

namespace shopping_game
{
    class Catalogue
    {
        // Properties         
        private static List<Product> products = new List<Product>();

        // Create New Instance
        private static Catalogue instance = new Catalogue(); // eagerly loads the singleton

        private Catalogue()
        {
            // private to prevent anyone else from instantiating
        }

        public static Catalogue getInstance()
        {
            // Load Inventory            
            List<Product> items = new List<Product>()
            {
                new Product() { SKU = "ipd", Name="Super iPad" , Price= 549.99, Currency = "$" },
                new Product() { SKU = "mbp", Name="MacBook Pro" , Price= 1399.99, Currency = "$"  },
                new Product() { SKU = "atv", Name="Apple TV" , Price= 109.50, Currency = "$"  },
                new Product() { SKU = "vga", Name="VGA adapter" , Price= 30.00, Currency = "$"  }
            };
            products = items;

            return instance;
        }

        public  List<Product> GetProducts()
        {
            return products;
        }


    }
}
