namespace BankAccount
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        private static Dictionary<int, BankAccount> accounts;
        public static void Main()
        {
            ReadInput();
        }

        private static void ReadInput()
        {
            accounts = new Dictionary<int, BankAccount>();

            string inputLine;
            while ((inputLine = Console.ReadLine())!= "End")
            {             
                Execute(inputLine);
            }
        }

        private static void Execute(string input)
        {
            var inputArr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var command = inputArr[0];
            var id = int.Parse(inputArr[1]);
            int amount;

            switch (command)
            {
                case "Create":
                    Create(id);
                    break;
                case "Deposit":
                    amount = int.Parse(inputArr[2]);
                    Deposit(id, amount);
                    break;
                case "Withdraw":
                    amount = int.Parse(inputArr[2]);
                    Withdraw(id, amount);
                    break;
                case "Print":
                    Print(id);
                    break;
            }
        }

        private static void Print(int id)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
                return;
            }

            Console.WriteLine(accounts[id].ToString());
        }

        private static void Withdraw(int id, int amount)
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

        private static void Deposit(int id, int amount)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
                return;
            }

            accounts[id].Deposit(amount);
        }

        private static void Create(int id)
        {
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
                return;
            }

            var acc = new BankAccount();
            acc.Id = id;
            accounts[id] = acc;
            
        }
    }
}
