using System;

namespace AssignmentTask4
{
    class Circle
    {
        double radius;
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public void showCircumference()
        {
            Console.WriteLine("Circumference of Circle = {0}", 2 * Math.PI * radius);
        }
        public void showArea()
        {
            Console.WriteLine("Area of Circle = {0}", Math.PI * (Math.Pow(radius, 2)));
        }
    }
}
