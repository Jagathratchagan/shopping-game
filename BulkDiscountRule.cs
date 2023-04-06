using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shopping_game
{
    class BulkDiscountRule : IPricingRule
    {
        private readonly string productid;
        private readonly int quantity;
        private readonly decimal discountPrice;

        public BulkDiscountRule(string product, int quantity, decimal discountPrice)
        {
            this.productid = product;
            this.quantity = quantity;
            this.discountPrice = discountPrice;
        }

        public decimal CalculatePrice(CartItem cartItems)
        {
            CartItem item = Checkout.getInstance().GetCartItem(productid);
            decimal result = 0;

            if(item!=null)
            {
                if (productid.ToUpper().Equals("IPD") && item.Quantity > 4)
                {
                    result = item.Quantity * Convert.ToDecimal("499.9");
                }
                else
                {
                    result = item.Quantity * item.Price;
                }
            }
            return result;
        }

    }
}
