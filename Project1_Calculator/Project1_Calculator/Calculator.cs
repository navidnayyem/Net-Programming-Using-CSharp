using System;

namespace Project1_Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            /*Background Color of Console*/
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();

            /*Color of Text*/
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("***C# Console Calculator***");

            while (true)
            {
                /*Showing Operands List*/
                Console.WriteLine("\nNow, what you want to do?");
                Console.WriteLine("Write + for Addition");
                Console.WriteLine("Write - for Subtraction");
                Console.WriteLine("Write / for Division");
                Console.WriteLine("Write * for Multiplication");
                Console.WriteLine("Write ^ for Power");
                Console.WriteLine("Write r for Square Root");
                Console.WriteLine("Write m for Modulus");
                Console.WriteLine("Write s for sin Value");
                Console.WriteLine("Write c for cos Value");
                Console.WriteLine("Write t for tan Value");
                Console.WriteLine("Write e for EXIT");

                /*User Choice Input*/
                Console.Write("\nEnter your choice: ");
                char choice = Convert.ToChar(Console.ReadLine());

                if (choice == '+') /*Addition*/
                {
                    /*Taking two double inputs from user*/
                    Console.Write("\nEnter 1st Value: ");
                    double num1 = Double.Parse(Console.ReadLine());
                    Console.Write("Enter 2nd Value: ");
                    double num2 = Double.Parse(Console.ReadLine());
                    double add_result = num1 + num2;
                    Console.WriteLine("\nADDITION RESULT: {0}", add_result);
                }          
                else if (choice == '-') /*Subtraction*/
                {
                    /*Taking two double inputs from user*/
                    Console.Write("\nEnter 1st Value: ");
                    double num1 = Double.Parse(Console.ReadLine());
                    Console.Write("Enter 2nd Value: ");
                    double num2 = Double.Parse(Console.ReadLine());
                    double sub_result = num1 - num2;
                    Console.WriteLine("\nSUBTRACTION RESULT: {0}", sub_result);
                }
                else if (choice == '/') /*Division*/
                {
                    /*Taking two double inputs from user*/
                    Console.Write("\nEnter 1st Value: ");
                    double num1 = Double.Parse(Console.ReadLine());
                    Console.Write("Enter 2nd Value: ");
                    double num2 = Double.Parse(Console.ReadLine());
                    double div_result = num1 / num2;
                    if(num2 == 0)
                    {
                        Console.WriteLine("Cannot Divided by Zero(0)");
                    }
                    else
                    {
                        Console.WriteLine("\nDIVISION RESULT: {0}", div_result);
                    }       
                }
                else if (choice == '*') /*Multiplication*/
                {
                    /*Taking two double inputs from user*/
                    Console.Write("\nEnter 1st Value: ");
                    double num1 = Double.Parse(Console.ReadLine());
                    Console.Write("Enter 2nd Value: ");
                    double num2 = Double.Parse(Console.ReadLine());
                    double mul_result = num1 * num2;
                    Console.WriteLine("\nMULTIPLICATION RESULT: {0}", mul_result);
                }
                else if (choice == '^') /*Power*/
                {
                    /*Taking two double inputs from user*/
                    Console.Write("\nEnter 1st Value: ");
                    double num1 = Double.Parse(Console.ReadLine());
                    Console.Write("Enter 2nd Value: ");
                    double num2 = Double.Parse(Console.ReadLine());
                    double pow_res = Math.Pow(num1, num2);
                    Console.WriteLine("\nRESULT OF {0} TO THE POWER {1}: {2}", num1, num2, pow_res);
                }
                else if (choice == 'r') /*FIND Square Root*/
                {
                    /*Taking value input from user*/
                    Console.Write("\nEnter Value for Finding Square Root: ");
                    double num1 = Double.Parse(Console.ReadLine());
                    double sr_res = Math.Sqrt(num1);
                    Console.WriteLine("\nRESULT of SQUARE ROOT OF {0}: {1}", num1, sr_res);
                }
                else if (choice == 'm') /*Finding Modulus*/
                {
                    /*Taking two double input from user*/
                    Console.Write("\nEnter 1st Value: ");
                    double num1 = Double.Parse(Console.ReadLine());
                    Console.Write("Enter 2nd Value: ");
                    double num2 = Double.Parse(Console.ReadLine());
                    double mod_result = num1 % num2;
                    Console.WriteLine("\nRESULT OF {0} MOD {1}: {2}", num1, num2, mod_result);
                }
                else if (choice == 's') /*FIND VALUE OF SIN IN DEGREES*/
                {
                    /*Taking θ(Theta) value input from user*/
                    Console.Write("\nEnter Value of Theta: ");
                    double num1 = Double.Parse(Console.ReadLine());
                    double sin_res = Math.Sin((num1 * Math.PI) / 180);
                    Console.WriteLine("\nRESULT of SIN {0}: {1}", num1, sin_res);
                }
                else if (choice == 'c') /*FIND VALUE OF COS IN DEGREES*/
                {
                    /*Taking θ(Theta) value input from user*/
                    Console.Write("\nEnter Value of Theta: ");
                    double num1 = Double.Parse(Console.ReadLine());
                    double cos_res = Math.Cos((num1 * Math.PI) / 180);
                    Console.WriteLine("\nRESULT of COS {0}: {1}", num1, cos_res);
                }
                else if (choice == 't') /*FIND VALUE OF TAN IN DEGREES*/
                {
                    /*Taking θ(Theta) value input from user*/
                    Console.Write("\nEnter Value of Theta: ");
                    double num1 = Double.Parse(Console.ReadLine());
                    double tan_res = Math.Tan((num1 * Math.PI) / 180);
                    Console.WriteLine("\nRESULT of TAN {0}: {1}", num1, tan_res);
                }
                else if (choice == 'e') /*EXIT THE PROGRAM*/
                {
                    Console.WriteLine("\nThank you for using this C# Calculator");
                    break;
                }         
                else
                {
                    Console.WriteLine("Wrong Input.Try Again!"); /*WRONG INPUT MESSAGE*/
                }
            }
            Console.ReadLine();
        }
    }
}