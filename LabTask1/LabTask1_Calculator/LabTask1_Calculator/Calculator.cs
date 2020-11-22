using System;

namespace LabTask1_Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator using C#");
            Console.WriteLine("Enter num1 == -1 && operand == 'e' && num2 == -1 OR operand == 'e' && num2 == -1 to exit");
            Console.Write("Please enter the first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                Console.Write("Please enter the operand (+, -, /, *, ^): ");
                char operand = Convert.ToChar(Console.ReadLine());

                Console.Write("Please enter the second integer: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if (operand == '+')
                {
                    int add_result = num1 + num2;
                    Console.WriteLine("{0}", add_result);
                    num1 = add_result;
                }
                else if (operand == '-')
                {
                    int sub_result = num1 - num2;
                    Console.WriteLine("{0}", sub_result);
                    num1 = sub_result;
                }
                else if (operand == '/')
                {
                    try
                    {
                        int div_result = num1 / num2;
                        Console.WriteLine("{0}", div_result);
                        num1 = div_result;
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("can not divided by zero");
                        Console.WriteLine("Current Output:{0}", num1);
                    }
                }
                else if (operand == '*')
                {
                    int mul_result = num1 * num2;
                    Console.WriteLine("{0}", mul_result);
                    num1 = mul_result;
                }
                else if (operand == '^')
                {
                    double pow_res = Math.Pow(num1, num2);
                    Console.WriteLine("{0}", pow_res);
                    num1 = (int)pow_res;
                }
                else if (num1 == -1 && operand == 'e' && num2 == -1 || operand == 'e' && num2 == -1)
                {
                    Console.WriteLine("\nThank you for using C# Calculator.");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Input.Try Again!");
                }
            }
        }
    }
}