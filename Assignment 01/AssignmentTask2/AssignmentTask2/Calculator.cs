using System;

namespace AssignmentTask2
{
    class Calculator
    {
        double myValue;
        public void setValue(double myValue)
        {
            this.myValue = myValue;
        }
        public void square()
        {
            Console.WriteLine("Square: {0}",Math.Pow(myValue, 2));
        }
        public void cube()
        {
            Console.WriteLine("Cube: {0}", Math.Pow(myValue, 3));
        }
    }
}
