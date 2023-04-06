using System;
using System.Collections.Generic;
using System.Text;

namespace shopping_game
{
    public class CartItem
    {

        // Properties
        private string producid;
        private string productname;
        private decimal price;
        private string currency;
        private decimal quantity;        
        private decimal finalprice;

        public CartItem()
        {

        }

        public string ProducID
        {
            get { return producid; }
            set { producid = value; }
        }

        public string ProductName
        {
            get { return productname; }
            set { productname = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Currency
        {
            get { return currency; }
            set { currency = value; }
        }

        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal FinalPrice
        {
            get { return finalprice; }
            set { finalprice = value; }
        }

    }
}
