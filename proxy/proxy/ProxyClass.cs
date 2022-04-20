using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy
{
    class ProxyClass : IServer
    {
        Server srv = new Server();
        bool loggedin = false;

        public void access_server()
        {
            if (srv.check_isLoggedIn() == false)
                Console.WriteLine("You have to be loggedin first...");
            else
                Console.WriteLine("Accessing is successfull to the server...");
        }

        public void read_some_data()
        {
            srv.some_operations();
        }

        public bool login(string _username, string _password)
        {
            loggedin = srv.login(_username, _password);
            return true;
        }
    }
}
