using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace shopping_game
{
    class Checkout
    {
        //private static List<Product> products = new List<Product>();
        private static List<CartItem> cartitems = new List<CartItem>();
        private static List<IPricingRule> pricingRules;

        // Create New Instance
        private static Checkout instance = new Checkout(); // eagerly loads the singleton

        private Checkout()
        {
            // private to prevent anyone else from instantiating
        }

        public static Checkout getInstance()
        {
            #region Create the pricing rules
            var rules = new List<IPricingRule>
            {
                new ThreeForTwoRule("atv"),
                new BulkDiscountRule("ipd", 4, 499.99m),
                new FreeProductRule("mbp", "vga")
            };
            #endregion
            pricingRules = rules;

            return instance;
        }

        public void Scan(string productid, decimal quantity)
        {

            Product product = Catalog.GetProduct(productid);
            CartItem cartitem = new CartItem();
            cartitem.ProducID = productid;
            cartitem.ProductName = product.ProductName;
            cartitem.Price = product.Price;
            cartitem.Currency = product.Currency;
            cartitem.Quantity = quantity;                        

            if (cartitem != null)
            {
                cartitems.Add(cartitem);
            }

        }

        public decimal Total(CartItem cartitem)
        {
            decimal total = 0;
            foreach (IPricingRule rule in pricingRules)
            {
                total = rule.CalculatePrice(cartitem);
            }
            return total;
        }

        public List<CartItem> ViewCartItems()
        {
            return cartitems;
        }

        public List<IPricingRule> GetPriceingRules()
        {
            return pricingRules;
        }

        public CartItem GetCartItem(string productid)
        {
            CartItem cartitem = cartitems.FirstOrDefault(p => p.ProducID == productid); 
            return cartitem;
        }

    }
}
