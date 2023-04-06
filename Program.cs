using System;
using System.Collections.Generic;

namespace shopping_game
{
    class Program  
    {
        private static bool authflag = false;
        private static List<IPricingRule> pricingRules = new List<IPricingRule>();
        private static Checkout checkout = Checkout.getInstance();

        static void Main(string[] args)
        {
            Console.WriteLine("####################################");
            Console.WriteLine("           Authentication          ");
            Console.WriteLine("####################################");
            Console.WriteLine();
            Console.WriteLine("Plesae enter you credentials :");
            Console.WriteLine("------------------------------");

            #region Authentication            
            do
            {
                Authenticate();
            } while (authflag == false);
            #endregion
             
            if (authflag)
            {
                Header();

                #region Transaction Options
                string input = Console.ReadLine();

                if (input.Equals("1"))
                {
                    bool ordercompletion = false;
                    #region Order Transaction
                    do
                    {
                        Console.Write("Enter Product Id (e.g. ipd, mbp, atv, vga): > ");
                        string productid = Console.ReadLine();

                        if (productid.ToUpper().Equals("IPD") || productid.ToUpper().Equals("MBP") || productid.ToUpper().Equals("ATV") || productid.ToUpper().Equals("VGA"))
                        {
                            Console.Write("Quantity: > ");
                            string quantity = Console.ReadLine();

                            Console.Write("Confirm item addition to Cart? (Yes/No): > ");
                            string itemconfirmation = Console.ReadLine();

                            // Add product in Cart
                            if (itemconfirmation.ToUpper().Equals("YES"))
                            {
                                // Scan Barcode          
                                checkout.Scan(productid, Convert.ToDecimal(quantity));
                                
                                Console.Write("Item successfully added to Cart!");
                                Console.WriteLine();
                                 
                            }
                            else if (itemconfirmation.ToUpper().Equals("NO"))
                            {

                            }
                            else
                            {
                                Console.Write("Invalid command.");
                                Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Do you want to add more items (Yes/No): > ");
                            Console.ForegroundColor = ConsoleColor.White;
                            string addmoreitemconfirmation = Console.ReadLine();

                            Console.WriteLine();
                            if (addmoreitemconfirmation.ToUpper().Equals("NO"))
                            {
                                ordercompletion = true;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid Product Id!. Please try again.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                        }

                    } while (ordercompletion == false);
                    #endregion

                    ShowCartItems();

                }
                else if (input.Equals("2"))
                {
                    Console.WriteLine("Under construction");
                }
                else if (input.Equals("3"))
                {
                    Console.WriteLine("Under construction");
                }
                else
                {
                    Console.WriteLine("Invalid command. Please choose right option.");
                }

                #endregion
            }
            Console.ReadLine();
        }

        private static void Header()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("####################################");
            Console.WriteLine("      Welcome to Shopping Game      ");
            Console.WriteLine("####################################");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            ShowProductCatelouge();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Choose Transaction :");
            Console.WriteLine("Press (1) Make Order, (2) Check Out, (3) View Offers");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.Write("Transaction > ");
        }

        private static void ShowProductCatelouge()
        {
            // Load Product Catalogue                        
            List<Product> products = new List<Product>();
            products = Catalog.ViewProducts();

            Console.WriteLine("Product Catalogue :");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("| SKU " + "\t| Name" + "\t\t\t| Price" + "\t\t|");
            Console.WriteLine("-------------------------------------------------");

            foreach (var item in products)
            {                
                Console.WriteLine("| " + item.ProductID + "\t| " + item.ProductName + "\t\t| " + item.Price.ToString("0.00") + "\t|");
            }

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
        }

        private static void ShowCartItems()
        {
            // Load Product Catalogue            
            List<CartItem> cartitems = new List<CartItem>();            
            cartitems = checkout.ViewCartItems();

            Console.WriteLine("Cart Items :");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("| SKU " + "\t| Product Name" + "\t| Quantity" + "\t| Actual Price" + "\t| Discount Price" + "|");
            Console.WriteLine("---------------------------------------------------------------------------");

            foreach (var item in cartitems)
            {
                Console.WriteLine("| " + item.ProducID + "\t| " + item.ProductName + "\t| " + item.Quantity + "\t\t| " + item.Currency + " " + item.Price.ToString("0.00") + "\t| " + checkout.Total(item).ToString("0.00") + "\t|");
            }

            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine();
        }

        private static bool Authenticate()
        {            
            Login login = new Login();            
            Console.Write("Enter User Id: ");
            string userid = Console.ReadLine();
            Console.Write("Enter Password: ");            
            string passwrord = Console.ReadLine();            
            authflag = login.Authentication(userid, passwrord);
            return authflag;
        }
         
    }
}
