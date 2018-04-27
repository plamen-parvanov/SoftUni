using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "pe6o", "go6o", "asq" };

            list = list.OrderByDescending(x => x).ToList();

            Console.WriteLine(string.Join("---", list));
        }
    }
}
