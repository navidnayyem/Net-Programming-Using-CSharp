using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student("Navid", 03, 3.61);
            Student std2 = new Student("Nayyem", 10, 3.50);
            Console.WriteLine("Average CGPA: {0}", std1.showAverage(std1, std2));
            Console.ReadKey();
        }
    }
}
