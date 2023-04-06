using System;
using System.Collections.Generic;
using System.Text;

namespace shopping_game
{
    class Product
    {
        // Properties
        private string sku;
        private string name;
        private double price;
        private string currency;

        public Product()
        {
             
        }
         
        public string SKU
        {
            get { return sku; }
            set { sku = value; }
        }

        public string Name
        {
            get { return name; } 
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Currency
        {
            get { return currency; }
            set { currency = value; }
        }

    }
}
