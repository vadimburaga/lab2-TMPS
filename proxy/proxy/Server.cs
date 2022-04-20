using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy
{
    class Server : IServer
    {
        private string username = "";
        private string password = "";
        private bool isLoggedIn = false;

        public bool login(string _username, string _password)
        {
            username = _username;
            password = _password;

            if (username != "" && password != "")
            {
                if (username == "burak" && password == "12345")
                {
                    Console.WriteLine("Logging in successful");
                    isLoggedIn = true;
                    return true;
                }
                else
                {
                    Console.WriteLine("Wrong user parameters");
                    isLoggedIn = false;
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Can not send empty user parameters..");
                isLoggedIn = false;
                return false;
            }
        }

        public bool check_isLoggedIn()
        {
            return isLoggedIn;
        }

        public void some_operations()
        {
            if (this.isLoggedIn)
            {
                Console.WriteLine("Operation representing...");
            }
            else
            {
                Console.WriteLine("Failed. You need to log in first...");
            }
        }
    }
}
