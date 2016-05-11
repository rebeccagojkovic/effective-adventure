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
            localhost.WebService obj = new localhost.WebService();
            
            list.ForEach(i => Console.Write("{0}\t", i));

            Console.WriteLine("{0}\t", obj.ReadCustomer());
            Console.Read();
        }
    }
}
