using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {

            var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var arr = stack.ToArray();

            Console.WriteLine(string.Join("-", stack));
            Console.WriteLine(string.Join(" ", arr));

            
        }
    }
}
