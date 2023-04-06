using System;
using System.Collections.Generic;
using System.Text;

namespace shopping_game
{
    public class Product
    {
        public string ProductID { get; }
        public string ProductName { get; }
        public decimal Price { get; }
        public string Currency { get; }
        
        public Product(string productid, string productname, decimal price, string currency)
        {
            ProductID = productid;
            ProductName = productname;
            Price = price;
            Currency = currency;
        }
    }

}
