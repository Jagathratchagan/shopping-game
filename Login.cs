using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace shopping_game
{
    class Login
    {
        // Login Credentials
        private static string AppLoginID = ConfigurationManager.AppSettings["userid"].ToString();
        private static string AppPassword = ConfigurationManager.AppSettings["password"].ToString();

        public Login()
        {

        }

        public bool Authentication(string userid, string password)
        {
            bool result = false;

            try
            {
                if (AppLoginID.Equals(userid) && AppPassword.Equals(password))
                {
                    result = true;
                }
                else 
                {                    
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid User Id or Password. Please try again.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    result = false;
                }
            }
            catch (Exception ex)
            {
                Log log = Log.getInstance();
                log.WriteLog(ex.Message);
            }

            return result;
        }

    }
}
