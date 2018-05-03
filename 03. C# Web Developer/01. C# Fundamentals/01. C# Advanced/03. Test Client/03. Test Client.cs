namespace _03._Test_Client
{
    using System;
    using System.Collections.Generic;

    public class Problem03
    {
        private static Dictionary<int, BankAccount> accounts;

        public static void Main()
        {
            accounts = new Dictionary<int, BankAccount>();

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "End")
                {
                    break;
                }

                ExecuteCommand(inputLine);
            }
        }

        private static void ExecuteCommand(string inputLine)
        {
            var arr = inputLine.Split();
            var command = arr[0];
            var id = int.Parse(arr[1]);

            switch (command)
            {
                case "Create":
                    CreateAccount(id);
                    break;
                case "Deposit":
                    var deposit = decimal.Parse(arr[2]);
                    MakeDeposit(id, deposit);
                    break;
                case "Withdraw":
                    var withdraw = decimal.Parse(arr[2]);
                    MakeWithdraw(id, withdraw);
                    break;
                case "Print":
                    PrintAccountInfoFor(id);
                    break;
            }
        }

        private static void PrintAccountInfoFor(int id)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
                return;
            }

            var balance = accounts[id].Balance;
            Console.WriteLine($"Account ID{id}, balance {balance:F2}");
        }

        private static void MakeWithdraw(int id, decimal amount)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
                return;
            }
            else if (accounts[id].Balance < amount)
            {
                Console.WriteLine("Insufficient balance");
                return;
            }

            accounts[id].Withdraw(amount);
        }

        private static void MakeDeposit(int id, decimal amount)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
                return;
            }

            accounts[id].Deposit(amount);
        }

        private static void CreateAccount(int id)
        {
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                var acc = new BankAccount();
                acc.Id = id;
                accounts.Add(id, acc);

            }
        }
    }
}
