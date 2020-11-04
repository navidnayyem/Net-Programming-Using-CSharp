using System;

namespace _3rdTask_ReferenceTypeExample
{
    class Program
    {
        public static void qube(ref int num) 
        { 
            num = num * num * num; 
        }
        static void Main(string[] args)
        {
            int original = 5; 
            Console.Write("Current Value: {0}\t", original);
            Program.qube(ref original); 
            Console.WriteLine("\nNow the current value is {0}\t", original); 
            Console.ReadLine();
        }
    }
}
