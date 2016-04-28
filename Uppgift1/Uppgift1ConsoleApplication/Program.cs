using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            localhost.WebService obj = new localhost.WebService();
            Console.WriteLine("Startar");
            Console.Write("Skriv in filnamn (test.txt) \n");
            String filename = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n" + obj.txtFile(filename));
            Console.WriteLine("\n ------------");
            Console.Read();
        }
    }
}
