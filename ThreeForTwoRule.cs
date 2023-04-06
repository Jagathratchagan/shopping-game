using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shopping_game
{
    public class ThreeForTwoRule : IPricingRule
    {
        private readonly string productid;

        public ThreeForTwoRule(string productid)
        {
            this.productid = productid;
        }

        public decimal CalculatePrice(CartItem cartItems)
        {            
            decimal result = 0;

            CartItem item = Checkout.getInstance().GetCartItem(productid);
            if (item != null)
            {
                if (productid.ToUpper().Equals("ATV") &&  item.Quantity == 3)
                {
                    result= item.Price * 2;
                }
                else
                {
                    result= item.Quantity * item.Price;
                }
            }

            return result;
        }
    }
}
