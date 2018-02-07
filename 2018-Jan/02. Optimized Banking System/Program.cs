namespace _02.Optimized_Banking_System
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem02
    {
        static List<BankAccount> list;
        public static void Main()
        {
            list = new List<BankAccount>();

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "end")
                {
                    break;
                }

                AddBankAccount(inputLine);
            }

            PrintOrdered();
        }

        public static void AddBankAccount(string input)
        {
            var arr = input.Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
            var bank = arr[0];
            var accName = arr[1];
            var balance = decimal.Parse(arr[2]);

            list.Add(new BankAccount(bank, accName, balance));
        }

        public static void PrintOrdered()
        {
            foreach (var bankAccount in list.OrderByDescending(b => b.AccountBalance)
                .ThenBy(b => b.Bank.Length))
            {
                var name = bankAccount.AccountName;
                var balance = bankAccount.AccountBalance;
                var bank = bankAccount.Bank;
                Console.WriteLine($"{name} -> {balance} ({bank})");
            }
        }
    }
}
