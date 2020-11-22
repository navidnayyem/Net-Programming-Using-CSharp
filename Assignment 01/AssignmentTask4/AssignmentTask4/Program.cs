using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle cir = new Circle();
            cir.setRadius(12);
            cir.showCircumference();
            cir.showArea();
            Console.ReadKey();
        }
    }
}
