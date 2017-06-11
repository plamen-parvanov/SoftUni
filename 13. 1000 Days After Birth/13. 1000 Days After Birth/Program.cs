using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime thousandDaysAfterBirth = birthDate.AddDays(999);

            string dateToPrint = thousandDaysAfterBirth.ToString("dd-MM-yyyy");
            Console.WriteLine(dateToPrint);
        }
    }
}
