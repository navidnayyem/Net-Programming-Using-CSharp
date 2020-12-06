using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            char userChoice;

            while (true)
            {
                Wordlist list = new Wordlist();
                list.getUserInput();
                comehere: Console.Write("Do you want to play Again? YES(Y) or NO(N)?: ");
                userChoice = Convert.ToChar(Console.ReadLine());
                if (userChoice == 'Y' || userChoice == 'y')
                {
                    Console.Clear();
                    continue;
                }
                else if(userChoice == 'N' || userChoice == 'n')
                {
                    Console.WriteLine("\nGAME EXITED");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Input\n");
                    Console.Clear();
                    goto comehere;
                } 
            }      
        }
    }
}
