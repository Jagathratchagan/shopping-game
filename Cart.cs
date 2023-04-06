using System;
using System.Collections.Generic;
using System.Text;

namespace shopping_game
{
    class Cart
    {
        // Properties         
        private static List<CartItem> cartitems = new List<CartItem>();

        // Create New Instance
        private static Cart instance = new Cart(); // eagerly loads the singleton

        private Cart()
        {
            // private to prevent anyone else from instantiating
        }

        public static Cart getInstance()
        {
            return instance;
        }

        public List<CartItem> ViewCart()
        {
            return cartitems;
        }

        public bool UpdateCart(CartItem item)
        {
            try
            {
                cartitems.Add(item);
                return true;
            }
            catch (Exception ex)
            {
                Log.getInstance().WriteLog(ex.Message);
                return false;
            }
        }


    }
}
