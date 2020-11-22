using System;


namespace AssignmentTask6
{
    class Account
    {
        private static int count = 0;
        private int acc_id;
        private double acc_balance;
        private string acc_name;
        private static int id = 10000;

        public Account()
        {

        }

        public Account(string acc_name, double acc_balance)
        {
            Account.count += 1;
            this.acc_balance = acc_balance;
            this.acc_name = acc_name;
            this.acc_id = Account.id + Account.count;
            Console.WriteLine("An Account is Created");
        }

        public int getAccountId()
        {
            return this.acc_id;
        }

        public void setAccount()
        {
            Account.count += 1;
            Console.Write("Enter Account Name: ");
            this.acc_name = Console.ReadLine();
            Console.Write("Enter Account Balance: ");
            this.acc_balance = Convert.ToDouble(Console.ReadLine());
            if (this.acc_balance >= 500)
            {
                this.acc_id = Account.id + Account.count;
                Console.WriteLine("A New Account is Created");
            }
            else
            {
                Console.WriteLine("At Least 500Taka required for the account to open");
            }
        }

        public int getTotalAccountNo()
        {
            return Account.count;
        }

        public void deposit(double money)
        {
            this.acc_balance += money;
        }

        public void withdraw(double money)
        {
            if (this.acc_balance >= (money + 500))
            {
                this.acc_balance -= money;
                Console.WriteLine("Withdraw Successful");
            }
            else
            {
                Console.WriteLine("Withdraw Error.");
            }
        }
        public void showAccount()
        {
            Console.WriteLine("Account Name: " + this.acc_name);
            Console.WriteLine("Account ID: " + this.acc_id);
            Console.WriteLine("Account Balance: " + this.acc_balance);
        }

        public bool transferMoney(int aId, double m)
        {
            if (this.acc_balance >= (m + 500))
            {
                this.acc_balance -= m;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
