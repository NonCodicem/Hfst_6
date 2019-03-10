using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoofdstuk_6_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(r.Next(100));
            Console.WriteLine(r.Next(100));
            Console.WriteLine(r.Next(100));
            Console.WriteLine(r.Next(50, 100));

            r = new Random(1000);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(r.Next(50, 100));
            Console.WriteLine(r.Next(50, 100));
            Console.WriteLine(r.Next(50, 100));

            r = new Random(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(r.Next(50, 100));
            Console.WriteLine(r.Next(50, 100));
            Console.WriteLine(r.Next(50, 100));

            Console.ReadKey();
        }
    }
}
