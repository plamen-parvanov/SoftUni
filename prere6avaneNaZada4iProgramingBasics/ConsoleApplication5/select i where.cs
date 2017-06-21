using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            var numList = new List<int> { 1, 2, 3, 4, 5, 6, 7};

            numList = numList.Select(n => n + 100).ToList();    //select preobrazuva 4isloto 

            numList = numList.Where(n => n % 2 == 0).ToList(); // where proverqva uslovieto

            Console.WriteLine(string.Join(" ", numList));

            


        }
    }
}
