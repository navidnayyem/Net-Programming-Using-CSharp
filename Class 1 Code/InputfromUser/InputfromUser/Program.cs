using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InputfromUser
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            double Circum;
            Console.Write("Give Input:");
            object ob = Console.ReadLine();
            num = Convert.ToInt32(ob);
            Circum = 2 * 3.1416 * num;
            Console.WriteLine("Radius:" + num.ToString());
            Console.WriteLine("Circumference:" + Circum.ToString());
            Console.ReadKey();


            /*
            int r = Int32.Parse(Console.ReadLine());
            Circum = 2 * 3.1416 * r;
            Console.WriteLine("Radius:" + r.ToString());
            Console.WriteLine("Circumference:" + Circum.ToString());
            Console.ReadKey(); 
             */

        }
    }
}
