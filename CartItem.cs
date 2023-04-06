using System;
using System.Collections.Generic;
using System.Text;

namespace shopping_game
{
    class CartItem
    {

        // Properties
        private string sku;
        private string name;
        private double price;
        private string currency;
        private string quantity;
        private string offerflag;
        private double finalprice;

        public CartItem()
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

        public string Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string OfferFlag
        {
            get { return offerflag; }
            set { offerflag = value; }
        }

        public double FinalPrice
        {
            get { return finalprice; }
            set { finalprice = value; }
        }

    }
}
