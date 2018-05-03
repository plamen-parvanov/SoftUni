namespace _01._Bank_Account
{
    using System;

    public class Problem01
    {
        public static void Main()
        {
            var acc = new BankAccount();

            acc.Id = 1;
            acc.Deposit(15);
            acc.Withdraw(10);

            Console.WriteLine(acc);

        }
    }
}
