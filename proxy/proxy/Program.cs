using proxy;
using System;

namespace ProxyPattern_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Proxy Design Pattern Example - Thecodeprogram";
            
            Console.WriteLine("Operations directly inside the server : ");

            Server _server = new Server();
            if (_server.check_isLoggedIn() == false)
                Console.WriteLine("-You have to login first");

            _server.login("burak", "12345");

            if (_server.check_isLoggedIn())
                Console.WriteLine("-You have logged in");

            _server.some_operations();

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Operations Via Proxy Class : ");
            ProxyClass proxy = new ProxyClass();
            proxy.access_server();
            proxy.login("burak", "12345");
            proxy.access_server();
            proxy.read_some_data();

            Console.ReadLine();
        }
    }
}