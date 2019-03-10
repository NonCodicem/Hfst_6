using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoofdstuk_6_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string y = "\\ is een \"backslash\"";
            Console.WriteLine(y);

            string x = @"\ is een ""backslash""";
            Console.WriteLine(x);

            string z = @"   Dit is een zin op
            twee lijnen";
            Console.WriteLine(z);

            string a = z.ToUpper();
            Console.WriteLine(a);

            string b = a.Trim();
            Console.WriteLine(b);

            string c = "Programmeren";
            c = c.Insert(8, "a");
            Console.WriteLine(c);
            c = c.Remove(9, 4);
            Console.WriteLine(c);

            string d = "vuur";
            d = d.Replace("u", "o");
            Console.WriteLine(d);

            bool contains = c.Contains("m");
            Console.WriteLine(contains);

            string stri1 = "The quick brown fox jumps over the lazy dog";
            string stri2 = "fox";
            bool contains2 = stri1.Contains(stri2);
            Console.WriteLine($"\"{stri2}\" komt voor in \"{stri1}\" : {contains2}");

            if (contains2)
            {
                int index = stri1.IndexOf(stri2);
                if (index > 0)
                {
                    Console.WriteLine($"\"{stri2}\" komt voor in \"{stri1}\" op positie {index +1}");

                }

            }

            char[] arr = stri2.ToArray();

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            string[] split = stri1.Split();

            foreach (var item in split)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            string[] split2 = stri1.Split(new char[] { 'o'});

            foreach (var item in split2)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            string[] split3 = stri1.Split(new char[] {' ', 'o' });

            foreach (var item in split3)
            {
                Console.WriteLine(item);

            }

            Console.ReadKey();
        }
    }
}
