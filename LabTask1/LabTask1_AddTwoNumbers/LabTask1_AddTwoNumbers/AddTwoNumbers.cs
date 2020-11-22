using System;

namespace LabTask1_AddTwoNumbers
{
    class AddTwoNumbers
    {
        static void Main(string[] args)
        {
            double num1 = Double.Parse(Console.ReadLine());
            double num2 = Double.Parse(Console.ReadLine());
            int n1 = Convert.ToInt32(num1);
            int n2 = Convert.ToInt32(num2);
            int addresult = n1 + n2;
            Console.WriteLine("{0} + {1} = {2}", n1, n2, addresult);
            Console.ReadLine();
        }
    }
}