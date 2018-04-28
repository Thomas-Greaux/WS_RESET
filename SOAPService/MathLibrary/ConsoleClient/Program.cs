using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleClient.ServiceReference1;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MathsOperationsClient client = new MathsOperationsClient();
            Console.WriteLine(client.Add(100, 11));
            Console.WriteLine(client.Mult(47, 10));
            Console.ReadLine();
        }
    }
}
