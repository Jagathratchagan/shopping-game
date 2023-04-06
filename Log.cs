using System;
using System.Collections.Generic;
using System.Text;

namespace shopping_game
{
    class Log
    {
        // Create New Instance
        private static Log instance = new Log(); // eagerly loads the singleton

        private Log()
        {
            // private to prevent anyone else from instantiating
        }

        public static Log getInstance()
        {   
            return instance;
        }

        public void WriteLog(string log)
        {
            Console.WriteLine(log);
        }

    }
}
