using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.LoginClient loginClient = new ServiceReference1.LoginClient();
            Console.WriteLine("Enter email:");
            string user = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();
            string res = loginClient.Login(user, password);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
