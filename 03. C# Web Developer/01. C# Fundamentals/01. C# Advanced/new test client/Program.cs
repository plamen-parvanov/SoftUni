using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        ReadInput();
    }

    private static void ReadInput()
    {
         var accounts = new Dictionary<int, BankAccount>();
        while (true)
        {
            var inpitLine = Console.ReadLine();
            if (inpitLine == "End")
            {
                break;
            }

            Execute(inpitLine, accounts);
        }
    }

    private static void Execute(string inpitLine, Dictionary<int, BankAccount> accounts)
    {
        var inputArr = inpitLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var command = inputArr[0];
        var id = int.Parse(inputArr[1]);

        switch (command)
        {
            case "Create":
                Create(id, accounts);
                break;

            case "Deposit":
                Deposit(id, decimal.Parse(inputArr[2]), accounts);
                break;

            case "Withdraw":
                Withdraw(id, decimal.Parse(inputArr[2]), accounts);
                break;

            case "Print":
                Print(id, accounts);
                break;
            default:
                break;
        }
    }

    private static void Print(int id, Dictionary<int, BankAccount> accounts)
    {
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            Console.WriteLine(accounts[id]);
        }
    }

    private static void Withdraw(int id, decimal amount, Dictionary<int, BankAccount> accounts)
    {
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else if (accounts[id].Balance < amount)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        {
            accounts[id].Withdraw(amount);
        }
    }

    private static void Deposit(int id, decimal amount, Dictionary<int, BankAccount> accounts)
    {
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            accounts[id].Deposit(amount);
        }
    }

    private static void Create(int id, Dictionary<int, BankAccount> accounts)
    {
        if (accounts.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
        }
        else
        {
            var currAccount = new BankAccount();
            currAccount.ID = id;

            accounts.Add(id, currAccount);
        }
    }
}
