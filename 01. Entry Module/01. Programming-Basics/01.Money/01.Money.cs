using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoin = double.Parse(Console.ReadLine());
            var chineseYuan = double.Parse(Console.ReadLine());
            var commission = double.Parse(Console.ReadLine());

            var bitcoinInLv = bitcoin * 1168d;
            var chineseYuanInLv = chineseYuan * 0.15 * 1.76;
            var valueInEuro = (bitcoinInLv + chineseYuanInLv) / 1.95;
            var changeCommission = commission * valueInEuro / 100;
            var value = (valueInEuro - changeCommission);

            Console.WriteLine(value);
        }
    }
}
