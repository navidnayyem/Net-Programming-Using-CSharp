using System;
using System.Collections;

namespace AssignmentTask6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ArrayList bankacc = new ArrayList();
            bankacc.Add(new Account("Navid", 50000));

            while (true)
            {
                Console.WriteLine("\n0. Create Account");
                Console.WriteLine("1. Show Account Info");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. TransferMoney");
                Console.WriteLine("5. Show All Accounts");
                Console.WriteLine("6. Show Total Number of Accounts");
                Console.WriteLine("7. Clear Screen");
                Console.WriteLine("8. Exit");

                int index = bankacc.Count;
                index -= 1;
                Account x = (Account)bankacc[index];

                Console.Write("\nEnter Choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        Account r = new Account();
                        r.setAccount();
                        bankacc.Add(r);
                        break;

                    case "1":
                        x.showAccount();
                        break;

                    case "2":
                        Console.Write("Enter Money for Deposit: ");
                        double d_m = Convert.ToDouble(Console.ReadLine());
                        x.deposit(d_m);
                        Console.WriteLine("Deposit Successful");
                        break;

                    case "3":
                        Console.Write("Enter Money for Withdraw: ");
                        double w_m = Convert.ToDouble(Console.ReadLine());
                        x.withdraw(w_m);
                        break;

                    case "4":
                        Console.Write("Enter Account ID:");
                        int acId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Money: ");
                        double t_m = Convert.ToDouble(Console.ReadLine());

                        int check = acId - 10000;
                        check -= 1;
                        if (check > -1 && check < bankacc.Count)
                        {
                            if (x.transferMoney(acId, t_m))
                            {
                                Account t = (Account)bankacc[check];
                                t.deposit(t_m);
                                Console.WriteLine("TransferMoney Successful");
                            }
                            else
                            {
                                Console.WriteLine("TransferMoney Error");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Account");
                        }
                        break;

                    case "5":
                        for (int i = 0; i < bankacc.Count; i++)
                        {
                            Account s = (Account)bankacc[i];
                            s.showAccount();
                        }
                        break;

                    case "6":
                        Console.WriteLine("Total Number of Accounts: " + x.getTotalAccountNo());
                        break;

                    case "7":
                        Console.Clear();
                        break;

                    case "8":
                        break;
                }
            }
        }
    }
}
