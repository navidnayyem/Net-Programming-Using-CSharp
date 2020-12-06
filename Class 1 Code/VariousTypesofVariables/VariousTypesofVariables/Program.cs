using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VariousTypesofVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            short a;
            int b;
            double c;
            decimal d;
            /* actual initialization */
            a = 10;
            b = 20;
            c = a + b;
            d = (a + b)/b;
            Console.WriteLine("a = {0}, b = {1}, c = {2} d={3}", a, b, c, d);
            Console.ReadKey();

        }
    }
}
