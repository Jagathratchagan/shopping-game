using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shopping_game
{
    class FreeProductRule : IPricingRule
    {
        private readonly string productid;
        private readonly string freeSku;

        public FreeProductRule(string product, string freeSku)
        {
            this.productid = product;
            this.freeSku = freeSku;
        }

        public decimal CalculatePrice(CartItem cartItems)
        {            
            decimal result = 0;

            CartItem item = Checkout.getInstance().GetCartItem(cartItems.ProducID);
            if (item != null)
            {
                if (cartItems.ProducID.ToUpper().Equals("MBP"))
                {    
                    result = item.Quantity * item.Price;
                }

                if (cartItems.ProducID.ToUpper().Equals("VGA"))
                {
                    CartItem item1 = Checkout.getInstance().GetCartItem("mbp");
                    if(item1 !=null)
                    {
                        result = 0;
                    }
                    else
                    {
                        result = item.Quantity * item.Price;
                    }
                }
            }

            return result;

        }
    }
}
