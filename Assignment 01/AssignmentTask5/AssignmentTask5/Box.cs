using System;

namespace AssignmentTask5
{
    class Box
    {
        double length, width, height;
        public Box()
        {

        }
        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }
        public double getArea()
        {
            return this.length * this.width * this.height;
        }
    }
}
