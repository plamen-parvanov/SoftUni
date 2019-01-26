using System.Collections.Generic;
using System.Linq;

namespace BankAccount
{
    public class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts;

        private Person()
        {
            this.accounts = new List<BankAccount>();
        }

        public Person(string name, int age) 
            : this()
        {
            this.name = name;
            this.age = age;
        }

        public Person(string name, int age, List<BankAccount> accounts)
            : this(name, age)
        {
            this.accounts = accounts;
        }

        public decimal GetBalance()
        {
            var balance = this.accounts.Sum(a => a.Balance);
            return balance;
        }
    }
}
