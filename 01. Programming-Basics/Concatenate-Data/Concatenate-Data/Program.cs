using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenate_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var FirstName = Console.ReadLine();
            var LastName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var town = Console.ReadLine();
            Console.WriteLine("You are {0} {1}, a {2} -years old person form {3}", FirstName, LastName, age, town);
        }
    }
}
