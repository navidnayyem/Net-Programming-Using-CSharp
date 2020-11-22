using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.setValue(5);
            calc.square();
            calc.cube();
            Console.ReadKey();
        }
    }
}
