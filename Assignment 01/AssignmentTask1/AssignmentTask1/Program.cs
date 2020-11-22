using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            Rectangle rect2 = new Rectangle(4,6);

            //area of rectangle 1
            rect1.setHeight(10);
            rect1.setWidth(10);
            rect1.showArea();

            //area of rectangle 2
            rect2.showArea();

            Console.ReadKey();
        }
    }
}
