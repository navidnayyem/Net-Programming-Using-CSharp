using System;

namespace AssignmentTask1
{
    class Rectangle
    {
        int width, height;
        public void setWidth(int width)
        {
            this.width = width;
        }
        public void setHeight(int height)
        {
            this.height = height;
        }
        public int getHeigth()
        {
            return this.height;
        }
        public int getWidth()
        {
            return this.width;
        }
        public void showArea()
        {
            Console.WriteLine("Area of Rectangle: {0}", this.width * this.height);
        }
    }
}