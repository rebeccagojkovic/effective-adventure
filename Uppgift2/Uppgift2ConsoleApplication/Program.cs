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
            //ServiceReference1.Customer obj = new ServiceReference1.Customer();

            //var service = new localhost.WebService();
            //Console.WriteLine("Service result: " + service.XMLRequest(xml));

            //var list = new List<int>(Enumerable.Range(0, 50));
            //    list.ForEach(i => Console.Write("{0}\t", i));


            var service = new ServiceReference1.Customer();
            Console.WriteLine("\n Calling show Method");
            Console.WriteLine("  " + service.CNumber);
            
            Console.Read();
        }
    }
}
