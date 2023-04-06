using System;
using System.Collections.Generic;
using System.Text;

namespace shopping_game
{
    interface IPricingRule
    {
        decimal CalculatePrice(CartItem cartitem);
    }
}
