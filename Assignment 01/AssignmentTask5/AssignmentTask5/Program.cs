using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(10, 5, 10);
            Console.WriteLine("Area of Box: {0}", box.getArea());
            Console.ReadKey();
        }
    }
}
