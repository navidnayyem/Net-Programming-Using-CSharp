using System;

namespace MidTerm
{
class Triangle
{
    protected double length;
    protected double width;
public Triangle(double l , double w )
    {
        length = l;
        width = w;
    }
public double GetArea()
    {
        return 0.5 * length * width;
    }
public void Display()
    {
        Console.WriteLine("Length: {0}", length);
        Console.WriteLine("Width: {0}", width);
        Console.WriteLine("Area: {0}", GetArea());
    }
}//end class Triangle
class Shape : Triangle
{
private double cost;
public Tabletop(double l, double w) : base(l, w)
{ 

}
public double GetCost()
{
    double cost;
    cost = GetArea() * 70;
    return cost;
}
}
