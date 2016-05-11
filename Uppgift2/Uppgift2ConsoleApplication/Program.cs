using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            localhost.WebService service = new localhost.WebService();
            foreach (string s in service.GetCustomers())
            {
                Console.WriteLine("\n Calling show Method");
                Console.WriteLine(s + "\n");
            }
                       
            Console.Read();
        }
    }
}
